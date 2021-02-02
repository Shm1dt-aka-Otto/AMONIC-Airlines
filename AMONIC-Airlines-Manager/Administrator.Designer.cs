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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageFlightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.officeLabel = new System.Windows.Forms.Label();
            this.officeBox = new System.Windows.Forms.ComboBox();
            this.administratorGridView = new System.Windows.Forms.DataGridView();
            this.changeRoleButton = new System.Windows.Forms.Button();
            this.enableDisableButton = new System.Windows.Forms.Button();
            this.surveyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSurveyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.administratorGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.manageFlightsToolStripMenuItem,
            this.surveyToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(691, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(82, 26);
            this.addUserToolStripMenuItem.Text = "Add user";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // manageFlightsToolStripMenuItem
            // 
            this.manageFlightsToolStripMenuItem.Name = "manageFlightsToolStripMenuItem";
            this.manageFlightsToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.manageFlightsToolStripMenuItem.Text = "Manage Flights";
            this.manageFlightsToolStripMenuItem.Click += new System.EventHandler(this.manageFlightsToolStripMenuItem_Click);
            // 
            // officeLabel
            // 
            this.officeLabel.AutoSize = true;
            this.officeLabel.Location = new System.Drawing.Point(14, 33);
            this.officeLabel.Name = "officeLabel";
            this.officeLabel.Size = new System.Drawing.Size(53, 17);
            this.officeLabel.TabIndex = 1;
            this.officeLabel.Text = "Office:";
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
            this.officeBox.Size = new System.Drawing.Size(140, 25);
            this.officeBox.TabIndex = 2;
            this.officeBox.SelectedIndexChanged += new System.EventHandler(this.officeBox_SelectedIndexChanged);
            // 
            // administratorGridView
            // 
            this.administratorGridView.AllowUserToAddRows = false;
            this.administratorGridView.AllowUserToDeleteRows = false;
            this.administratorGridView.AllowUserToResizeColumns = false;
            this.administratorGridView.AllowUserToResizeRows = false;
            this.administratorGridView.BackgroundColor = System.Drawing.Color.White;
            this.administratorGridView.ColumnHeadersHeight = 29;
            this.administratorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.administratorGridView.EnableHeadersVisualStyles = false;
            this.administratorGridView.Location = new System.Drawing.Point(17, 71);
            this.administratorGridView.MultiSelect = false;
            this.administratorGridView.Name = "administratorGridView";
            this.administratorGridView.RowHeadersVisible = false;
            this.administratorGridView.RowHeadersWidth = 51;
            this.administratorGridView.RowTemplate.ReadOnly = true;
            this.administratorGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.administratorGridView.Size = new System.Drawing.Size(650, 284);
            this.administratorGridView.TabIndex = 3;
            // 
            // changeRoleButton
            // 
            this.changeRoleButton.Location = new System.Drawing.Point(17, 375);
            this.changeRoleButton.Name = "changeRoleButton";
            this.changeRoleButton.Size = new System.Drawing.Size(112, 24);
            this.changeRoleButton.TabIndex = 4;
            this.changeRoleButton.Text = "Change Role";
            this.changeRoleButton.UseVisualStyleBackColor = true;
            this.changeRoleButton.Click += new System.EventHandler(this.changeRoleButton_Click);
            // 
            // enableDisableButton
            // 
            this.enableDisableButton.Location = new System.Drawing.Point(184, 376);
            this.enableDisableButton.Name = "enableDisableButton";
            this.enableDisableButton.Size = new System.Drawing.Size(185, 24);
            this.enableDisableButton.TabIndex = 5;
            this.enableDisableButton.Text = "Enable/Disable Login";
            this.enableDisableButton.UseVisualStyleBackColor = true;
            this.enableDisableButton.Click += new System.EventHandler(this.enableDisableButton_Click);
            // 
            // surveyToolStripMenuItem
            // 
            this.surveyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSurveyToolStripMenuItem,
            this.summaryResultToolStripMenuItem,
            this.detailResultToolStripMenuItem});
            this.surveyToolStripMenuItem.Name = "surveyToolStripMenuItem";
            this.surveyToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.surveyToolStripMenuItem.Text = "Survey";
            // 
            // addSurveyToolStripMenuItem
            // 
            this.addSurveyToolStripMenuItem.Name = "addSurveyToolStripMenuItem";
            this.addSurveyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addSurveyToolStripMenuItem.Text = "Add Survey";
            this.addSurveyToolStripMenuItem.Click += new System.EventHandler(this.addSurveyToolStripMenuItem_Click);
            // 
            // summaryResultToolStripMenuItem
            // 
            this.summaryResultToolStripMenuItem.Name = "summaryResultToolStripMenuItem";
            this.summaryResultToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.summaryResultToolStripMenuItem.Text = "Summary Result";
            this.summaryResultToolStripMenuItem.Click += new System.EventHandler(this.summaryResultToolStripMenuItem_Click);
            // 
            // detailResultToolStripMenuItem
            // 
            this.detailResultToolStripMenuItem.Name = "detailResultToolStripMenuItem";
            this.detailResultToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.detailResultToolStripMenuItem.Text = "Detail Result";
            this.detailResultToolStripMenuItem.Click += new System.EventHandler(this.detailResultToolStripMenuItem_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 420);
            this.Controls.Add(this.enableDisableButton);
            this.Controls.Add(this.changeRoleButton);
            this.Controls.Add(this.administratorGridView);
            this.Controls.Add(this.officeBox);
            this.Controls.Add(this.officeLabel);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AMONIC Airlines Automation System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Administrator_FormClosing);
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.administratorGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label officeLabel;
        private System.Windows.Forms.ComboBox officeBox;
        private System.Windows.Forms.DataGridView administratorGridView;
        private System.Windows.Forms.Button changeRoleButton;
        private System.Windows.Forms.Button enableDisableButton;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private System.Windows.Forms.ToolStripMenuItem manageFlightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem surveyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSurveyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailResultToolStripMenuItem;
    }
}