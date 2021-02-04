namespace AMONIC_Airlines_5
{
    partial class ShortSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShortSummary));
            this.amonicPicture = new System.Windows.Forms.PictureBox();
            this.lastDaysBox = new System.Windows.Forms.GroupBox();
            this.customersBox = new System.Windows.Forms.GroupBox();
            this.flightsBox = new System.Windows.Forms.GroupBox();
            this.passangersBox = new System.Windows.Forms.GroupBox();
            this.officesBox = new System.Windows.Forms.GroupBox();
            this.firstCustomer = new System.Windows.Forms.Label();
            this.secondCustomer = new System.Windows.Forms.Label();
            this.thirdCustomer = new System.Windows.Forms.Label();
            this.firstFlight = new System.Windows.Forms.Label();
            this.secondFlight = new System.Windows.Forms.Label();
            this.thirdFlight = new System.Windows.Forms.Label();
            this.busyPassanger = new System.Windows.Forms.Label();
            this.quitePassanger = new System.Windows.Forms.Label();
            this.firstOffice = new System.Windows.Forms.Label();
            this.thirdOffice = new System.Windows.Forms.Label();
            this.secondOffice = new System.Windows.Forms.Label();
            this.revenueBox = new System.Windows.Forms.GroupBox();
            this.percentBox = new System.Windows.Forms.GroupBox();
            this.yesterday = new System.Windows.Forms.Label();
            this.twoDaysAgo = new System.Windows.Forms.Label();
            this.threeDaysAgo = new System.Windows.Forms.Label();
            this.weekPercent = new System.Windows.Forms.Label();
            this.lastWeekPercent = new System.Windows.Forms.Label();
            this.twoWeeksAgoPercent = new System.Windows.Forms.Label();
            this.generatedReport = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amonicPicture)).BeginInit();
            this.lastDaysBox.SuspendLayout();
            this.customersBox.SuspendLayout();
            this.flightsBox.SuspendLayout();
            this.passangersBox.SuspendLayout();
            this.officesBox.SuspendLayout();
            this.revenueBox.SuspendLayout();
            this.percentBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // amonicPicture
            // 
            this.amonicPicture.Image = ((System.Drawing.Image)(resources.GetObject("amonicPicture.Image")));
            this.amonicPicture.Location = new System.Drawing.Point(217, 12);
            this.amonicPicture.Name = "amonicPicture";
            this.amonicPicture.Size = new System.Drawing.Size(324, 98);
            this.amonicPicture.TabIndex = 0;
            this.amonicPicture.TabStop = false;
            // 
            // lastDaysBox
            // 
            this.lastDaysBox.Controls.Add(this.officesBox);
            this.lastDaysBox.Controls.Add(this.passangersBox);
            this.lastDaysBox.Controls.Add(this.flightsBox);
            this.lastDaysBox.Controls.Add(this.customersBox);
            this.lastDaysBox.Location = new System.Drawing.Point(12, 130);
            this.lastDaysBox.Name = "lastDaysBox";
            this.lastDaysBox.Size = new System.Drawing.Size(748, 294);
            this.lastDaysBox.TabIndex = 1;
            this.lastDaysBox.TabStop = false;
            this.lastDaysBox.Text = "In the last 30 days...";
            // 
            // customersBox
            // 
            this.customersBox.Controls.Add(this.thirdCustomer);
            this.customersBox.Controls.Add(this.secondCustomer);
            this.customersBox.Controls.Add(this.firstCustomer);
            this.customersBox.Location = new System.Drawing.Point(381, 22);
            this.customersBox.Name = "customersBox";
            this.customersBox.Size = new System.Drawing.Size(361, 125);
            this.customersBox.TabIndex = 0;
            this.customersBox.TabStop = false;
            this.customersBox.Text = "Top Customers (Number of purchases)";
            // 
            // flightsBox
            // 
            this.flightsBox.Controls.Add(this.thirdFlight);
            this.flightsBox.Controls.Add(this.secondFlight);
            this.flightsBox.Controls.Add(this.firstFlight);
            this.flightsBox.Location = new System.Drawing.Point(6, 22);
            this.flightsBox.Name = "flightsBox";
            this.flightsBox.Size = new System.Drawing.Size(354, 125);
            this.flightsBox.TabIndex = 1;
            this.flightsBox.TabStop = false;
            this.flightsBox.Text = "Fllights";
            // 
            // passangersBox
            // 
            this.passangersBox.Controls.Add(this.quitePassanger);
            this.passangersBox.Controls.Add(this.busyPassanger);
            this.passangersBox.Location = new System.Drawing.Point(6, 153);
            this.passangersBox.Name = "passangersBox";
            this.passangersBox.Size = new System.Drawing.Size(354, 125);
            this.passangersBox.TabIndex = 2;
            this.passangersBox.TabStop = false;
            this.passangersBox.Text = "Number of passangers flying";
            // 
            // officesBox
            // 
            this.officesBox.Controls.Add(this.secondOffice);
            this.officesBox.Controls.Add(this.thirdOffice);
            this.officesBox.Controls.Add(this.firstOffice);
            this.officesBox.Location = new System.Drawing.Point(381, 153);
            this.officesBox.Name = "officesBox";
            this.officesBox.Size = new System.Drawing.Size(361, 125);
            this.officesBox.TabIndex = 3;
            this.officesBox.TabStop = false;
            this.officesBox.Text = "Top AMONIC Airlines Offices (Revenue)";
            // 
            // firstCustomer
            // 
            this.firstCustomer.AutoSize = true;
            this.firstCustomer.Location = new System.Drawing.Point(6, 34);
            this.firstCustomer.Name = "firstCustomer";
            this.firstCustomer.Size = new System.Drawing.Size(28, 17);
            this.firstCustomer.TabIndex = 0;
            this.firstCustomer.Text = "1) ";
            // 
            // secondCustomer
            // 
            this.secondCustomer.AutoSize = true;
            this.secondCustomer.Location = new System.Drawing.Point(6, 63);
            this.secondCustomer.Name = "secondCustomer";
            this.secondCustomer.Size = new System.Drawing.Size(28, 17);
            this.secondCustomer.TabIndex = 1;
            this.secondCustomer.Text = "2) ";
            // 
            // thirdCustomer
            // 
            this.thirdCustomer.AutoSize = true;
            this.thirdCustomer.Location = new System.Drawing.Point(6, 94);
            this.thirdCustomer.Name = "thirdCustomer";
            this.thirdCustomer.Size = new System.Drawing.Size(28, 17);
            this.thirdCustomer.TabIndex = 2;
            this.thirdCustomer.Text = "3) ";
            // 
            // firstFlight
            // 
            this.firstFlight.AutoSize = true;
            this.firstFlight.Location = new System.Drawing.Point(6, 34);
            this.firstFlight.Name = "firstFlight";
            this.firstFlight.Size = new System.Drawing.Size(148, 17);
            this.firstFlight.TabIndex = 3;
            this.firstFlight.Text = "Number confirmed: ";
            // 
            // secondFlight
            // 
            this.secondFlight.AutoSize = true;
            this.secondFlight.Location = new System.Drawing.Point(6, 63);
            this.secondFlight.Name = "secondFlight";
            this.secondFlight.Size = new System.Drawing.Size(141, 17);
            this.secondFlight.TabIndex = 4;
            this.secondFlight.Text = "Number cancelled: ";
            // 
            // thirdFlight
            // 
            this.thirdFlight.AutoSize = true;
            this.thirdFlight.Location = new System.Drawing.Point(6, 94);
            this.thirdFlight.Name = "thirdFlight";
            this.thirdFlight.Size = new System.Drawing.Size(187, 17);
            this.thirdFlight.TabIndex = 5;
            this.thirdFlight.Text = "Average daily flight time: ";
            // 
            // busyPassanger
            // 
            this.busyPassanger.AutoSize = true;
            this.busyPassanger.Location = new System.Drawing.Point(6, 40);
            this.busyPassanger.Name = "busyPassanger";
            this.busyPassanger.Size = new System.Drawing.Size(101, 17);
            this.busyPassanger.TabIndex = 6;
            this.busyPassanger.Text = "Busiest day: ";
            // 
            // quitePassanger
            // 
            this.quitePassanger.AutoSize = true;
            this.quitePassanger.Location = new System.Drawing.Point(6, 77);
            this.quitePassanger.Name = "quitePassanger";
            this.quitePassanger.Size = new System.Drawing.Size(123, 17);
            this.quitePassanger.TabIndex = 7;
            this.quitePassanger.Text = "Most quite day: ";
            // 
            // firstOffice
            // 
            this.firstOffice.AutoSize = true;
            this.firstOffice.Location = new System.Drawing.Point(6, 28);
            this.firstOffice.Name = "firstOffice";
            this.firstOffice.Size = new System.Drawing.Size(28, 17);
            this.firstOffice.TabIndex = 8;
            this.firstOffice.Text = "1) ";
            // 
            // thirdOffice
            // 
            this.thirdOffice.AutoSize = true;
            this.thirdOffice.Location = new System.Drawing.Point(6, 86);
            this.thirdOffice.Name = "thirdOffice";
            this.thirdOffice.Size = new System.Drawing.Size(28, 17);
            this.thirdOffice.TabIndex = 9;
            this.thirdOffice.Text = "3) ";
            // 
            // secondOffice
            // 
            this.secondOffice.AutoSize = true;
            this.secondOffice.Location = new System.Drawing.Point(6, 56);
            this.secondOffice.Name = "secondOffice";
            this.secondOffice.Size = new System.Drawing.Size(28, 17);
            this.secondOffice.TabIndex = 10;
            this.secondOffice.Text = "2) ";
            // 
            // revenueBox
            // 
            this.revenueBox.Controls.Add(this.threeDaysAgo);
            this.revenueBox.Controls.Add(this.twoDaysAgo);
            this.revenueBox.Controls.Add(this.yesterday);
            this.revenueBox.Location = new System.Drawing.Point(12, 430);
            this.revenueBox.Name = "revenueBox";
            this.revenueBox.Size = new System.Drawing.Size(748, 74);
            this.revenueBox.TabIndex = 2;
            this.revenueBox.TabStop = false;
            this.revenueBox.Text = "Revenue from ticket sales";
            // 
            // percentBox
            // 
            this.percentBox.Controls.Add(this.twoWeeksAgoPercent);
            this.percentBox.Controls.Add(this.lastWeekPercent);
            this.percentBox.Controls.Add(this.weekPercent);
            this.percentBox.Location = new System.Drawing.Point(12, 510);
            this.percentBox.Name = "percentBox";
            this.percentBox.Size = new System.Drawing.Size(748, 74);
            this.percentBox.TabIndex = 3;
            this.percentBox.TabStop = false;
            this.percentBox.Text = "Weekly report of percentage of empty seats";
            // 
            // yesterday
            // 
            this.yesterday.AutoSize = true;
            this.yesterday.Location = new System.Drawing.Point(12, 37);
            this.yesterday.Name = "yesterday";
            this.yesterday.Size = new System.Drawing.Size(97, 17);
            this.yesterday.TabIndex = 4;
            this.yesterday.Text = "Yesterday: $";
            // 
            // twoDaysAgo
            // 
            this.twoDaysAgo.AutoSize = true;
            this.twoDaysAgo.Location = new System.Drawing.Point(268, 37);
            this.twoDaysAgo.Name = "twoDaysAgo";
            this.twoDaysAgo.Size = new System.Drawing.Size(130, 17);
            this.twoDaysAgo.TabIndex = 5;
            this.twoDaysAgo.Text = "Two days ago:  $";
            // 
            // threeDaysAgo
            // 
            this.threeDaysAgo.AutoSize = true;
            this.threeDaysAgo.Location = new System.Drawing.Point(514, 37);
            this.threeDaysAgo.Name = "threeDaysAgo";
            this.threeDaysAgo.Size = new System.Drawing.Size(142, 17);
            this.threeDaysAgo.TabIndex = 6;
            this.threeDaysAgo.Text = "Three days ago:  $";
            // 
            // weekPercent
            // 
            this.weekPercent.AutoSize = true;
            this.weekPercent.Location = new System.Drawing.Point(12, 36);
            this.weekPercent.Name = "weekPercent";
            this.weekPercent.Size = new System.Drawing.Size(88, 17);
            this.weekPercent.TabIndex = 7;
            this.weekPercent.Text = "This week: ";
            // 
            // lastWeekPercent
            // 
            this.lastWeekPercent.AutoSize = true;
            this.lastWeekPercent.Location = new System.Drawing.Point(268, 36);
            this.lastWeekPercent.Name = "lastWeekPercent";
            this.lastWeekPercent.Size = new System.Drawing.Size(89, 17);
            this.lastWeekPercent.TabIndex = 8;
            this.lastWeekPercent.Text = "Last week: ";
            // 
            // twoWeeksAgoPercent
            // 
            this.twoWeeksAgoPercent.AutoSize = true;
            this.twoWeeksAgoPercent.Location = new System.Drawing.Point(514, 36);
            this.twoWeeksAgoPercent.Name = "twoWeeksAgoPercent";
            this.twoWeeksAgoPercent.Size = new System.Drawing.Size(126, 17);
            this.twoWeeksAgoPercent.TabIndex = 9;
            this.twoWeeksAgoPercent.Text = "Two weeks ago: ";
            // 
            // generatedReport
            // 
            this.generatedReport.AutoSize = true;
            this.generatedReport.Location = new System.Drawing.Point(12, 605);
            this.generatedReport.Name = "generatedReport";
            this.generatedReport.Size = new System.Drawing.Size(154, 17);
            this.generatedReport.TabIndex = 10;
            this.generatedReport.Text = "Report generated in ";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(685, 602);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ShortSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 637);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.generatedReport);
            this.Controls.Add(this.percentBox);
            this.Controls.Add(this.revenueBox);
            this.Controls.Add(this.lastDaysBox);
            this.Controls.Add(this.amonicPicture);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShortSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AMONIC Airlines Short Summary";
            this.Load += new System.EventHandler(this.ShortSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amonicPicture)).EndInit();
            this.lastDaysBox.ResumeLayout(false);
            this.customersBox.ResumeLayout(false);
            this.customersBox.PerformLayout();
            this.flightsBox.ResumeLayout(false);
            this.flightsBox.PerformLayout();
            this.passangersBox.ResumeLayout(false);
            this.passangersBox.PerformLayout();
            this.officesBox.ResumeLayout(false);
            this.officesBox.PerformLayout();
            this.revenueBox.ResumeLayout(false);
            this.revenueBox.PerformLayout();
            this.percentBox.ResumeLayout(false);
            this.percentBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox amonicPicture;
        private System.Windows.Forms.GroupBox lastDaysBox;
        private System.Windows.Forms.GroupBox officesBox;
        private System.Windows.Forms.Label secondOffice;
        private System.Windows.Forms.Label thirdOffice;
        private System.Windows.Forms.Label firstOffice;
        private System.Windows.Forms.GroupBox passangersBox;
        private System.Windows.Forms.Label quitePassanger;
        private System.Windows.Forms.Label busyPassanger;
        private System.Windows.Forms.GroupBox flightsBox;
        private System.Windows.Forms.Label thirdFlight;
        private System.Windows.Forms.Label secondFlight;
        private System.Windows.Forms.Label firstFlight;
        private System.Windows.Forms.GroupBox customersBox;
        private System.Windows.Forms.Label thirdCustomer;
        private System.Windows.Forms.Label secondCustomer;
        private System.Windows.Forms.Label firstCustomer;
        private System.Windows.Forms.GroupBox revenueBox;
        private System.Windows.Forms.Label threeDaysAgo;
        private System.Windows.Forms.Label twoDaysAgo;
        private System.Windows.Forms.Label yesterday;
        private System.Windows.Forms.GroupBox percentBox;
        private System.Windows.Forms.Label twoWeeksAgoPercent;
        private System.Windows.Forms.Label lastWeekPercent;
        private System.Windows.Forms.Label weekPercent;
        private System.Windows.Forms.Label generatedReport;
        private System.Windows.Forms.Button closeButton;
    }
}