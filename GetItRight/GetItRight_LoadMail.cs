using System;
using System.Windows.Forms;

namespace GetItRight
{
    public partial class GetItRight_LoadMail : Form
    {
        public GetItRight_LoadMail()
        {
            InitializeComponent();
            this.FileName.KeyPress += (sender, args) =>
            {
                if ((Keys)args.KeyChar == Keys.Enter)
                {
                    Load_Click(this, EventArgs.Empty);
                }
            }; //Fast Input
        }

        private void Load_Click(object sender, EventArgs e)
        {
            if (this.FileName.Text != string.Empty)
            {
                if (Mail.LoadConf(this.FileName.Text))
                {
                    Quit_Click(this,EventArgs.Empty);
                }
            }
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
