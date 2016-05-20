using System;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Mail;
using System.Windows.Forms;

namespace GetItRight
{
    public static class Mail
    {
        public static MailAddress From;
        public static MailMessage Message;
        public static SmtpClient Client;
        public static  string Login, Password;
        public static string Subject;
        public static bool inited = false;

        public static void MailBuild(string mail_from, string subject, string smtp_host, int smtp_port, string smtp_login, string smtp_password, bool ssl_enabled)
        {
            Mail.From = new MailAddress(mail_from);
            Mail.Client = new SmtpClient(smtp_host,smtp_port);
            Mail.Client.Credentials = new NetworkCredential(smtp_login,smtp_password);
            Mail.Client.EnableSsl = ssl_enabled;
            Mail.Client.DeliveryMethod = SmtpDeliveryMethod.Network;
            Mail.Subject = subject;
            Mail.Login = smtp_login;
            Mail.Password = smtp_password;
            Mail.inited = true;
        }

        public static void Send(string body, MailAddress to)
        {
            Mail.Message = new MailMessage(Mail.From,to);
            Mail.Message.Priority = MailPriority.High;
            Mail.Message.Subject = Mail.Subject;
            Mail.Message.Body = body;
            try
            {
                Mail.Client.Send(Mail.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(@"Error while sending the mail: "+ e.Message);
            }
        } //TODO change Client.Send by AsyncSend to be faster / don't have in app frezzez

        public static void SaveConf(string filename)
        {
            if (!File.Exists(".\\"+filename))
            {
                string data = "#FromEmail\n" + Mail.From.Address + '\n';
                data += "#Subject\n" + Mail.Subject + '\n';
                data += "#SmtpHost\n" + Mail.Client.Host + '\n';
                data += "#SmtpPort\n" + Mail.Client.Port + '\n';
                data += "#SmtpLogin\n" + Mail.Login + '\n';
                data += "#SmtpPassword\n" + Mail.Password + '\n';
                data += "#SSLEnable\n" + Mail.Client.EnableSsl;
                FileStream fs = new FileStream("."+"\\"+filename,FileMode.Create);
                byte[] bytedata = Encoding.ASCII.GetBytes(data);
                fs.Write(bytedata,0,bytedata.Length);
                //BinaryWriter writer = new BinaryWriter(fs);
                //writer.Write(data);
                //writer.Close();
                fs.Close();
            }
            else
            {
                MessageBox.Show("Error with the filename");
            }
        }

        public static void LoadConf(string filename)
        {
            if (File.Exists(".\\" + filename))
            {
                FileStream fs = new FileStream(".\\"+filename,FileMode.Open);
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, (int)fs.Length);
                fs.Close();
                string[] file = Encoding.ASCII.GetString(data).Split('\n');
                if (file.Length == 14)
                {
                    MailBuild(file[1],file[3],file[5],Int32.Parse(file[7]),file[9],file[11],file[13]==true.ToString());
                    MessageBox.Show(@"Conf Loaded correctly");
                }
                else
                {
                    MessageBox.Show(@"The Config File is corrupted");
                }
            }
        }

    }
}
