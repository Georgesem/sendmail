using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sendmail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (StreamReader swconf = new StreamReader(@"c:\mail.cnf",  System.Text.Encoding.Default))
            {
                string line;
                string line1;
                string line2;
                while ((line = swconf.ReadLine()) != null)
                {
                    line1 = line.Substring(0, line.IndexOf(":")+1);
                    line2 = line.Substring(line.IndexOf(":")+1, line.IndexOf(";") - line.IndexOf(":") - 1);
                    switch (line1.Trim())
                    {
                        case ("mail_from:"):
                            TbEmailFrom.Text =line2.Trim();
                            break;
                        case ("mail_name_from:"):
                            TbNameFrom.Text = line2.Trim();
                            break;
                        case ("mail_to:"):
                            TbEmailTo.Text = line2.Trim();
                            break;
                        case ("mail_tema:"):
                            TbTema.Text = line2.Trim();
                            break;
                        case ("smtp_server:"):
                            TbSmtpSever.Text = line2.Trim();
                            break;
                        case ("smtp_server_port:"):
                            TbSmtpPort.Text = line2.Trim();
                            break;
                        case ("smtp_avt_login:"):
                            TbAvtName.Text = line2.Trim();
                            break;
                        case ("smtp_avt_password:"):
                            TbAvtPass.Text = line2.Trim();
                            break;
                        default:
                            break;
                    }

                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress(TbEmailFrom.Text, TbNameFrom.Text);
            // кому отправляем
            MailAddress to = new MailAddress(TbEmailTo.Text);
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = TbTema.Text;
            // текст письма
            m.Body = "<h2>Письмо-тест работы smtp-клиента</h2>";
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient(TbSmtpSever.Text, Int32.Parse(TbSmtpPort.Text));
            // логин и пароль
            smtp.Credentials = new NetworkCredential(TbAvtName.Text, TbAvtPass.Text);
            if (CbSSL.Checked)
            {
                smtp.EnableSsl = true;
            }
            else
            {
                smtp.EnableSsl = false;
            }


            //smtp.UseDefaultCredentials = true;
            smtp.Timeout = 20000;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            try
            {
                smtp.Send(m);
                TbMessage.Text = "Сообщение отправлено";
                using (StreamWriter sw = new StreamWriter(@"c:\mail.log", true, System.Text.Encoding.Default))
                {
                    sw.WriteLine("сообщение отправлено");
                }

            }
            catch (Exception er)
            {
                TbMessage.Text = "Сообщение не отправлено" + er;
                using (StreamWriter sw = new StreamWriter(@"c:\mail.log", true, System.Text.Encoding.Default))
                {
                    sw.WriteLine("Сообщение не отправлено" + er);
                }
            }
        }

        
        private void CbSSL_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            using (StreamWriter swconf = new StreamWriter(@"c:\mail.cnf", false, System.Text.Encoding.Default))
            {
                swconf.WriteLine("mail_from: " + TbEmailFrom.Text + ";");
                swconf.WriteLine("mail_name_from: " + TbNameFrom.Text + ";");
                swconf.WriteLine("mail_to: " + TbEmailTo.Text + ";");
                swconf.WriteLine("mail_tema: " + TbTema.Text + ";");
                swconf.WriteLine("smtp_server: " + TbSmtpSever.Text + ";");
                swconf.WriteLine("smtp_server_port: " + TbSmtpPort.Text + ";");
                swconf.WriteLine("smtp_avt_login: " + TbAvtName.Text + ";");
                swconf.WriteLine("smtp_avt_password: " + TbAvtPass.Text + ";");
                swconf.Dispose();
            }
        }
    }
}
