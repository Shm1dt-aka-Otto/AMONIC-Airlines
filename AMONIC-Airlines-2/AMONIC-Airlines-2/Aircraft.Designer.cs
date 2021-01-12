namespace AMONIC_Airlines_2
{
    partial class Aircraft
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aircraft));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flightnumber = new System.Windows.Forms.TextBox();
            this.outbound = new System.Windows.Forms.TextBox();
            this.sortby = new System.Windows.Forms.ComboBox();
            this.to = new System.Windows.Forms.ComboBox();
            this.airportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.session2_xxDataSet1 = new AMONIC_Airlines_2.session2_xxDataSet1();
            this.from = new System.Windows.Forms.ComboBox();
            this.apply = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelflight = new System.Windows.Forms.Button();
            this.editflight = new System.Windows.Forms.Button();
            this.importchanges = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.schedulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.session2_xxDataSet = new AMONIC_Airlines_2.session2_xxDataSet();
            this.schedulesTableAdapter = new AMONIC_Airlines_2.session2_xxDataSetTableAdapters.schedulesTableAdapter();
            this.aircraftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aircraftsTableAdapter = new AMONIC_Airlines_2.session2_xxDataSet1TableAdapters.aircraftsTableAdapter();
            this.airportsTableAdapter = new AMONIC_Airlines_2.session2_xxDataSet1TableAdapters.airportsTableAdapter();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session2_xxDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session2_xxDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircraftsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flightnumber);
            this.groupBox1.Controls.Add(this.outbound);
            this.groupBox1.Controls.Add(this.sortby);
            this.groupBox1.Controls.Add(this.to);
            this.groupBox1.Controls.Add(this.from);
            this.groupBox1.Controls.Add(this.apply);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by";
            // 
            // flightnumber
            // 
            this.flightnumber.Location = new System.Drawing.Point(400, 73);
            this.flightnumber.Name = "flightnumber";
            this.flightnumber.Size = new System.Drawing.Size(92, 23);
            this.flightnumber.TabIndex = 10;
            this.flightnumber.Click += new System.EventHandler(this.flightnumber_Click);
            // 
            // outbound
            // 
            this.outbound.Location = new System.Drawing.Point(101, 73);
            this.outbound.Name = "outbound";
            this.outbound.Size = new System.Drawing.Size(166, 23);
            this.outbound.TabIndex = 9;
            this.outbound.Click += new System.EventHandler(this.outbound_Click);
            // 
            // sortby
            // 
            this.sortby.FormattingEnabled = true;
            this.sortby.Items.AddRange(new object[] {
            "Date-Time",
            "Price-Econom",
            "Confirmed"});
            this.sortby.Location = new System.Drawing.Point(607, 31);
            this.sortby.Name = "sortby";
            this.sortby.Size = new System.Drawing.Size(174, 24);
            this.sortby.TabIndex = 8;
            this.sortby.Text = "Date-Time";
            // 
            // to
            // 
            this.to.FormattingEnabled = true;
            this.to.Items.AddRange(new object[] {
            "[ Airport list ]"});
            this.to.Location = new System.Drawing.Point(318, 31);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(174, 24);
            this.to.TabIndex = 7;
            this.to.ValueMember = "ID";
            this.to.SelectedIndexChanged += new System.EventHandler(this.to_SelectedIndexChanged);
            // 
            // airportsBindingSource
            // 
            this.airportsBindingSource.DataMember = "airports";
            this.airportsBindingSource.DataSource = this.session2_xxDataSet1;
            // 
            // session2_xxDataSet1
            // 
            this.session2_xxDataSet1.DataSetName = "session2_xxDataSet1";
            this.session2_xxDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // from
            // 
            this.from.FormattingEnabled = true;
            this.from.Items.AddRange(new object[] {
            "[ Airport list ]"});
            this.from.Location = new System.Drawing.Point(93, 31);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(174, 24);
            this.from.TabIndex = 6;
            this.from.ValueMember = "ID";
            this.from.SelectedIndexChanged += new System.EventHandler(this.from_SelectedIndexChanged);
            // 
            // apply
            // 
            this.apply.Location = new System.Drawing.Point(607, 69);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(174, 30);
            this.apply.TabIndex = 5;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
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
            // cancelflight
            // 
            this.cancelflight.Image = ((System.Drawing.Image)(resources.GetObject("cancelflight.Image")));
            this.cancelflight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelflight.Location = new System.Drawing.Point(21, 515);
            this.cancelflight.Name = "cancelflight";
            this.cancelflight.Size = new System.Drawing.Size(120, 30);
            this.cancelflight.TabIndex = 1;
            this.cancelflight.Text = "Cancel Flight";
            this.cancelflight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelflight.UseVisualStyleBackColor = true;
            this.cancelflight.Click += new System.EventHandler(this.cancelflight_Click);
            // 
            // editflight
            // 
            this.editflight.Image = ((System.Drawing.Image)(resources.GetObject("editflight.Image")));
            this.editflight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editflight.Location = new System.Drawing.Point(175, 515);
            this.editflight.Name = "editflight";
            this.editflight.Size = new System.Drawing.Size(120, 30);
            this.editflight.TabIndex = 2;
            this.editflight.Text = "Edit Flight";
            this.editflight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editflight.UseVisualStyleBackColor = true;
            this.editflight.Click += new System.EventHandler(this.editflight_Click);
            // 
            // importchanges
            // 
            this.importchanges.Image = ((System.Drawing.Image)(resources.GetObject("importchanges.Image")));
            this.importchanges.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.importchanges.Location = new System.Drawing.Point(622, 515);
            this.importchanges.Name = "importchanges";
            this.importchanges.Size = new System.Drawing.Size(171, 32);
            this.importchanges.TabIndex = 3;
            this.importchanges.Text = "Import Changes";
            this.importchanges.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.importchanges.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 153);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(806, 335);
            this.dataGridView1.TabIndex = 4;
            // 
            // schedulesBindingSource
            // 
            this.schedulesBindingSource.DataMember = "schedules";
            this.schedulesBindingSource.DataSource = this.session2_xxDataSet;
            // 
            // session2_xxDataSet
            // 
            this.session2_xxDataSet.DataSetName = "session2_xxDataSet";
            this.session2_xxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schedulesTableAdapter
            // 
            this.schedulesTableAdapter.ClearBeforeFill = true;
            // 
            // aircraftsBindingSource
            // 
            this.aircraftsBindingSource.DataMember = "aircrafts";
            this.aircraftsBindingSource.DataSource = this.session2_xxDataSet1;
            // 
            // aircraftsTableAdapter
            // 
            this.aircraftsTableAdapter.ClearBeforeFill = true;
            // 
            // airportsTableAdapter
            // 
            this.airportsTableAdapter.ClearBeforeFill = true;
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
            this.routeIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // RouteID
            // 
            this.RouteID.HeaderText = "To";
            this.RouteID.MinimumWidth = 6;
            this.RouteID.Name = "RouteID";
            this.RouteID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RouteID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RouteID.Width = 70;
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
            this.FirstClassPrice.Width = 96;
            // 
            // confirmedDataGridViewCheckBoxColumn
            // 
            this.confirmedDataGridViewCheckBoxColumn.HeaderText = "Confirmed";
            this.confirmedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.confirmedDataGridViewCheckBoxColumn.Name = "confirmedDataGridViewCheckBoxColumn";
            this.confirmedDataGridViewCheckBoxColumn.Visible = false;
            this.confirmedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // Aircraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 570);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.importchanges);
            this.Controls.Add(this.editflight);
            this.Controls.Add(this.cancelflight);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Aircraft";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Flight Schedules";
            this.Load += new System.EventHandler(this.Aircraft_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session2_xxDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session2_xxDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircraftsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancelflight;
        private System.Windows.Forms.Button editflight;
        private System.Windows.Forms.Button importchanges;
        private System.Windows.Forms.TextBox outbound;
        private System.Windows.Forms.ComboBox sortby;
        private System.Windows.Forms.ComboBox to;
        private System.Windows.Forms.ComboBox from;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox flightnumber;
        private System.Windows.Forms.DataGridView dataGridView1;
        private session2_xxDataSet session2_xxDataSet;
        private System.Windows.Forms.BindingSource schedulesBindingSource;
        private session2_xxDataSetTableAdapters.schedulesTableAdapter schedulesTableAdapter;
        private session2_xxDataSet1 session2_xxDataSet1;
        private System.Windows.Forms.BindingSource aircraftsBindingSource;
        private session2_xxDataSet1TableAdapters.aircraftsTableAdapter aircraftsTableAdapter;
        private System.Windows.Forms.BindingSource airportsBindingSource;
        private session2_xxDataSet1TableAdapters.airportsTableAdapter airportsTableAdapter;
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

