namespace AMONIC_Airlines_2
{
    partial class Schedule_edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedule_edit));
            this.flightRouteBox = new System.Windows.Forms.GroupBox();
            this.aircraftNameLabel = new System.Windows.Forms.Label();
            this.toIATALabel = new System.Windows.Forms.Label();
            this.fromIATALabel = new System.Windows.Forms.Label();
            this.aircraftLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.economyPriceLabel = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.dateBox = new System.Windows.Forms.MaskedTextBox();
            this.timeBox = new System.Windows.Forms.MaskedTextBox();
            this.flightRouteBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // flightRouteBox
            // 
            this.flightRouteBox.Controls.Add(this.aircraftNameLabel);
            this.flightRouteBox.Controls.Add(this.toIATALabel);
            this.flightRouteBox.Controls.Add(this.fromIATALabel);
            this.flightRouteBox.Controls.Add(this.aircraftLabel);
            this.flightRouteBox.Controls.Add(this.toLabel);
            this.flightRouteBox.Controls.Add(this.fromLabel);
            this.flightRouteBox.Location = new System.Drawing.Point(12, 12);
            this.flightRouteBox.Name = "flightRouteBox";
            this.flightRouteBox.Size = new System.Drawing.Size(566, 92);
            this.flightRouteBox.TabIndex = 0;
            this.flightRouteBox.TabStop = false;
            this.flightRouteBox.Text = "Flight route";
            // 
            // aircraftNameLabel
            // 
            this.aircraftNameLabel.AutoSize = true;
            this.aircraftNameLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aircraftNameLabel.Location = new System.Drawing.Point(413, 36);
            this.aircraftNameLabel.Name = "aircraftNameLabel";
            this.aircraftNameLabel.Size = new System.Drawing.Size(51, 17);
            this.aircraftNameLabel.TabIndex = 5;
            this.aircraftNameLabel.Text = "Name";
            // 
            // toIATALabel
            // 
            this.toIATALabel.AutoSize = true;
            this.toIATALabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toIATALabel.Location = new System.Drawing.Point(227, 36);
            this.toIATALabel.Name = "toIATALabel";
            this.toIATALabel.Size = new System.Drawing.Size(88, 17);
            this.toIATALabel.TabIndex = 4;
            this.toIATALabel.Text = "IATACode";
            // 
            // fromIATALabel
            // 
            this.fromIATALabel.AutoSize = true;
            this.fromIATALabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromIATALabel.Location = new System.Drawing.Point(78, 36);
            this.fromIATALabel.Name = "fromIATALabel";
            this.fromIATALabel.Size = new System.Drawing.Size(88, 17);
            this.fromIATALabel.TabIndex = 3;
            this.fromIATALabel.Text = "IATACode";
            // 
            // aircraftLabel
            // 
            this.aircraftLabel.AutoSize = true;
            this.aircraftLabel.Location = new System.Drawing.Point(355, 36);
            this.aircraftLabel.Name = "aircraftLabel";
            this.aircraftLabel.Size = new System.Drawing.Size(65, 17);
            this.aircraftLabel.TabIndex = 2;
            this.aircraftLabel.Text = "Aircraft:";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(204, 36);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(30, 17);
            this.toLabel.TabIndex = 1;
            this.toLabel.Text = "To:";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(36, 36);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(50, 17);
            this.fromLabel.TabIndex = 0;
            this.fromLabel.Text = "From:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(23, 136);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(47, 17);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "Date:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(199, 136);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(47, 17);
            this.timeLabel.TabIndex = 7;
            this.timeLabel.Text = "Time:";
            // 
            // economyPriceLabel
            // 
            this.economyPriceLabel.AutoSize = true;
            this.economyPriceLabel.Location = new System.Drawing.Point(357, 136);
            this.economyPriceLabel.Name = "economyPriceLabel";
            this.economyPriceLabel.Size = new System.Drawing.Size(130, 17);
            this.economyPriceLabel.TabIndex = 8;
            this.economyPriceLabel.Text = "Economy price: $";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(483, 133);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(95, 23);
            this.priceBox.TabIndex = 11;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(370, 188);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 25);
            this.updateButton.TabIndex = 12;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.update_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Red;
            this.cancelButton.Location = new System.Drawing.Point(493, 188);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 25);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(66, 133);
            this.dateBox.Mask = "0000-00-00";
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(127, 23);
            this.dateBox.TabIndex = 14;
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(242, 133);
            this.timeBox.Mask = "00:00:00";
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(109, 23);
            this.timeBox.TabIndex = 15;
            // 
            // Schedule_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 227);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.economyPriceLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.flightRouteBox);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Schedule_edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule edit";
            this.Load += new System.EventHandler(this.Schedule_edit_Load);
            this.flightRouteBox.ResumeLayout(false);
            this.flightRouteBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox flightRouteBox;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label aircraftNameLabel;
        private System.Windows.Forms.Label toIATALabel;
        private System.Windows.Forms.Label fromIATALabel;
        private System.Windows.Forms.Label aircraftLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label economyPriceLabel;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.MaskedTextBox dateBox;
        private System.Windows.Forms.MaskedTextBox timeBox;
    }
}