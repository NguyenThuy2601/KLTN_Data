using QLKetQuaGiangDay.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QLKetQuaGiangDay
{
    public partial class frmXemDiem : Form
    {
        DataTable dataAll;
        DataTable dataRaw;
        DataTable dataTyLe;
        

        string[] columnTitle = { "Điểm 0", "Điểm (0-1]", "Điểm (1-2]", "Điểm (2-3]", "Điểm (3-4]", "Điểm (4-5]", "Điểm (5-6]", "Điểm (6-7]", "Điểm (7-8]", "Điểm (8-9]", "Điểm (9-10]" };
        string[] columnName = { "D0", "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "D10" };
        string[] pieChartLable = { "Đậu", "Rớt" }; 
        public frmXemDiem()
        {
            InitializeComponent();
        }

        public DataTable MergeDataTables(DataTable dataTable1, DataTable dataTable2)
        {
            // Clone DataTable 1 để giữ cấu trúc
            DataTable mergedDataTable = dataTable2.Clone();

            // Copy dữ liệu từ DataTable 1 vào DataTable mới
            foreach (DataRow row in dataTable2.Rows)
            {
                mergedDataTable.Rows.Add(row.ItemArray);
            }

            // Copy dữ liệu từ DataTable 2 vào DataTable mới
            foreach (DataRow row in dataTable1.Rows)
            {
                DataRow newRow = mergedDataTable.NewRow();

                // Copy các giá trị từ DataTable 2, bỏ qua hai cột đầu tiên
                for (int i =0; i < dataTable1.Columns.Count; i++)
                {
                    // Nếu cột của DataTable 2 có kiểu double, chuyển đổi sang double trước khi thêm vào DataTable mới
                    if (dataTable1.Columns[i].DataType == typeof(double))
                        newRow[i] = Convert.ToDouble(row[i]);
                    else
                        newRow[i] = row[i];
                }

                mergedDataTable.Rows.Add(newRow);
            }

            return mergedDataTable;
        }

        public frmXemDiem(DataTable dataRaw, DataTable dataPercent, string info, string frmName) : this()
        {
           
            dataAll = MergeDataTables(dataRaw, dataPercent);

            this.dataRaw = dataRaw;
            this.dataTyLe = dataPercent;

            while (Chart.Series.Count > 0) { Chart.Series.RemoveAt(0); }
            Chart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            Chart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            cbbChonBieuDo.SelectedIndex = 0;
            cbbLoaiBieuDo.SelectedIndex = 0;
            DoiSoLieuBieuDo(cbbChonBieuDo.SelectedIndex);
            DoiLoaiBieuDo(cbbLoaiBieuDo.SelectedIndex);

            string[] temp = info.Split(',');

            CommonUtils.setText(hkLbl, temp[0]);
            CommonUtils.setText(mMHLbl, temp[1]);
            CommonUtils.setText(tenMHLbl, temp[2]);
            CommonUtils.setText(mGVLbl, temp[3]);
            CommonUtils.setText(tenGVLbl, temp[4]);

            CommonUtils.setText(slsvLbl, dataRaw.Rows[0][1].ToString());
           

            if (temp.Length == 6)
            {
                CommonUtils.setText(lopLbl, temp[5]);

                this.Text = string.Format(frmName, temp[0],
                                                    temp[1],
                                                    temp[2],
                                                    temp[3],
                                                    temp[4],
                                                    temp[5]); 
                
            }   
            else
            {
                CommonUtils.hideControl(lopLbl);
                CommonUtils.hideControl(lopFixLbl);

                this.Text = string.Format(frmName, temp[0],
                                                    temp[1],
                                                    temp[2],
                                                    temp[3],
                                                    temp[4]);
            }    
            titleLbl.Text = this.Text;
        }

        private void frmXemDiem_Load(object sender, EventArgs e)
        {
            dgvDetail.DataSource = dataAll;
            setDataPieChart();
        }

        private void setDataPieChart()
        {
            pieChart.Series.Clear();

            // Add a new series for the pie chart
            Series series = new Series("PieSeries");
            pieChart.Series.Add(series);
            series.ChartType = SeriesChartType.Pie;

            // Add data points from columns 2 and 3 of the DataTable to the series
            foreach (DataRow row in dataRaw.Rows)
            {
                for (int i = 2; i <= 3; i++)
                {
                    string title = pieChartLable[i - 2];
                    double value = Double.Parse(row[i].ToString());
                    pieChart.Series["PieSeries"].Points.AddXY(title, value);
                    pieChart.Series[0].Points.Last().LegendText = title;
                }
            }

            pieChart.Series[0].IsValueShownAsLabel = true;
            pieChart.Series[0].Label = "#PERCENT{P0}";
            
        }

        private void DoiSoLieuBieuDo(int ChonBieuDo)
        {

            Chart.Series.Clear();
            int j = 0;

            if (ChonBieuDo == 0)
            {
                Chart.Series.Add("Số lượng");
                //Thêm vào các điểm ứng với số lượng SV

                foreach (DataRow row in dataRaw.Rows)
                {
                    for (int i = 4; i < dataRaw.Columns.Count; i++)
                    {
                        string title = columnTitle[j];
                        double value = Double.Parse(row[i].ToString());
                        Chart.Series["Số lượng"].Points.AddXY(title, value);
                        j++;
                    }
                }    
                
                    
                Chart.Series[0].Color = Color.Blue;
            }
            if (ChonBieuDo == 1)
            {
                Chart.Series.Add("Tỷ lệ");
                //Thêm vào các điểm ứng với tỷ lệ SV
                foreach (DataRow row in dataRaw.Rows)
                {
                    for (int i = 4; i < dataRaw.Columns.Count; i++)
                    {
                        string title = columnTitle[j];
                        double value = Double.Parse(row[i].ToString());
                        Chart.Series["Tỷ lệ"].Points.AddXY(title, value);
                        j++;
                    }
                }

                Chart.Series[0].Color = Color.Red;
            }

            Chart.ChartAreas[0].RecalculateAxesScale();  //tự động xác định min và max trục Y
            Chart.ChartAreas[0].AxisX.Interval = 1;     //hiện các giá trị trên trục X
            Chart.Series[0].IsValueShownAsLabel = true; //hiện giá trị  trên Chart

        }
        public void DoiLoaiBieuDo(int dangBD)
        {
            if (dangBD == 0)
                Chart.Series[0].ChartType = SeriesChartType.Column;
            if (dangBD == 1)
                Chart.Series[0].ChartType = SeriesChartType.Area;
            if (dangBD == 2)
                Chart.Series[0].ChartType = SeriesChartType.SplineArea;

        }


        private void changeChartBtn_Click(object sender, EventArgs e)
        {
            DoiSoLieuBieuDo(cbbChonBieuDo.SelectedIndex);
            DoiLoaiBieuDo(cbbLoaiBieuDo.SelectedIndex);
            
        }
    }
}
