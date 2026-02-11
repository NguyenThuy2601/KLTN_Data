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
    public partial class ThongKeDiem : Form
    {
        DbBus dbBus;
        ThongKeDiemBUS bus;
        DataTable dt;
        FrequentParam param;
 
        bool haveLopInDatatable;
        string info;
        string formatedHocKi;
        public ThongKeDiem()
        {
            InitializeComponent();
        }

        public ThongKeDiem(DbBus dBBus) : this()
        {
            dbBus = dBBus;
            bus = new ThongKeDiemBUS();

            DataTable dt = bus.getMonHocGiangDayInHocKy(100, 500, dbBus);
            CommonUtils.initCbbData(hkbdCbb, CommonUtils.getColumn(dt, "MHK"));
            CommonUtils.initCbbData(hkktCbb, CommonUtils.getColumn(dt, "MHK"));
        }

        
        private void Form2_Load(object sender, EventArgs e)
        {
            CommonUtils.hideControl(LopLbl);
            CommonUtils.hideControl(LopTxt);

            
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

        private void displayDgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            displayDgv.CurrentRow.Selected = true;

            string maGV = displayDgv.CurrentRow.Cells["MAGIANGVIEN"].Value.ToString();
            string GV = displayDgv.CurrentRow.Cells["HOTEN"].Value.ToString();
            string maMH = displayDgv.CurrentRow.Cells["MAMH"].Value.ToString();
            string tenMH = displayDgv.CurrentRow.Cells["TENMH"].Value.ToString();


            if (!haveLopInDatatable)
            {
                param = new FrequentParam(hkbdCbb.Text, hkktCbb.Text, maGV,maMH, null);
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


        private void button3_Click(object sender, EventArgs e)
        {
            CommonUtils.clearText(monHoctxt);
            CommonUtils.clearText(gvTxt);

            displayDgv.DataSource = dt;
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            DataTable tempDT = dt;

            if (!String.IsNullOrEmpty(monHoctxt.Text))
                tempDT = CommonBusUtils.findDataByQuery(tempDT, String.Format("TENMH LIKE '*{0}*'", monHoctxt.Text));

            if (!String.IsNullOrEmpty(gvTxt.Text))
                tempDT = CommonBusUtils.findDataByQuery(tempDT, String.Format("HOTEN LIKE '*{0}*'", gvTxt.Text));

            if (!String.IsNullOrEmpty(LopTxt.Text))
                tempDT = CommonBusUtils.findDataByQuery(tempDT, String.Format("MANLOPHOC LIKE '*{0}*'", LopTxt.Text));

            displayDgv.DataSource = tempDT;
        }
      
        private void gkBtn_Click(object sender, EventArgs e)
        {
            string frmName;
            if (displayDgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chưa chọn thông tin cần xem thống kê điểm số");
                return;
            }    
            DataTable dtRaw;
            DataTable dtTyLe;

            if(!haveLopInDatatable)
            {
                dtTyLe = bus.getThongKeTyLeDiem(param, dbBus, "ThongKeTyLeQTTheoMon");
                dtRaw = bus.getThongKeDiem(param, dbBus, "BCMH2_8");
                frmName = "Giữa kì-{0}-{1}-{2}-{3}-{4}";
            }    
            else
            {
                dtTyLe = bus.getThongKeTyLeDiemTheoLop(param, dbBus, "ThongKeTyLeDiemQTTheoLop");
                dtRaw = bus.getThongKeDiemTheoLop(param, dbBus, "ThongKeDiemQTTheoLop");
                frmName = "Giữa kì-{0}-{1}-{2}-{3}-{4}-{5}";
            }

           
            frmXemDiem form = new frmXemDiem(dtRaw, dtTyLe, info, frmName);
            form.Show();
        }

        private void ckBtn_Click(object sender, EventArgs e)
        {
            string frmName;
            if (displayDgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chưa chọn thông tin cần xem thống kê điểm số");
                return;
            }
            DataTable dtRaw;
            DataTable dtTyLe;
            if (!haveLopInDatatable)
            {
                dtTyLe = bus.getThongKeTyLeDiem(param, dbBus, "ThongKeTyLeCKTheoMon");
                dtRaw = bus.getThongKeDiem(param, dbBus, "BCMH2_9");

                frmName = "Cuối kì-{0}-{1}-{2}-{3}-{4}"; 
            }
            else
            {
                dtTyLe = bus.getThongKeTyLeDiemTheoLop(param, dbBus, "ThongKeTyLeDiemCKTheoLop");
                dtRaw = bus.getThongKeDiemTheoLop(param, dbBus, "ThongKeDiemCKTheoLop");

                frmName = "Cuối kì-{0}-{1}-{2}-{3}-{4}-{5}";
            }

            
            frmXemDiem form = new frmXemDiem(dtRaw, dtTyLe, info, frmName);
            form.Show();
        }

        private void tongKetBtn_Click(object sender, EventArgs e)
        {
            string frmName;
            if (displayDgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chưa chọn thông tin cần xem thống kê điểm số");
                return;
            }
            DataTable dtRaw;
            DataTable dtTyLe;
            if (!haveLopInDatatable)
            {
                dtTyLe = bus.getThongKeTyLeDiem(param, dbBus, "ThongKeTyLeTongKetTheoMon");
                dtRaw = bus.getThongKeDiem(param, dbBus, "BCMH2_10");
                frmName = "Tổng kết-{0}-{1}-{2}-{3}-{4}";
            }
            else
            {
                dtTyLe = bus.getThongKeTyLeDiemTheoLop(param, dbBus, "ThongKeTyLeDiemTongKetTheoLop");
                dtRaw = bus.getThongKeDiemTheoLop(param, dbBus, "ThongKeDiemTongKetTheoLop");
                frmName = "Tổng kết-{0}-{1}-{2}-{3}-{4}-{5}";
            }

            frmXemDiem form = new frmXemDiem(dtRaw, dtTyLe, info, frmName);
            form.Show();
        }
    }
}
