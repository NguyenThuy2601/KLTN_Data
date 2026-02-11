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
    public partial class frmHoTroPhanCong : Form
    {
        Form1 mainForm;

        DbBus dbBus;
        HoTroPhanCongBus bus;

        int currentVisibleResult = 0;
        int crossTableMaxRow = 0;

        int nguongDat = 50;
        int nguongTot = 80;

        double doLech = 0.3;

        List<MonHoc> listMH;
        List<MonHoc> listChosenMH;

        List<int> nguongDatList = new List<int>();
        List<int> nguongTotList = new List<int>();
        List<int> hkBDList = new List<int>();
        List<int> hkKTList = new List<int>();

        List<DataTable> resultDTList;

        string tyLeTotQuery = "[Tỷ lệ đạt] >= {0}";
        string tyLeDatQuery = "[Tỷ lệ đạt] >= {0} AND [Tỷ lệ đạt] < {1}";
        string tyLeKhongDatQuery = "[Tỷ lệ đạt] < {0}";

        DataTable dtMonHoc;
        DataTable dtCrossTable;
        public frmHoTroPhanCong()
        {
            InitializeComponent();
        }
        public frmHoTroPhanCong(DbBus dbBus, Form1 mainForm) : this()
        {
            this.dbBus = dbBus;
            this.mainForm = mainForm;

            listMH = new List<MonHoc>();
            listChosenMH = new List<MonHoc>();

            resultDTList = new List<DataTable>();

            bus = new HoTroPhanCongBus();

            dtMonHoc = bus.getMonHoc(dbBus);
        }

        private void frmHoTroPhanCong_Load(object sender, EventArgs e)
        {
            dgvMonHoc.DataSource = dtMonHoc;

            previousBtn.Enabled = false;
            afterBtn.Enabled = false;
            openCrossTableFrmBtn.Enabled = false;

            errorLbl.Visible = false;
        }

        private void setResultDGV(string condition, DataGridView dgv, DataTable source)
        {
            DataTable temp = CommonBusUtils.findDataByQuery(source, condition);
            dgv.DataSource = temp;
        }

        private void initNguongDatVaNguongTotList(int Limit, int nguongDatStandard, int nguongTotStandard, int hkBD, int hkKT)
        {
            if (nguongDatList.Count != 0)
                nguongDatList.Clear();
            if (nguongTotList.Count != 0)
                nguongTotList.Clear();
            if(hkBDList.Count != 0)
                hkBDList.Clear();
            if(hkKTList.Count != 0)
                hkKTList.Clear();

            for(int i = 0; i < Limit; i++)
            {
                nguongTotList.Add(nguongTotStandard);
                nguongDatList.Add(nguongDatStandard);
                hkBDList.Add(hkBD);
                hkKTList.Add(hkKT);
            }    
        }

        private bool checkExistGVInList(string maMH)
        {
            bool containsMaGV = listMH.Any(mh => mh.maMH == maMH);

            return containsMaGV;
        }

        private void dgvMonHoc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvMonHoc.CurrentRow.Selected = true;

            string maMH = dgvMonHoc.CurrentRow.Cells["MAMONHOC"].Value.ToString();
            string tenMH = dgvMonHoc.CurrentRow.Cells["TENMONHOC"].Value.ToString();

            MonHoc mh = new MonHoc(maMH, tenMH);

            if(!checkExistGVInList(maMH))
            {
                listMH.Add(mh);
                selectedMHListBox.Items.Add(mh.ToString());
            }    
        }

        private void findNameBtn_Click(object sender, EventArgs e)
        {
            DataTable temp = dtMonHoc;
            if(!String.IsNullOrEmpty(tenMHTxt.Text))
            {
                temp = CommonBusUtils.findDataByQuery(dtMonHoc, String.Format("TENMONHOC LIKE '*{0}*'", tenMHTxt.Text));
            }

            dgvMonHoc.DataSource = temp;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DataTable temp = dtMonHoc;
            if (!String.IsNullOrEmpty(mMHTxt.Text))
            {
                temp = CommonBusUtils.findDataByQuery(dtMonHoc, String.Format("MAMONHOC = '{0}'", mMHTxt.Text));
               
            }

            dgvMonHoc.DataSource = temp;
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            if(listMH.Count <= 0)
            {
                return;
            } 
            if(doLechTxt.Text == "")
            {
                errorLbl.Text = "Chưa nhập dữ liệu";
                errorLbl.Visible = true;
                return ;
            }    
            listChosenMH = new List<MonHoc>(listMH);
            errorLbl.Visible = false;
            currentVisibleResult = 0;
            intitCrossTableData();
            doLech = (double)int.Parse(doLechTxt.Text) / 100 ;

            if (resultDTList.Count > 0)
                resultDTList.Clear();

            for(int i = 0; i < listChosenMH.Count; i++)
            {
                DataTable result = bus.getXepHangGV(listChosenMH[i], 100, 500, doLech, dbBus);
                resultDTList.Add(result);
                setDataCrossTable(result, selectedMHListBox.Items[i].ToString());
            }

            
            setResultDGV(string.Format(tyLeTotQuery, nguongTot), dauRaTotDGV, resultDTList[0]);
            setResultDGV(string.Format(tyLeDatQuery, nguongDat, nguongTot), dauRaDatDGV, resultDTList[0]);
            setResultDGV(string.Format(tyLeKhongDatQuery, nguongDat), dauRaYeuDGV, resultDTList[0]);

            initNguongDatVaNguongTotList(resultDTList.Count, 50, 80, 100, 500);
            CommonUtils.setText(mMHLbl, listChosenMH[0].maMH);
            CommonUtils.setText(tenMHLbl, listChosenMH[0].tenMH);

            nguongDatTxt.Text = "50";
            nguongTotTxt.Text = "80";
            hkBDTxt.Text = "";
            hkKTTxt.Text = "";

            previousBtn.Enabled = true;
            afterBtn.Enabled = true;
            openCrossTableFrmBtn.Enabled = true;
        }


        private void previousBtn_Click(object sender, EventArgs e)
        {
            if (currentVisibleResult == 0)
                return;
            else
            {
                currentVisibleResult--;

                CommonUtils.setText(mMHLbl, listChosenMH[currentVisibleResult].maMH);
                CommonUtils.setText(tenMHLbl, listChosenMH[currentVisibleResult].tenMH);

                setResultDGV(string.Format(tyLeTotQuery, nguongTotList[currentVisibleResult]), dauRaTotDGV, resultDTList[currentVisibleResult]);
                setResultDGV(string.Format(tyLeDatQuery, nguongDatList[currentVisibleResult], nguongTotList[currentVisibleResult]), dauRaDatDGV, resultDTList[currentVisibleResult]);
                setResultDGV(string.Format(tyLeKhongDatQuery, nguongDatList[currentVisibleResult]), dauRaYeuDGV, resultDTList[currentVisibleResult]);

                CommonUtils.setText(nguongDatTxt, nguongDatList[currentVisibleResult].ToString());
                CommonUtils.setText(nguongTotTxt, nguongTotList[currentVisibleResult].ToString());

                CommonUtils.setText(nguongDatTxt, nguongDatList[currentVisibleResult].ToString());
                CommonUtils.setText(nguongTotTxt, nguongTotList[currentVisibleResult].ToString());
                CommonUtils.setText(hkBDTxt, hkBDList[currentVisibleResult] == 100
                                             ? ""
                                             : hkBDList[currentVisibleResult].ToString());
                CommonUtils.setText(hkKTTxt, hkKTList[currentVisibleResult] == 500
                                             ? ""
                                             : hkKTList[currentVisibleResult].ToString());
            }
        }

        private void afterBtn_Click(object sender, EventArgs e)
        {
            hkKTTxt.Text = "";
            hkBDTxt.Text = "";

            if (currentVisibleResult == listChosenMH.Count - 1)
                return;
            else
            {
                currentVisibleResult++;

                CommonUtils.setText(mMHLbl, listChosenMH[currentVisibleResult].maMH);
                CommonUtils.setText(tenMHLbl, listChosenMH[currentVisibleResult].tenMH);

                setResultDGV(string.Format(tyLeTotQuery, nguongTotList[currentVisibleResult]), dauRaTotDGV, resultDTList[currentVisibleResult]);
                setResultDGV(string.Format(tyLeDatQuery, nguongDatList[currentVisibleResult], nguongTotList[currentVisibleResult]), dauRaDatDGV, resultDTList[currentVisibleResult]);
                setResultDGV(string.Format(tyLeKhongDatQuery, nguongDatList[currentVisibleResult]), dauRaYeuDGV, resultDTList[currentVisibleResult]);

                CommonUtils.setText(nguongDatTxt, nguongDatList[currentVisibleResult].ToString());
                CommonUtils.setText(nguongTotTxt, nguongTotList[currentVisibleResult].ToString());
                CommonUtils.setText(hkBDTxt, hkBDList[currentVisibleResult] == 100 
                                             ? "" 
                                             : hkBDList[currentVisibleResult].ToString());
                CommonUtils.setText(hkKTTxt, hkKTList[currentVisibleResult] == 500
                                             ? ""
                                             : hkKTList[currentVisibleResult].ToString());
            }
        }

        private void delAllBtn_Click(object sender, EventArgs e)
        {
            listMH.Clear();
            selectedMHListBox.Items.Clear();

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = selectedMHListBox.SelectedIndex;
            if (listMH.Count == 0)
                return;
            if (selectedIndex == -1)
            {
                listMH.RemoveAt(selectedMHListBox.Items.Count - 1);
                selectedMHListBox.Items.RemoveAt(selectedMHListBox.Items.Count - 1);
                
                
            }
            else
            {
                selectedMHListBox.Items.RemoveAt(selectedIndex);

                listMH.RemoveAt(selectedIndex);
            }
        }

        private void changeChartBtn_Click(object sender, EventArgs e)
        {
            initNguongDatVaNguongTotList(listChosenMH.Count, nguongDat, nguongTot, 100, 500);

            CommonUtils.setText(nguongDatTxt, "50");
            CommonUtils.setText(nguongTotTxt, "80");
            CommonUtils.setText(hkBDTxt, "");
            CommonUtils.setText(hkKTTxt, "");
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            int hkBD = hkBDTxt.Text == "" ? 100 : int.Parse(hkBDTxt.Text);
            int hkKT = hkKTTxt.Text == "" ? 500 : int.Parse(hkKTTxt.Text);
            if (listChosenMH.Count == 0)
                return;
            

            DataTable result = bus.getXepHangGV(listChosenMH[currentVisibleResult], hkBD, hkKT, doLech, dbBus);
            resultDTList[currentVisibleResult] = result;
            updateDataCrossTable(result, selectedMHListBox.Items[currentVisibleResult].ToString());

            setResultDGV(string.Format(tyLeTotQuery, nguongTotTxt.Text), dauRaTotDGV, resultDTList[currentVisibleResult]);
            setResultDGV(string.Format(tyLeDatQuery, nguongDatTxt.Text, nguongTotTxt.Text), dauRaDatDGV, resultDTList[currentVisibleResult]);
            setResultDGV(string.Format(tyLeKhongDatQuery, nguongDatTxt.Text), dauRaYeuDGV, resultDTList[currentVisibleResult]);

            nguongDatList[currentVisibleResult] = int.Parse(nguongDatTxt.Text);
            nguongTotList[currentVisibleResult] = int.Parse(nguongTotTxt.Text);
            hkBDList[currentVisibleResult] = hkBD;
            hkKTList[currentVisibleResult] = hkKT;
        }


        private void intitCrossTableData()
        {
            dtCrossTable = new DataTable();

            dtCrossTable.Columns.Add("Tên GV/ môn học");

            DataTable temp = bus.getAllGiangVien(dbBus);
            for(int i = 0; i < temp.Rows.Count; i++)
                dtCrossTable.Rows.Add(temp.Rows[i][0].ToString());

            crossTableMaxRow = temp.Rows.Count;
        }

        private void setDataCrossTable(DataTable data, string columnName)
        {
            dtCrossTable.Columns.Add(columnName);
            for(int i = 0; i < crossTableMaxRow; i++)
            {
                string maGV = dtCrossTable.Rows[i]["Tên GV/ môn học"].ToString().Split(' ')[0].Trim();
                DataRow[] drResult = data.Select(string.Format("MAGIANGVIEN Like '{0}'", maGV));

                if(drResult.Length > 0)
                {
                    dtCrossTable.Rows[i][columnName] = drResult[0]["Tỷ lệ đạt"].ToString();
                }   
                else
                {
                    dtCrossTable.Rows[i][columnName] = "0";
                }    
            }    
        }

        private void updateDataCrossTable(DataTable data, string columnName)
        {
            for (int i = 0; i < crossTableMaxRow; i++)
            {
               
                string maGV = dtCrossTable.Rows[i]["Tên GV/ môn học"].ToString().Split(' ')[0].Trim();
                DataRow[] drResult = data.Select(string.Format("MAGIANGVIEN Like '{0}'", maGV));

                if (drResult.Length > 0)
                {
                    dtCrossTable.Rows[i][columnName] = drResult[0]["Tỷ lệ đạt"].ToString();
                }
                else
                {
                    dtCrossTable.Rows[i][columnName] = "0";
                }
            }
        }

        private void openCrossTableFrmBtn_Click(object sender, EventArgs e)
        {
            DataTable dtTyLeDatAllGV = bus.getThongKeTyLeDatCuaGiangVienInHK(100, 500, dbBus);

            mainForm.archiveForm = this;
            mainForm.openChildForm(new frmCrossTable(mainForm, dtCrossTable, dtTyLeDatAllGV, bus, dbBus), false);
        }

        private void doLechTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
