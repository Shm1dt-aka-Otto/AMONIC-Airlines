namespace AMONIC_Airlines_2
{
    partial class ApplyChanges
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplyChanges));
            this.statementLabel = new System.Windows.Forms.Label();
            this.importBox = new System.Windows.Forms.TextBox();
            this.importButton = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.GroupBox();
            this.successfulLabel = new System.Windows.Forms.Label();
            this.duplicateLabel = new System.Windows.Forms.Label();
            this.recordLabel = new System.Windows.Forms.Label();
            this.successfulCountLabel = new System.Windows.Forms.Label();
            this.duplicateCountLabel = new System.Windows.Forms.Label();
            this.recordCountLabel = new System.Windows.Forms.Label();
            this.resultBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // statementLabel
            // 
            this.statementLabel.AutoSize = true;
            this.statementLabel.Location = new System.Drawing.Point(22, 21);
            this.statementLabel.Name = "statementLabel";
            this.statementLabel.Size = new System.Drawing.Size(307, 17);
            this.statementLabel.TabIndex = 0;
            this.statementLabel.Text = "Please select the text file with the changes";
            // 
            // importBox
            // 
            this.importBox.Location = new System.Drawing.Point(39, 51);
            this.importBox.Name = "importBox";
            this.importBox.Size = new System.Drawing.Size(334, 23);
            this.importBox.TabIndex = 1;
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(379, 51);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(85, 23);
            this.importButton.TabIndex = 2;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // resultBox
            // 
            this.resultBox.Controls.Add(this.recordCountLabel);
            this.resultBox.Controls.Add(this.duplicateCountLabel);
            this.resultBox.Controls.Add(this.successfulCountLabel);
            this.resultBox.Controls.Add(this.recordLabel);
            this.resultBox.Controls.Add(this.duplicateLabel);
            this.resultBox.Controls.Add(this.successfulLabel);
            this.resultBox.Location = new System.Drawing.Point(25, 99);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(439, 137);
            this.resultBox.TabIndex = 3;
            this.resultBox.TabStop = false;
            this.resultBox.Text = "Results";
            // 
            // successfulLabel
            // 
            this.successfulLabel.AutoSize = true;
            this.successfulLabel.Location = new System.Drawing.Point(21, 33);
            this.successfulLabel.Name = "successfulLabel";
            this.successfulLabel.Size = new System.Drawing.Size(210, 17);
            this.successfulLabel.TabIndex = 0;
            this.successfulLabel.Text = "Successful Changes Applied:";
            // 
            // duplicateLabel
            // 
            this.duplicateLabel.AutoSize = true;
            this.duplicateLabel.Location = new System.Drawing.Point(21, 60);
            this.duplicateLabel.Name = "duplicateLabel";
            this.duplicateLabel.Size = new System.Drawing.Size(214, 17);
            this.duplicateLabel.TabIndex = 1;
            this.duplicateLabel.Text = "Duplicate Records Discarded:";
            // 
            // recordLabel
            // 
            this.recordLabel.AutoSize = true;
            this.recordLabel.Location = new System.Drawing.Point(21, 88);
            this.recordLabel.Name = "recordLabel";
            this.recordLabel.Size = new System.Drawing.Size(268, 17);
            this.recordLabel.TabIndex = 2;
            this.recordLabel.Text = "Record with missing fields discarded:";
            // 
            // successfulCountLabel
            // 
            this.successfulCountLabel.AutoSize = true;
            this.successfulCountLabel.Location = new System.Drawing.Point(326, 33);
            this.successfulCountLabel.Name = "successfulCountLabel";
            this.successfulCountLabel.Size = new System.Drawing.Size(44, 17);
            this.successfulCountLabel.TabIndex = 3;
            this.successfulCountLabel.Text = "xxxx";
            // 
            // duplicateCountLabel
            // 
            this.duplicateCountLabel.AutoSize = true;
            this.duplicateCountLabel.Location = new System.Drawing.Point(326, 60);
            this.duplicateCountLabel.Name = "duplicateCountLabel";
            this.duplicateCountLabel.Size = new System.Drawing.Size(44, 17);
            this.duplicateCountLabel.TabIndex = 4;
            this.duplicateCountLabel.Text = "xxxx";
            // 
            // recordCountLabel
            // 
            this.recordCountLabel.AutoSize = true;
            this.recordCountLabel.Location = new System.Drawing.Point(326, 88);
            this.recordCountLabel.Name = "recordCountLabel";
            this.recordCountLabel.Size = new System.Drawing.Size(44, 17);
            this.recordCountLabel.TabIndex = 5;
            this.recordCountLabel.Text = "xxxx";
            // 
            // ApplyChanges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 255);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.importBox);
            this.Controls.Add(this.statementLabel);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApplyChanges";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apply Schedule Changes";
            this.Load += new System.EventHandler(this.ApplyChanges_Load);
            this.resultBox.ResumeLayout(false);
            this.resultBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statementLabel;
        private System.Windows.Forms.TextBox importBox;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.GroupBox resultBox;
        private System.Windows.Forms.Label recordCountLabel;
        private System.Windows.Forms.Label duplicateCountLabel;
        private System.Windows.Forms.Label successfulCountLabel;
        private System.Windows.Forms.Label recordLabel;
        private System.Windows.Forms.Label duplicateLabel;
        private System.Windows.Forms.Label successfulLabel;
    }
}