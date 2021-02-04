namespace AMONIC_Airlines_4
{
    partial class AddSurvey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSurvey));
            this.fileText = new System.Windows.Forms.TextBox();
            this.importButton = new System.Windows.Forms.Button();
            this.successLabel = new System.Windows.Forms.Label();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.monthText = new System.Windows.Forms.TextBox();
            this.yearText = new System.Windows.Forms.TextBox();
            this.monthLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fileText
            // 
            this.fileText.Location = new System.Drawing.Point(31, 46);
            this.fileText.Name = "fileText";
            this.fileText.Size = new System.Drawing.Size(400, 23);
            this.fileText.TabIndex = 0;
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(437, 46);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(75, 23);
            this.importButton.TabIndex = 1;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.Location = new System.Drawing.Point(106, 125);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(241, 17);
            this.successLabel.TabIndex = 2;
            this.successLabel.Text = "Import Successful! Close window";
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Location = new System.Drawing.Point(28, 26);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(242, 17);
            this.chooseLabel.TabIndex = 3;
            this.chooseLabel.Text = "Choose file with survey to import";
            // 
            // monthText
            // 
            this.monthText.Location = new System.Drawing.Point(86, 88);
            this.monthText.Name = "monthText";
            this.monthText.Size = new System.Drawing.Size(100, 23);
            this.monthText.TabIndex = 4;
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(262, 88);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(100, 23);
            this.yearText.TabIndex = 5;
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(28, 91);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(52, 17);
            this.monthLabel.TabIndex = 6;
            this.monthLabel.Text = "Month";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(218, 91);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(38, 17);
            this.yearLabel.TabIndex = 7;
            this.yearLabel.Text = "Year";
            // 
            // AddSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 162);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.monthText);
            this.Controls.Add(this.chooseLabel);
            this.Controls.Add(this.successLabel);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.fileText);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSurvey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSurvey";
            this.Load += new System.EventHandler(this.AddSurvey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileText;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Label successLabel;
        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.TextBox monthText;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label yearLabel;
    }
}