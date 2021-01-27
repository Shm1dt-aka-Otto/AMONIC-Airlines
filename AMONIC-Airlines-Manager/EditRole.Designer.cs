namespace AMONIC_Airlines
{
    partial class EditRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRole));
            this.emailLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.officeLabel = new System.Windows.Forms.Label();
            this.officeBox = new System.Windows.Forms.ComboBox();
            this.officesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._amonic_airlinesDataSet = new AMONIC_Airlines._amonic_airlinesDataSet();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.userRadioButton = new System.Windows.Forms.RadioButton();
            this.administratorRadioButton = new System.Windows.Forms.RadioButton();
            this.roleLabel = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.officesTableAdapter1 = new AMONIC_Airlines._amonic_airlinesDataSetTableAdapters.officesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.officesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._amonic_airlinesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(32, 31);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(107, 17);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email Address";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(55, 70);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(83, 17);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(56, 107);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(82, 17);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // officeLabel
            // 
            this.officeLabel.AutoSize = true;
            this.officeLabel.Location = new System.Drawing.Point(90, 144);
            this.officeLabel.Name = "officeLabel";
            this.officeLabel.Size = new System.Drawing.Size(47, 17);
            this.officeLabel.TabIndex = 3;
            this.officeLabel.Text = "Office";
            // 
            // officeBox
            // 
            this.officeBox.DataSource = this.officesBindingSource;
            this.officeBox.DisplayMember = "Title";
            this.officeBox.FormattingEnabled = true;
            this.officeBox.Location = new System.Drawing.Point(143, 141);
            this.officeBox.Name = "officeBox";
            this.officeBox.Size = new System.Drawing.Size(184, 25);
            this.officeBox.TabIndex = 4;
            this.officeBox.ValueMember = "Title";
            // 
            // officesBindingSource
            // 
            this.officesBindingSource.DataMember = "offices";
            this.officesBindingSource.DataSource = this._amonic_airlinesDataSet;
            // 
            // _amonic_airlinesDataSet
            // 
            this._amonic_airlinesDataSet.DataSetName = "_amonic_airlinesDataSet";
            this._amonic_airlinesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(143, 28);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(184, 24);
            this.emailBox.TabIndex = 5;
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(143, 67);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(184, 24);
            this.firstNameBox.TabIndex = 6;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(143, 104);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(184, 24);
            this.lastNameBox.TabIndex = 7;
            // 
            // userRadioButton
            // 
            this.userRadioButton.AutoSize = true;
            this.userRadioButton.Location = new System.Drawing.Point(143, 183);
            this.userRadioButton.Name = "userRadioButton";
            this.userRadioButton.Size = new System.Drawing.Size(61, 21);
            this.userRadioButton.TabIndex = 8;
            this.userRadioButton.TabStop = true;
            this.userRadioButton.Text = "User";
            this.userRadioButton.UseVisualStyleBackColor = true;
            // 
            // administratorRadioButton
            // 
            this.administratorRadioButton.AutoSize = true;
            this.administratorRadioButton.Location = new System.Drawing.Point(143, 206);
            this.administratorRadioButton.Name = "administratorRadioButton";
            this.administratorRadioButton.Size = new System.Drawing.Size(125, 21);
            this.administratorRadioButton.TabIndex = 9;
            this.administratorRadioButton.TabStop = true;
            this.administratorRadioButton.Text = "Administrator";
            this.administratorRadioButton.UseVisualStyleBackColor = true;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(99, 197);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(38, 17);
            this.roleLabel.TabIndex = 10;
            this.roleLabel.Text = "Role";
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(42, 248);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 25);
            this.applyButton.TabIndex = 11;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Red;
            this.cancelButton.Location = new System.Drawing.Point(263, 248);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 25);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // officesTableAdapter1
            // 
            this.officesTableAdapter1.ClearBeforeFill = true;
            // 
            // EditRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 293);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.administratorRadioButton);
            this.Controls.Add(this.userRadioButton);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.officeBox);
            this.Controls.Add(this.officeLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.emailLabel);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Role";
            this.Load += new System.EventHandler(this.Edit_Role_Load);
            ((System.ComponentModel.ISupportInitialize)(this.officesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._amonic_airlinesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label officeLabel;
        private System.Windows.Forms.ComboBox officeBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.RadioButton userRadioButton;
        private System.Windows.Forms.RadioButton administratorRadioButton;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        private _amonic_airlinesDataSet _amonic_airlinesDataSet;
        private System.Windows.Forms.BindingSource officesBindingSource;
        private _amonic_airlinesDataSetTableAdapters.officesTableAdapter officesTableAdapter1;
    }
}