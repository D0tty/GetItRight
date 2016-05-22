namespace GetItRight
{
    partial class GetItRight
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abouttToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TreeViewStudents = new System.Windows.Forms.TreeView();
            this.ShowData = new System.Windows.Forms.RichTextBox();
            this.Loggle = new System.Windows.Forms.Button();
            this.SendMail = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(557, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginInformationToolStripMenuItem,
            this.createListToolStripMenuItem,
            this.quitToolStripMenuItem,
            this.abouttToolStripMenuItem});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.managementToolStripMenuItem.Text = "Management";
            // 
            // loginInformationToolStripMenuItem
            // 
            this.loginInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.loginInformationToolStripMenuItem.Name = "loginInformationToolStripMenuItem";
            this.loginInformationToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.loginInformationToolStripMenuItem.Text = "Login Information";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.setupToolStripMenuItem.Text = "Setup";
            this.setupToolStripMenuItem.Click += new System.EventHandler(this.setupToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // createListToolStripMenuItem
            // 
            this.createListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadListToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.addStudentToolStripMenuItem});
            this.createListToolStripMenuItem.Name = "createListToolStripMenuItem";
            this.createListToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.createListToolStripMenuItem.Text = "List";
            // 
            // loadListToolStripMenuItem
            // 
            this.loadListToolStripMenuItem.Name = "loadListToolStripMenuItem";
            this.loadListToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.loadListToolStripMenuItem.Text = "Load";
            this.loadListToolStripMenuItem.Click += new System.EventHandler(this.loadListToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // abouttToolStripMenuItem
            // 
            this.abouttToolStripMenuItem.Name = "abouttToolStripMenuItem";
            this.abouttToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.abouttToolStripMenuItem.Text = "About";
            this.abouttToolStripMenuItem.Click += new System.EventHandler(this.abouttToolStripMenuItem_Click);
            // 
            // TreeViewStudents
            // 
            this.TreeViewStudents.CheckBoxes = true;
            this.TreeViewStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TreeViewStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeViewStudents.Location = new System.Drawing.Point(0, 27);
            this.TreeViewStudents.Name = "TreeViewStudents";
            this.TreeViewStudents.Size = new System.Drawing.Size(201, 278);
            this.TreeViewStudents.TabIndex = 1;
            // 
            // ShowData
            // 
            this.ShowData.Location = new System.Drawing.Point(207, 27);
            this.ShowData.Name = "ShowData";
            this.ShowData.ReadOnly = true;
            this.ShowData.Size = new System.Drawing.Size(350, 307);
            this.ShowData.TabIndex = 2;
            this.ShowData.Text = "";
            // 
            // Loggle
            // 
            this.Loggle.Location = new System.Drawing.Point(0, 311);
            this.Loggle.Name = "Loggle";
            this.Loggle.Size = new System.Drawing.Size(100, 23);
            this.Loggle.TabIndex = 3;
            this.Loggle.Text = "Toggle";
            this.Loggle.UseVisualStyleBackColor = true;
            this.Loggle.Click += new System.EventHandler(this.Loggle_Click);
            // 
            // SendMail
            // 
            this.SendMail.Location = new System.Drawing.Point(103, 311);
            this.SendMail.Name = "SendMail";
            this.SendMail.Size = new System.Drawing.Size(100, 23);
            this.SendMail.TabIndex = 4;
            this.SendMail.Text = "Send Mail";
            this.SendMail.UseVisualStyleBackColor = true;
            this.SendMail.Click += new System.EventHandler(this.SendMail_Click);
            // 
            // GetItRight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 334);
            this.Controls.Add(this.SendMail);
            this.Controls.Add(this.Loggle);
            this.Controls.Add(this.ShowData);
            this.Controls.Add(this.TreeViewStudents);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(573, 373);
            this.MinimumSize = new System.Drawing.Size(573, 373);
            this.Name = "GetItRight";
            this.Text = "Get It Right";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abouttToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadListToolStripMenuItem;
        private System.Windows.Forms.TreeView TreeViewStudents;
        private System.Windows.Forms.RichTextBox ShowData;
        private System.Windows.Forms.ToolStripMenuItem loginInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.Button Loggle;
        private System.Windows.Forms.Button SendMail;
    }
}

