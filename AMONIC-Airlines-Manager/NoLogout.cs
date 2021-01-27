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
    public partial class NoLogout : Form
    {
        string idUserLogout, dateUserLogout, timeUserLogout;
        public NoLogout(string id, string enterDate, string enterTime) //complete
        {
            InitializeComponent();
            idUserLogout = id;
            dateUserLogout = enterDate;
            timeUserLogout = enterTime;
        }

        private void confirmButton_Click(object sender, EventArgs e) //complete
        {
            string connection_to_server = "server=localhost;user=root;" +
                "database=amonic-airlines;password=As89149625780@;";
            MySqlConnection connection_to_datebase = new MySqlConnection(connection_to_server);
            connection_to_datebase.Open();
            if (softwareRadioButton.Checked)
            {
                string queryOne = "UPDATE trecking SET Crash_report = '" +
                    reasonBox.Text + "', Crash_type = 'software crash', Logout_date = '0001-01-01' WHERE ID = " + idUserLogout;
                MySqlCommand commandOne = new MySqlCommand(queryOne, connection_to_datebase);
                commandOne.ExecuteNonQuery();
            }
            else if (systemRadioButton.Checked)
            {
                string queryTwo = "UPDATE trecking SET Crash_report = '" +
                       reasonBox.Text + "', Crash_type = 'system crash', Logout_date = '0001-01-01' WHERE ID = " + idUserLogout;
                MySqlCommand commandTwo = new MySqlCommand(queryTwo, connection_to_datebase);
                commandTwo.ExecuteNonQuery();
            }
            else if (softwareRadioButton.Checked == false && systemRadioButton.Checked == false)
            {
                DialogResult dialog = MessageBox.Show("You must fill every statements " +
                        "into fields",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            connection_to_datebase.Close();
            Close();
        }
        private void NoLogout_Load(object sender, EventArgs e) //complete
        {
            string[] dateSplit = dateUserLogout.Split(' ');
            string dateOfLogin = dateSplit[0];
            noLogoutLabel.Text = "No logout detected for your last login on " + dateOfLogin + " at " + timeUserLogout;
        }
    }
}
