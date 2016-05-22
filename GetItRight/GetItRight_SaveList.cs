using System;
using System.Windows.Forms;

namespace GetItRight
{
    public partial class GetItRight_SaveList : Form
    {
        public StudentHandler StudentHandler;

        public GetItRight_SaveList( StudentHandler _studentHandler)
        {
            this.StudentHandler = _studentHandler;
            InitializeComponent();
            this.FileName.KeyPress += (sender, args) =>
            {
                if ((Keys)args.KeyChar == Keys.Enter)
                {
                    Save_Click(this, EventArgs.Empty);
                }
            }; //Fast Input
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (this.FileName.Text != string.Empty)
            {
                this.StudentHandler.SaveList(this.FileName.Text);
                this.Dispose();
            }
        }
    }
}
