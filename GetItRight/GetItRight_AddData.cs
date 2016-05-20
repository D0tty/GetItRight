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
    public partial class GetItRight_AddData : Form
    {
        private Student Student;

        public GetItRight_AddData(Student _student)
        {
            InitializeComponent();
            this.Student = _student;
            #region recup last data for modif

            if (this.Student.Data != null && this.Student.Data.Length > 0)
            {
                int end = 0;
                string[] txt = this.Student.Data.Split('\n');
                while (txt[txt.Length - 1 - end] == "")
                    end++;
                this.DecisionConseil.Text = txt[1];
                for (int i = 3; i < txt.Length - end; i++)
                {
                    this.Data.Text += txt[i] + '\n';
                }
            }

            #endregion
            this.DecisionConseil.KeyPress += (sender, args) =>
            {
                if ((Keys)args.KeyChar == Keys.Enter)
                {
                    AddData_Click(this, EventArgs.Empty);
                }
            }; //Fast Input
        }

        private void AddData_Click(object sender, EventArgs e)
        {
            if (this.Decision.Text != string.Empty && this.Data.Text != string.Empty)
            {
                this.Student.MakeData(this.DecisionConseil.Text,this.Data.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("You need to fill decision and resume.");
            }
        }
    }
}
