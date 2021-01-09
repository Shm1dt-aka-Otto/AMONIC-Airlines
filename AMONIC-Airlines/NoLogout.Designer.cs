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
            this.detect = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.software = new System.Windows.Forms.RadioButton();
            this.sys = new System.Windows.Forms.RadioButton();
            this.confirm = new System.Windows.Forms.Button();
            this.reasonBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // detect
            // 
            this.detect.AutoSize = true;
            this.detect.Location = new System.Drawing.Point(35, 29);
            this.detect.Name = "detect";
            this.detect.Size = new System.Drawing.Size(466, 17);
            this.detect.TabIndex = 0;
            this.detect.Text = "No logout detected for your last login on 06/07/2017 at 8:22:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reason:";
            // 
            // software
            // 
            this.software.AutoSize = true;
            this.software.Location = new System.Drawing.Point(58, 279);
            this.software.Name = "software";
            this.software.Size = new System.Drawing.Size(138, 21);
            this.software.TabIndex = 2;
            this.software.TabStop = true;
            this.software.Text = "Software Crash";
            this.software.UseVisualStyleBackColor = true;
            // 
            // sys
            // 
            this.sys.AutoSize = true;
            this.sys.Location = new System.Drawing.Point(220, 279);
            this.sys.Name = "sys";
            this.sys.Size = new System.Drawing.Size(128, 21);
            this.sys.TabIndex = 3;
            this.sys.TabStop = true;
            this.sys.Text = "System Crash";
            this.sys.UseVisualStyleBackColor = true;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(416, 279);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(107, 23);
            this.confirm.TabIndex = 4;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.sys);
            this.Controls.Add(this.software);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.detect);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoLogout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "No logout detected";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label detect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton software;
        private System.Windows.Forms.RadioButton sys;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.TextBox reasonBox;
    }
}