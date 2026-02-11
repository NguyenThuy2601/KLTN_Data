using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace QLKetQuaGiangDay.BUS
{
    public class GuiEmailBus
    {
        public DataTable getMonHocGiangDayInHocKy(int hocKiBD, int hockiKT, DbBus dbBus)
        {
            if (dbBus.isUsingAcess)
            {
                List<OleDbParameter> parameters = new List<OleDbParameter>();
                parameters.Add(new OleDbParameter("@Parameter1", hocKiBD));
                parameters.Add(new OleDbParameter("@Parameter2", hockiKT));
                parameters.Add(new OleDbParameter("@Parameter3", "%"));

                return dbBus.DBfunction.GetDataToTableByProc("MonHocGiangDayTrongHK", parameters);
            }
            return null;

        }

        public DataTable getGVDiTre(int hocKiBD, int hockiKT, DbBus dbBus)
        {
            if (dbBus.isUsingAcess)
            {
                List<OleDbParameter> parameters = new List<OleDbParameter>();
                parameters.Add(new OleDbParameter("@Parameter1", hocKiBD));
                parameters.Add(new OleDbParameter("@Parameter2", hockiKT));
                parameters.Add(new OleDbParameter("@Parameter3", "%"));

                return dbBus.DBfunction.GetDataToTableByProc("NhomGVDiTreVeSom", parameters);
            }
            return null;
        }

        public DataTable getGVChuaKySDB(int hocKiBD, int hockiKT, DbBus dbBus)
        {
            if (dbBus.isUsingAcess)
            {
                List<OleDbParameter> parameters = new List<OleDbParameter>();
                parameters.Add(new OleDbParameter("@Parameter1", hocKiBD));
                parameters.Add(new OleDbParameter("@Parameter2", hockiKT));
                parameters.Add(new OleDbParameter("@Parameter3", "%"));

                return dbBus.DBfunction.GetDataToTableByProc("NhomGVChuaKySoDauBai", parameters);
            }
            return null;
        }

        public DataTable getGVDayKhongDungLich(int hocKiBD, int hockiKT, DbBus dbBus)
        {
            if (dbBus.isUsingAcess)
            {
                List<OleDbParameter> parameters = new List<OleDbParameter>();
                parameters.Add(new OleDbParameter("@Parameter1", hocKiBD));
                parameters.Add(new OleDbParameter("@Parameter2", hockiKT));
                parameters.Add(new OleDbParameter("@Parameter3", "%"));

                return dbBus.DBfunction.GetDataToTableByProc("NhomGVDayKhongDungLich", parameters);
            }
            return null;
        }

        public DataTable getGVThieuTiet(int hocKiBD, int hockiKT, DbBus dbBus)
        {
            if (dbBus.isUsingAcess)
            {
                List<OleDbParameter> parameters = new List<OleDbParameter>();
                parameters.Add(new OleDbParameter("@Parameter1", hocKiBD));
                parameters.Add(new OleDbParameter("@Parameter2", hockiKT));
                parameters.Add(new OleDbParameter("@Parameter3", "%"));

                return dbBus.DBfunction.GetDataToTableByProc("NhomGVThieuTiet", parameters);
            }
            return null;
        }

        public string gennerateEmailFronDT(DataTable dt)
        {
            StringBuilder listEmail = new StringBuilder();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                listEmail.Append(dr["Email"].ToString().Trim());
                if (i != dt.Rows.Count - 1)
                    listEmail.Append("; ");
            }
            return listEmail.ToString();
        }
        public void addMailAttachment(List<String> filePath, ref MailMessage mail)
        {
            for (int i = 0; i < filePath.Count; i++)
            {
                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(filePath[i]);
                mail.Attachments.Add(attachment);
            }
        }

        public void sendEmail(string email, string tittle, string ccEmail,string content, List<String> filePath)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("2051052135thuy@ou.edu.vn");
            mail.To.Add(email);
            if(!string.IsNullOrEmpty(ccEmail))
            {
                if(ccEmail.Contains(","))
                {
                    string[] temp = ccEmail.Split(',');
                    for (int i = 0; i < temp.Length; i++)
                        mail.CC.Add(temp[i]);
                }
                else
                {
                    mail.CC.Add(ccEmail);
                } 
                    
                
            }    
            mail.Subject = tittle;
            var html = RtfPipe.Rtf.ToHtml(content);
            string formatedHTML = html.ToString();
            mail.IsBodyHtml = true;
            mail.Body = formatedHTML;

            if (filePath.Count > 0)
                addMailAttachment(filePath, ref mail);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("2051052135thuy@ou.edu.vn", "seojuhyun286");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
    }
}
