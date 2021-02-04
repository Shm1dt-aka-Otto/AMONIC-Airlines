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
    public partial class ManageFlight : Form
    {
        string state = "";
        bool buttonApplyPress = false;
        public ManageFlight()
        {
            InitializeComponent();
        }
        private void Aircraft_Load(object sender, EventArgs e) //complete
        {
            fromBox.SelectedIndex = 0;
            toBox.SelectedIndex = 0;
            string connection_to_server = "server = localhost; user id = root; password = As89149625780@;" +
                "persistsecurityinfo = True; database = amonic-airlines";
            MySqlConnection connection_to_database = new MySqlConnection(connection_to_server);
            connection_to_database.Open();
            string sqlOne = "SELECT IATACode from airports";
            MySqlCommand commandOne = new MySqlCommand(sqlOne, connection_to_database);
            MySqlDataReader readerOne = commandOne.ExecuteReader();
            while (readerOne.Read())
            {
                fromBox.Items.Add(readerOne[0].ToString());
                toBox.Items.Add(readerOne[0].ToString());
            }
            fromBox.Items.RemoveAt(1);
            toBox.Items.RemoveAt(1);
            readerOne.Close();
            connection_to_database.Close();
        }
        private void CheckAllBox() //complete
        {
            if (fromBox.Text != "[ Airport list ]")
            {
                state = "air1.IATACode = '" + fromBox.Text + "'";
            }
            if (toBox.Text != "[ Airport list ]" && state != "")
            {
                state = state + " AND air2.IATACode = '" + toBox.Text + "'";
            }
            else if (toBox.Text != "[ Airport list ]" && state == "")
            {
                state = "air2.IATACode = '" + toBox.Text + "'";
            }
            if (outboundBox.Text != "    -  -" && state != "")
            {
                state = state + " AND `Date` = '" + outboundBox.Text + "'";
            }
            else if (outboundBox.Text != "    -  -" && state == "")
            {
                state = "`Date` = '" + outboundBox.Text + "'";
            }
            if (flightNumberBox.Text != "" && state != "")
            {
                state = state + " AND FlightNumber = '" + flightNumberBox.Text + "'";
            }
            else if (flightNumberBox.Text != "" && state == "")
            {
                state = "FlightNumber = '" + flightNumberBox.Text + "'";
            }
            if (state != "")
            {
                state = "WHERE " + state;
                if (sortBox.Text == "Date-Time")
                {
                    state = state + " order by `Date`, `Time`";
                }
                else if (sortBox.Text == "Price-Econom")
                {
                    state = state + " order by EconomyPrice";
                }
                else
                {
                    state = state + " order by Confirmed";
                }
            }
            else
            {
                if (sortBox.Text == "Date-Time")
                {
                    state = "order by `Date`, `Time`";
                }
                else if (sortBox.Text == "Price-Econom")
                {
                    state = "order by EconomyPrice";
                }
                else
                {
                    state = "order by Confirmed";
                }
            }
        }
        private void UpdateRow() //complete
        {
            string connection_to_server = "server = localhost; user id = root; password = As89149625780@;" +
                "persistsecurityinfo = True; database = amonic-airlines";
            MySqlConnection connection_to_database = new MySqlConnection(connection_to_server);
            connection_to_database.Open();
            CheckAllBox();
            string sqlTwo = "select `Date`, `Time`, air1.IATACode as `From`, air2.IATACode as `To`, " +
                "FlightNumber, aircrafts.`Name`, EconomyPrice, Confirmed " +
                "from schedules join aircrafts on (aircrafts.ID = AircraftID) " +
                "join routes rou on (rou.ID = RouteID) " +
                "inner join airports air1 on (rou.DepartureAirportID = air1.ID) " +
                "inner join airports air2 on (rou.ArrivalAirportID = air2.ID) " + state;
            MySqlCommand commandTwo = new MySqlCommand(sqlTwo, connection_to_database);
            MySqlDataReader readerTwo = commandTwo.ExecuteReader();
            while (readerTwo.Read())
            {
                string date = readerTwo[0].ToString();
                string[] dateSplit = date.Split(' ');
                string price = readerTwo[6].ToString();
                double economPrice = Math.Round(Convert.ToDouble(price), 0);
                double bisinessPrice = Math.Round(Convert.ToDouble(economPrice + economPrice * 0.35), 0);
                double firstClassPrice = Math.Round(Convert.ToDouble(bisinessPrice + bisinessPrice * 0.3), 0);
                manageGridView.Rows.Add(dateSplit[0], readerTwo[1].ToString(), readerTwo[2].ToString(),
                    readerTwo[3].ToString(), readerTwo[4].ToString(), readerTwo[5].ToString(),
                    economPrice, bisinessPrice, firstClassPrice, readerTwo[7].ToString());
            }
            readerTwo.Close();
            connection_to_database.Close();
            state = "";
            return;
        }
        private void cancelFlightButton_Click(object sender, EventArgs e) //complete
        {
            if (buttonApplyPress == false)
            {
                return;
            }
            string date = manageGridView.CurrentRow.Cells[0].Value.ToString();
            string[] dateSplit = date.Split('.');
            string dateToCancel = dateSplit[2] + "-" + dateSplit[1] + "-" + dateSplit[0];
            string time = manageGridView.CurrentRow.Cells[1].Value.ToString();
            string confirm = "";
            string connection_to_server = "server=localhost;user=root;database=amonic-airlines;" +
                "password=As89149625780@;";
            MySqlConnection connection_to_database = new MySqlConnection(connection_to_server);
            connection_to_database.Open();
            string sqlThree = "SELECT `Date`, `Time`, Confirmed FROM schedules WHERE `Date` = '" +
                dateToCancel + "' AND `Time` = '" +
                manageGridView.CurrentRow.Cells[1].Value.ToString() + "'";
            MySqlCommand commandThree = new MySqlCommand(sqlThree, connection_to_database);
            MySqlDataReader readerThree = commandThree.ExecuteReader();
            while (readerThree.Read())
            {
                confirm = readerThree[2].ToString();
            }
            readerThree.Close();
            if (confirm == "True")
            {
                string queryOne = "UPDATE schedules SET Confirmed = 0 WHERE `Date` = '" + dateToCancel +
                    "' AND `Time` = '" + time + "'";
                MySqlCommand commandFour = new MySqlCommand(queryOne, connection_to_database);
                commandFour.ExecuteNonQuery();
                connection_to_database.Close();
            }
            else if (confirm == "False")
            {
                string queryOne = "UPDATE schedules SET Confirmed = 1 WHERE `Date` = '" + dateToCancel +
                    "' AND `Time` = '" + time + "'";
                MySqlCommand commandFour = new MySqlCommand(queryOne, connection_to_database);
                commandFour.ExecuteNonQuery();
                connection_to_database.Close();
            }
            applyButton_Click(sender, e);
        }
        private void editFlightButton_Click(object sender, EventArgs e) //complete
        {
            if (buttonApplyPress == false)
            {
                return;
            }
            string date = manageGridView.CurrentRow.Cells[0].Value.ToString();
            string[] dateSplit = date.Split('.');
            string dateToEdit = dateSplit[2] + "-" + dateSplit[1] + "-" + dateSplit[0];
            string time = manageGridView.CurrentRow.Cells[1].Value.ToString();
            string departure = manageGridView.CurrentRow.Cells[2].Value.ToString();
            string arrival = manageGridView.CurrentRow.Cells[3].Value.ToString();
            string aircraft = manageGridView.CurrentRow.Cells[5].Value.ToString();
            Schedule_edit edit = new Schedule_edit(departure, arrival, aircraft, dateToEdit, time);
            edit.ShowDialog();
            applyButton_Click(sender, e);
        }
        private void toBox_SelectedIndexChanged(object sender, EventArgs e) //complete
        {
            if (toBox.SelectedIndex == fromBox.SelectedIndex && toBox.SelectedIndex != 0)
            {
                DialogResult dialog = MessageBox.Show("Departure airport and Arrival airport" +
                    "must be different", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                toBox.SelectedIndex = 0;
            }
        }
        private void fromBox_SelectedIndexChanged(object sender, EventArgs e) //complete
        {
            if (fromBox.SelectedIndex == toBox.SelectedIndex && fromBox.SelectedIndex != 0)
            {
                DialogResult dialog = MessageBox.Show("Departure airport and Arrival airport" +
                    "must be different", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fromBox.SelectedIndex = 0;
            }
        }
        private void applyButton_Click(object sender, EventArgs e) //complete
        {
            if (outboundBox.Text != "    -  -")
            {
                string check = outboundBox.Text;
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
            if (buttonApplyPress == true)
            {
                manageGridView.Rows.Clear();
            }
            UpdateRow();
            foreach (DataGridViewRow row in manageGridView.Rows)
            {
                if (row.Cells[9].Value.ToString() == "False")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
            buttonApplyPress = true;
        }

        private void importChangesButton_Click(object sender, EventArgs e)
        {
            ApplyChanges changes = new ApplyChanges();
            changes.ShowDialog();
            applyButton_Click(sender, e);
        }
    }
}
