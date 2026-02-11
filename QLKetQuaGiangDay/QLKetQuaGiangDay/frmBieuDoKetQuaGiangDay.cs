using QLKetQuaGiangDay.BUS;
using QLKetQuaGiangDay.BUS.Common;
using QLKetQuaGiangDay.DTO;
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
    public partial class frmBieuDoKetQuaGiangDay : Form
    {
        DataTable dtMonHoc;
        DataTable dtTyLe;

        MonHoc monHoc;

        int hkBD;
        int hkKT;

        string mGV;

        DbBus dbBus;
        ThongKeKetQuaGiangDayBus bus;
        public frmBieuDoKetQuaGiangDay()
        {
            InitializeComponent();
        }
        public frmBieuDoKetQuaGiangDay(ThongKeKetQuaGiangDayBus bus ,DbBus dbBus, DataTable dtMonHoc, DataTable dtTyLe, int hkBD, int hkKT, MonHoc monHoc):this() 
        {
            this.dtMonHoc = dtMonHoc;
            this.dtTyLe = dtTyLe;

            this.hkBD = hkBD;
            this.hkKT = hkKT;

            this.monHoc = monHoc;

            this.bus = bus;
            this.dbBus = dbBus;

            generateMonHocBieuDo();
            generateGiangVienBieuDo();

            gvTabLbl.Text = string.Format(gvTabLbl.Text, hkBD, hkKT);

            
        }

        public frmBieuDoKetQuaGiangDay(ThongKeKetQuaGiangDayBus bus, DbBus dbBus,  DataTable dtTyLe, int hkBD, int hkKT) : this()
        {
            this.dtTyLe = dtTyLe;

            this.hkBD = hkBD;
            this.hkKT = hkKT;

            this.bus = bus;
            this.dbBus = dbBus;

            generateGiangVienBieuDo();

            gvTabLbl.Text = string.Format(gvTabLbl.Text, hkBD, hkKT);


        }

        private void frmBieuDoKetQuaGiangDay_Load(object sender, EventArgs e)
        {
            DataTable dt = bus.getMonHocGiangDayInHocKy(hkBD,hkKT, dbBus);
            CommonUtils.initCbbData(hkCbb, CommonUtils.getColumn(dt, "MHK"));

            monHocDGV.DataSource = dtMonHoc;
            gvDGV.DataSource= dtTyLe;
        }
        
        private void generateMonHocBieuDo()
        {
            while (bieuDoChart.Series.Count > 0) { bieuDoChart.Series.RemoveAt(0); }
            bieuDoChart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            bieuDoChart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            Series series = new Series(string.Format("{0} {1}", monHoc.maMH ,monHoc.tenMH));
            bieuDoChart.Series.Add(series);
            foreach (DataRow row in dtMonHoc.Rows)
            {
                for (int i = 2; i < dtMonHoc.Columns.Count; i++)
                {
                    string title = string.Format("{0} {1}", row["MAGIANGVIEN"].ToString(),
                                                  row["HOTEN"].ToString());
                    double value = Double.Parse(row[i].ToString());
                    bieuDoChart.Series[0].Points.AddXY(title, value);

                }
            }

            bieuDoChart.ChartAreas[0].RecalculateAxesScale();  //tự động xác định min và max trục Y
            bieuDoChart.ChartAreas[0].AxisX.Interval = 1;     //hiện các giá trị trên trục X
            bieuDoChart.Series[0].IsValueShownAsLabel = true;

        }

        private void generateGiangVienBieuDo()
        {
            while (GVBieuDo.Series.Count > 0) { GVBieuDo.Series.RemoveAt(0); }
            GVBieuDo.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            GVBieuDo.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            Series series = new Series("Tỷ lệ đạt");
            GVBieuDo.Series.Add(series);
            foreach (DataRow row in dtTyLe.Rows)
            {
                for (int i = 2; i < dtTyLe.Columns.Count; i++)
                {
                    string title = string.Format("{0} {1}", row["MAGIANGVIEN"].ToString(),
                                                  row["HOTEN"].ToString());
                    double value = Double.Parse(row[i].ToString());
                    GVBieuDo.Series["Tỷ lệ đạt"].Points.AddXY(title, value);
                    
                }
            }

            GVBieuDo.ChartAreas[0].RecalculateAxesScale();  //tự động xác định min và max trục Y
            GVBieuDo.ChartAreas[0].AxisX.Interval = 1;     //hiện các giá trị trên trục X
            GVBieuDo.Series[0].IsValueShownAsLabel = true;

        }
        private void cbbLoaiBieuDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbbLoaiBieuDo.SelectedIndex)
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

        private void gvDGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            hkCbb.Enabled = true;
            hkCbb.SelectedIndex = -1;

            mGV = gvDGV.CurrentRow.Cells["MAGIANGVIEN"].Value.ToString();
            DataTable dt = bus.getTyLeDatGVThroughOutHK(hkBD, hkKT, mGV, dbBus);

            updateGVBieuDo(mGV, dt);
        }

        private void updateGVBieuDo(string maGV, DataTable dt)
        {
            if(dt.Rows.Count <= 0 || dt == null)
            {
                return;
            }    

            while (GVBieuDo.Series.Count > 0) { GVBieuDo.Series.RemoveAt(0); }
            GVBieuDo.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            GVBieuDo.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            Series series = new Series(string.Format("{0} {1}",
                                       maGV,
                                       dt.Rows[0][2].ToString()));
            GVBieuDo.Series.Add(series);
            foreach (DataRow row in dt.Rows)
            {
                for (int i = 3; i < dt.Columns.Count; i++)
                {
                    string title = row["MHK"].ToString();
                    double value = Double.Parse(row[i].ToString());
                    GVBieuDo.Series[0].Points.AddXY(title, value);

                }
            }

            GVBieuDo.ChartAreas[0].RecalculateAxesScale();  //tự động xác định min và max trục Y
            GVBieuDo.ChartAreas[0].AxisX.Interval = 1;     //hiện các giá trị trên trục X
            GVBieuDo.Series[0].IsValueShownAsLabel = true;
        }

        
        private void resetBtn_Click(object sender, EventArgs e)
        {
            generateGiangVienBieuDo();
            hkCbb.Enabled = false;
        }

        private void cbbLoaiBieuDoGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbLoaiBieuDoGV.SelectedIndex)
            {
                case 0:
                    GVBieuDo.Series[0].ChartType = SeriesChartType.Column;
                    break;
                case 1:
                    GVBieuDo.Series[0].ChartType = SeriesChartType.Bar;
                    break;
                case 2:
                    GVBieuDo.Series[0].ChartType = SeriesChartType.Line;
                    break;

            }
        }

        private void hkCbb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedHK = int.Parse(hkCbb.SelectedItem.ToString());
            DataTable dtCurrent = bus.getTyLeDatGVTheoMonInHK(selectedHK, selectedHK, mGV, dbBus);

            if (dtCurrent.Rows.Count <= 0 || dtCurrent == null)
            {
                return;
            }

            while (GVBieuDo.Series.Count > 0) { GVBieuDo.Series.RemoveAt(0); }
            GVBieuDo.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            GVBieuDo.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            Series series = new Series(string.Format("{0} {1}",
                                       mGV,
                                       dtCurrent.Rows[0][2].ToString()));
            GVBieuDo.Series.Add(series);
            foreach (DataRow row in dtCurrent.Rows)
            {
                string title = row["MAMONHOC"].ToString() + " " + row["TENMH"].ToString();
                double value = Double.Parse(row["Tỷ lệ đạt"].ToString());
                GVBieuDo.Series[0].Points.AddXY(title, value);
            }

            GVBieuDo.ChartAreas[0].RecalculateAxesScale();  //tự động xác định min và max trục Y
            GVBieuDo.ChartAreas[0].AxisX.Interval = 1;     //hiện các giá trị trên trục X
            GVBieuDo.Series[0].IsValueShownAsLabel = true;
        }

        private void findGVBtn_Click(object sender, EventArgs e)
        {
            string selectQuery;
            if (dtTyLe == null)
            {
                return;
            }
            if (tenGVRadioBtn.Checked)
            {
                selectQuery = string.Format("HOTEN LIKE '*{0}*'", findGVTxt.Text);
            }
            else
            {
                selectQuery = string.Format("MAGIANGVIEN = '{0}'", findGVTxt.Text);
            }
            gvDGV.DataSource = CommonBusUtils.findDataByQuery(dtTyLe, selectQuery);
        }
    }
}
