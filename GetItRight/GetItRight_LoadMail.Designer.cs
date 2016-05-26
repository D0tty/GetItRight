namespace GetItRight
{
    partial class GetItRight_LoadMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetItRight_LoadMail));
            this.FileName = new System.Windows.Forms.TextBox();
            this._Load = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(13, 13);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(100, 20);
            this.FileName.TabIndex = 0;
            this.FileName.Text = "File Name";
            // 
            // _Load
            // 
            this._Load.Location = new System.Drawing.Point(13, 40);
            this._Load.Name = "_Load";
            this._Load.Size = new System.Drawing.Size(100, 23);
            this._Load.TabIndex = 1;
            this._Load.Text = "Load";
            this._Load.UseVisualStyleBackColor = true;
            this._Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(13, 70);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(100, 23);
            this.Quit.TabIndex = 2;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // GetItRight_LoadMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(124, 98);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this._Load);
            this.Controls.Add(this.FileName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GetItRight_LoadMail";
            this.Text = "Load Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Button _Load;
        private System.Windows.Forms.Button Quit;
    }
}