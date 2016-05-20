namespace GetItRight
{
    partial class GetItRight_AddData
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
            this._Name = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.RichTextBox();
            this.Decision = new System.Windows.Forms.Label();
            this.DecisionConseil = new System.Windows.Forms.TextBox();
            this.AddData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _Name
            // 
            this._Name.AutoSize = true;
            this._Name.Location = new System.Drawing.Point(12, 9);
            this._Name.Name = "_Name";
            this._Name.Size = new System.Drawing.Size(0, 13);
            this._Name.TabIndex = 0;
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(12, 25);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(422, 268);
            this.Data.TabIndex = 1;
            this.Data.Text = "";
            // 
            // Decision
            // 
            this.Decision.AutoSize = true;
            this.Decision.Location = new System.Drawing.Point(15, 300);
            this.Decision.Name = "Decision";
            this.Decision.Size = new System.Drawing.Size(85, 13);
            this.Decision.TabIndex = 2;
            this.Decision.Text = "Decision Conseil";
            // 
            // DecisionConseil
            // 
            this.DecisionConseil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecisionConseil.Location = new System.Drawing.Point(106, 297);
            this.DecisionConseil.Name = "DecisionConseil";
            this.DecisionConseil.Size = new System.Drawing.Size(247, 20);
            this.DecisionConseil.TabIndex = 3;
            // 
            // AddData
            // 
            this.AddData.Location = new System.Drawing.Point(359, 295);
            this.AddData.Name = "AddData";
            this.AddData.Size = new System.Drawing.Size(75, 23);
            this.AddData.TabIndex = 4;
            this.AddData.Text = "Add Data";
            this.AddData.UseVisualStyleBackColor = true;
            this.AddData.Click += new System.EventHandler(this.AddData_Click);
            // 
            // GetItRight_AddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 323);
            this.Controls.Add(this.AddData);
            this.Controls.Add(this.DecisionConseil);
            this.Controls.Add(this.Decision);
            this.Controls.Add(this.Data);
            this.Controls.Add(this._Name);
            this.MaximumSize = new System.Drawing.Size(462, 362);
            this.MinimumSize = new System.Drawing.Size(462, 362);
            this.Name = "GetItRight_AddData";
            this.Text = "Fill Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _Name;
        private System.Windows.Forms.RichTextBox Data;
        private System.Windows.Forms.Label Decision;
        private System.Windows.Forms.TextBox DecisionConseil;
        private System.Windows.Forms.Button AddData;
    }
}