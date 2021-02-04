using AMONIC_Airlines_2;
using AMONIC_Airlines_3;
using AMONIC_Airlines_5;
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

namespace AMONIC_Airlines
{
    public partial class User : Form
    {
        string emailUser, enterId;
        int timeLogin = 0, countCrash = 0;
        public User(string email) //complete
        {
            InitializeComponent();
            spentTimeTimer.Start();
            emailUser = email;
            string connection_to_server = "server=localhost;user=root;" +
                "database=amonic-airlines;password=As89149625780@;";
            MySqlConnection connection_to_datebase = new MySqlConnection(connection_to_server);
            connection_to_datebase.Open();
            string sqlOne = "SELECT FirstName FROM users WHERE EmaiL = '" + email + "'";
            MySqlCommand commandOne = new MySqlCommand(sqlOne, connection_to_datebase);
            MySqlDataReader readerOne = commandOne.ExecuteReader();
            while (readerOne.Read())
            {
                greetingLabel.Text = "Hi " + readerOne[0].ToString() + ", Welcome to AMONIC Airlines";
            }
            readerOne.Close();
            connection_to_datebase.Close();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) //complete
        {
            Close();
        }
        private void User_FormClosing(object sender, FormClosingEventArgs e) //complete
        {
            string connection_to_server = "server=localhost;user=root;" +
                "database=amonic-airlines;password=As89149625780@;";
            MySqlConnection connection_to_datebase = new MySqlConnection(connection_to_server);
            connection_to_datebase.Open();
            string queryOne = "UPDATE trecking SET Logout_date = CURDATE(), Logout_time = CURTIME() " +
                "WHERE Email = '" + emailUser + "' AND ID = " + enterId;
            MySqlCommand commandTwo = new MySqlCommand(queryOne, connection_to_datebase);
            commandTwo.ExecuteNonQuery();
            connection_to_datebase.Close();
        }
        private void spentTimeTimer_Tick(object sender, EventArgs e) //complete
        {
            timeLogin += 1;
            int hour = timeLogin / 3600;
            int minute = timeLogin / 60;
            int second = timeLogin % 60;
            DateTime date = new DateTime(2021, 01, 01, hour, minute, second);
            if (hour == 0)
            {
                timerLabel.Text = "0" + date.ToLongTimeString();
            }
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connection_to_server = "server=localhost;user=root;database=amonic-airlines;" +
                "password=As89149625780@;";
            MySqlConnection connection_to_datebase = new MySqlConnection(connection_to_server);
            connection_to_datebase.Open();
            string sqlFour = "SELECT ID from users where Email = '" + emailUser + "'";
            MySqlCommand commandThree = new MySqlCommand(sqlFour, connection_to_datebase);
            MySqlDataReader readerTwo = commandThree.ExecuteReader();
            string idUser = "";
            if (readerTwo.Read())
            {
                idUser = readerTwo[0].ToString();
            }
            readerTwo.Close();
            connection_to_datebase.Close();
            SearchFlight search = new SearchFlight(idUser);
            search.ShowDialog();
        }

        private void amenititesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Amenities amenitites = new Amenities();
            amenitites.ShowDialog();
        }

