using QLKetQuaGiangDay.BUS;
using QLKetQuaGiangDay.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKetQuaGiangDay
{
    public partial class frmGuiEmail : Form
    {
        DbBus dbBus;
        GuiEmailBus bus;

        int hkBD;

        long totalsize = 0;

        List<uploadFile> fileList = new List<uploadFile>();

        string emailContent = "";
        string emailTitle = "";

        DataTable dtNhomGV;

        public frmGuiEmail()
        {
            InitializeComponent();
        }

        public frmGuiEmail(DbBus dbBus) : this()
        {
            this.dbBus = dbBus; 

            bus = new GuiEmailBus();


            DataTable dt = bus.getMonHocGiangDayInHocKy(100, 500, dbBus);
            CommonUtils.initCbbData(hkbdCbb, CommonUtils.getColumn(dt, "MHK"));
        }

        private void upFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            String path = "";
            dlg.Multiselect = false;
            dlg.Filter = "Excel Files|*.xls;*.xlsx|" +
                            "Docfile|*.doc; *.docx|" +
                            "PDF file|*.pdf";
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                path = dlg.FileName;
                long fileSize = new FileInfo(path).Length;
                if (totalsize > 25000000)
                    MessageBox.Show("Quá tải dung lượng");
                else
                {
                    if (fileSize > 25000000)
                        MessageBox.Show("Quá tải dung lượng");
                    else
                    {
                        uploadFile file = new uploadFile(path);
                        file.TopLevel = false;
                        fileFlowOutPanel.Controls.Add(file);
                        file.Show();
                        totalsize += fileSize;
                        fileList.Add(file);
                    }
                }

            }
        }

        private void colorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                colorLbl.BackColor = dlg.Color;
                contenRichTextBox.SelectionColor = dlg.Color;
            }
        }

        private void fontSizeNumeric_ValueChanged(object sender, EventArgs e)
        {
            FontStyle style = setFont();
            contenRichTextBox.SelectionFont = new Font(contenRichTextBox.SelectionFont.FontFamily,
                                                (int)fontSizeNumeric.Value,
                                                style);
        }

        private FontStyle setFont()
        {
            FontStyle style = FontStyle.Regular;

            if (boldBtn.BackColor == SystemColors.InactiveCaption)
            {
                style |= FontStyle.Bold;
            }

            if (underlineBtn.BackColor == SystemColors.InactiveCaption)
            {
                style |= FontStyle.Underline;
            }

            if (italicBtn.BackColor == SystemColors.InactiveCaption)
            {
                style |= FontStyle.Italic;
            }

            return style;
        }

        private void changeStyleAndBtnBackColor(bool condition, Button button)
        {
            button.BackColor = !condition ? SystemColors.InactiveCaption : Color.White;

            FontStyle style = setFont();

            
            contenRichTextBox.SelectionFont = new Font(contenRichTextBox.SelectionFont.FontFamily,
                                                    (int)fontSizeNumeric.Value,
                                                    style);
        }

        private void boldBtn_Click(object sender, EventArgs e)
        {
            changeStyleAndBtnBackColor(contenRichTextBox.SelectionFont.Bold, boldBtn);
           
        }

        private void italicBtn_Click(object sender, EventArgs e)
        {
            changeStyleAndBtnBackColor(contenRichTextBox.SelectionFont.Italic, italicBtn);
        }

        private void underlineBtn_Click(object sender, EventArgs e)
        {
            changeStyleAndBtnBackColor(contenRichTextBox.SelectionFont.Underline, underlineBtn);
        }

        private void setAlign(HorizontalAlignment alignment, Button btn)
        {
            contenRichTextBox.SelectionAlignment = alignment;
            if (btn.BackColor == Color.White)
                btn.BackColor = SystemColors.InactiveCaption;
            else
                btn.BackColor = Color.White;
        }

        private void leftAlignBtn_Click(object sender, EventArgs e)
        {
            setAlign(HorizontalAlignment.Left, leftAlignBtn);
        }

        private void centerAlignBth_Click(object sender, EventArgs e)
        {
            setAlign(HorizontalAlignment.Center, centerAlignBth);
        }

        private void rightAlignBtn_Click(object sender, EventArgs e)
        {
            setAlign(HorizontalAlignment.Right, rightAlignBtn);
        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            if (contenRichTextBox.SelectionBullet == false)
            {
                contenRichTextBox.SelectionIndent = 30;
                contenRichTextBox.SelectionBullet = true;
                contenRichTextBox.AcceptsTab = true;
                listBtn.BackColor = SystemColors.InactiveCaption;
            }
            else
            {
                contenRichTextBox.SelectionIndent = 0;
                contenRichTextBox.SelectionBullet = false;
                listBtn.BackColor = Color.White;
            }
        }


        private void enterBtn_Click(object sender, EventArgs e)
        {
            int selctedNhomIndex = nhomGVCbb.SelectedIndex;
            hkBD = int.Parse(hkbdCbb.Text);

            titleTxt.Text = string.Format(emailTitle, hkBD);
            contenRichTextBox.Text = string.Format(emailContent, hkBD) ;

            switch (selctedNhomIndex)
            {
                case 1:
                    dtNhomGV = bus.getGVChuaKySDB(hkBD, hkBD, dbBus);
                    break;
                case 2:
                    dtNhomGV = bus.getGVDayKhongDungLich(hkBD, hkBD, dbBus);
                    break;
                case 3:
                    dtNhomGV = bus.getGVDiTre(hkBD, hkBD, dbBus);
                    break;
                case 4:
                    dtNhomGV = bus.getGVThieuTiet(hkBD, hkBD, dbBus);
                    break ;
            }

            dgvDSGV.DataSource = dtNhomGV;
        }

        public List<string> getStringPath(List<uploadFile> fileList)
        {
            List<string> filePath = new List<string>();
            for (int i = 0; i < fileList.Count; i++)
            {
                if (fileList[i].getFullPath() != "")
                    filePath.Add(fileList[i].getFullPath());
            }
            return filePath;
        }

        private bool checkToEmailIsInCbb()
        {
            for(int i = 0; i < toEmailCbb.Items.Count; i++)
            {
                if (toEmailCbb.Text.Equals(toEmailCbb.Items[i].ToString()))
                    return true;
            }

            return false;
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            string emailAccount = "";
            if(toEmailCbb.Text == "")
            {
                MessageBox.Show("Chưa có thông tin người nhận");
            } 
            else
            {
                if (checkToEmailIsInCbb())
                    emailAccount = bus.gennerateEmailFronDT(dtNhomGV);
                else
                    emailAccount = toEmailCbb.Text.Trim();

                List<string> list = new List<string>();
                list = getStringPath(fileList);

                bus.sendEmail(emailAccount, titleTxt.Text, ccEmailTxt.Text, contenRichTextBox.Rtf, list);

                MessageBox.Show("Đã gửi email");
            }    
        }

        

        private void nhomGVCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            toEmailCbb.SelectedIndex = nhomGVCbb.SelectedIndex;
        }

        private void toEmailCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch(toEmailCbb.SelectedIndex)
            {
                case 0:
                    emailTitle = "Nhắc nhở việc hoàn tất sổ đầu bài trong học kì {0}";

                    emailContent = "Gửi quý thầy/cô \n Các thầy/cô nhận được email này hiện chưa hoàn tất sổ đầu bài cho lớp giảng dạy. Mong quý thầy cô thực hiện hoàn tất sổ đầu bài cho học kì {0}";
                    break;
                case 1:
                    emailTitle = "Nhắc nhở tình trạng dạy không đúng thời khóa biểu trong học kì {0}";

                    emailContent = "Gửi quý thầy/cô \n Các thầy/cô nhận được email này hiện trong học kì {0} " +
                                                 "đang dạy không đúng lịch từ 4 buổi trở lên. Mong các thầy cô cải thiện tình trạng trên";
                    break;
                case 2:
                    emailTitle = "Nhắc nhở tình trạng đi trễ về sớm trong học kì {0}";

                    emailContent = "Gửi quý thầy/cô \n Các thầy/cô nhận được email nà hiện trong học kì {0} " +
                                                 "có trường hợp đi trễ về sớm từ 3 buổi trở lên. Mong các thầy cô cải thiện tình trạng trên";
                    break;
                case 3:
                    emailTitle = "Nhắc nhở tình trạng thiếu tiết trong học kì {0}";

                    emailContent = "Gửi quý thầy/cô \n Các thầy/cô nhận được email nà hiện trong học kì {0} " +
                                                 "đang còn thiếu tiết của các lớp đảm nhận, các thầy cô nhanh chóng bổ sung " +
                                                 "cho đủ số lượng tiết yêu cầu";
                    break;

            }
            
        }
    }
}
