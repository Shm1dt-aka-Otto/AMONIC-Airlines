namespace AMONIC_Airlines
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greetingLabel = new System.Windows.Forms.Label();
            this.timespentLabel = new System.Windows.Forms.Label();
            this.crashLabel = new System.Windows.Forms.Label();
            this.userGridView = new System.Windows.Forms.DataGridView();
            this.spentTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logout_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time_spent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unsuccessful = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(684, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // greetingLabel
            // 
            this.greetingLabel.AutoSize = true;
            this.greetingLabel.Location = new System.Drawing.Point(23, 44);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(279, 17);
            this.greetingLabel.TabIndex = 1;
            this.greetingLabel.Text = "Hi USER, Welcome to AMONIC Airlines.";
            // 
            // timespentLabel
            // 
            this.timespentLabel.AutoSize = true;
            this.timespentLabel.Location = new System.Drawing.Point(167, 74);
            this.timespentLabel.Name = "timespentLabel";
            this.timespentLabel.Size = new System.Drawing.Size(171, 17);
            this.timespentLabel.TabIndex = 2;
            this.timespentLabel.Text = "Time spent on system:";
            // 
            // crashLabel
            // 
            this.crashLabel.AutoSize = true;
            this.crashLabel.Location = new System.Drawing.Point(443, 74);
            this.crashLabel.Name = "crashLabel";
            this.crashLabel.Size = new System.Drawing.Size(161, 17);
            this.crashLabel.TabIndex = 3;
            this.crashLabel.Text = "Number of crashes: 0";
            // 
            // userGridView
            // 
            this.userGridView.AllowUserToAddRows = false;
            this.userGridView.AllowUserToDeleteRows = false;
            this.userGridView.AllowUserToResizeColumns = false;
            this.userGridView.AllowUserToResizeRows = false;
            this.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Login_time,
            this.Logout_time,
            this.Time_spent,
            this.Unsuccessful});
            this.userGridView.Location = new System.Drawing.Point(12, 134);
            this.userGridView.Name = "userGridView";
            this.userGridView.RowHeadersVisible = false;
            this.userGridView.RowHeadersWidth = 51;
            this.userGridView.RowTemplate.Height = 24;
            this.userGridView.Size = new System.Drawing.Size(660, 265);
            this.userGridView.TabIndex = 4;
            // 
            // spentTimeTimer
            // 
            this.spentTimeTimer.Interval = 1000;
            this.spentTimeTimer.Tick += new System.EventHandler(this.spentTimeTimer_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(307, 74);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(74, 17);
            this.timerLabel.TabIndex = 5;
            this.timerLabel.Text = "00:00:00";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Date.Width = 102;
            // 
            // Login_time
            // 
            this.Login_time.HeaderText = "Login time";
            this.Login_time.MinimumWidth = 6;
            this.Login_time.Name = "Login_time";
            this.Login_time.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Login_time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Login_time.Width = 102;
            // 
            // Logout_time
            // 
            this.Logout_time.HeaderText = "Logout time";
            this.Logout_time.MinimumWidth = 6;
            this.Logout_time.Name = "Logout_time";
            this.Logout_time.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Logout_time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Logout_time.Width = 102;
            // 
            // Time_spent
            // 
            this.Time_spent.HeaderText = "Time spent on system";
            this.Time_spent.MinimumWidth = 6;
            this.Time_spent.Name = "Time_spent";
            this.Time_spent.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Time_spent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Time_spent.Width = 150;
            // 
            // Unsuccessful
            // 
            this.Unsuccessful.HeaderText = "Unsuccessful logout reason";
            this.Unsuccessful.MinimumWidth = 6;
            this.Unsuccessful.Name = "Unsuccessful";
            this.Unsuccessful.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Unsuccessful.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Unsuccessful.Width = 200;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.userGridView);
            this.Controls.Add(this.crashLabel);
            this.Controls.Add(this.timespentLabel);
            this.Controls.Add(this.greetingLabel);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AMONIC Airlines Automation System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.User_FormClosing);
            this.Load += new System.EventHandler(this.User_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label greetingLabel;
        private System.Windows.Forms.Label timespentLabel;
        private System.Windows.Forms.Label crashLabel;
        private System.Windows.Forms.DataGridView userGridView;
        private System.Windows.Forms.Timer spentTimeTimer;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Logout_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time_spent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unsuccessful;
    }
}