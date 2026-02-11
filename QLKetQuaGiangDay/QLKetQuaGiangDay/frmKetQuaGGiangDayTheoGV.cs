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
    public partial class frmKetQuaGGiangDayTheoGV : Form
    {
        DbBus dbBus;
        ThongKeKetQuaGiangDayBus bus;

        int hkBD = 100;
        int hkKT = 500;

        string maGV;

        DataTable dtGV;
        DataTable dtTyleDatOverall;
        DataTable dtTyleDatCKCKOverall;

        DataTable dtTyleDatSpecific;
        DataTable dtTyLeDatGKCKSpecific;

        DataTable dtTacPhong;
        DataTable dtTacPhongSpecific;

        public frmKetQuaGGiangDayTheoGV()
        {
            InitializeComponent();
        }

        public frmKetQuaGGiangDayTheoGV(DbBus dbBus) : this()
        {
            this.dbBus = dbBus;
            bus = new ThongKeKetQuaGiangDayBus();

            DataTable dt = bus.getMonHocGiangDayInHocKy(100, 500, dbBus);
            CommonUtils.initCbbData(hkbdCbb, CommonUtils.getColumn(dt, "MHK"));
            CommonUtils.initCbbData(hkktCbb, CommonUtils.getColumn(dt, "MHK"));

            dtGV = bus.getAllGV(dbBus);
        }
        private void frmKetQuaGGiangDayTheoGV_Load(object sender, EventArgs e)
        {
            displayDgv.DataSource = dtGV;
            

            hkCbb.Visible = false;

            detailChkBox.Visible = false;
            detailChkBox.Checked = false;
            xemTacPhongChkBox.Visible = false;
            xemTacPhongChkBox.Checked = false;
            
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            findGVTxt.Text = "";
        }

        private void tenMHRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            findGVLbl.Text = tenGVRadioBtn.Text;
        }

        private void mMHRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            findGVLbl.Text = mGVRadioBtn.Text;
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            string selectedString = "";
            if(tenGVRadioBtn.Checked)
            {
                selectedString = string.Format("GiangVien LIKE '*{0}*'", findGVTxt.Text);
            }   
            else
            {
                selectedString = string.Format("GiangVien LIKE '{0}*'", findGVTxt.Text);
            }

            displayDgv.DataSource = CommonBusUtils.findDataByQuery(dtGV, selectedString);
        }

        private void setHkBtn_Click(object sender, EventArgs e)
        {
            hkBD = hkbdCbb.SelectedIndex == -1 ? 100 : int.Parse(hkbdCbb.Text);
            hkKT = hkktCbb.SelectedIndex == -1 ? 500 : int.Parse(hkktCbb.Text);

            if(displayDgv.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn giảng viên cần xem");
            }    

            DataTable dt = bus.getMonHocGiangDayInHocKy(hkBD, hkKT, dbBus);

            string[] temp = displayDgv.CurrentRow.Cells["GiangVien"].Value.ToString().Split(' ');
            maGV = temp[0].Trim();

            dtTyleDatCKCKOverall = bus.getTyLeDatCKGKThroughOutHK(maGV, hkBD, hkKT, dbBus);
            dtTyleDatOverall = bus.getTyLeDatGVThroughOutHK(hkBD, hkKT, maGV, dbBus);
            dtTacPhong = bus.getTinhHinhGiangDayInHK(maGV, hkBD, hkKT, dbBus);

            List<string> list = CommonUtils.getColumn(dt, "MHK");
            list.Add("Tất cả học kì");
            CommonUtils.initCbbData(hkCbb, list);

            giangVienDGV.DataSource = dtTyleDatOverall;
            generateMonHocBieuDo();

            hkCbb.Visible = true;
            detailChkBox.Visible = true;
            xemTacPhongChkBox.Visible = true;

            detailChkBox.Checked = false;
            xemTacPhongChkBox.Checked = false;

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
                        bieuDoChart.Series[i].ChartType = SeriesChartType.Line;
                        break;

                }
            }    
            
        }

        public void setGiangVienDGVContent()
        {
            DataTable chosenDT;
            bool condition = hkCbb.SelectedIndex == -1 || hkCbb.SelectedIndex == hkCbb.Items.Count - 1;
            if (!detailChkBox.Checked && !xemTacPhongChkBox.Checked)
            {
                chosenDT = condition ? dtTyleDatOverall : dtTyleDatSpecific;
            }
            else if (detailChkBox.Checked)
            {
                chosenDT = condition ? dtTyleDatCKCKOverall : dtTyLeDatGKCKSpecific;
            }
            else
            {
                chosenDT = condition ? dtTacPhong : dtTacPhongSpecific;
                
            }
            giangVienDGV.DataSource = chosenDT;
        }

        private void detailChkBox_Click(object sender, EventArgs e)
        {
            if(detailChkBox.Checked)
            {
                xemTacPhongChkBox.Checked = false;
            }    
            generateMonHocBieuDo();
            setGiangVienDGVContent();
        }

        private void generateMonHocBieuDo()
        {
            bieuDoChart.Series.Clear();

            populateBieuDoSeries();

            for (int i = 0; i < bieuDoChart.Series.Count; i++)
            {
                bieuDoChart.Series[i].IsValueShownAsLabel = true;
            }
            for (int i = 0; i < bieuDoChart.ChartAreas.Count; i++)
            {
                bieuDoChart.ChartAreas[i].RecalculateAxesScale();  //tự động xác định min và max trục Y
                bieuDoChart.ChartAreas[i].AxisX.Interval = 1;     //hiện các giá trị trên trục X

                bieuDoChart.ChartAreas[i].AxisX.MajorGrid.LineWidth = 0;
                bieuDoChart.ChartAreas[i].AxisY.MajorGrid.LineWidth = 0;
            }

        }

       public void generateSeries(string seriesName, int  beginColIndex, int currentRow, DataTable dt )
        {
            string title = seriesName;

            Series series = new Series(title);
            bieuDoChart.Series.Add(series);

            for (int j = beginColIndex; j < dt.Columns.Count; j++)
            {
                string titleCol = dt.Columns[j].ColumnName;
                double value = double.Parse(dt.Rows[currentRow][j].ToString());
                bieuDoChart.Series[currentRow].Points.AddXY(titleCol, CommonUtils.RoundIfNeeded(value));
            }
        }

        public void populateBieuDoSeries()
        {
            int i = 0;
            if (!detailChkBox.Checked && !xemTacPhongChkBox.Checked)
            {
                if (hkCbb.SelectedIndex == -1 || hkCbb.SelectedIndex == hkCbb.Items.Count - 1)
                {
                    foreach (DataRow row in dtTyleDatOverall.Rows)
                    {
                        generateSeries(row["MHK"].ToString(), 3, i, dtTyleDatOverall);
                        i++;
                    }

                }   
                else
                {
                  
                    foreach (DataRow row in dtTyleDatSpecific.Rows)
                    {
                        string title = string.Format("{0} {1}", row["MAMONHOC"].ToString(),
                                                   row["TENMH"].ToString());

                        generateSeries(title, 4, i , dtTyleDatSpecific);
                        i++;
                    }
                }    
            }
            else if(detailChkBox.Checked)
            {
                if(hkCbb.SelectedIndex == -1 || hkCbb.SelectedIndex == hkCbb.Items.Count - 1)
                {
                    
                    foreach (DataRow row in dtTyleDatCKCKOverall.Rows)
                    {
                        generateSeries(row["MHK"].ToString(), 3, i, dtTyleDatCKCKOverall);
                        i++;
                    }
                }    
               else
                {
                    foreach (DataRow row in dtTyLeDatGKCKSpecific.Rows)
                    {
                        string title = string.Format("{0} {1}", row["MAMONHOC"].ToString(),
                                                      row["TENMH"].ToString());

                        generateSeries(title, 4, i, dtTyLeDatGKCKSpecific);
                        i++;
                    }
                }    
            }
            else 
            {
                if (hkCbb.SelectedIndex == -1 || hkCbb.SelectedIndex == hkCbb.Items.Count - 1)
                {

                    foreach (DataRow row in dtTacPhong.Rows)
                    {
                        generateSeries(row["MHK"].ToString(), 3, i, dtTacPhong);
                        i++;
                    }
                }
                else
                {
                    foreach (DataRow row in dtTacPhongSpecific.Rows)
                    {
                        string title = string.Format("{0} {1}", row["MAMH"].ToString(),
                                                      row["TENMH"].ToString());

                        generateSeries(title, 4, i, dtTacPhongSpecific);
                        i++;
                    }
                }
            }
        }

        

        private void xemTacPhongChkBox_Click(object sender, EventArgs e)
        {
            if(xemTacPhongChkBox.Checked)
            {
                detailChkBox.Checked = false;
            }
            generateMonHocBieuDo();
            setGiangVienDGVContent(); 
        }

        private void hkCbb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(hkCbb.SelectedIndex == hkCbb.Items.Count - 1)
            {
                dtTyleDatOverall = bus.getTyLeDatGVThroughOutHK(hkBD, hkKT, maGV, dbBus);
                dtTyleDatCKCKOverall = bus.getTyLeDatCKGKThroughOutHK(maGV, hkBD, hkKT, dbBus);
                dtTacPhong = bus.getTinhHinhGiangDayInHK(maGV, hkBD, hkKT, dbBus);
            }   
            else
            {
                int selectedHK = int.Parse(hkCbb.SelectedItem.ToString());
                dtTacPhongSpecific = bus.getTinhHinhGiangDayInHKTheoMon(maGV, selectedHK, selectedHK, dbBus);
                dtTyleDatSpecific = bus.getTyLeDatGVTheoMonInHK(selectedHK , selectedHK, maGV, dbBus);
                dtTyLeDatGKCKSpecific = bus.getTyLeGKVaCKDatGVTheoMonInHK(maGV, selectedHK, selectedHK, dbBus);
            }

            generateMonHocBieuDo();
            setGiangVienDGVContent();
        }

        private void displayDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            displayDgv.CurrentRow.Selected = true;

            

        }

        private void frmKetQuaGGiangDayTheoGV_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void frmKetQuaGGiangDayTheoGV_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.updateThongKeKetQuaForm(false, this);
        }
    }
}
