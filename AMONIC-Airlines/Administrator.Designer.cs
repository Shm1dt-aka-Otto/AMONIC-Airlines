namespace AMONIC_Airlines
{
    partial class Administrator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.officeBox = new System.Windows.Forms.ComboBox();
            this.officesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.session1_xxDataSet1 = new AMONIC_Airlines.session1_xxDataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.changerole = new System.Windows.Forms.Button();
            this.enabledisable = new System.Windows.Forms.Button();
            this.countriesTableAdapter = new AMONIC_Airlines.session1_xxDataSet1TableAdapters.countriesTableAdapter();
            this.usersTableAdapter = new AMONIC_Airlines.session1_xxDataSet1TableAdapters.usersTableAdapter();
            this.officesTableAdapter = new AMONIC_Airlines.session1_xxDataSet1TableAdapters.officesTableAdapter();
            this.rolesTableAdapter = new AMONIC_Airlines.session1_xxDataSet1TableAdapters.rolesTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1_xxDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(691, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.addUserToolStripMenuItem.Text = "Add user";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Office:";
            // 
            // officeBox
            // 
            this.officeBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.officeBox.FormattingEnabled = true;
            this.officeBox.Items.AddRange(new object[] {
            "All offices",
            "Abu dhabi",
            "Cairo",
            "Bahrain",
            "Doha",
            "Riyadh"});
            this.officeBox.Location = new System.Drawing.Point(65, 30);
            this.officeBox.Name = "officeBox";
            this.officeBox.Size = new System.Drawing.Size(140, 21);
            this.officeBox.TabIndex = 2;
            this.officeBox.SelectedIndexChanged += new System.EventHandler(this.officeBox_SelectedIndexChanged);
            // 
            // officesBindingSource
            // 
            this.officesBindingSource.DataMember = "offices";
            this.officesBindingSource.DataSource = this.session1_xxDataSet1;
            // 
            // session1_xxDataSet1
            // 
            this.session1_xxDataSet1.DataSetName = "session1_xxDataSet1";
            this.session1_xxDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(17, 71);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(650, 284);
            this.dataGridView1.TabIndex = 3;
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "roles";
            this.rolesBindingSource.DataSource = this.session1_xxDataSet1;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.session1_xxDataSet1;
            // 
            // changerole
            // 
            this.changerole.Location = new System.Drawing.Point(17, 375);
            this.changerole.Name = "changerole";
            this.changerole.Size = new System.Drawing.Size(112, 24);
            this.changerole.TabIndex = 4;
            this.changerole.Text = "Change Role";
            this.changerole.UseVisualStyleBackColor = true;
            this.changerole.Click += new System.EventHandler(this.changerole_Click);
            // 
            // enabledisable
            // 
            this.enabledisable.Location = new System.Drawing.Point(184, 376);
            this.enabledisable.Name = "enabledisable";
            this.enabledisable.Size = new System.Drawing.Size(159, 24);
            this.enabledisable.TabIndex = 5;
            this.enabledisable.Text = "Enable/Disable Login";
            this.enabledisable.UseVisualStyleBackColor = true;
            this.enabledisable.Click += new System.EventHandler(this.enabledisable_Click);
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // officesTableAdapter
            // 
            this.officesTableAdapter.ClearBeforeFill = true;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 420);
            this.Controls.Add(this.enabledisable);
            this.Controls.Add(this.changerole);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.officeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AMONIC Airlines Automation System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Administrator_FormClosing);
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1_xxDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox officeBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button changerole;
        private System.Windows.Forms.Button enabledisable;
        private session1_xxDataSet1TableAdapters.countriesTableAdapter countriesTableAdapter;
        private session1_xxDataSet1 session1_xxDataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private session1_xxDataSet1TableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource officesBindingSource;
        private session1_xxDataSet1TableAdapters.officesTableAdapter officesTableAdapter;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private session1_xxDataSet1TableAdapters.rolesTableAdapter rolesTableAdapter;
    }
}