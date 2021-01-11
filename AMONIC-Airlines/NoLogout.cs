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
        string i, date, time;
        public NoLogout(string id, string enter_date, string enter_time)
        {
            InitializeComponent();
            i = id;
            date = enter_date;
            time = enter_time;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            string connection_to_server = "server=localhost;user=root;" +
                   "database=session1_xx;password=As89149625780@;";
            MySqlConnection connection_to_datebase = new MySqlConnection(connection_to_server);
            connection_to_datebase.Open();
            if (software.Checked)
            {
                string query = "UPDATE trecking SET Crash_report = '" +
                    reasonBox.Text + "', Crash_type = 'software crash' WHERE ID = " + i;
                MySqlCommand command = new MySqlCommand(query, connection_to_datebase);
                command.ExecuteNonQuery();
            }
            else if (sys.Checked)
            {
                string query = "UPDATE trecking SET Crash_report = '" +
                       reasonBox.Text + "', Crash_type = 'system crash' WHERE ID = " + i;
                MySqlCommand command = new MySqlCommand(query, connection_to_datebase);
                command.ExecuteNonQuery();
            }
            else if (software.Checked == false && sys.Checked == false)
            {
                DialogResult dialog = MessageBox.Show("You must fill every statements " +
                        "into fields",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            connection_to_datebase.Close();
            Close();
        }

        private void NoLogout_Load(object sender, EventArgs e)
        {
            string[] sp = date.Split(' ');
            string spp = sp[0];
            detect.Text = "No logout detected for your last login on " + spp + "at " + time;
        }
    }
}
