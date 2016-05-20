using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetItRight
{
    public partial class GetItRight_LoadMail : Form
    {
        public GetItRight_LoadMail()
        {
            InitializeComponent();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            if (this.FileName.Text != string.Empty)
            {
                Mail.LoadConf(this.FileName.Text);
            }
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
