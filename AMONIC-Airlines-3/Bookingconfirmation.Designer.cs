namespace AMONIC_Airlines_3
{
    partial class Bookingconfirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bookingconfirmation));
            this.outboundDetailBox = new System.Windows.Forms.GroupBox();
            this.flightNumberOutbound = new System.Windows.Forms.Label();
            this.flightNumberLabel = new System.Windows.Forms.Label();
            this.dateOutbound = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.cabinTypeOutbound = new System.Windows.Forms.Label();
            this.cabinTypeLabel = new System.Windows.Forms.Label();
            this.iataOutboundTo = new System.Windows.Forms.Label();
            this.toOutboundLabel = new System.Windows.Forms.Label();
            this.iataOutboundFrom = new System.Windows.Forms.Label();
            this.fromOutboundLabel = new System.Windows.Forms.Label();
            this.returnDetailBox = new System.Windows.Forms.GroupBox();
            this.flightNumberReturn = new System.Windows.Forms.Label();
            this.flightNumberReturnLabel = new System.Windows.Forms.Label();
            this.dateReturn = new System.Windows.Forms.Label();
            this.dateReturnLabel = new System.Windows.Forms.Label();
            this.cabinTypeReturn = new System.Windows.Forms.Label();
            this.cabinTypeReturnLabel = new System.Windows.Forms.Label();
            this.iataReturnTo = new System.Windows.Forms.Label();
            this.toReturnLabel = new System.Windows.Forms.Label();
            this.iataReturnFrom = new System.Windows.Forms.Label();
            this.fromReturnLabel = new System.Windows.Forms.Label();
            this.passengerDetailBox = new System.Windows.Forms.GroupBox();
            this.passCountryBox = new System.Windows.Forms.ComboBox();
            this.passNumText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.addPassengerButton = new System.Windows.Forms.Button();
            this.phone = new System.Windows.Forms.Label();
            this.passportCountry = new System.Windows.Forms.Label();
            this.passportNumber = new System.Windows.Forms.Label();
            this.birthDate = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.passangerListLabel = new System.Windows.Forms.Label();
            this.passlistGridView = new System.Windows.Forms.DataGridView();
            this.f_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_hone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.birthDateText = new System.Windows.Forms.MaskedTextBox();
            this.phoneText = new System.Windows.Forms.MaskedTextBox();
            this.outboundDetailBox.SuspendLayout();
            this.returnDetailBox.SuspendLayout();
            this.passengerDetailBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passlistGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // outboundDetailBox
            // 
            this.outboundDetailBox.Controls.Add(this.flightNumberOutbound);
            this.outboundDetailBox.Controls.Add(this.flightNumberLabel);
            this.outboundDetailBox.Controls.Add(this.dateOutbound);
            this.outboundDetailBox.Controls.Add(this.dateLabel);
            this.outboundDetailBox.Controls.Add(this.cabinTypeOutbound);
            this.outboundDetailBox.Controls.Add(this.cabinTypeLabel);
            this.outboundDetailBox.Controls.Add(this.iataOutboundTo);
            this.outboundDetailBox.Controls.Add(this.toOutboundLabel);
            this.outboundDetailBox.Controls.Add(this.iataOutboundFrom);
            this.outboundDetailBox.Controls.Add(this.fromOutboundLabel);
            this.outboundDetailBox.Location = new System.Drawing.Point(12, 12);
            this.outboundDetailBox.Name = "outboundDetailBox";
            this.outboundDetailBox.Size = new System.Drawing.Size(816, 75);
            this.outboundDetailBox.TabIndex = 0;
            this.outboundDetailBox.TabStop = false;
            this.outboundDetailBox.Text = "Outbound flight details";
            // 
            // flightNumberOutbound
            // 
            this.flightNumberOutbound.AutoSize = true;
            this.flightNumberOutbound.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flightNumberOutbound.Location = new System.Drawing.Point(706, 33);
            this.flightNumberOutbound.Name = "flightNumberOutbound";
            this.flightNumberOutbound.Size = new System.Drawing.Size(69, 17);
            this.flightNumberOutbound.TabIndex = 9;
            this.flightNumberOutbound.Text = "Number";
            // 
            // flightNumberLabel
            // 
            this.flightNumberLabel.AutoSize = true;
            this.flightNumberLabel.Location = new System.Drawing.Point(598, 33);
            this.flightNumberLabel.Name = "flightNumberLabel";
            this.flightNumberLabel.Size = new System.Drawing.Size(117, 17);
            this.flightNumberLabel.TabIndex = 8;
            this.flightNumberLabel.Text = "Flight Number: ";
            // 
            // dateOutbound
            // 
            this.dateOutbound.AutoSize = true;
            this.dateOutbound.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOutbound.Location = new System.Drawing.Point(478, 33);
            this.dateOutbound.Name = "dateOutbound";
            this.dateOutbound.Size = new System.Drawing.Size(92, 17);
            this.dateOutbound.TabIndex = 7;
            this.dateOutbound.Text = "yyyymmdd";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(435, 33);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(47, 17);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "Date:";
            // 
            // cabinTypeOutbound
            // 
            this.cabinTypeOutbound.AutoSize = true;
            this.cabinTypeOutbound.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cabinTypeOutbound.Location = new System.Drawing.Point(319, 33);
            this.cabinTypeOutbound.Name = "cabinTypeOutbound";
            this.cabinTypeOutbound.Size = new System.Drawing.Size(95, 17);
            this.cabinTypeOutbound.TabIndex = 5;
            this.cabinTypeOutbound.Text = "Type Cabin";
            // 
            // cabinTypeLabel
            // 
            this.cabinTypeLabel.AutoSize = true;
            this.cabinTypeLabel.Location = new System.Drawing.Point(233, 33);
            this.cabinTypeLabel.Name = "cabinTypeLabel";
            this.cabinTypeLabel.Size = new System.Drawing.Size(91, 17);
            this.cabinTypeLabel.TabIndex = 4;
            this.cabinTypeLabel.Text = "Cabin Type:";
            // 
            // iataOutboundTo
            // 
            this.iataOutboundTo.AutoSize = true;
            this.iataOutboundTo.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iataOutboundTo.Location = new System.Drawing.Point(154, 33);
            this.iataOutboundTo.Name = "iataOutboundTo";
            this.iataOutboundTo.Size = new System.Drawing.Size(48, 17);
            this.iataOutboundTo.TabIndex = 3;
            this.iataOutboundTo.Text = "IATA";
            // 
            // toOutboundLabel
            // 
            this.toOutboundLabel.AutoSize = true;
            this.toOutboundLabel.Location = new System.Drawing.Point(130, 33);
            this.toOutboundLabel.Name = "toOutboundLabel";
            this.toOutboundLabel.Size = new System.Drawing.Size(30, 17);
            this.toOutboundLabel.TabIndex = 2;
            this.toOutboundLabel.Text = "To:";
            // 
            // iataOutboundFrom
            // 
            this.iataOutboundFrom.AutoSize = true;
            this.iataOutboundFrom.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iataOutboundFrom.Location = new System.Drawing.Point(63, 33);
            this.iataOutboundFrom.Name = "iataOutboundFrom";
            this.iataOutboundFrom.Size = new System.Drawing.Size(48, 17);
            this.iataOutboundFrom.TabIndex = 1;
            this.iataOutboundFrom.Text = "IATA";
            // 
            // fromOutboundLabel
            // 
            this.fromOutboundLabel.AutoSize = true;
            this.fromOutboundLabel.Location = new System.Drawing.Point(16, 33);
            this.fromOutboundLabel.Name = "fromOutboundLabel";
            this.fromOutboundLabel.Size = new System.Drawing.Size(50, 17);
            this.fromOutboundLabel.TabIndex = 0;
            this.fromOutboundLabel.Text = "From:";
            // 
            // returnDetailBox
            // 
            this.returnDetailBox.Controls.Add(this.flightNumberReturn);
            this.returnDetailBox.Controls.Add(this.flightNumberReturnLabel);
            this.returnDetailBox.Controls.Add(this.dateReturn);
            this.returnDetailBox.Controls.Add(this.dateReturnLabel);
            this.returnDetailBox.Controls.Add(this.cabinTypeReturn);
            this.returnDetailBox.Controls.Add(this.cabinTypeReturnLabel);
            this.returnDetailBox.Controls.Add(this.iataReturnTo);
            this.returnDetailBox.Controls.Add(this.toReturnLabel);
            this.returnDetailBox.Controls.Add(this.iataReturnFrom);
            this.returnDetailBox.Controls.Add(this.fromReturnLabel);
            this.returnDetailBox.Location = new System.Drawing.Point(12, 93);
            this.returnDetailBox.Name = "returnDetailBox";
            this.returnDetailBox.Size = new System.Drawing.Size(816, 75);
            this.returnDetailBox.TabIndex = 10;
            this.returnDetailBox.TabStop = false;
            this.returnDetailBox.Text = "Return flight details";
            // 
            // flightNumberReturn
            // 
            this.flightNumberReturn.AutoSize = true;
            this.flightNumberReturn.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flightNumberReturn.Location = new System.Drawing.Point(706, 33);
            this.flightNumberReturn.Name = "flightNumberReturn";
            this.flightNumberReturn.Size = new System.Drawing.Size(69, 17);
            this.flightNumberReturn.TabIndex = 9;
            this.flightNumberReturn.Text = "Number";
            // 
            // flightNumberReturnLabel
            // 
            this.flightNumberReturnLabel.AutoSize = true;
            this.flightNumberReturnLabel.Location = new System.Drawing.Point(598, 33);
            this.flightNumberReturnLabel.Name = "flightNumberReturnLabel";
            this.flightNumberReturnLabel.Size = new System.Drawing.Size(117, 17);
            this.flightNumberReturnLabel.TabIndex = 8;
            this.flightNumberReturnLabel.Text = "Flight Number: ";
            // 
            // dateReturn
            // 
            this.dateReturn.AutoSize = true;
            this.dateReturn.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateReturn.Location = new System.Drawing.Point(478, 33);
            this.dateReturn.Name = "dateReturn";
            this.dateReturn.Size = new System.Drawing.Size(92, 17);
            this.dateReturn.TabIndex = 7;
            this.dateReturn.Text = "yyyymmdd";
            // 
            // dateReturnLabel
            // 
            this.dateReturnLabel.AutoSize = true;
            this.dateReturnLabel.Location = new System.Drawing.Point(435, 33);
            this.dateReturnLabel.Name = "dateReturnLabel";
            this.dateReturnLabel.Size = new System.Drawing.Size(47, 17);
            this.dateReturnLabel.TabIndex = 6;
            this.dateReturnLabel.Text = "Date:";
            // 
            // cabinTypeReturn
            // 
            this.cabinTypeReturn.AutoSize = true;
            this.cabinTypeReturn.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cabinTypeReturn.Location = new System.Drawing.Point(319, 33);
            this.cabinTypeReturn.Name = "cabinTypeReturn";
            this.cabinTypeReturn.Size = new System.Drawing.Size(95, 17);
            this.cabinTypeReturn.TabIndex = 5;
            this.cabinTypeReturn.Text = "Type Cabin";
            // 
            // cabinTypeReturnLabel
            // 
            this.cabinTypeReturnLabel.AutoSize = true;
            this.cabinTypeReturnLabel.Location = new System.Drawing.Point(233, 33);
            this.cabinTypeReturnLabel.Name = "cabinTypeReturnLabel";
            this.cabinTypeReturnLabel.Size = new System.Drawing.Size(91, 17);
            this.cabinTypeReturnLabel.TabIndex = 4;
            this.cabinTypeReturnLabel.Text = "Cabin Type:";
            // 
            // iataReturnTo
            // 
            this.iataReturnTo.AutoSize = true;
            this.iataReturnTo.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iataReturnTo.Location = new System.Drawing.Point(154, 33);
            this.iataReturnTo.Name = "iataReturnTo";
            this.iataReturnTo.Size = new System.Drawing.Size(48, 17);
            this.iataReturnTo.TabIndex = 3;
            this.iataReturnTo.Text = "IATA";
            // 
            // toReturnLabel
            // 
            this.toReturnLabel.AutoSize = true;
            this.toReturnLabel.Location = new System.Drawing.Point(130, 33);
            this.toReturnLabel.Name = "toReturnLabel";
            this.toReturnLabel.Size = new System.Drawing.Size(30, 17);
            this.toReturnLabel.TabIndex = 2;
            this.toReturnLabel.Text = "To:";
            // 
            // iataReturnFrom
            // 
            this.iataReturnFrom.AutoSize = true;
            this.iataReturnFrom.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iataReturnFrom.Location = new System.Drawing.Point(63, 33);
            this.iataReturnFrom.Name = "iataReturnFrom";
            this.iataReturnFrom.Size = new System.Drawing.Size(48, 17);
            this.iataReturnFrom.TabIndex = 1;
            this.iataReturnFrom.Text = "IATA";
            // 
            // fromReturnLabel
            // 
            this.fromReturnLabel.AutoSize = true;
            this.fromReturnLabel.Location = new System.Drawing.Point(16, 33);
            this.fromReturnLabel.Name = "fromReturnLabel";
            this.fromReturnLabel.Size = new System.Drawing.Size(50, 17);
            this.fromReturnLabel.TabIndex = 0;
            this.fromReturnLabel.Text = "From:";
            // 
            // passengerDetailBox
            // 
            this.passengerDetailBox.Controls.Add(this.phoneText);
            this.passengerDetailBox.Controls.Add(this.birthDateText);
            this.passengerDetailBox.Controls.Add(this.passCountryBox);
            this.passengerDetailBox.Controls.Add(this.passNumText);
            this.passengerDetailBox.Controls.Add(this.lastNameText);
            this.passengerDetailBox.Controls.Add(this.firstNameText);
            this.passengerDetailBox.Controls.Add(this.addPassengerButton);
            this.passengerDetailBox.Controls.Add(this.phone);
            this.passengerDetailBox.Controls.Add(this.passportCountry);
            this.passengerDetailBox.Controls.Add(this.passportNumber);
            this.passengerDetailBox.Controls.Add(this.birthDate);
            this.passengerDetailBox.Controls.Add(this.lastName);
            this.passengerDetailBox.Controls.Add(this.firstName);
            this.passengerDetailBox.Location = new System.Drawing.Point(12, 174);
            this.passengerDetailBox.Name = "passengerDetailBox";
            this.passengerDetailBox.Size = new System.Drawing.Size(816, 146);
            this.passengerDetailBox.TabIndex = 11;
            this.passengerDetailBox.TabStop = false;
            this.passengerDetailBox.Text = "Passenger details";
            // 
            // passCountryBox
            // 
            this.passCountryBox.FormattingEnabled = true;
            this.passCountryBox.Items.AddRange(new object[] {
            "[ Select country ]"});
            this.passCountryBox.Location = new System.Drawing.Point(429, 66);
            this.passCountryBox.Name = "passCountryBox";
            this.passCountryBox.Size = new System.Drawing.Size(121, 24);
            this.passCountryBox.TabIndex = 13;
            // 
            // passNumText
            // 
            this.passNumText.Location = new System.Drawing.Point(154, 66);
            this.passNumText.Name = "passNumText";
            this.passNumText.Size = new System.Drawing.Size(134, 23);
            this.passNumText.TabIndex = 10;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(373, 30);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(177, 23);
            this.lastNameText.TabIndex = 8;
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(102, 30);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(186, 23);
            this.firstNameText.TabIndex = 7;
            // 
            // addPassengerButton
            // 
            this.addPassengerButton.Location = new System.Drawing.Point(644, 107);
            this.addPassengerButton.Name = "addPassengerButton";
            this.addPassengerButton.Size = new System.Drawing.Size(147, 25);
            this.addPassengerButton.TabIndex = 6;
            this.addPassengerButton.Text = "Add passenger";
            this.addPassengerButton.UseVisualStyleBackColor = true;
            this.addPassengerButton.Click += new System.EventHandler(this.addPassengerButton_Click);
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(565, 69);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(51, 17);
            this.phone.TabIndex = 5;
            this.phone.Text = "Phone";
            // 
            // passportCountry
            // 
            this.passportCountry.AutoSize = true;
            this.passportCountry.Location = new System.Drawing.Point(294, 69);
            this.passportCountry.Name = "passportCountry";
            this.passportCountry.Size = new System.Drawing.Size(129, 17);
            this.passportCountry.TabIndex = 4;
            this.passportCountry.Text = "Passport country";
            // 
            // passportNumber
            // 
            this.passportNumber.AutoSize = true;
            this.passportNumber.Location = new System.Drawing.Point(19, 69);
            this.passportNumber.Name = "passportNumber";
            this.passportNumber.Size = new System.Drawing.Size(129, 17);
            this.passportNumber.TabIndex = 3;
            this.passportNumber.Text = "Passport number";
            // 
            // birthDate
            // 
            this.birthDate.AutoSize = true;
            this.birthDate.Location = new System.Drawing.Point(565, 33);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(73, 17);
            this.birthDate.TabIndex = 2;
            this.birthDate.Text = "Birthdate";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(294, 33);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(76, 17);
            this.lastName.TabIndex = 1;
            this.lastName.Text = "Lastname";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(19, 33);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(77, 17);
            this.firstName.TabIndex = 0;
            this.firstName.Text = "Firstname";
            // 
            // passangerListLabel
            // 
            this.passangerListLabel.AutoSize = true;
            this.passangerListLabel.Location = new System.Drawing.Point(12, 334);
            this.passangerListLabel.Name = "passangerListLabel";
            this.passangerListLabel.Size = new System.Drawing.Size(105, 17);
            this.passangerListLabel.TabIndex = 12;
            this.passangerListLabel.Text = "Passenger list";
            // 
            // passlistGridView
            // 
            this.passlistGridView.AllowUserToAddRows = false;
            this.passlistGridView.AllowUserToDeleteRows = false;
            this.passlistGridView.AllowUserToResizeColumns = false;
            this.passlistGridView.AllowUserToResizeRows = false;
            this.passlistGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passlistGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.f_name,
            this.l_name,
            this.b_date,
            this.pass_num,
            this.pass_count,
            this.p_hone});
            this.passlistGridView.Location = new System.Drawing.Point(12, 354);
            this.passlistGridView.Name = "passlistGridView";
            this.passlistGridView.RowHeadersVisible = false;
            this.passlistGridView.RowHeadersWidth = 51;
            this.passlistGridView.RowTemplate.Height = 24;
            this.passlistGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.passlistGridView.Size = new System.Drawing.Size(816, 150);
            this.passlistGridView.TabIndex = 13;
            // 
            // f_name
            // 
            this.f_name.HeaderText = "Firstame";
            this.f_name.MinimumWidth = 6;
            this.f_name.Name = "f_name";
            this.f_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.f_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.f_name.Width = 135;
            // 
            // l_name
            // 
            this.l_name.HeaderText = "Lastname";
            this.l_name.MinimumWidth = 6;
            this.l_name.Name = "l_name";
            this.l_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.l_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.l_name.Width = 135;
            // 
            // b_date
            // 
            this.b_date.HeaderText = "Birthdate";
            this.b_date.MinimumWidth = 6;
            this.b_date.Name = "b_date";
            this.b_date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.b_date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.b_date.Width = 137;
            // 
            // pass_num
            // 
            this.pass_num.HeaderText = "Passport number";
            this.pass_num.MinimumWidth = 6;
            this.pass_num.Name = "pass_num";
            this.pass_num.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pass_num.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pass_num.Width = 135;
            // 
            // pass_count
            // 
            this.pass_count.HeaderText = "Passport country";
            this.pass_count.MinimumWidth = 6;
            this.pass_count.Name = "pass_count";
            this.pass_count.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pass_count.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pass_count.Width = 135;
            // 
            // p_hone
            // 
            this.p_hone.HeaderText = "Phone";
            this.p_hone.MinimumWidth = 6;
            this.p_hone.Name = "p_hone";
            this.p_hone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.p_hone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.p_hone.Width = 135;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(673, 520);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(155, 25);
            this.removeButton.TabIndex = 14;
            this.removeButton.Text = "Remove passenger";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(188, 566);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(238, 25);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "Back to search for flights";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(460, 566);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(153, 25);
            this.confirmButton.TabIndex = 16;
            this.confirmButton.Text = "Confirm booking";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // birthDateText
            // 
            this.birthDateText.Location = new System.Drawing.Point(644, 30);
            this.birthDateText.Mask = "0000-00-00";
            this.birthDateText.Name = "birthDateText";
            this.birthDateText.Size = new System.Drawing.Size(149, 23);
            this.birthDateText.TabIndex = 14;
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(644, 66);
            this.phoneText.Mask = "000-000-0000";
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(149, 23);
            this.phoneText.TabIndex = 15;
            // 
            // Bookingconfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 612);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.passlistGridView);
            this.Controls.Add(this.passangerListLabel);
            this.Controls.Add(this.passengerDetailBox);
            this.Controls.Add(this.returnDetailBox);
            this.Controls.Add(this.outboundDetailBox);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bookingconfirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking confirmation";
            this.Load += new System.EventHandler(this.Bookingconfirmation_Load);
            this.outboundDetailBox.ResumeLayout(false);
            this.outboundDetailBox.PerformLayout();
            this.returnDetailBox.ResumeLayout(false);
            this.returnDetailBox.PerformLayout();
            this.passengerDetailBox.ResumeLayout(false);
            this.passengerDetailBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passlistGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox outboundDetailBox;
        private System.Windows.Forms.Label flightNumberOutbound;
        private System.Windows.Forms.Label flightNumberLabel;
        private System.Windows.Forms.Label dateOutbound;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label cabinTypeOutbound;
        private System.Windows.Forms.Label cabinTypeLabel;
        private System.Windows.Forms.Label iataOutboundTo;
        private System.Windows.Forms.Label toOutboundLabel;
        private System.Windows.Forms.Label iataOutboundFrom;
        private System.Windows.Forms.Label fromOutboundLabel;
        private System.Windows.Forms.GroupBox returnDetailBox;
        private System.Windows.Forms.Label flightNumberReturn;
        private System.Windows.Forms.Label flightNumberReturnLabel;
        private System.Windows.Forms.Label dateReturnLabel;
        private System.Windows.Forms.Label cabinTypeReturn;
        private System.Windows.Forms.Label cabinTypeReturnLabel;
        private System.Windows.Forms.Label iataReturnTo;
        private System.Windows.Forms.Label toReturnLabel;
        private System.Windows.Forms.Label iataReturnFrom;
        private System.Windows.Forms.Label fromReturnLabel;
        private System.Windows.Forms.GroupBox passengerDetailBox;
        private System.Windows.Forms.ComboBox passCountryBox;
        private System.Windows.Forms.TextBox passNumText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Button addPassengerButton;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label passportCountry;
        private System.Windows.Forms.Label passportNumber;
        private System.Windows.Forms.Label birthDate;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label passangerListLabel;
        private System.Windows.Forms.DataGridView passlistGridView;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn l_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_hone;
        private System.Windows.Forms.Label dateReturn;
        private System.Windows.Forms.MaskedTextBox phoneText;
        private System.Windows.Forms.MaskedTextBox birthDateText;
    }
}