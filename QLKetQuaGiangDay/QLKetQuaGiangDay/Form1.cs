using QLKetQuaGiangDay.BUS;
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
    public partial class Form1 : Form
    {
        private Form activeForm = null;
        public Form archiveForm = null;
        private static Form danhGiaTheoMonForm = null;
        private static Form danhGiaTheoGVForm = null;
        DbBus dBBus;

        bool isKetQuaGiangDaySubMenuOpen = false;
        public Form1()
        {
            InitializeComponent();
            dBBus = new DbBus();
        }

        public void openChildForm(Form childForm, bool isNeedToCloseActiveForm)
        {
            if (activeForm != null && isNeedToCloseActiveForm )
            {
                if(danhGiaTheoMonForm == null && danhGiaTheoGVForm == null)
                {
                    activeForm.Close();
                    if (archiveForm != null)
                    {
                        activeForm.GetType();
                        archiveForm.Close();
                    }
                }          
            }    
                
            activeForm = childForm;
            childForm.TopLevel = false;

            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        public void setSubMenuVisible()
        {
            ketQuaGiangDaySubMenuPanel.Visible = isKetQuaGiangDaySubMenuOpen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dBBus.load(true);
            isKetQuaGiangDaySubMenuOpen = false;
            setSubMenuVisible();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new ThongKeDiem(dBBus), true);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            dBBus?.close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHoTroPhanCong(dBBus, this), true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new frmGuiEmail(dBBus), true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new frmKetQuaKhaoSat(dBBus), true);
        }

        private void button_Hover(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            btn.BackColor = Color.Silver;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            btn.BackColor = Color.Transparent;
        }

        private void kqGiangDayBtn_Click(object sender, EventArgs e)
        {
            isKetQuaGiangDaySubMenuOpen = isKetQuaGiangDaySubMenuOpen ? false : true;
            setSubMenuVisible();
        }

        private void ketQuaDayTheoMonBtn_Click(object sender, EventArgs e)
        {
            danhGiaTheoMonForm= danhGiaTheoMonForm == null ?
                                new frmKetQuaGiangDayTheoMon(dBBus) :
                                danhGiaTheoMonForm;

            openChildForm(danhGiaTheoMonForm, false);
        }

        private void ketQuaTheoGVBtn_Click(object sender, EventArgs e)
        {
            danhGiaTheoGVForm = danhGiaTheoGVForm == null ?
                                new frmKetQuaGGiangDayTheoGV(dBBus) :
                                danhGiaTheoGVForm;
            openChildForm(danhGiaTheoGVForm, false);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHoTroPhanCong(dBBus, this), false);
        }

        private void guiEmailBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new frmGuiEmail(dBBus), true);
        }

        public static void updateThongKeKetQuaForm(bool theoMon, Form currentForm)
        {
            if(theoMon)
            {
                danhGiaTheoMonForm =  currentForm;
            }    
            else
            {
                danhGiaTheoGVForm = currentForm;
            }    
        }
    }
}
