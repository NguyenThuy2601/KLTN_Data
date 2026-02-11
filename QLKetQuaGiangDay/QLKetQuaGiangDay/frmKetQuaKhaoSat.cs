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

namespace QLKetQuaGiangDay
{
    public partial class frmKetQuaKhaoSat : Form
    {
        DbBus dbBus;
        XemKetQuaDanhGiaBus bus;

        DataTable dt;

        string info;
        string formatedHocKi;
        bool haveLopInDatatable;

        FrequentParam param = null;
        public frmKetQuaKhaoSat()
        {
            InitializeComponent();
        }

        public frmKetQuaKhaoSat(DbBus dBBus) : this()
        {
            dbBus = dBBus;
            bus = new XemKetQuaDanhGiaBus();

            DataTable dt = bus.getMonHocGiangDayInHocKy(100, 500, dbBus);
            CommonUtils.initCbbData(hkbdCbb, CommonUtils.getColumn(dt, "MHK"));
            CommonUtils.initCbbData(hkktCbb, CommonUtils.getColumn(dt, "MHK"));
        }

        private void getDataBtn_Click(object sender, EventArgs e)
        {
            int hkBD = int.Parse(hkbdCbb.Text);
            int hkKT = int.Parse(hkktCbb.Text);
            dt = TheoLopChk.Checked ?
                  bus.getLopGiangDayInHocKy(hkBD, hkKT, dbBus) :
                   bus.getMonHocGiangDayInHocKyWithGV(hkBD, hkKT, dbBus);
            displayDgv.DataSource = dt;
            formatedHocKi = hkBD == hkKT ? hkbdCbb.Text : string.Format("{0}-{1}", hkBD, hkKT);

            haveLopInDatatable = TheoLopChk.Checked;
            if (!TheoLopChk.Checked)
            {
                CommonUtils.hideControl(LopLbl);
                CommonUtils.hideControl(LopTxt);
            }
            else
            {
                CommonUtils.showControl(LopLbl);
                CommonUtils.showControl(LopTxt);
            }
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            DataTable tempDT = dt;

            if (!String.IsNullOrEmpty(monHoctxt.Text))
                tempDT = CommonBusUtils.findDataByQuery(tempDT, String.Format("TENMH LIKE '*{0}*'", monHoctxt.Text));

            if (!String.IsNullOrEmpty(gvTxt.Text))
                tempDT = CommonBusUtils.findDataByQuery(tempDT, String.Format("HOTEN LIKE '*{0}*'", gvTxt.Text));

            if (!String.IsNullOrEmpty(LopTxt.Text) && haveLopInDatatable)
                tempDT = CommonBusUtils.findDataByQuery(tempDT, String.Format("MANLOPHOC LIKE '*{0}*'", LopTxt.Text));

            displayDgv.DataSource = tempDT;
        }

        private void displayDgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            displayDgv.CurrentRow.Selected = true;

            string maGV = displayDgv.CurrentRow.Cells["MAGIANGVIEN"].Value.ToString();
            string GV = displayDgv.CurrentRow.Cells["HOTEN"].Value.ToString();
            string maMH = displayDgv.CurrentRow.Cells["MAMH"].Value.ToString();
            string tenMH = displayDgv.CurrentRow.Cells["TENMH"].Value.ToString();


            if (!haveLopInDatatable)
            {
                param = new FrequentParam(hkbdCbb.Text, hkktCbb.Text, maGV, maMH, null);
                info = string.Format("{0},{1},{2},{3},{4}",
                                      formatedHocKi,
                                      maMH,
                                      tenMH,
                                      maGV,
                                      GV);
            }
            else
            {
                string maLop = displayDgv.CurrentRow.Cells["MANLOPHOC"].Value.ToString();
                param = new FrequentParam(hkbdCbb.Text, hkktCbb.Text, maGV, maMH, maLop);
                info = string.Format("{0},{1},{2},{3},{4},{5}",
                                      formatedHocKi,
                                      maMH,
                                      tenMH,
                                      maGV,
                                      GV,
                                      maLop);
            }
        }

        private void ckBtn_Click(object sender, EventArgs e)
        {
            if(param == null)
            {
                MessageBox.Show("Chưa chọn thông tin");
            }
            else
            {
                DataTable data = bus.getDiemKhaoSat(param, dbBus);
                DataTable yKienKhacData = bus.getYKienKhac(param, dbBus);
                DataTable thongKeData = bus.getThongKeKhaoSat(param, dbBus);


                frmKetQuaDanhGia form = new frmKetQuaDanhGia(info, data, yKienKhacData, thongKeData);
                form.Show();
            }    
            
        }

        private void frmKetQuaKhaoSat_Load(object sender, EventArgs e)
        {
            CommonUtils.hideControl(LopLbl);
            CommonUtils.hideControl(LopTxt);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CommonUtils.clearText(LopTxt);
            CommonUtils.clearText(gvTxt);
            CommonUtils.clearText(monHoctxt);

            displayDgv.DataSource = dt;
        }
    }
}
