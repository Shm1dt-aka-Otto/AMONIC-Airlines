namespace AMONIC_Airlines
{
    partial class Add_usercs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_usercs));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.first = new System.Windows.Forms.TextBox();
            this.last = new System.Windows.Forms.TextBox();
            this.off = new System.Windows.Forms.ComboBox();
            this.officesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.session1_xxDataSet1 = new AMONIC_Airlines.session1_xxDataSet1();
            this.date = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.officesTableAdapter = new AMONIC_Airlines.session1_xxDataSet1TableAdapters.officesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.officesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1_xxDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Office";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Birthdate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(133, 24);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(186, 21);
            this.mail.TabIndex = 6;
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(133, 62);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(186, 21);
            this.first.TabIndex = 7;
            // 
            // last
            // 
            this.last.Location = new System.Drawing.Point(133, 98);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(186, 21);
            this.last.TabIndex = 8;
            // 
            // off
            // 
            this.off.DataSource = this.officesBindingSource;
            this.off.DisplayMember = "Title";
            this.off.FormattingEnabled = true;
            this.off.Location = new System.Drawing.Point(133, 134);
            this.off.Name = "off";
            this.off.Size = new System.Drawing.Size(186, 21);
            this.off.TabIndex = 9;
            this.off.ValueMember = "ID";
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
            // date
            // 
            this.date.Location = new System.Drawing.Point(133, 171);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(186, 21);
            this.date.TabIndex = 10;
            this.date.Text = "[ yyyy-mm-dd ]";
            this.date.Click += new System.EventHandler(this.date_Click);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(133, 212);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(186, 21);
            this.pass.TabIndex = 11;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(71, 267);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 12;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(229, 267);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 13;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // officesTableAdapter
            // 
            this.officesTableAdapter.ClearBeforeFill = true;
            // 
            // Add_usercs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.date);
            this.Controls.Add(this.off);
            this.Controls.Add(this.last);
            this.Controls.Add(this.first);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_usercs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add user";
            this.Load += new System.EventHandler(this.Add_usercs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.officesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1_xxDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.TextBox last;
        private System.Windows.Forms.ComboBox off;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private session1_xxDataSet1 session1_xxDataSet1;
        private System.Windows.Forms.BindingSource officesBindingSource;
        private session1_xxDataSet1TableAdapters.officesTableAdapter officesTableAdapter;
    }
}