using System;
using System.Windows.Forms;

namespace GetItRight
{
    public partial class GetItRight_SetupMail : Form
    {
        public GetItRight_SetupMail()
        {
            InitializeComponent();
            GetMailData();
            this.SmtpPassword.KeyPress += (sender, args) =>
            {
                if ((Keys)args.KeyChar == Keys.Enter)
                {
                    Setup_Click(this, EventArgs.Empty);
                    Quit_Click(this,EventArgs.Empty);
                }
            }; //Fast Input
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

        private void Setup_Click(object sender, EventArgs e)
        {
            if (this.EmailFrom.Text != string.Empty
                && this.Subject.Text != string.Empty
                && this.SmtpHost.Text != string.Empty
                && this.SmtpPort.Text != string.Empty
                && this.SmtpLogin.Text != string.Empty
                && this.SmtpPassword.Text != string.Empty)
            {
                int port = Int32.Parse(this.SmtpPort.Text);
                Mail.MailBuild(this.EmailFrom.Text,this.Subject.Text,this.SmtpHost.Text,port,this.SmtpLogin.Text,this.SmtpPassword.Text,this.SSLEnable.Checked);
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
