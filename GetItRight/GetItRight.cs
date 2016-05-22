using System;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;
using GetItRight.Properties;

namespace GetItRight
{
    public partial class GetItRight : Form
    {
        StudentHandler StudentHandler = new StudentHandler();
        private bool TreeAllState = false;
        private int ShowedStudent;

        public GetItRight()
        {
            InitializeComponent();
            this.StudentHandler = new StudentHandler();
            this.TreeViewStudents.NodeMouseDoubleClick += treeView1_NodeMouseDoubleClick;
            this.TreeViewStudents.NodeMouseHover += TreeViewStudentsOnNodeMouseHover;
            this.ShowData.MouseDoubleClick += ModifData;
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
            DialogResult result = AddStudent.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                UpdateTreeView();
            }
            else
            {
                this.StudentHandler.PopLast();
            }
        }

        private void UpdateTreeView()
        {
            this.TreeViewStudents.Nodes.Clear();
            for (int i = 0; i < StudentHandler.Lenght; i++)
            {
                this.TreeViewStudents.Nodes.Add(this.StudentHandler[i].Name + " " + this.StudentHandler[i].FirstName);
            }
        }

        private void ModifData(object sender, MouseEventArgs e)
        {
            if (this.StudentHandler.Lenght > 0 && this.ShowedStudent < this.StudentHandler.Lenght)
            {
                GetItRight_AddData AddData = new GetItRight_AddData(this.StudentHandler[this.ShowedStudent]);
                AddData.ShowDialog();
                UpdateTreeView(); //ah oui c'est salle et osef //will be patch next year XD
            }
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            GetItRight_AddStudent ModifyStudent = new GetItRight_AddStudent(this.StudentHandler[e.Node.Index]);
            ModifyStudent.ShowDialog();
            UpdateTreeView(); // again it's ugly
        }

        private void TreeViewStudentsOnNodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
        {
            this.ShowData.Text = this.StudentHandler[e.Node.Index].Data;
            this.ShowedStudent = e.Node.Index;
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

        private void Loggle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.TreeViewStudents.Nodes.Count; i++)
            {
                this.TreeViewStudents.Nodes[i].Checked = !this.TreeAllState;
            }
            this.TreeAllState = !this.TreeAllState;
        }

        private void SendMail_Click(object sender, EventArgs e)
        {
            if (Mail.inited)
            {
                for (int i = 0; i < this.TreeViewStudents.Nodes.Count; i++)
                {
                    if (this.TreeViewStudents.Nodes[i].Checked)
                    {
                        Mail.Send(this.StudentHandler[i].Data,new MailAddress(this.StudentHandler[i].Login+"@epita.fr"));
                        this.TreeViewStudents.Nodes[i].Checked = false; 
                        this.TreeViewStudents.Nodes[i].BackColor = Color.ForestGreen;
                    }
                }
            }
            else
            {
                MessageBox.Show(@"Setupor load mail config first");
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GetItRight_SaveList SaveList = new GetItRight_SaveList(this.StudentHandler);
            SaveList.ShowDialog();
        }

        private void loadListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetItRight_LoadList LoadList = new GetItRight_LoadList(this.StudentHandler);
            LoadList.ShowDialog();
            UpdateTreeView();
        }
    }
}
