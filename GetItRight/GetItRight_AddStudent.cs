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
    public partial class GetItRight_AddStudent : Form
    {
        private Student Student;

        public GetItRight_AddStudent(Student _student)
        {
            InitializeComponent();
            this.Student = _student;
            this.Login.KeyPress += (sender, args) =>
            {
                if ((Keys) args.KeyChar == Keys.Enter)
                {
                    Add_Click(this, EventArgs.Empty);
                }
            }; //Fast Input
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            this.FirstName.Text = string.Empty;
            this.Login.Text = string.Empty;
            this._Name.Text = string.Empty;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (this._Name.Text != string.Empty && this.FirstName.Text != string.Empty && this.Login.Text != string.Empty)
            {
                this.Student.Name = this._Name.Text;
                this.Student.FirstName = this.FirstName.Text;
                this.Student.Login = this.Login.Text;
                this.Close();
            }
            else
            {
                //maybe make a popup some day
                MessageBox.Show(@"You HAVE to fill all attributes");
            }
        }
    }
}
