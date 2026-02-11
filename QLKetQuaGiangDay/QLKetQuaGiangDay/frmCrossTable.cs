using QLKetQuaGiangDay.BUS;
using QLKetQuaGiangDay.BUS.Common;
using QLKetQuaGiangDay.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QLKetQuaGiangDay
{
    public partial class frmCrossTable : Form
    {
        Form1 mainFrom;

        DataTable dtContent;
        DataTable dtTyLeAllGV;

        HoTroPhanCongBus bus;
        DbBus dbBus;
        public frmCrossTable()
        {
            InitializeComponent();
        }

        public frmCrossTable(Form1 mainFrom, DataTable dt, DataTable dtTyLeAllGV, HoTroPhanCongBus bus, DbBus dbBus) : this()
        {
            this.mainFrom = mainFrom;
            dtContent= dt;
            this.dtTyLeAllGV = dtTyLeAllGV;

            this.bus = bus; 
            this.dbBus = dbBus;
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            mainFrom.openChildForm(mainFrom.archiveForm, false);
            this.Close();
        }

        private void frmCrossTable_Load(object sender, EventArgs e)
        {
            tyLeDatMonDgv.DataSource = dtContent;
            allTyLeDatContentDgv.DataSource = dtTyLeAllGV;

            DataTable dt = bus.getMonHocGiangDayInHocKy(100, 500, dbBus);
            CommonUtils.initCbbData(hkbdCbb, CommonUtils.getColumn(dt, "MHK"));
            CommonUtils.initCbbData(hkktCbb, CommonUtils.getColumn(dt, "MHK"));
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            if(hkbdCbb.SelectedIndex < 0 || hkktCbb.SelectedIndex < 0)
            {
                MessageBox.Show("Chưa chọn học kì bắt đầu hoặc kết thúc");
            }    
            else
            {
                dtTyLeAllGV = bus.getThongKeTyLeDatCuaGiangVienInHK(int.Parse(hkbdCbb.Text),
                                                                    int.Parse(hkktCbb.Text),
                                                                    dbBus);
                allTyLeDatContentDgv.DataSource = dtTyLeAllGV;
            }
            
        }

        private void tyLeDatMonDgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedCol = tyLeDatMonDgv.CurrentCell.ColumnIndex;
            foreach (DataGridViewRow row in tyLeDatMonDgv.Rows)
            {
                row.Cells[selectedCol].Selected = true;
            }

            if (selectedCol == 0)
                return;

            setBieuDoData(selectedCol);
        }

        private void setBieuDoData(int selectedColIndex)
        {
            while (bieuDoChart.Series.Count > 0) { bieuDoChart.Series.RemoveAt(0); }
            bieuDoChart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            bieuDoChart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            Series series = new Series(dtContent.Columns[selectedColIndex].ColumnName);
            bieuDoChart.Series.Add(series);

            foreach (DataRow row in dtContent.Rows)
            {

                string title = string.Format("{0} {1}", row[0].ToString(),
                                                  row[1].ToString());
                double value = Double.Parse(row[selectedColIndex].ToString());
                bieuDoChart.Series[0].Points.AddXY(title, value);
            }

            bieuDoChart.ChartAreas[0].RecalculateAxesScale();  //tự động xác định min và max trục Y
            bieuDoChart.ChartAreas[0].AxisX.Interval = 1;     //hiện các giá trị trên trục X
            bieuDoChart.Series[0].IsValueShownAsLabel = true;
        }

        private void cbbLoaiBieuDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbLoaiBieuDo.SelectedIndex)
            {
                case 0:
                    bieuDoChart.Series[0].ChartType = SeriesChartType.Column;
                    break;
                case 1:
                    bieuDoChart.Series[0].ChartType = SeriesChartType.Bar;
                    break;
                case 2:
                    bieuDoChart.Series[0].ChartType = SeriesChartType.Line;
                    break;

            }
        }

        private void printExcelBtn_Click(object sender, EventArgs e)
        {

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Excel File |*.xls;*.xlsx";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                DataTable inputDT = tabControl1.SelectedIndex == 0 ? dtContent : dtTyLeAllGV;
                if (ExcelUtils.createExcelFile(dlg.FileName, inputDT) == 1)
                    MessageBox.Show("Sucess");
            }
            
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            string selectedString = "";
            if(string.IsNullOrEmpty(findGVTxt.Text))
            {
                allTyLeDatContentDgv.DataSource = dtTyLeAllGV;
                return;
            }    
            if (tenGVRadioBtn.Checked)
            {
                selectedString = string.Format("HOTEN LIKE '*{0}*'", findGVTxt.Text);
            }
            else
            {
                selectedString = string.Format("MAGIANGVIEN = '{0}'", findGVTxt.Text);
            }

            allTyLeDatContentDgv.DataSource = CommonBusUtils.findDataByQuery(dtTyLeAllGV, selectedString);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            findGVTxt.Text = "";
            allTyLeDatContentDgv.DataSource = dtTyLeAllGV;
        }
    }
}
