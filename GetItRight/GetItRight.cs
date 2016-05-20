using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GetItRight.Properties;

namespace GetItRight
{
    public partial class GetItRight : Form
    {
        StudentHandler StudentHandler = new StudentHandler();

        public GetItRight()
        {
            InitializeComponent();
            this.StudentHandler = new StudentHandler();
            this.TreeViewStudents.NodeMouseDoubleClick += treeView1_NodeMouseDoubleClick;
            this.TreeViewStudents.NodeMouseHover += TreeViewStudentsOnNodeMouseHover;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose(); //seems nicer than the Env.exit
            //Environment.Exit(Environment.ExitCode);
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.StudentHandler.AddStudent();
            GetItRight_AddStudent AddStudent =
                new GetItRight_AddStudent(this.StudentHandler[this.StudentHandler.Lenght - 1]); //I can use "Length - 1" without other verification 
                                                                                                //because I allways adds a student before so Lenght is >= 1
            AddStudent.ShowDialog();
            UpdateTreeView();
        }

        private void UpdateTreeView()
        {
            this.TreeViewStudents.Nodes.Clear();
            for (int i = 0; i < StudentHandler.Lenght; i++)
            {
                this.TreeViewStudents.Nodes.Add(this.StudentHandler[i].Name + " " + this.StudentHandler[i].FirstName);
            }
        }

        void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            GetItRight_AddData AddData = new GetItRight_AddData(this.StudentHandler[e.Node.Index]);
            AddData.ShowDialog();
            UpdateTreeView(); //ah oui c'est salle et osef //will be patch next year XD
        }

        private void TreeViewStudentsOnNodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
        {
            this.ShowData.Text = this.StudentHandler[e.Node.Index].Data;
        }

        private void abouttToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Resources.String_About, @"About", MessageBoxButtons.OK);
        }

        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetItRight_SetupMail SetupMail = new GetItRight_SetupMail();
            SetupMail.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetItRight_SaveMail SaveMail = new GetItRight_SaveMail();
            SaveMail.ShowDialog();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetItRight_LoadMail LoadMail = new GetItRight_LoadMail();
            LoadMail.ShowDialog();
        }
    }
}
