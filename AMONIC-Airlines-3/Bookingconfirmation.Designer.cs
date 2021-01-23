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
            this.outbounddetBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iatafrom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iatato = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cabintype = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ddmmyyyy = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flightnumber = new System.Windows.Forms.Label();
            this.returndetBox = new System.Windows.Forms.GroupBox();
            this.returnnumber = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.returndate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.returncabin = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.iatareturnto = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.iatareturnfrom = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.passengerBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.addpassenger = new System.Windows.Forms.Button();
            this.firstnameText = new System.Windows.Forms.TextBox();
            this.lastnameText = new System.Windows.Forms.TextBox();
            this.birthdateText = new System.Windows.Forms.TextBox();
            this.passnumText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.passcountryBox = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.passlistGridView = new System.Windows.Forms.DataGridView();
            this.removepassenger = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.f_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_hone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outbounddetBox.SuspendLayout();
            this.returndetBox.SuspendLayout();
            this.passengerBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passlistGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // outbounddetBox
            // 
            this.outbounddetBox.Controls.Add(this.flightnumber);
            this.outbounddetBox.Controls.Add(this.label5);
            this.outbounddetBox.Controls.Add(this.ddmmyyyy);
            this.outbounddetBox.Controls.Add(this.label4);
            this.outbounddetBox.Controls.Add(this.cabintype);
            this.outbounddetBox.Controls.Add(this.label3);
            this.outbounddetBox.Controls.Add(this.iatato);
            this.outbounddetBox.Controls.Add(this.label2);
            this.outbounddetBox.Controls.Add(this.iatafrom);
            this.outbounddetBox.Controls.Add(this.label1);
            this.outbounddetBox.Location = new System.Drawing.Point(12, 12);
            this.outbounddetBox.Name = "outbounddetBox";
            this.outbounddetBox.Size = new System.Drawing.Size(816, 75);
            this.outbounddetBox.TabIndex = 0;
            this.outbounddetBox.TabStop = false;
            this.outbounddetBox.Text = "Outbound flight details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // iatafrom
            // 
            this.iatafrom.AutoSize = true;
            this.iatafrom.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iatafrom.Location = new System.Drawing.Point(63, 33);
            this.iatafrom.Name = "iatafrom";
            this.iatafrom.Size = new System.Drawing.Size(48, 17);
            this.iatafrom.TabIndex = 1;
            this.iatafrom.Text = "IATA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "To:";
            // 
            // iatato
            // 
            this.iatato.AutoSize = true;
            this.iatato.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iatato.Location = new System.Drawing.Point(154, 33);
            this.iatato.Name = "iatato";
            this.iatato.Size = new System.Drawing.Size(48, 17);
            this.iatato.TabIndex = 3;
            this.iatato.Text = "IATA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cabin Type:";
            // 
            // cabintype
            // 
            this.cabintype.AutoSize = true;
            this.cabintype.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cabintype.Location = new System.Drawing.Point(319, 33);
            this.cabintype.Name = "cabintype";
            this.cabintype.Size = new System.Drawing.Size(95, 17);
            this.cabintype.TabIndex = 5;
            this.cabintype.Text = "Type Cabin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date:";
            // 
            // ddmmyyyy
            // 
            this.ddmmyyyy.AutoSize = true;
            this.ddmmyyyy.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ddmmyyyy.Location = new System.Drawing.Point(478, 33);
            this.ddmmyyyy.Name = "ddmmyyyy";
            this.ddmmyyyy.Size = new System.Drawing.Size(95, 17);
            this.ddmmyyyy.TabIndex = 7;
            this.ddmmyyyy.Text = "Type Cabin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(598, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Flight Number: ";
            // 
            // flightnumber
            // 
            this.flightnumber.AutoSize = true;
            this.flightnumber.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flightnumber.Location = new System.Drawing.Point(706, 33);
            this.flightnumber.Name = "flightnumber";
            this.flightnumber.Size = new System.Drawing.Size(69, 17);
            this.flightnumber.TabIndex = 9;
            this.flightnumber.Text = "Number";
            // 
            // returndetBox
            // 
            this.returndetBox.Controls.Add(this.returnnumber);
            this.returndetBox.Controls.Add(this.label7);
            this.returndetBox.Controls.Add(this.returndate);
            this.returndetBox.Controls.Add(this.label9);
            this.returndetBox.Controls.Add(this.returncabin);
            this.returndetBox.Controls.Add(this.label11);
            this.returndetBox.Controls.Add(this.iatareturnto);
            this.returndetBox.Controls.Add(this.label13);
            this.returndetBox.Controls.Add(this.iatareturnfrom);
            this.returndetBox.Controls.Add(this.label15);
            this.returndetBox.Location = new System.Drawing.Point(12, 93);
            this.returndetBox.Name = "returndetBox";
            this.returndetBox.Size = new System.Drawing.Size(816, 75);
            this.returndetBox.TabIndex = 10;
            this.returndetBox.TabStop = false;
            this.returndetBox.Text = "Return flight details";
            // 
            // returnnumber
            // 
            this.returnnumber.AutoSize = true;
            this.returnnumber.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnnumber.Location = new System.Drawing.Point(706, 33);
            this.returnnumber.Name = "returnnumber";
            this.returnnumber.Size = new System.Drawing.Size(69, 17);
            this.returnnumber.TabIndex = 9;
            this.returnnumber.Text = "Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(598, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Flight Number: ";
            // 
            // returndate
            // 
            this.returndate.AutoSize = true;
            this.returndate.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returndate.Location = new System.Drawing.Point(478, 33);
            this.returndate.Name = "returndate";
            this.returndate.Size = new System.Drawing.Size(95, 17);
            this.returndate.TabIndex = 7;
            this.returndate.Text = "Type Cabin";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(435, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Date:";
            // 
            // returncabin
            // 
            this.returncabin.AutoSize = true;
            this.returncabin.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returncabin.Location = new System.Drawing.Point(319, 33);
            this.returncabin.Name = "returncabin";
            this.returncabin.Size = new System.Drawing.Size(95, 17);
            this.returncabin.TabIndex = 5;
            this.returncabin.Text = "Type Cabin";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(233, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Cabin Type:";
            // 
            // iatareturnto
            // 
            this.iatareturnto.AutoSize = true;
            this.iatareturnto.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iatareturnto.Location = new System.Drawing.Point(154, 33);
            this.iatareturnto.Name = "iatareturnto";
            this.iatareturnto.Size = new System.Drawing.Size(48, 17);
            this.iatareturnto.TabIndex = 3;
            this.iatareturnto.Text = "IATA";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(130, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "To:";
            // 
            // iatareturnfrom
            // 
            this.iatareturnfrom.AutoSize = true;
            this.iatareturnfrom.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iatareturnfrom.Location = new System.Drawing.Point(63, 33);
            this.iatareturnfrom.Name = "iatareturnfrom";
            this.iatareturnfrom.Size = new System.Drawing.Size(48, 17);
            this.iatareturnfrom.TabIndex = 1;
            this.iatareturnfrom.Text = "IATA";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "From:";
            // 
            // passengerBox
            // 
            this.passengerBox.Controls.Add(this.passcountryBox);
            this.passengerBox.Controls.Add(this.phoneText);
            this.passengerBox.Controls.Add(this.passnumText);
            this.passengerBox.Controls.Add(this.birthdateText);
            this.passengerBox.Controls.Add(this.lastnameText);
            this.passengerBox.Controls.Add(this.firstnameText);
            this.passengerBox.Controls.Add(this.addpassenger);
            this.passengerBox.Controls.Add(this.label16);
            this.passengerBox.Controls.Add(this.label14);
            this.passengerBox.Controls.Add(this.label12);
            this.passengerBox.Controls.Add(this.label10);
            this.passengerBox.Controls.Add(this.label8);
            this.passengerBox.Controls.Add(this.label6);
            this.passengerBox.Location = new System.Drawing.Point(12, 174);
            this.passengerBox.Name = "passengerBox";
            this.passengerBox.Size = new System.Drawing.Size(816, 146);
            this.passengerBox.TabIndex = 11;
            this.passengerBox.TabStop = false;
            this.passengerBox.Text = "Passenger details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Firstname";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Lastname";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(565, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Birthdate";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Passport number";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(294, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 17);
            this.label14.TabIndex = 4;
            this.label14.Text = "Passport country";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(565, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 17);
            this.label16.TabIndex = 5;
            this.label16.Text = "Phone";
            // 
            // addpassenger
            // 
            this.addpassenger.Location = new System.Drawing.Point(644, 107);
            this.addpassenger.Name = "addpassenger";
            this.addpassenger.Size = new System.Drawing.Size(147, 25);
            this.addpassenger.TabIndex = 6;
            this.addpassenger.Text = "Add passenger";
            this.addpassenger.UseVisualStyleBackColor = true;
            // 
            // firstnameText
            // 
            this.firstnameText.Location = new System.Drawing.Point(102, 30);
            this.firstnameText.Name = "firstnameText";
            this.firstnameText.Size = new System.Drawing.Size(186, 23);
            this.firstnameText.TabIndex = 7;
            // 
            // lastnameText
            // 
            this.lastnameText.Location = new System.Drawing.Point(373, 30);
            this.lastnameText.Name = "lastnameText";
            this.lastnameText.Size = new System.Drawing.Size(177, 23);
            this.lastnameText.TabIndex = 8;
            // 
            // birthdateText
            // 
            this.birthdateText.Location = new System.Drawing.Point(644, 30);
            this.birthdateText.Name = "birthdateText";
            this.birthdateText.Size = new System.Drawing.Size(149, 23);
            this.birthdateText.TabIndex = 9;
            // 
            // passnumText
            // 
            this.passnumText.Location = new System.Drawing.Point(154, 66);
            this.passnumText.Name = "passnumText";
            this.passnumText.Size = new System.Drawing.Size(134, 23);
            this.passnumText.TabIndex = 10;
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(644, 66);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(149, 23);
            this.phoneText.TabIndex = 12;
            // 
            // passcountryBox
            // 
            this.passcountryBox.FormattingEnabled = true;
            this.passcountryBox.Location = new System.Drawing.Point(429, 66);
            this.passcountryBox.Name = "passcountryBox";
            this.passcountryBox.Size = new System.Drawing.Size(121, 24);
            this.passcountryBox.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 334);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 17);
            this.label17.TabIndex = 12;
            this.label17.Text = "Passenger list";
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
            // removepassenger
            // 
            this.removepassenger.Location = new System.Drawing.Point(673, 520);
            this.removepassenger.Name = "removepassenger";
            this.removepassenger.Size = new System.Drawing.Size(155, 25);
            this.removepassenger.TabIndex = 14;
            this.removepassenger.Text = "Remove passenger";
            this.removepassenger.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(188, 566);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(238, 25);
            this.back.TabIndex = 15;
            this.back.Text = "Back to search for flights";
            this.back.UseVisualStyleBackColor = true;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(460, 566);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(153, 25);
            this.confirm.TabIndex = 16;
            this.confirm.Text = "Confirm booking";
            this.confirm.UseVisualStyleBackColor = true;
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
            // Bookingconfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 612);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.back);
            this.Controls.Add(this.removepassenger);
            this.Controls.Add(this.passlistGridView);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.passengerBox);
            this.Controls.Add(this.returndetBox);
            this.Controls.Add(this.outbounddetBox);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bookingconfirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking confirmation";
            this.outbounddetBox.ResumeLayout(false);
            this.outbounddetBox.PerformLayout();
            this.returndetBox.ResumeLayout(false);
            this.returndetBox.PerformLayout();
            this.passengerBox.ResumeLayout(false);
            this.passengerBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passlistGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox outbounddetBox;
        private System.Windows.Forms.Label flightnumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ddmmyyyy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cabintype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label iatato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label iatafrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox returndetBox;
        private System.Windows.Forms.Label returnnumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label returndate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label returncabin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label iatareturnto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label iatareturnfrom;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox passengerBox;
        private System.Windows.Forms.ComboBox passcountryBox;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox passnumText;
        private System.Windows.Forms.TextBox birthdateText;
        private System.Windows.Forms.TextBox lastnameText;
        private System.Windows.Forms.TextBox firstnameText;
        private System.Windows.Forms.Button addpassenger;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView passlistGridView;
        private System.Windows.Forms.Button removepassenger;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn l_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_hone;
    }
}