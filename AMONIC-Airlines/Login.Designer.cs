namespace AMONIC_Airlines
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.amonic_picture = new System.Windows.Forms.PictureBox();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.Incorrect_enter = new System.Windows.Forms.Timer(this.components);
            this.ban = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amonic_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // amonic_picture
            // 
            this.amonic_picture.Image = ((System.Drawing.Image)(resources.GetObject("amonic_picture.Image")));
            this.amonic_picture.Location = new System.Drawing.Point(145, 28);
            this.amonic_picture.Name = "amonic_picture";
            this.amonic_picture.Size = new System.Drawing.Size(310, 100);
            this.amonic_picture.TabIndex = 0;
            this.amonic_picture.TabStop = false;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(145, 173);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(310, 20);
            this.login.TabIndex = 1;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(145, 212);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(310, 20);
            this.password.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password: ";
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(159, 261);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(80, 30);
            this.loginbutton.TabIndex = 5;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(361, 261);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(80, 30);
            this.exitbutton.TabIndex = 6;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // Incorrect_enter
            // 
            this.Incorrect_enter.Interval = 1000;
            this.Incorrect_enter.Tick += new System.EventHandler(this.Incorrect_enter_Tick);
            // 
            // ban
            // 
            this.ban.AutoSize = true;
            this.ban.ForeColor = System.Drawing.Color.Red;
            this.ban.Location = new System.Drawing.Point(142, 140);
            this.ban.Name = "ban";
            this.ban.Size = new System.Drawing.Size(257, 13);
            this.ban.TabIndex = 7;
            this.ban.Text = "Incorrect login or password. Try again later.";
            this.ban.Visible = false;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.ForeColor = System.Drawing.Color.Red;
            this.time.Location = new System.Drawing.Point(403, 140);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(44, 13);
            this.time.TabIndex = 8;
            this.time.Text = "10 sec";
            this.time.Visible = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 303);
            this.Controls.Add(this.time);
            this.Controls.Add(this.ban);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.amonic_picture);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.amonic_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox amonic_picture;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Timer Incorrect_enter;
        private System.Windows.Forms.Label ban;
        private System.Windows.Forms.Label time;
    }
}

