namespace AMONIC_Airlines_2
{
    partial class ManageFlight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageFlight));
            this.filterBox = new System.Windows.Forms.GroupBox();
            this.outboundBox = new System.Windows.Forms.MaskedTextBox();
            this.flightNumberBox = new System.Windows.Forms.TextBox();
            this.sortBox = new System.Windows.Forms.ComboBox();
            this.toBox = new System.Windows.Forms.ComboBox();
            this.fromBox = new System.Windows.Forms.ComboBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelFlightButton = new System.Windows.Forms.Button();
            this.editFlightButton = new System.Windows.Forms.Button();
            this.importChangesButton = new System.Windows.Forms.Button();
            this.manageGridView = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RouteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aircraftIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.economyPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BussinesPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstClassPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.filterBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // filterBox
            // 
            this.filterBox.Controls.Add(this.outboundBox);
            this.filterBox.Controls.Add(this.flightNumberBox);
            this.filterBox.Controls.Add(this.sortBox);
            this.filterBox.Controls.Add(this.toBox);
            this.filterBox.Controls.Add(this.fromBox);
            this.filterBox.Controls.Add(this.applyButton);
            this.filterBox.Controls.Add(this.label5);
            this.filterBox.Controls.Add(this.label4);
            this.filterBox.Controls.Add(this.label3);
            this.filterBox.Controls.Add(this.label2);
            this.filterBox.Controls.Add(this.label1);
            this.filterBox.Location = new System.Drawing.Point(12, 12);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(806, 123);
            this.filterBox.TabIndex = 0;
            this.filterBox.TabStop = false;
            this.filterBox.Text = "Filter by";
            // 
            // outboundBox
            // 
            this.outboundBox.Location = new System.Drawing.Point(101, 73);
            this.outboundBox.Mask = "0000-00-00";
            this.outboundBox.Name = "outboundBox";
            this.outboundBox.Size = new System.Drawing.Size(166, 23);
            this.outboundBox.TabIndex = 11;
            // 
            // flightNumberBox
            // 
            this.flightNumberBox.Location = new System.Drawing.Point(400, 73);
            this.flightNumberBox.Name = "flightNumberBox";
            this.flightNumberBox.Size = new System.Drawing.Size(92, 23);
            this.flightNumberBox.TabIndex = 10;
            // 
            // sortBox
            // 
            this.sortBox.FormattingEnabled = true;
            this.sortBox.Items.AddRange(new object[] {
            "Date-Time",
            "Price-Econom",
            "Confirmed"});
            this.sortBox.Location = new System.Drawing.Point(607, 31);
            this.sortBox.Name = "sortBox";
            this.sortBox.Size = new System.Drawing.Size(174, 24);
            this.sortBox.TabIndex = 8;
            this.sortBox.Text = "Date-Time";
            // 
            // toBox
            // 
            this.toBox.DisplayMember = "ID";
            this.toBox.FormattingEnabled = true;
            this.toBox.Items.AddRange(new object[] {
            "[ Airport list ]"});
            this.toBox.Location = new System.Drawing.Point(318, 31);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(174, 24);
            this.toBox.TabIndex = 7;
            this.toBox.ValueMember = "ID";
            this.toBox.SelectedIndexChanged += new System.EventHandler(this.toBox_SelectedIndexChanged);
            // 
            // fromBox
            // 
            this.fromBox.DisplayMember = "ID";
            this.fromBox.FormattingEnabled = true;
            this.fromBox.Items.AddRange(new object[] {
            "[ Airport list ]"});
            this.fromBox.Location = new System.Drawing.Point(93, 31);
            this.fromBox.Name = "fromBox";
            this.fromBox.Size = new System.Drawing.Size(174, 24);
            this.fromBox.TabIndex = 6;
            this.fromBox.ValueMember = "ID";
            this.fromBox.SelectedIndexChanged += new System.EventHandler(this.fromBox_SelectedIndexChanged);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(607, 69);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(174, 30);
            this.applyButton.TabIndex = 5;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Flight Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Outbound";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sort by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // cancelFlightButton
            // 
            this.cancelFlightButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelFlightButton.Location = new System.Drawing.Point(21, 515);
            this.cancelFlightButton.Name = "cancelFlightButton";
            this.cancelFlightButton.Size = new System.Drawing.Size(120, 30);
            this.cancelFlightButton.TabIndex = 1;
            this.cancelFlightButton.Text = "Cancel Flight";
            this.cancelFlightButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelFlightButton.UseVisualStyleBackColor = true;
            this.cancelFlightButton.Click += new System.EventHandler(this.cancelFlightButton_Click);
            // 
            // editFlightButton
            // 
            this.editFlightButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editFlightButton.Location = new System.Drawing.Point(175, 515);
            this.editFlightButton.Name = "editFlightButton";
            this.editFlightButton.Size = new System.Drawing.Size(120, 30);
            this.editFlightButton.TabIndex = 2;
            this.editFlightButton.Text = "Edit Flight";
            this.editFlightButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editFlightButton.UseVisualStyleBackColor = true;
            this.editFlightButton.Click += new System.EventHandler(this.editFlightButton_Click);
            // 
            // importChangesButton
            // 
            this.importChangesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.importChangesButton.Location = new System.Drawing.Point(622, 515);
            this.importChangesButton.Name = "importChangesButton";
            this.importChangesButton.Size = new System.Drawing.Size(171, 32);
            this.importChangesButton.TabIndex = 3;
            this.importChangesButton.Text = "Import Changes";
            this.importChangesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.importChangesButton.UseVisualStyleBackColor = true;
            this.importChangesButton.Click += new System.EventHandler(this.importChangesButton_Click);
            // 
            // manageGridView
            // 
            this.manageGridView.AllowUserToAddRows = false;
            this.manageGridView.AllowUserToDeleteRows = false;
            this.manageGridView.AllowUserToResizeColumns = false;
            this.manageGridView.AllowUserToResizeRows = false;
            this.manageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manageGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.routeIDDataGridViewTextBoxColumn,
            this.RouteID,
            this.flightNumberDataGridViewTextBoxColumn,
            this.aircraftIDDataGridViewTextBoxColumn,
            this.economyPriceDataGridViewTextBoxColumn,
            this.BussinesPrice,
            this.FirstClassPrice,
            this.confirmedDataGridViewCheckBoxColumn});
            this.manageGridView.Location = new System.Drawing.Point(12, 153);
            this.manageGridView.MultiSelect = false;
            this.manageGridView.Name = "manageGridView";
            this.manageGridView.RowHeadersVisible = false;
            this.manageGridView.RowHeadersWidth = 45;
            this.manageGridView.RowTemplate.Height = 24;
            this.manageGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.manageGridView.Size = new System.Drawing.Size(806, 335);
            this.manageGridView.TabIndex = 4;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dateDataGridViewTextBoxColumn.Width = 88;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.timeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.timeDataGridViewTextBoxColumn.Width = 88;
            // 
            // routeIDDataGridViewTextBoxColumn
            // 
            this.routeIDDataGridViewTextBoxColumn.HeaderText = "From";
            this.routeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.routeIDDataGridViewTextBoxColumn.Name = "routeIDDataGridViewTextBoxColumn";
            this.routeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.routeIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.routeIDDataGridViewTextBoxColumn.Width = 63;
            // 
            // RouteID
            // 
            this.RouteID.HeaderText = "To";
            this.RouteID.MinimumWidth = 6;
            this.RouteID.Name = "RouteID";
            this.RouteID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RouteID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RouteID.Width = 63;
            // 
            // flightNumberDataGridViewTextBoxColumn
            // 
            this.flightNumberDataGridViewTextBoxColumn.HeaderText = "Flight number";
            this.flightNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.flightNumberDataGridViewTextBoxColumn.Name = "flightNumberDataGridViewTextBoxColumn";
            this.flightNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.flightNumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.flightNumberDataGridViewTextBoxColumn.Width = 90;
            // 
            // aircraftIDDataGridViewTextBoxColumn
            // 
            this.aircraftIDDataGridViewTextBoxColumn.HeaderText = "Aircraft";
            this.aircraftIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aircraftIDDataGridViewTextBoxColumn.Name = "aircraftIDDataGridViewTextBoxColumn";
            this.aircraftIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.aircraftIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.aircraftIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // economyPriceDataGridViewTextBoxColumn
            // 
            this.economyPriceDataGridViewTextBoxColumn.HeaderText = "Economy price";
            this.economyPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.economyPriceDataGridViewTextBoxColumn.Name = "economyPriceDataGridViewTextBoxColumn";
            this.economyPriceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.economyPriceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.economyPriceDataGridViewTextBoxColumn.Width = 96;
            // 
            // BussinesPrice
            // 
            this.BussinesPrice.HeaderText = "Bussines price";
            this.BussinesPrice.MinimumWidth = 6;
            this.BussinesPrice.Name = "BussinesPrice";
            this.BussinesPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BussinesPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BussinesPrice.Width = 96;
            // 
            // FirstClassPrice
            // 
            this.FirstClassPrice.HeaderText = "First class price";
            this.FirstClassPrice.MinimumWidth = 6;
            this.FirstClassPrice.Name = "FirstClassPrice";
            this.FirstClassPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FirstClassPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FirstClassPrice.Width = 112;
            // 
            // confirmedDataGridViewCheckBoxColumn
            // 
            this.confirmedDataGridViewCheckBoxColumn.HeaderText = "Confirmed";
            this.confirmedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.confirmedDataGridViewCheckBoxColumn.Name = "confirmedDataGridViewCheckBoxColumn";
            this.confirmedDataGridViewCheckBoxColumn.Visible = false;
            this.confirmedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // ManageFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 570);
            this.Controls.Add(this.manageGridView);
            this.Controls.Add(this.importChangesButton);
            this.Controls.Add(this.editFlightButton);
            this.Controls.Add(this.cancelFlightButton);
            this.Controls.Add(this.filterBox);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageFlight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Flight Schedules";
            this.Load += new System.EventHandler(this.Aircraft_Load);
            this.filterBox.ResumeLayout(false);
            this.filterBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox filterBox;
        private System.Windows.Forms.Button cancelFlightButton;
        private System.Windows.Forms.Button editFlightButton;
        private System.Windows.Forms.Button importChangesButton;
        private System.Windows.Forms.ComboBox sortBox;
        private System.Windows.Forms.ComboBox toBox;
        private System.Windows.Forms.ComboBox fromBox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox flightNumberBox;
        private System.Windows.Forms.DataGridView manageGridView;
        private System.Windows.Forms.MaskedTextBox outboundBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RouteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aircraftIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn economyPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BussinesPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstClassPrice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn confirmedDataGridViewCheckBoxColumn;
    }
}

