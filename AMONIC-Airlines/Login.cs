using MySql.Data.MySqlClient;
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
        int count_try = 0;
        int timer = 10;
        string email, id, enterDate, enterTime;
        Thread log;
        public LoginPage() //complete
        {
            InitializeComponent();
        }
        public void admin() //complete
        {
            string connection_to_server = "server=localhost;user=root;" +
               "database=session1_xx;password=As89149625780@;";
            MySqlConnection connection_to_datebase = new MySqlConnection(connection_to_server);
            connection_to_datebase.Open();
            string sqlTwo = "SELECT ID, Enter_date, Enter_time, Logout_date, Crash_type FROM trecking WHERE Email = '" + email + "'";
            MySqlCommand commandTwo = new MySqlCommand(sqlTwo, connection_to_datebase);
            MySqlDataReader readerTwo = commandTwo.ExecuteReader();
            while (readerTwo.Read())
            {
                if (readerTwo[3].ToString() == "")
                {
                    id = readerTwo[0].ToString();
                    enterDate = readerTwo[1].ToString();
                    enterTime = readerTwo[2].ToString();
                    NoLogout nlg = new NoLogout(id, enterDate, enterTime);
                    nlg.ShowDialog();
                }
            }
            readerTwo.Close();
            string queryOne = "INSERT INTO trecking (Email, Enter_date, Enter_time) VALUES ('" + email
                + "', CURDATE(), CURTIME())";
            MySqlCommand commandThree = new MySqlCommand(queryOne, connection_to_datebase);
            commandThree.ExecuteNonQuery();
            connection_to_datebase.Close();
            Application.Run(new Administrator(email));
        }
        public void user() //complete
        {
            string connection_to_server = "server=localhost;user=root;" +
               "database=session1_xx;password=As89149625780@;";
            MySqlConnection connection_to_datebase = new MySqlConnection(connection_to_server);
            connection_to_datebase.Open();
            string sqlTwo = "SELECT ID, Enter_date, Enter_time, Logout_date FROM trecking WHERE Email = '" + email + "'";
            MySqlCommand commandTwo = new MySqlCommand(sqlTwo, connection_to_datebase);
            MySqlDataReader readerTwo = commandTwo.ExecuteReader();
            while (readerTwo.Read())
            {
                if (readerTwo[3].ToString() == "")
                {
                    id = readerTwo[0].ToString();
                    enterDate = readerTwo[1].ToString();
                    enterTime = readerTwo[2].ToString();
                    NoLogout nlg = new NoLogout(id, enterDate, enterTime);
                    nlg.ShowDialog();
                }
            }
            readerTwo.Close();
            string queryOne = "INSERT INTO trecking (Email, Enter_date, Enter_time) VALUES ('" + email
                + "', CURDATE(), CURTIME())";
            MySqlCommand commandThree = new MySqlCommand(queryOne, connection_to_datebase);
            commandThree.ExecuteNonQuery();
            connection_to_datebase.Close();
            Application.Run(new User(email));
        }
        private void loginButtonClick(object sender, EventArgs e) //complete
        {
            string connection_to_server = "server=localhost;user=root;" +
                "database=session1_xx;password=As89149625780@;";
            MySqlConnection connection_to_datebase = new MySqlConnection(connection_to_server);
            connection_to_datebase.Open();
            string sqlOne = "SELECT Email, Password, RoleID, Active FROM users " +
                "WHERE EmaiL = '" + loginTextBox.Text + "' AND Password = md5('" + passwordTextBox.Text + "')";
            MySqlCommand commandOne = new MySqlCommand(sqlOne, connection_to_datebase);
            MySqlDataReader readerOne = commandOne.ExecuteReader();
            while (readerOne.Read())
            {
                if (readerOne[2].ToString() == "1" && readerOne[3].ToString() != "False")
                {
                    email = readerOne[0].ToString();
                    pass = true;
                    this.Close();
                    log = new Thread(admin);
                    log.SetApartmentState(ApartmentState.STA);
                    log.Start();
                }
                else if (readerOne[2].ToString() == "2" && readerOne[3].ToString() != "False")
                {
                    email = readerOne[0].ToString();
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
                banLabel.Visible = true;
                count_try += 1;
                if (count_try > 3)
                {
                    timer = 10;
                    timerLabel.Text = timer + " sec";
                    timerLabel.Visible = true;
                    loginButton.Enabled = false;
                    IncorrectEnterTimer.Enabled = true;
                    IncorrectEnterTimer.Start();
                }
            }
            connection_to_datebase.Close();
        }
        private void exitButtonClick(object sender, EventArgs e) //complete
        {
            Close();
        }
        private void IncorrectEnterTimerTick(object sender, EventArgs e) //complete
        {
            timer -= 1;
            timerLabel.Text = timer + " sec";
            if (timer == 0)
            {
                timerLabel.Visible = false;
                banLabel.Visible = false;
                loginButton.Enabled = true;
                count_try = 0;
                IncorrectEnterTimer.Stop();
            }
        }
    }
}
