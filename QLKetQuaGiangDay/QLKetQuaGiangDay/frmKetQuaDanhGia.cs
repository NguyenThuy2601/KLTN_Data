using QLKetQuaGiangDay.BUS.Common;
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
    public partial class frmKetQuaDanhGia : Form
    {
        DataTable data;
        DataTable YKienKhac;
        DataTable TKdata;
        public frmKetQuaDanhGia()
        {
            InitializeComponent();
        }

        public frmKetQuaDanhGia(string info, DataTable data, DataTable YKienKhacData, DataTable dataTK) : this()
        {
            this.data = data;
            YKienKhac = getYKienKhac(YKienKhacData);
            TKdata = dataTK; 

            while (Chart.Series.Count > 0) { Chart.Series.RemoveAt(0); }
            Chart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            Chart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            cbbLoaiBieuDo.SelectedIndex = 0;
            DoiSoLieuBieuDo();
            DoiLoaiBieuDo(cbbLoaiBieuDo.SelectedIndex);

            string[] temp = info.Split(',');

            CommonUtils.setText(hkLbl, temp[0]);
            CommonUtils.setText(hkTab2Lbl, temp[0]);

            CommonUtils.setText(mMHLbl, temp[1]);
            CommonUtils.setText(maMHTab2Lbl, temp[1]);

            CommonUtils.setText(tenMHLbl, temp[2]);
            CommonUtils.setText(tenMHTab2Lbl, temp[2]);

            CommonUtils.setText(mGVLbl, temp[3]);
            CommonUtils.setText(maGVTab2Lbl, temp[3]);

            CommonUtils.setText(tenGVLbl, temp[4]);
            CommonUtils.setText(tenGVTab2Lbl, temp[4]);

            CommonUtils.setText(slsvLbl, data.Rows[0]["SLSV"].ToString());
            CommonUtils.setText(slKhaoSatLbl, setSumSLSVLamDanhGia(data));

            dgvDetail.DataSource = data;


            if (temp.Length == 6)
            {
                CommonUtils.setText(lopLbl, temp[5]);
            }
            else
            {
                CommonUtils.hideControl(lopLbl);
                CommonUtils.hideControl(lopFixLbl);
            }
        }

        public void DoiLoaiBieuDo(int dangBD)
        {
            for(int i = 0; i < Chart.Series.Count; i++)
            {
                if (dangBD == 0)
                    Chart.Series[i].ChartType = SeriesChartType.Column;
                if (dangBD == 1)
                    Chart.Series[i].ChartType = SeriesChartType.Bar;
                if (dangBD == 2)
                    Chart.Series[i].ChartType = SeriesChartType.FastLine;
            }    
        }

        private void setInfoForThongKePanel()
        {
            string avg = Math.Round(Double.Parse(TKdata.Rows[0]["AvgOfTRUNGBINHDANHGIA"].ToString()), 2).ToString();
            string min = Math.Round(Double.Parse(TKdata.Rows[0]["MinOfTRUNGBINHDANHGIA"].ToString()), 2).ToString();
            string max = Math.Round(Double.Parse(TKdata.Rows[0]["MaxOfTRUNGBINHDANHGIA"].ToString()), 2).ToString();

            string stdev = "0";
            double result;
            bool success = double.TryParse(TKdata.Rows[0]["StDevOfTRUNGBINHDANHGIA"].ToString(), out result);

            if (success)
            {
                stdev = Math.Round(Double.Parse(TKdata.Rows[0]["StDevOfTRUNGBINHDANHGIA"].ToString()), 2).ToString();
            }
           

            CommonUtils.setText(avgLbl, avg);
            CommonUtils.setText(minLbl, min);
            CommonUtils.setText(maxLbl, max);
            CommonUtils.setText(stdevLbl, stdev);
        }

        private DataTable getYKienKhac(DataTable data)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MAHOCKY", typeof(int));
            dt.Columns.Add("MALOP", typeof(string));
            dt.Columns.Add("YKKIEN", typeof(string));


            foreach(DataRow row in data.Rows)
            {
                string []temp = row["NHANXETKHACTUSV"].ToString().Split(';');
                for(int i = 0; i < temp.Length; i++)
                {
                    dt.Rows.Add(row["MAHOCKY"].ToString(), 
                                row["MALOP"].ToString(),
                                temp[i]);
                }    
            }

            return dt;
        }

        public void gennerateHKItemList(string hk)
        {
            List<String> listItem = new List<string>();
            if (hk.Contains("-"))
            {
                string[] temp = hk.Split('-');

                int min = int.Parse(temp[0]);
                int max = int.Parse(temp[1]);

                listItem.Add(temp[0]);
                for (int i = min; i < max; i++)
                {
                    int tempItem = i;
                    if ((i - 3) % 5 == 0)
                        tempItem = (i - 3) + 11;
                    else
                        tempItem += 1;

                    if (tempItem == max)
                        break;
                    listItem.Add(tempItem.ToString());

                }
                listItem.Add(temp[temp.Length - 1]);
            }
            else
                listItem.Add(hk);

            CommonUtils.initCbbData(hkCbb, listItem);
        }

        public void generateLopItemList()
        {
            List<string> distinctNames = YKienKhac.AsEnumerable()
                                      .Select(row => row.Field<string>("MALOP"))
                                      .Distinct()
                                      .ToList();

            CommonUtils.initCbbData(lopCbb, distinctNames);
        }

        private string setSumSLSVLamDanhGia(DataTable dt)
        {
            int sum = 0;
            foreach (DataRow row in dt.Rows)
            {
                sum += int.Parse(row["SOLUONGDANHGIA"].ToString());
            }

            return sum.ToString();  
        }

        private void frmKetQuaDanhGia_Load(object sender, EventArgs e)
        {
            lopTab2Lbl.Text = "";
            gopYDgv.DataSource = YKienKhac;

            gennerateHKItemList(hkLbl.Text);
            generateLopItemList();
            setInfoForThongKePanel();
        }


        private void DoiSoLieuBieuDo()
        {

            Chart.Series.Clear();


            for (int i = 0; i < data.Rows.Count; i++)
            {
                Chart.Series.Add(data.Rows[i]["MANLOPHOC"].ToString());
                for (int j = 3; j < data.Columns.Count; j ++)
                {
                    string title = data.Columns[j].ColumnName;
                    double value = Double.Parse(data.Rows[i][j].ToString());
                    Chart.Series[i].Points.AddXY(title, value);
                }
            }
            
            for(int i = 0; i < Chart.ChartAreas.Count; i++)
            {
                Chart.ChartAreas[i].RecalculateAxesScale();  //tự động xác định min và max trục Y
                Chart.ChartAreas[i].AxisX.Interval = 1;     //hiện các giá trị trên trục X
            }    
        }

        private void changeChartBtn_Click(object sender, EventArgs e)
        {
            DoiLoaiBieuDo(cbbLoaiBieuDo.SelectedIndex);
        }

        private void gopYDgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (YKienKhac.Rows.Count > 0)
            {
                gopYDgv.CurrentRow.Selected = true;

                lopTab2Lbl.Text = gopYDgv.CurrentRow.Cells["MALOP"].Value.ToString();
                contentTxt.Text = gopYDgv.CurrentRow.Cells["YKKIEN"].Value.ToString();
            }
            else
                return;
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
 
            DataTable tempDT = YKienKhac;

            if (hkCbb.SelectedIndex != -1)
                tempDT = CommonBusUtils.findDataByQuery(tempDT, String.Format("MAHOCKY = {0}", hkCbb.Text));

            if (lopCbb.SelectedIndex != -1)
                tempDT = CommonBusUtils.findDataByQuery(tempDT, String.Format("MALOP = '{0}'", lopCbb.Text));

            

            gopYDgv.DataSource = tempDT;
        }

        private void resetFilterBtn_Click(object sender, EventArgs e)
        {
            hkCbb.SelectedIndex = -1;
            lopCbb.SelectedIndex = -1;

            gopYDgv.DataSource = YKienKhac;
        }
    }
}
