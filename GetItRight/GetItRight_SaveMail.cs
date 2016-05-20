using System;
using System.Windows.Forms;

namespace GetItRight
{
    public partial class GetItRight_SaveMail : Form
    {
        public GetItRight_SaveMail()
        {
            InitializeComponent();
            GetMailData();
        }

        private void GetMailData()
        {
            if (Mail.inited)
            {
                this.EmailFrom.Text = Mail.From.Address;
                this.Subject.Text = Mail.Subject;
                this.SmtpHost.Text = Mail.Client.Host;
                this.SmtpPort.Text = String.Empty + Mail.Client.Port;
                this.SmtpLogin.Text = Mail.Login;
                this.SmtpPassword.Text = Mail.Password;
                this.SSLEnable.Checked = Mail.Client.EnableSsl;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (this.FileName.Text != string.Empty)
            {
                Mail.SaveConf(this.FileName.Text);
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            this.EmailFrom.Text = @"EmailFrom";
            this.Subject.Text = @"Subject";
            this.SmtpHost.Text = @"Smtp Host";
            this.SmtpPort.Text = @"Smtp Port";
            this.SmtpLogin.Text = @"Smtp Login";
            this.SmtpPassword.Text = @"Smtp Password";
            this.SSLEnable.Checked = false;
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
