using System;
using System.Windows.Forms;

namespace GetItRight
{
    public partial class GetItRight_LoadList : Form
    {
        public StudentHandler StudentHandler;

        public GetItRight_LoadList(StudentHandler _studentHandler)
        {
            this.StudentHandler = _studentHandler;
            InitializeComponent();
            this.FileName.KeyPress += (sender, args) =>
            {
                if ((Keys)args.KeyChar == Keys.Enter)
                {
                    LoadList_Click(this, EventArgs.Empty);
                }
            }; //Fast Input
        }

        private void LoadList_Click(object sender, EventArgs e)
        {
            if (this.FileName.Text != string.Empty)
            {
                StudentHandler.LoadList(this.FileName.Text);
                this.Dispose();
            }
            else
            {
                MessageBox.Show(@"Error: "+this.FileName.Text+@" does not exist");
            }
        }
    }
}
