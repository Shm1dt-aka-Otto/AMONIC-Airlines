namespace AMONIC_Airlines
{
    partial class Edit_Role
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Role));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.off = new System.Windows.Forms.ComboBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.first = new System.Windows.Forms.TextBox();
            this.last = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.RadioButton();
            this.admin = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.session1_xxDataSet1 = new AMONIC_Airlines.session1_xxDataSet1();
            this.officesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.officesTableAdapter = new AMONIC_Airlines.session1_xxDataSet1TableAdapters.officesTableAdapter();
            this.Apply = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.session1_xxDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Office";
            // 
            // off
            // 
            this.off.DataSource = this.officesBindingSource;
            this.off.DisplayMember = "Title";
            this.off.FormattingEnabled = true;
            this.off.Location = new System.Drawing.Point(143, 141);
            this.off.Name = "off";
            this.off.Size = new System.Drawing.Size(184, 21);
            this.off.TabIndex = 4;
            this.off.Text = "[ Office name ]";
            this.off.ValueMember = "ID";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(143, 28);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(184, 21);
            this.mail.TabIndex = 5;
            this.mail.Text = "[ email address ]";
            this.mail.Click += new System.EventHandler(this.mail_Click);
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(143, 67);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(184, 21);
            this.first.TabIndex = 6;
            this.first.Text = "[ first name ]";
            this.first.Click += new System.EventHandler(this.first_Click);
            // 
            // last
            // 
            this.last.Location = new System.Drawing.Point(143, 104);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(184, 21);
            this.last.TabIndex = 7;
            this.last.Text = "[ last name ]";
            this.last.Click += new System.EventHandler(this.last_Click);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(143, 183);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(51, 17);
            this.user.TabIndex = 8;
            this.user.TabStop = true;
            this.user.Text = "User";
            this.user.UseVisualStyleBackColor = true;
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.Location = new System.Drawing.Point(143, 206);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(102, 17);
            this.admin.TabIndex = 9;
            this.admin.TabStop = true;
            this.admin.Text = "Administrator";
            this.admin.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Role";
            // 
            // session1_xxDataSet1
            // 
            this.session1_xxDataSet1.DataSetName = "session1_xxDataSet1";
            this.session1_xxDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // officesBindingSource
            // 
            this.officesBindingSource.DataMember = "offices";
            this.officesBindingSource.DataSource = this.session1_xxDataSet1;
            // 
            // officesTableAdapter
            // 
            this.officesTableAdapter.ClearBeforeFill = true;
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(42, 248);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 23);
            this.Apply.TabIndex = 11;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(263, 248);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 12;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Edit_Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 293);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.user);
            this.Controls.Add(this.last);
            this.Controls.Add(this.first);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.off);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Edit_Role";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Role";
            this.Load += new System.EventHandler(this.Edit_Role_Load);
            ((System.ComponentModel.ISupportInitialize)(this.session1_xxDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox off;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.TextBox last;
        private System.Windows.Forms.RadioButton user;
        private System.Windows.Forms.RadioButton admin;
        private System.Windows.Forms.Label label5;
        private session1_xxDataSet1 session1_xxDataSet1;
        private System.Windows.Forms.BindingSource officesBindingSource;
        private session1_xxDataSet1TableAdapters.officesTableAdapter officesTableAdapter;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Button Cancel;
    }
}