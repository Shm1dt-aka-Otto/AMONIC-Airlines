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

namespace AMONIC_Airlines_2
{
    public partial class Schedule_edit : Form
    {
        string departureIATA, arrivalIATA, aircraft_name, date_fly, time_fly;
        public Schedule_edit(string departure, string arrival, string aircraft, string date, string time)
        {
            departureIATA = departure;
            arrivalIATA = arrival;
            aircraft_name = aircraft;
            date_fly = date;
            time_fly = time;
            InitializeComponent();
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void update_Click(object sender, EventArgs e)
        {
            if (dateBox.Text != "    -  -")
            {
                string check = dateBox.Text;
                string[] check_date = check.Split('-');
                string parse = check_date[2] + " " + check_date[1] + " " + check_date[0];
                if (check_date[1] == "02" && check_date[2] == "29")
                {
                    DialogResult dialog = MessageBox.Show("Incorrect date, there is no 29th of February in this year",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    try
                    {
                        DateTime.Parse(parse);
                    }
                    catch (Exception)
                    {
                        DialogResult dialog = MessageBox.Show("Something wrong! Check:\n" +
                            "1) Date format must be yyyy-mm-dd\n" +
                            "2) Date must be correct",
                            "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            if (timeBox.Text != "    -  -")
            {
                string check = timeBox.Text;
                string[] check_time = check.Split(':');
                if (Convert.ToInt32(check_time[0]) > 23 || Convert.ToInt32(check_time[1]) > 59 ||
                    Convert.ToInt32(check_time[2]) > 59)
                {
                    DialogResult dialog = MessageBox.Show("Something wrong! Check:\n" +
                        "1) Time format must be hh::mm:ss\n" +
                        "2) Time must be correct",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            string connection_to_server = "server=localhost;user=root;database=amonic-airlines;" +
                "password=As89149625780@;";
            MySqlConnection connection_to_database = new MySqlConnection(connection_to_server);
            connection_to_database.Open();
            string queryOne = "UPDATE schedules SET `Date` = '" + dateBox.Text + "', `Time` = '" + timeBox.Text +
                "', EconomyPrice = '" + priceBox.Text + "' WHERE `Date` = '" + date_fly + "' AND `Time` = '" + time_fly + "'";
            MySqlCommand commandOne = new MySqlCommand(queryOne, connection_to_database);
            commandOne.ExecuteNonQuery();
            connection_to_database.Close();
            Close();
        }
        private void Schedule_edit_Load(object sender, EventArgs e)
        {
            fromIATALabel.Text = departureIATA;
            toIATALabel.Text = arrivalIATA;
            aircraftNameLabel.Text = aircraft_name;
        }
    }
}
