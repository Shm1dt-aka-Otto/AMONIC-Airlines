namespace AMONIC_Airlines_3
{
    partial class ConfirmBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmBooking));
            this.totalLabel = new System.Windows.Forms.Label();
            this.allPrice = new System.Windows.Forms.Label();
            this.paidLabel = new System.Windows.Forms.Label();
            this.cardRadioButton = new System.Windows.Forms.RadioButton();
            this.cashRadioButton = new System.Windows.Forms.RadioButton();
            this.voucherRadioButton = new System.Windows.Forms.RadioButton();
            this.issueButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(64, 48);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(106, 17);
            this.totalLabel.TabIndex = 0;
            this.totalLabel.Text = "Total amount:";
            // 
            // allPrice
            // 
            this.allPrice.AutoSize = true;
            this.allPrice.Location = new System.Drawing.Point(188, 48);
            this.allPrice.Name = "allPrice";
            this.allPrice.Size = new System.Drawing.Size(73, 17);
            this.allPrice.TabIndex = 1;
            this.allPrice.Text = "summary";
            // 
            // paidLabel
            // 
            this.paidLabel.AutoSize = true;
            this.paidLabel.Location = new System.Drawing.Point(64, 96);
            this.paidLabel.Name = "paidLabel";
            this.paidLabel.Size = new System.Drawing.Size(85, 17);
            this.paidLabel.TabIndex = 2;
            this.paidLabel.Text = "Paid using:";
            // 
            // cardRadioButton
            // 
            this.cardRadioButton.AutoSize = true;
            this.cardRadioButton.Location = new System.Drawing.Point(139, 125);
            this.cardRadioButton.Name = "cardRadioButton";
            this.cardRadioButton.Size = new System.Drawing.Size(109, 21);
            this.cardRadioButton.TabIndex = 3;
            this.cardRadioButton.TabStop = true;
            this.cardRadioButton.Text = "Credit Card";
            this.cardRadioButton.UseVisualStyleBackColor = true;
            // 
            // cashRadioButton
            // 
            this.cashRadioButton.AutoSize = true;
            this.cashRadioButton.Location = new System.Drawing.Point(139, 152);
            this.cashRadioButton.Name = "cashRadioButton";
            this.cashRadioButton.Size = new System.Drawing.Size(64, 21);
            this.cashRadioButton.TabIndex = 4;
            this.cashRadioButton.TabStop = true;
            this.cashRadioButton.Text = "Cash";
            this.cashRadioButton.UseVisualStyleBackColor = true;
            // 
            // voucherRadioButton
            // 
            this.voucherRadioButton.AutoSize = true;
            this.voucherRadioButton.Location = new System.Drawing.Point(139, 179);
            this.voucherRadioButton.Name = "voucherRadioButton";
            this.voucherRadioButton.Size = new System.Drawing.Size(86, 21);
            this.voucherRadioButton.TabIndex = 5;
            this.voucherRadioButton.TabStop = true;
            this.voucherRadioButton.Text = "Voucher";
            this.voucherRadioButton.UseVisualStyleBackColor = true;
            // 
            // issueButton
            // 
            this.issueButton.Location = new System.Drawing.Point(67, 221);
            this.issueButton.Name = "issueButton";
            this.issueButton.Size = new System.Drawing.Size(114, 23);
            this.issueButton.TabIndex = 6;
            this.issueButton.Text = "Issue tickets";
            this.issueButton.UseVisualStyleBackColor = true;
            this.issueButton.Click += new System.EventHandler(this.issueButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(238, 221);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(114, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ConfirmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 268);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.issueButton);
            this.Controls.Add(this.voucherRadioButton);
            this.Controls.Add(this.cashRadioButton);
            this.Controls.Add(this.cardRadioButton);
            this.Controls.Add(this.paidLabel);
            this.Controls.Add(this.allPrice);
            this.Controls.Add(this.totalLabel);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfirmBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label allPrice;
        private System.Windows.Forms.Label paidLabel;
        private System.Windows.Forms.RadioButton cardRadioButton;
        private System.Windows.Forms.RadioButton cashRadioButton;
        private System.Windows.Forms.RadioButton voucherRadioButton;
        private System.Windows.Forms.Button issueButton;
        private System.Windows.Forms.Button cancelButton;
    }
}