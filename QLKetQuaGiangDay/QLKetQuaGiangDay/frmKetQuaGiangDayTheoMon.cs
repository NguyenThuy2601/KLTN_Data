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
    public partial class frmKetQuaGiangDayTheoMon : Form
    {
        DbBus dbBus;
        ThongKeKetQuaGiangDayBus bus;

        DataTable dtMonHoc = null;
        DataTable dtThongKe = null;
        DataTable dtThongKeDetail = null;


        int hkBD = 100;
        int hkKT = 500;

        string maMH;

        MonHoc mh;
        public frmKetQuaGiangDayTheoMon()
        {
            InitializeComponent();
        }

        public frmKetQuaGiangDayTheoMon(DbBus dbBus):  this()
        {
            this.dbBus = dbBus;
            bus = new ThongKeKetQuaGiangDayBus();

            DataTable dt = bus.getMonHocGiangDayInHocKy(100, 500, dbBus);
            CommonUtils.initCbbData(hkbdCbb, CommonUtils.getColumn(dt, "MHK"));
            CommonUtils.initCbbData(hkktCbb, CommonUtils.getColumn(dt, "MHK"));
        }

        private void frmKetQuaGiangDay_Load(object sender, EventArgs e)
        {

            dtMonHoc = bus.getMonHoc(dbBus) ;
            displayDgv.DataSource = dtMonHoc;

            detailChkBox.Visible = false;
            detailChkBox.Checked = false;

        }

        private void getDataBtn_Click(object sender, EventArgs e)
        {
            if(displayDgv.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }    
            hkBD = hkbdCbb.SelectedIndex == -1 ? int.Parse(hkbdCbb.Items[0].ToString()) : int.Parse(hkbdCbb.Text);
            hkKT = hkktCbb.SelectedIndex == -1 ? int.Parse(hkktCbb.Items[hkktCbb.Items.Count - 1].ToString()) 
                                                : int .Parse(hkktCbb.Text);

            detailChkBox.Visible = true;
            detailChkBox.Checked = false;


            mh = new MonHoc(displayDgv.SelectedRows[0].Cells["MAMONHOC"].Value.ToString(), displayDgv.SelectedRows[0].Cells["TENMONHOC"].Value.ToString());
           
            dtThongKe = bus.getTyLeDatWithDoChenhLech(mh.maMH ,hkBD, hkKT, dbBus);
            dtThongKeDetail = bus.getDetailDiemGKAnhCK(mh.maMH, hkBD, hkKT, dbBus);

            monHocDGV.DataSource = dtThongKe;
            generateMonHocBieuDo();
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            string selectQuery = "";
            if(dtMonHoc == null)
            {
                return;
            }    
            if(tenMHRadioBtn.Checked)
            {
                selectQuery = string.Format("TENMONHOC LIKE '*{0}*'", findMHTxt.Text);
            }   
            else
            {
                selectQuery = string.Format("MAMONHOC = '{0}'", findMHTxt.Text);
            }    

            displayDgv.DataSource = CommonBusUtils.findDataByQuery(dtMonHoc, selectQuery);
        }

        private void tenMHRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            findMHLbl.Text = tenMHRadioBtn.Text;
        }

        private void mMHRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            findMHLbl.Text = mMHRadioBtn.Text;
        }
        

        private void resetBtn_Click(object sender, EventArgs e)
        {
            mMHRadioBtn.Checked = false;
            tenMHRadioBtn.Checked = true;

            findMHTxt.Text = "";
            displayDgv.DataSource = dtMonHoc;
        }


        private void generateMonHocBieuDo()
        {
            bieuDoChart.Series.Clear();

            populateBieuDoSeries();

            for(int i = 0; i <  bieuDoChart.Series.Count; i++)
            {
              
                bieuDoChart.Series[i].IsValueShownAsLabel = true;

               
            }
            for(int i = 0; i < bieuDoChart.ChartAreas.Count; i++)
            {
                bieuDoChart.ChartAreas[i].RecalculateAxesScale();  //tự động xác định min và max trục Y
                bieuDoChart.ChartAreas[i].AxisX.Interval = 1;     //hiện các giá trị trên trục X

                bieuDoChart.ChartAreas[i].AxisX.MajorGrid.LineWidth = 0;
                bieuDoChart.ChartAreas[i].AxisY.MajorGrid.LineWidth = 0;
            }    

        }

        public void populateBieuDoSeries()
        {
            int i = 0;
            if (!detailChkBox.Checked )
            {
                
                foreach (DataRow row in dtThongKe.Rows)
                {
                    string title = string.Format("{0} {1}", row["MAGIANGVIEN"].ToString(),
                                                      row["HOTEN"].ToString());

                    Series series = new Series(title);
                    bieuDoChart.Series.Add(series);

                    for (int j = 2; j < dtThongKe.Columns.Count; j++)
                    {
                        string titleCol = dtThongKe.Columns[j].ColumnName;
                        int value = int.Parse(row[j].ToString());
                        bieuDoChart.Series[i].Points.AddXY(titleCol, value);
                    }
                    i++;
                }
                
            }   
            else
            {
                foreach (DataRow row in dtThongKeDetail.Rows)
                {
                    string title = string.Format("{0} {1}", row["MAGIANGVIEN"].ToString(),
                                                      row["HOTEN"].ToString());

                    Series series = new Series(title);
                    bieuDoChart.Series.Add(series);


                    for (int j = 4; j < dtThongKeDetail.Columns.Count; j++)
                    {
                        string titleCol = dtThongKeDetail.Columns[j].ColumnName;
                        int value = int.Parse(row[j].ToString());
                        bieuDoChart.Series[i].Points.AddXY(titleCol, value);
                    }
                    i++;
                }
            } 
        }

        private void displayDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            displayDgv.CurrentCell.Selected = true;
        }

        private void detailChkBox_Click(object sender, EventArgs e)
        {
            generateMonHocBieuDo();

        }

        private void cbbLoaiBieuDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < bieuDoChart.Series.Count; i++)
            {
                switch (cbbLoaiBieuDo.SelectedIndex)
                {
                    case 0:
                        bieuDoChart.Series[i].ChartType = SeriesChartType.Column;
                        break;
                    case 1:
                        bieuDoChart.Series[i].ChartType = SeriesChartType.Bar;
                        break;
                    case 2:
                        bieuDoChart.Series[i].ChartType = SeriesChartType.Point;
                        break;

                }
            }    
            
        }

        private void frmKetQuaGiangDayTheoMon_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void frmKetQuaGiangDayTheoMon_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.updateThongKeKetQuaForm(true, this);
        }
    }
}