        private void User_Load(object sender, EventArgs e) //complete
        {
            string connection_to_server = "server=localhost;user=root;database=amonic-airlines;" +
                "password=As89149625780@;";
            MySqlConnection connection_to_datebase = new MySqlConnection(connection_to_server);
            connection_to_datebase.Open();
            string sqlTwo = "SELECT COUNT(*) FROM trecking WHERE Email = '" + emailUser + "'";
            MySqlCommand commandThree = new MySqlCommand(sqlTwo, connection_to_datebase);
            MySqlDataReader readerTwo = commandThree.ExecuteReader();
            readerTwo.Read();
            int count = int.Parse(readerTwo[0].ToString());
            readerTwo.Close();
            string sqlThree = "SELECT ID, Enter_date as `Date`, Enter_time as `Login time`, Logout_time as `Logout time`, " +
                "Crash_type as `Unsuccessful logout reason` FROM trecking WHERE Email =  '" + emailUser + "'";
            MySqlCommand commandFour = new MySqlCommand(sqlThree, connection_to_datebase);
            MySqlDataReader readerThree = commandFour.ExecuteReader();
            int i = 1;
            while (readerThree.Read())
            {
                if (i == count)
                {
                    enterId = readerThree[0].ToString();
                    break;
                }
                if (readerThree[4].ToString() == "")
                {
                    string enterDate = readerThree[1].ToString();
                    string[] enterDateSplit = enterDate.Split(' ');
                    string enterTime = readerThree[2].ToString();
                    string[] enterTimeSplit = enterTime.Split(':');
                    int hourEnter = Convert.ToInt32(enterTimeSplit[0]) * 3600;
                    int minuteEnter = Convert.ToInt32(enterTimeSplit[1]) * 60;
                    int secondsEnter = Convert.ToInt32(enterTimeSplit[2]);
                    int timeEnter = hourEnter + minuteEnter + secondsEnter;
                    string logoutDate = readerThree[3].ToString();
                    string[] logoutDateSplit = logoutDate.Split(':');
                    int hourLogout = Convert.ToInt32(logoutDateSplit[0]) * 3600;
                    int minuteLogout = Convert.ToInt32(logoutDateSplit[1]) * 60;
                    int secondsLogout = Convert.ToInt32(logoutDateSplit[2]);
                    int timeLogout = hourLogout + minuteLogout + secondsLogout;
                    int spentTime = timeLogout - timeEnter;
                    int spentTimeHour = spentTime / 3600;
                    int spentTimeMinute = spentTime / 60;
                    int spentTimeSeconds = spentTime % 60;
                    string timeSpentTime;
                    if (spentTimeHour < 10)
                    {
                        if (spentTimeMinute < 10)
                        {
                            if (spentTimeSeconds < 10)
                            {
                                timeSpentTime = "0" + spentTimeHour.ToString() + ":0" +
                                    spentTimeMinute.ToString() + ":0" + spentTimeSeconds.ToString();
                            }
                            else
                            {
                                timeSpentTime = "0" + spentTimeHour.ToString() + ":0" +
                                    spentTimeMinute.ToString() + ":" + spentTimeSeconds.ToString();
                            }
                        }
                        else
                        {
                            if (spentTimeSeconds < 10)
                            {
                                timeSpentTime = "0" + spentTimeHour.ToString() + ":" +
                                    spentTimeMinute.ToString() + ":0" + spentTimeSeconds.ToString();
                            }
                            else
                            {
                                timeSpentTime = "0" + spentTimeHour.ToString() + ":" +
                                    spentTimeMinute.ToString() + ":" + spentTimeSeconds.ToString();
                            }
                        }
                    }
                    else
                    {
                        if (spentTimeMinute < 10)
                        {
                            if (spentTimeSeconds < 10)
                            {
                                timeSpentTime = spentTimeHour.ToString() + ":0" +
                                    spentTimeMinute.ToString() + ":0" + spentTimeSeconds.ToString();
                            }
                            else
                            {
                                timeSpentTime = spentTimeHour.ToString() + ":0" +
                                    spentTimeMinute.ToString() + ":" + spentTimeSeconds.ToString();
                            }
                        }
                        else
                        {
                            if (spentTimeSeconds < 10)
                            {
                                timeSpentTime = spentTimeHour.ToString() + ":" +
                                    spentTimeMinute.ToString() + ":0" + spentTimeSeconds.ToString();
                            }
                            else
                            {
                                timeSpentTime = spentTimeHour.ToString() + ":" +
                                    spentTimeMinute.ToString() + ":" + spentTimeSeconds.ToString();
                            }
                        }
                    }
                    userGridView.Rows.Add(enterDateSplit[0], readerThree[2].ToString(), readerThree[3].ToString(),
                        timeSpentTime, readerThree[4].ToString());
                    i += 1;
                }
                else
                {
                    string enterDate = readerThree[1].ToString();
                    string[] enterDateSplit = enterDate.Split(' ');
                    userGridView.Rows.Add(enterDateSplit[0], readerThree[2].ToString(), "**",
                        "**", readerThree[4].ToString());
                    countCrash += 1;
                    i += 1;
                }
                crashLabel.Text = "Number of crashes: " + countCrash.ToString();
                PaintRow();
            }
            readerThree.Close();
            connection_to_datebase.Close();
        }
        private void PaintRow() //complete
        {
            foreach (DataGridViewRow row in userGridView.Rows)
            {
                if (row.Cells[4].Value.ToString() != "")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
    }
}
