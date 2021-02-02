namespace AMONIC_Airlines_4
{
    partial class Survey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Survey));
            this.surveyMenu = new System.Windows.Forms.MenuStrip();
            this.addSurveyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewResultSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDetailResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.surveyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // surveyMenu
            // 
            this.surveyMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.surveyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSurveyToolStripMenuItem,
            this.viewResultSummaryToolStripMenuItem,
            this.viewDetailResultToolStripMenuItem});
            this.surveyMenu.Location = new System.Drawing.Point(0, 0);
            this.surveyMenu.Name = "surveyMenu";
            this.surveyMenu.Size = new System.Drawing.Size(827, 28);
            this.surveyMenu.TabIndex = 0;
            this.surveyMenu.Text = "surveyMenu";
            // 
            // addSurveyToolStripMenuItem
            // 
            this.addSurveyToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addSurveyToolStripMenuItem.Name = "addSurveyToolStripMenuItem";
            this.addSurveyToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.addSurveyToolStripMenuItem.Text = "Add Survey";
            this.addSurveyToolStripMenuItem.Click += new System.EventHandler(this.addSurveyToolStripMenuItem_Click);
            // 
            // viewResultSummaryToolStripMenuItem
            // 
            this.viewResultSummaryToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewResultSummaryToolStripMenuItem.Name = "viewResultSummaryToolStripMenuItem";
            this.viewResultSummaryToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.viewResultSummaryToolStripMenuItem.Text = "View Result Summary";
            this.viewResultSummaryToolStripMenuItem.Click += new System.EventHandler(this.viewResultSummaryToolStripMenuItem_Click);
            // 
            // viewDetailResultToolStripMenuItem
            // 
            this.viewDetailResultToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewDetailResultToolStripMenuItem.Name = "viewDetailResultToolStripMenuItem";
            this.viewDetailResultToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.viewDetailResultToolStripMenuItem.Text = "View Detail Result";
            this.viewDetailResultToolStripMenuItem.Click += new System.EventHandler(this.viewDetailResultToolStripMenuItem_Click);
            // 
            // Survey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 468);
            this.Controls.Add(this.surveyMenu);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.surveyMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Survey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight Satisfaction Survey Report";
            this.surveyMenu.ResumeLayout(false);
            this.surveyMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip surveyMenu;
        private System.Windows.Forms.ToolStripMenuItem addSurveyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewResultSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDetailResultToolStripMenuItem;
    }
}

