namespace AMONIC_Airlines_3
{
    partial class SearchFlight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchFlight));
            this.searchBox = new System.Windows.Forms.GroupBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.cabinBox = new System.Windows.Forms.ComboBox();
            this.toBox = new System.Windows.Forms.ComboBox();
            this.fromBox = new System.Windows.Forms.ComboBox();
            this.returnLabel = new System.Windows.Forms.Label();
            this.outboundLabel = new System.Windows.Forms.Label();
            this.oneWayButton = new System.Windows.Forms.RadioButton();
            this.returnButton = new System.Windows.Forms.RadioButton();
            this.cabinTypeLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.outboundFlightLabel = new System.Windows.Forms.Label();
            this.outboundGridView = new System.Windows.Forms.DataGridView();
            this.outboundCheck = new System.Windows.Forms.CheckBox();
            this.confirmBox = new System.Windows.Forms.GroupBox();
            this.passangerText = new System.Windows.Forms.TextBox();
            this.bookButton = new System.Windows.Forms.Button();
            this.passangersLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.returnGridView = new System.Windows.Forms.DataGridView();
            this.returnFlightLabel = new System.Windows.Forms.Label();
            this.returnCheck = new System.Windows.Forms.CheckBox();
            this.outboundText = new System.Windows.Forms.MaskedTextBox();
            this.returnText = new System.Windows.Forms.MaskedTextBox();
            this.fromColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.economColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from_reColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to_reColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_reColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_reColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flight_reColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_reColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stop_reColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eco_reColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outboundGridView)).BeginInit();
            this.confirmBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Controls.Add(this.returnText);
            this.searchBox.Controls.Add(this.outboundText);
            this.searchBox.Controls.Add(this.applyButton);
            this.searchBox.Controls.Add(this.cabinBox);
            this.searchBox.Controls.Add(this.toBox);
            this.searchBox.Controls.Add(this.fromBox);
            this.searchBox.Controls.Add(this.returnLabel);
            this.searchBox.Controls.Add(this.outboundLabel);
            this.searchBox.Controls.Add(this.oneWayButton);
            this.searchBox.Controls.Add(this.returnButton);
            this.searchBox.Controls.Add(this.cabinTypeLabel);
            this.searchBox.Controls.Add(this.toLabel);
            this.searchBox.Controls.Add(this.fromLabel);
            resources.ApplyResources(this.searchBox, "searchBox");
            this.searchBox.Name = "searchBox";
            this.searchBox.TabStop = false;
            // 
            // applyButton
            // 
            resources.ApplyResources(this.applyButton, "applyButton");
            this.applyButton.Name = "applyButton";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // cabinBox
            // 
            this.cabinBox.FormattingEnabled = true;
            this.cabinBox.Items.AddRange(new object[] {
            resources.GetString("cabinBox.Items"),
            resources.GetString("cabinBox.Items1"),
            resources.GetString("cabinBox.Items2")});
            resources.ApplyResources(this.cabinBox, "cabinBox");
            this.cabinBox.Name = "cabinBox";
            // 
            // toBox
            // 
            this.toBox.FormattingEnabled = true;
            this.toBox.Items.AddRange(new object[] {
            resources.GetString("toBox.Items")});
            resources.ApplyResources(this.toBox, "toBox");
            this.toBox.Name = "toBox";
            this.toBox.SelectedIndexChanged += new System.EventHandler(this.toBox_SelectedIndexChanged);
            // 
            // fromBox
            // 
            this.fromBox.FormattingEnabled = true;
            this.fromBox.Items.AddRange(new object[] {
            resources.GetString("fromBox.Items")});
            resources.ApplyResources(this.fromBox, "fromBox");
            this.fromBox.Name = "fromBox";
            this.fromBox.SelectedIndexChanged += new System.EventHandler(this.fromBox_SelectedIndexChanged);
            // 
            // returnLabel
            // 
            resources.ApplyResources(this.returnLabel, "returnLabel");
            this.returnLabel.Name = "returnLabel";
            // 
            // outboundLabel
            // 
            resources.ApplyResources(this.outboundLabel, "outboundLabel");
            this.outboundLabel.Name = "outboundLabel";
            // 
            // oneWayButton
            // 
            resources.ApplyResources(this.oneWayButton, "oneWayButton");
            this.oneWayButton.Name = "oneWayButton";
            this.oneWayButton.TabStop = true;
            this.oneWayButton.UseVisualStyleBackColor = true;
            this.oneWayButton.CheckedChanged += new System.EventHandler(this.onewayButton_CheckedChanged);
            // 
            // returnButton
            // 
            resources.ApplyResources(this.returnButton, "returnButton");
            this.returnButton.Name = "returnButton";
            this.returnButton.TabStop = true;
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.CheckedChanged += new System.EventHandler(this.returnButton_CheckedChanged);
            // 
            // cabinTypeLabel
            // 
            resources.ApplyResources(this.cabinTypeLabel, "cabinTypeLabel");
            this.cabinTypeLabel.Name = "cabinTypeLabel";
            // 
            // toLabel
            // 
            resources.ApplyResources(this.toLabel, "toLabel");
            this.toLabel.Name = "toLabel";
            // 
            // fromLabel
            // 
            resources.ApplyResources(this.fromLabel, "fromLabel");
            this.fromLabel.Name = "fromLabel";
            // 
            // outboundFlightLabel
            // 
            resources.ApplyResources(this.outboundFlightLabel, "outboundFlightLabel");
            this.outboundFlightLabel.Name = "outboundFlightLabel";
            // 
            // outboundGridView
            // 
            this.outboundGridView.AllowUserToAddRows = false;
            this.outboundGridView.AllowUserToDeleteRows = false;
            this.outboundGridView.AllowUserToResizeColumns = false;
            this.outboundGridView.AllowUserToResizeRows = false;
            this.outboundGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outboundGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fromColumn,
            this.toColumn,
            this.dateColumn,
            this.timeColumn,
            this.flightColumn,
            this.priceColumn,
            this.stopColumn,
            this.economColumn});
            resources.ApplyResources(this.outboundGridView, "outboundGridView");
            this.outboundGridView.Name = "outboundGridView";
            this.outboundGridView.RowHeadersVisible = false;
            this.outboundGridView.RowTemplate.Height = 24;
            this.outboundGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // outboundCheck
            // 
            resources.ApplyResources(this.outboundCheck, "outboundCheck");
            this.outboundCheck.Name = "outboundCheck";
            this.outboundCheck.UseVisualStyleBackColor = true;
            // 
            // confirmBox
            // 
            this.confirmBox.Controls.Add(this.passangerText);
            this.confirmBox.Controls.Add(this.bookButton);
            this.confirmBox.Controls.Add(this.passangersLabel);
            resources.ApplyResources(this.confirmBox, "confirmBox");
            this.confirmBox.Name = "confirmBox";
            this.confirmBox.TabStop = false;
            // 
            // passangerText
            // 
            resources.ApplyResources(this.passangerText, "passangerText");
            this.passangerText.Name = "passangerText";
            // 
            // bookButton
            // 
            resources.ApplyResources(this.bookButton, "bookButton");
            this.bookButton.Name = "bookButton";
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // passangersLabel
            // 
            resources.ApplyResources(this.passangersLabel, "passangersLabel");
            this.passangersLabel.Name = "passangersLabel";
            // 
            // exitButton
            // 
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.Name = "exitButton";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // returnGridView
            // 
            this.returnGridView.AllowUserToAddRows = false;
            this.returnGridView.AllowUserToDeleteRows = false;
            this.returnGridView.AllowUserToResizeColumns = false;
            this.returnGridView.AllowUserToResizeRows = false;
            this.returnGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.from_reColumn,
            this.to_reColumn,
            this.date_reColumn,
            this.time_reColumn,
            this.flight_reColumn,
            this.price_reColumn,
            this.stop_reColumn,
            this.eco_reColumn});
            resources.ApplyResources(this.returnGridView, "returnGridView");
            this.returnGridView.Name = "returnGridView";
            this.returnGridView.RowHeadersVisible = false;
            this.returnGridView.RowTemplate.Height = 24;
            this.returnGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // returnFlightLabel
            // 
            resources.ApplyResources(this.returnFlightLabel, "returnFlightLabel");
            this.returnFlightLabel.Name = "returnFlightLabel";
            // 
            // returnCheck
            // 
            resources.ApplyResources(this.returnCheck, "returnCheck");
            this.returnCheck.Name = "returnCheck";
            this.returnCheck.UseVisualStyleBackColor = true;
            // 
            // outboundText
            // 
            resources.ApplyResources(this.outboundText, "outboundText");
            this.outboundText.Name = "outboundText";
            // 
            // returnText
            // 
            resources.ApplyResources(this.returnText, "returnText");
            this.returnText.Name = "returnText";
            // 
            // fromColumn
            // 
            resources.ApplyResources(this.fromColumn, "fromColumn");
            this.fromColumn.Name = "fromColumn";
            this.fromColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fromColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // toColumn
            // 
            resources.ApplyResources(this.toColumn, "toColumn");
            this.toColumn.Name = "toColumn";
            this.toColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.toColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dateColumn
            // 
            resources.ApplyResources(this.dateColumn, "dateColumn");
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dateColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // timeColumn
            // 
            resources.ApplyResources(this.timeColumn, "timeColumn");
            this.timeColumn.Name = "timeColumn";
            this.timeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.timeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // flightColumn
            // 
            resources.ApplyResources(this.flightColumn, "flightColumn");
            this.flightColumn.Name = "flightColumn";
            this.flightColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.flightColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // priceColumn
            // 
            resources.ApplyResources(this.priceColumn, "priceColumn");
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.priceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // stopColumn
            // 
            resources.ApplyResources(this.stopColumn, "stopColumn");
            this.stopColumn.Name = "stopColumn";
            this.stopColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.stopColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // economColumn
            // 
            resources.ApplyResources(this.economColumn, "economColumn");
            this.economColumn.Name = "economColumn";
            this.economColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.economColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // from_reColumn
            // 
            resources.ApplyResources(this.from_reColumn, "from_reColumn");
            this.from_reColumn.Name = "from_reColumn";
            this.from_reColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.from_reColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // to_reColumn
            // 
            resources.ApplyResources(this.to_reColumn, "to_reColumn");
            this.to_reColumn.Name = "to_reColumn";
            this.to_reColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.to_reColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // date_reColumn
            // 
            resources.ApplyResources(this.date_reColumn, "date_reColumn");
            this.date_reColumn.Name = "date_reColumn";
            this.date_reColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.date_reColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // time_reColumn
            // 
            resources.ApplyResources(this.time_reColumn, "time_reColumn");
            this.time_reColumn.Name = "time_reColumn";
            this.time_reColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.time_reColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // flight_reColumn
            // 
            resources.ApplyResources(this.flight_reColumn, "flight_reColumn");
            this.flight_reColumn.Name = "flight_reColumn";
            this.flight_reColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.flight_reColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // price_reColumn
            // 
            resources.ApplyResources(this.price_reColumn, "price_reColumn");
            this.price_reColumn.Name = "price_reColumn";
            this.price_reColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.price_reColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // stop_reColumn
            // 
            resources.ApplyResources(this.stop_reColumn, "stop_reColumn");
            this.stop_reColumn.Name = "stop_reColumn";
            this.stop_reColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.stop_reColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // eco_reColumn
            // 
            resources.ApplyResources(this.eco_reColumn, "eco_reColumn");
            this.eco_reColumn.Name = "eco_reColumn";
            // 
            // Searchflight
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.returnCheck);
            this.Controls.Add(this.returnFlightLabel);
            this.Controls.Add(this.returnGridView);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.confirmBox);
            this.Controls.Add(this.outboundCheck);
            this.Controls.Add(this.outboundGridView);
            this.Controls.Add(this.outboundFlightLabel);
            this.Controls.Add(this.searchBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Searchflight";
            this.Load += new System.EventHandler(this.Searchflight_Load);
            this.searchBox.ResumeLayout(false);
            this.searchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outboundGridView)).EndInit();
            this.confirmBox.ResumeLayout(false);
            this.confirmBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox searchBox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.ComboBox cabinBox;
        private System.Windows.Forms.ComboBox toBox;
        private System.Windows.Forms.ComboBox fromBox;
        private System.Windows.Forms.Label returnLabel;
        private System.Windows.Forms.Label outboundLabel;
        private System.Windows.Forms.RadioButton oneWayButton;
        private System.Windows.Forms.RadioButton returnButton;
        private System.Windows.Forms.Label cabinTypeLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label outboundFlightLabel;
        private System.Windows.Forms.DataGridView outboundGridView;
        private System.Windows.Forms.CheckBox outboundCheck;
        private System.Windows.Forms.GroupBox confirmBox;
        private System.Windows.Forms.TextBox passangerText;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.Label passangersLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView returnGridView;
        private System.Windows.Forms.Label returnFlightLabel;
        private System.Windows.Forms.CheckBox returnCheck;
        private System.Windows.Forms.MaskedTextBox returnText;
        private System.Windows.Forms.MaskedTextBox outboundText;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn economColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn from_reColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn to_reColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_reColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_reColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flight_reColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_reColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stop_reColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eco_reColumn;
    }
}

