namespace AMONIC_Airlines_5
{
    partial class Amenities
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Amenities));
            this.referenceLabel = new System.Windows.Forms.Label();
            this.referenceBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.listGroupBox = new System.Windows.Forms.GroupBox();
            this.amenitiesButton = new System.Windows.Forms.Button();
            this.flightBox = new System.Windows.Forms.ComboBox();
            this.flightLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.passportLabel = new System.Windows.Forms.Label();
            this.cabinLabel = new System.Windows.Forms.Label();
            this.amonicGroupBox = new System.Windows.Forms.GroupBox();
            this.nineBox = new System.Windows.Forms.CheckBox();
            this.tenBox = new System.Windows.Forms.CheckBox();
            this.elevenBox = new System.Windows.Forms.CheckBox();
            this.twelveBox = new System.Windows.Forms.CheckBox();
            this.eightBox = new System.Windows.Forms.CheckBox();
            this.sevenBox = new System.Windows.Forms.CheckBox();
            this.sixBox = new System.Windows.Forms.CheckBox();
            this.fiveBox = new System.Windows.Forms.CheckBox();
            this.fourBox = new System.Windows.Forms.CheckBox();
            this.thirdBox = new System.Windows.Forms.CheckBox();
            this.secondBox = new System.Windows.Forms.CheckBox();
            this.firstBox = new System.Windows.Forms.CheckBox();
            this.itemLabel = new System.Windows.Forms.Label();
            this.taxesLabel = new System.Windows.Forms.Label();
            this.payableLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.listGroupBox.SuspendLayout();
            this.amonicGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // referenceLabel
            // 
            this.referenceLabel.AutoSize = true;
            this.referenceLabel.Location = new System.Drawing.Point(12, 9);
            this.referenceLabel.Name = "referenceLabel";
            this.referenceLabel.Size = new System.Drawing.Size(149, 17);
            this.referenceLabel.TabIndex = 0;
            this.referenceLabel.Text = "Booking references:";
            // 
            // referenceBox
            // 
            this.referenceBox.Location = new System.Drawing.Point(167, 6);
            this.referenceBox.Name = "referenceBox";
            this.referenceBox.Size = new System.Drawing.Size(115, 23);
            this.referenceBox.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(288, 6);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // listGroupBox
            // 
            this.listGroupBox.Controls.Add(this.amenitiesButton);
            this.listGroupBox.Controls.Add(this.flightBox);
            this.listGroupBox.Controls.Add(this.flightLabel);
            this.listGroupBox.Location = new System.Drawing.Point(12, 35);
            this.listGroupBox.Name = "listGroupBox";
            this.listGroupBox.Size = new System.Drawing.Size(776, 66);
            this.listGroupBox.TabIndex = 3;
            this.listGroupBox.TabStop = false;
            this.listGroupBox.Text = "Flight list";
            // 
            // amenitiesButton
            // 
            this.amenitiesButton.Location = new System.Drawing.Point(635, 26);
            this.amenitiesButton.Name = "amenitiesButton";
            this.amenitiesButton.Size = new System.Drawing.Size(132, 23);
            this.amenitiesButton.TabIndex = 2;
            this.amenitiesButton.Text = "Show Amenities";
            this.amenitiesButton.UseVisualStyleBackColor = true;
            this.amenitiesButton.Click += new System.EventHandler(this.amenitiesButton_Click);
            // 
            // flightBox
            // 
            this.flightBox.FormattingEnabled = true;
            this.flightBox.Location = new System.Drawing.Point(179, 26);
            this.flightBox.Name = "flightBox";
            this.flightBox.Size = new System.Drawing.Size(437, 24);
            this.flightBox.TabIndex = 1;
            // 
            // flightLabel
            // 
            this.flightLabel.AutoSize = true;
            this.flightLabel.Location = new System.Drawing.Point(21, 29);
            this.flightLabel.Name = "flightLabel";
            this.flightLabel.Size = new System.Drawing.Size(152, 17);
            this.flightLabel.TabIndex = 0;
            this.flightLabel.Text = "Choose your flights:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 116);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(210, 17);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Full name: XXXX XXXXXXXX";
            // 
            // passportLabel
            // 
            this.passportLabel.AutoSize = true;
            this.passportLabel.Location = new System.Drawing.Point(285, 116);
            this.passportLabel.Name = "passportLabel";
            this.passportLabel.Size = new System.Drawing.Size(265, 17);
            this.passportLabel.TabIndex = 5;
            this.passportLabel.Text = "Passport number: XXXX XXXXXXXX";
            // 
            // cabinLabel
            // 
            this.cabinLabel.AutoSize = true;
            this.cabinLabel.Location = new System.Drawing.Point(12, 147);
            this.cabinLabel.Name = "cabinLabel";
            this.cabinLabel.Size = new System.Drawing.Size(272, 17);
            this.cabinLabel.TabIndex = 6;
            this.cabinLabel.Text = "Your cabin class is: XXXX XXXXXXXX";
            // 
            // amonicGroupBox
            // 
            this.amonicGroupBox.Controls.Add(this.nineBox);
            this.amonicGroupBox.Controls.Add(this.tenBox);
            this.amonicGroupBox.Controls.Add(this.elevenBox);
            this.amonicGroupBox.Controls.Add(this.twelveBox);
            this.amonicGroupBox.Controls.Add(this.eightBox);
            this.amonicGroupBox.Controls.Add(this.sevenBox);
            this.amonicGroupBox.Controls.Add(this.sixBox);
            this.amonicGroupBox.Controls.Add(this.fiveBox);
            this.amonicGroupBox.Controls.Add(this.fourBox);
            this.amonicGroupBox.Controls.Add(this.thirdBox);
            this.amonicGroupBox.Controls.Add(this.secondBox);
            this.amonicGroupBox.Controls.Add(this.firstBox);
            this.amonicGroupBox.Location = new System.Drawing.Point(12, 176);
            this.amonicGroupBox.Name = "amonicGroupBox";
            this.amonicGroupBox.Size = new System.Drawing.Size(776, 142);
            this.amonicGroupBox.TabIndex = 7;
            this.amonicGroupBox.TabStop = false;
            this.amonicGroupBox.Text = "AMONIC Airlines Amenities";
            // 
            // nineBox
            // 
            this.nineBox.AutoSize = true;
            this.nineBox.Location = new System.Drawing.Point(555, 22);
            this.nineBox.Name = "nineBox";
            this.nineBox.Size = new System.Drawing.Size(144, 21);
            this.nineBox.TabIndex = 11;
            this.nineBox.Text = "Extra Bag ($15)";
            this.nineBox.UseVisualStyleBackColor = true;
            this.nineBox.CheckedChanged += new System.EventHandler(this.nineBox_CheckedChanged);
            // 
            // tenBox
            // 
            this.tenBox.AutoSize = true;
            this.tenBox.Location = new System.Drawing.Point(555, 49);
            this.tenBox.Name = "tenBox";
            this.tenBox.Size = new System.Drawing.Size(200, 21);
            this.tenBox.TabIndex = 10;
            this.tenBox.Text = "Fast Checkin Lane ($10)";
            this.tenBox.UseVisualStyleBackColor = true;
            this.tenBox.CheckedChanged += new System.EventHandler(this.tenBox_CheckedChanged);
            // 
            // elevenBox
            // 
            this.elevenBox.AutoSize = true;
            this.elevenBox.Location = new System.Drawing.Point(555, 76);
            this.elevenBox.Name = "elevenBox";
            this.elevenBox.Size = new System.Drawing.Size(163, 21);
            this.elevenBox.TabIndex = 9;
            this.elevenBox.Text = "Wi-Fi 50 mb (Free)";
            this.elevenBox.UseVisualStyleBackColor = true;
            // 
            // twelveBox
            // 
            this.twelveBox.AutoSize = true;
            this.twelveBox.Location = new System.Drawing.Point(555, 103);
            this.twelveBox.Name = "twelveBox";
            this.twelveBox.Size = new System.Drawing.Size(169, 21);
            this.twelveBox.TabIndex = 8;
            this.twelveBox.Text = "Wi-Fi 250 mb ($25)";
            this.twelveBox.UseVisualStyleBackColor = true;
            this.twelveBox.CheckedChanged += new System.EventHandler(this.twelveBox_CheckedChanged);
            // 
            // eightBox
            // 
            this.eightBox.AutoSize = true;
            this.eightBox.Location = new System.Drawing.Point(283, 103);
            this.eightBox.Name = "eightBox";
            this.eightBox.Size = new System.Drawing.Size(266, 21);
            this.eightBox.TabIndex = 7;
            this.eightBox.Text = "Premium Headphones Rental ($5)";
            this.eightBox.UseVisualStyleBackColor = true;
            this.eightBox.CheckedChanged += new System.EventHandler(this.eightBox_CheckedChanged);
            // 
            // sevenBox
            // 
            this.sevenBox.AutoSize = true;
            this.sevenBox.Location = new System.Drawing.Point(283, 76);
            this.sevenBox.Name = "sevenBox";
            this.sevenBox.Size = new System.Drawing.Size(157, 21);
            this.sevenBox.TabIndex = 6;
            this.sevenBox.Text = "Soft Drinks (Free)";
            this.sevenBox.UseVisualStyleBackColor = true;
            // 
            // sixBox
            // 
            this.sixBox.AutoSize = true;
            this.sixBox.Location = new System.Drawing.Point(283, 49);
            this.sixBox.Name = "sixBox";
            this.sixBox.Size = new System.Drawing.Size(179, 21);
            this.sixBox.TabIndex = 5;
            this.sixBox.Text = "Lounge Access ($25)";
            this.sixBox.UseVisualStyleBackColor = true;
            this.sixBox.CheckedChanged += new System.EventHandler(this.sixBox_CheckedChanged);
            // 
            // fiveBox
            // 
            this.fiveBox.AutoSize = true;
            this.fiveBox.Location = new System.Drawing.Point(283, 22);
            this.fiveBox.Name = "fiveBox";
            this.fiveBox.Size = new System.Drawing.Size(172, 21);
            this.fiveBox.TabIndex = 4;
            this.fiveBox.Text = "Laptop Rental ($15)";
            this.fiveBox.UseVisualStyleBackColor = true;
            this.fiveBox.CheckedChanged += new System.EventHandler(this.fiveBox_CheckedChanged);
            // 
            // fourBox
            // 
            this.fourBox.AutoSize = true;
            this.fourBox.Location = new System.Drawing.Point(6, 103);
            this.fourBox.Name = "fourBox";
            this.fourBox.Size = new System.Drawing.Size(164, 21);
            this.fourBox.TabIndex = 3;
            this.fourBox.Text = "Tablet Rental ($12)";
            this.fourBox.UseVisualStyleBackColor = true;
            this.fourBox.CheckedChanged += new System.EventHandler(this.fourBox_CheckedChanged);
            // 
            // thirdBox
            // 
            this.thirdBox.AutoSize = true;
            this.thirdBox.Location = new System.Drawing.Point(6, 76);
            this.thirdBox.Name = "thirdBox";
            this.thirdBox.Size = new System.Drawing.Size(271, 21);
            this.thirdBox.TabIndex = 2;
            this.thirdBox.Text = "Two Neighboring Seats Free ($50)";
            this.thirdBox.UseVisualStyleBackColor = true;
            this.thirdBox.CheckedChanged += new System.EventHandler(this.thirdBox_CheckedChanged);
            // 
            // secondBox
            // 
            this.secondBox.AutoSize = true;
            this.secondBox.Location = new System.Drawing.Point(6, 49);
            this.secondBox.Name = "secondBox";
            this.secondBox.Size = new System.Drawing.Size(179, 21);
            this.secondBox.TabIndex = 1;
            this.secondBox.Text = "Next Seat Free ($30)";
            this.secondBox.UseVisualStyleBackColor = true;
            this.secondBox.CheckedChanged += new System.EventHandler(this.secondBox_CheckedChanged);
            // 
            // firstBox
            // 
            this.firstBox.AutoSize = true;
            this.firstBox.Location = new System.Drawing.Point(6, 22);
            this.firstBox.Name = "firstBox";
            this.firstBox.Size = new System.Drawing.Size(169, 21);
            this.firstBox.TabIndex = 0;
            this.firstBox.Text = "Extra Blanket ($10)";
            this.firstBox.UseVisualStyleBackColor = true;
            this.firstBox.CheckedChanged += new System.EventHandler(this.firstBox_CheckedChanged);
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Location = new System.Drawing.Point(12, 343);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(143, 17);
            this.itemLabel.TabIndex = 8;
            this.itemLabel.Text = "Item selected: XXX";
            // 
            // taxesLabel
            // 
            this.taxesLabel.AutoSize = true;
            this.taxesLabel.Location = new System.Drawing.Point(12, 370);
            this.taxesLabel.Name = "taxesLabel";
            this.taxesLabel.Size = new System.Drawing.Size(169, 17);
            this.taxesLabel.TabIndex = 9;
            this.taxesLabel.Text = "Duties and taxes: XXX";
            // 
            // payableLabel
            // 
            this.payableLabel.AutoSize = true;
            this.payableLabel.Location = new System.Drawing.Point(12, 399);
            this.payableLabel.Name = "payableLabel";
            this.payableLabel.Size = new System.Drawing.Size(140, 17);
            this.payableLabel.TabIndex = 10;
            this.payableLabel.Text = "Total payable: XXX";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(602, 343);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(186, 27);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save and confirm";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(602, 389);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(186, 27);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Amenities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.payableLabel);
            this.Controls.Add(this.taxesLabel);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.amonicGroupBox);
            this.Controls.Add(this.cabinLabel);
            this.Controls.Add(this.passportLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.listGroupBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.referenceBox);
            this.Controls.Add(this.referenceLabel);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Amenities";
            this.Text = "Purchase Amenities";
            this.Load += new System.EventHandler(this.Amenities_Load);
            this.listGroupBox.ResumeLayout(false);
            this.listGroupBox.PerformLayout();
            this.amonicGroupBox.ResumeLayout(false);
            this.amonicGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label referenceLabel;
        private System.Windows.Forms.TextBox referenceBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.GroupBox listGroupBox;
        private System.Windows.Forms.Button amenitiesButton;
        private System.Windows.Forms.ComboBox flightBox;
        private System.Windows.Forms.Label flightLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label passportLabel;
        private System.Windows.Forms.Label cabinLabel;
        private System.Windows.Forms.GroupBox amonicGroupBox;
        private System.Windows.Forms.CheckBox nineBox;
        private System.Windows.Forms.CheckBox tenBox;
        private System.Windows.Forms.CheckBox elevenBox;
        private System.Windows.Forms.CheckBox twelveBox;
        private System.Windows.Forms.CheckBox eightBox;
        private System.Windows.Forms.CheckBox sevenBox;
        private System.Windows.Forms.CheckBox sixBox;
        private System.Windows.Forms.CheckBox fiveBox;
        private System.Windows.Forms.CheckBox fourBox;
        private System.Windows.Forms.CheckBox thirdBox;
        private System.Windows.Forms.CheckBox secondBox;
        private System.Windows.Forms.CheckBox firstBox;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.Label taxesLabel;
        private System.Windows.Forms.Label payableLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exitButton;
    }
}

