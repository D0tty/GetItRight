namespace GetItRight
{
    partial class GetItRight_SaveMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetItRight_SaveMail));
            this.EmailFrom = new System.Windows.Forms.TextBox();
            this.Subject = new System.Windows.Forms.TextBox();
            this.SmtpHost = new System.Windows.Forms.TextBox();
            this.SmtpPort = new System.Windows.Forms.TextBox();
            this.SmtpPassword = new System.Windows.Forms.TextBox();
            this.SmtpLogin = new System.Windows.Forms.TextBox();
            this.SSLEnable = new System.Windows.Forms.CheckBox();
            this.FileName = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmailFrom
            // 
            this.EmailFrom.Location = new System.Drawing.Point(12, 12);
            this.EmailFrom.Name = "EmailFrom";
            this.EmailFrom.Size = new System.Drawing.Size(100, 20);
            this.EmailFrom.TabIndex = 3;
            this.EmailFrom.Text = "EmailFrom";
            // 
            // Subject
            // 
            this.Subject.Location = new System.Drawing.Point(12, 38);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(100, 20);
            this.Subject.TabIndex = 4;
            this.Subject.Text = "Subject";
            // 
            // SmtpHost
            // 
            this.SmtpHost.Location = new System.Drawing.Point(12, 64);
            this.SmtpHost.Name = "SmtpHost";
            this.SmtpHost.Size = new System.Drawing.Size(100, 20);
            this.SmtpHost.TabIndex = 5;
            this.SmtpHost.Text = "Smtp Host";
            // 
            // SmtpPort
            // 
            this.SmtpPort.Location = new System.Drawing.Point(12, 90);
            this.SmtpPort.Name = "SmtpPort";
            this.SmtpPort.Size = new System.Drawing.Size(100, 20);
            this.SmtpPort.TabIndex = 6;
            this.SmtpPort.Text = "Smtp Port";
            // 
            // SmtpPassword
            // 
            this.SmtpPassword.Location = new System.Drawing.Point(12, 142);
            this.SmtpPassword.Name = "SmtpPassword";
            this.SmtpPassword.PasswordChar = '*';
            this.SmtpPassword.Size = new System.Drawing.Size(100, 20);
            this.SmtpPassword.TabIndex = 8;
            // 
            // SmtpLogin
            // 
            this.SmtpLogin.Location = new System.Drawing.Point(12, 116);
            this.SmtpLogin.Name = "SmtpLogin";
            this.SmtpLogin.Size = new System.Drawing.Size(100, 20);
            this.SmtpLogin.TabIndex = 7;
            this.SmtpLogin.Text = "Smtp Login";
            // 
            // SSLEnable
            // 
            this.SSLEnable.AutoSize = true;
            this.SSLEnable.Location = new System.Drawing.Point(13, 169);
            this.SSLEnable.Name = "SSLEnable";
            this.SSLEnable.Size = new System.Drawing.Size(88, 17);
            this.SSLEnable.TabIndex = 9;
            this.SSLEnable.Text = "SSL Enabled";
            this.SSLEnable.UseVisualStyleBackColor = true;
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(167, 11);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(100, 20);
            this.FileName.TabIndex = 0;
            this.FileName.Text = "FileName.txt";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(167, 34);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 1;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(167, 62);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 10;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(167, 88);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 2;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // GetItRight_SaveMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 201);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.SSLEnable);
            this.Controls.Add(this.SmtpPort);
            this.Controls.Add(this.SmtpLogin);
            this.Controls.Add(this.SmtpPassword);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.SmtpHost);
            this.Controls.Add(this.EmailFrom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GetItRight_SaveMail";
            this.Text = "Save Mail Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailFrom;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.TextBox SmtpHost;
        private System.Windows.Forms.TextBox SmtpPort;
        private System.Windows.Forms.TextBox SmtpPassword;
        private System.Windows.Forms.TextBox SmtpLogin;
        private System.Windows.Forms.CheckBox SSLEnable;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Quit;
    }
}