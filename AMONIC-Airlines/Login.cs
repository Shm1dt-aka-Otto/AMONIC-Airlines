﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AMONIC_Airlines
{
    public partial class LoginPage : Form
    {
        bool pass = false;
        int trying = 0;
        int timer = 10;
        string email;
        Thread log;
        public LoginPage()
        {
            InitializeComponent();
        }
        public void admin() //complete
        {
            string connection_to_server = "server=localhost;user=root;" +
               "database=session1_xx;password=As89149625780@;";
            MySqlConnection connection_to_datebase = new MySqlConnection(connection_to_server);
            connection_to_datebase.Open();
            string query = "INSERT INTO trecking (Email, Enter_date, Enter_time) VALUES ('" + email
                + "', UTC_DATE(), UTC_TIME())";
            MySqlCommand command = new MySqlCommand(query, connection_to_datebase);
            command.ExecuteNonQuery();
            connection_to_datebase.Close();
            Application.Run(new Administrator());
        }
        public void user()
        {
            string connection_to_server = "server=localhost;user=root;" +
                "database=session1_xx;password=As89149625780@;";
            MySqlConnection connection_to_datebase = new MySqlConnection(connection_to_server);
            connection_to_datebase.Open();
            string query = "INSERT INTO trecking (Email, Enter_date, Enter_time) VALUES ('" + email
                + "', UTC_DATE(), UTC_TIME())";
            Application.Run(new User(email));
        }
        private void loginbutton_Click(object sender, EventArgs e)
        {
            string connection_to_server = "server=localhost;user=root;" +
                "database=session1_xx;password=As89149625780@;";
            MySqlConnection connection_to_datebase = new MySqlConnection(connection_to_server);
            connection_to_datebase.Open();
            string sql = "SELECT Email, Password, RoleID, Active FROM users " +
                "WHERE EmaiL = '" + login.Text + "' AND Password = md5('" + password.Text + "')";
            MySqlCommand command = new MySqlCommand(sql, connection_to_datebase);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader[2].ToString() == "1" && reader[3].ToString() != "False")
                {
                    email = reader[0].ToString();
                    pass = true;
                    this.Close();
                    log = new Thread(admin);
                    log.SetApartmentState(ApartmentState.STA);
                    log.Start();
                }
                else if (reader[2].ToString() == "2" && reader[3].ToString() != "False")
                {
                    email = reader[0].ToString();
                    pass = true;
                    this.Close();
                    log = new Thread(user);
                    log.SetApartmentState(ApartmentState.STA);
                    log.Start();
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Your account has been blocked. " +
                        "Contact the administrator to clarify the circumstances.", 
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (pass == false)
            {
                ban.Visible = true;
                trying += 1;
                if (trying > 3)
                {
                    time.Visible = true;
                    loginbutton.Enabled = false;
                    Incorrect_enter.Enabled = true;
                    Incorrect_enter.Start();
                }
            }
            connection_to_datebase.Close();
        }
        private void exitbutton_Click(object sender, EventArgs e) //complete
        {
            Close();
        }

        private void Incorrect_enter_Tick(object sender, EventArgs e) //complete
        {
            timer -= 1;
            TimeSpan span = TimeSpan.FromSeconds(timer);
            time.Text = timer + " sec";
            if (timer == 0)
            {
                time.Visible = false;
                ban.Visible = false;
                loginbutton.Enabled = true;
                trying = 0;
            }
        }
    }
}
