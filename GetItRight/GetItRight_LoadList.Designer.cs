namespace GetItRight
{
    partial class GetItRight_LoadList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoadList = new System.Windows.Forms.Button();
            this.FileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoadList
            // 
            this.LoadList.Location = new System.Drawing.Point(13, 39);
            this.LoadList.Name = "LoadList";
            this.LoadList.Size = new System.Drawing.Size(100, 23);
            this.LoadList.TabIndex = 1;
            this.LoadList.Text = "Load List";
            this.LoadList.UseVisualStyleBackColor = true;
            this.LoadList.Click += new System.EventHandler(this.LoadList_Click);
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(13, 13);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(100, 20);
            this.FileName.TabIndex = 0;
            // 
            // GetItRight_LoadList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(124, 75);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.LoadList);
            this.Name = "GetItRight_LoadList";
            this.Text = "GetItRight_LoadList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadList;
        private System.Windows.Forms.TextBox FileName;
    }
}