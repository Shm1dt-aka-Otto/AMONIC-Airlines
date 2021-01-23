namespace AMONIC_Airlines
{
    partial class NoLogout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoLogout));
            this.noLogoutLabel = new System.Windows.Forms.Label();
            this.reasonLabel = new System.Windows.Forms.Label();
            this.softwareRadioButton = new System.Windows.Forms.RadioButton();
            this.systemRadioButton = new System.Windows.Forms.RadioButton();
            this.confirmButton = new System.Windows.Forms.Button();
            this.reasonBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // noLogoutLabel
            // 
            this.noLogoutLabel.AutoSize = true;
            this.noLogoutLabel.Location = new System.Drawing.Point(35, 29);
            this.noLogoutLabel.Name = "noLogoutLabel";
            this.noLogoutLabel.Size = new System.Drawing.Size(466, 17);
            this.noLogoutLabel.TabIndex = 0;
            this.noLogoutLabel.Text = "No logout detected for your last login on 06/07/2017 at 8:22:00";
            // 
            // reasonLabel
            // 
            this.reasonLabel.AutoSize = true;
            this.reasonLabel.Location = new System.Drawing.Point(35, 71);
            this.reasonLabel.Name = "reasonLabel";
            this.reasonLabel.Size = new System.Drawing.Size(66, 17);
            this.reasonLabel.TabIndex = 1;
            this.reasonLabel.Text = "Reason:";
            // 
            // softwareRadioButton
            // 
            this.softwareRadioButton.AutoSize = true;
            this.softwareRadioButton.Location = new System.Drawing.Point(58, 279);
            this.softwareRadioButton.Name = "softwareRadioButton";
            this.softwareRadioButton.Size = new System.Drawing.Size(138, 21);
            this.softwareRadioButton.TabIndex = 2;
            this.softwareRadioButton.TabStop = true;
            this.softwareRadioButton.Text = "Software Crash";
            this.softwareRadioButton.UseVisualStyleBackColor = true;
            // 
            // systemRadioButton
            // 
            this.systemRadioButton.AutoSize = true;
            this.systemRadioButton.Location = new System.Drawing.Point(220, 279);
            this.systemRadioButton.Name = "systemRadioButton";
            this.systemRadioButton.Size = new System.Drawing.Size(128, 21);
            this.systemRadioButton.TabIndex = 3;
            this.systemRadioButton.TabStop = true;
            this.systemRadioButton.Text = "System Crash";
            this.systemRadioButton.UseVisualStyleBackColor = true;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(416, 279);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(107, 23);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // reasonBox
            // 
            this.reasonBox.Location = new System.Drawing.Point(38, 91);
            this.reasonBox.Multiline = true;
            this.reasonBox.Name = "reasonBox";
            this.reasonBox.Size = new System.Drawing.Size(485, 153);
            this.reasonBox.TabIndex = 5;
            // 
            // NoLogout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 330);
            this.Controls.Add(this.reasonBox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.systemRadioButton);
            this.Controls.Add(this.softwareRadioButton);
            this.Controls.Add(this.reasonLabel);
            this.Controls.Add(this.noLogoutLabel);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoLogout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "No logout detected";
            this.Load += new System.EventHandler(this.NoLogout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label noLogoutLabel;
        private System.Windows.Forms.Label reasonLabel;
        private System.Windows.Forms.RadioButton softwareRadioButton;
        private System.Windows.Forms.RadioButton systemRadioButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox reasonBox;
    }
}