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
    public partial class Aircraft : Form
    {
        string state = "";
        bool pressed = false;
        string item = "";
        public Aircraft()
        {
            InitializeComponent();
        }
        private void outbound_Click(object sender, EventArgs e)
        {
            outbound.Text = "";
        }
        private void flightnumber_Click(object sender, EventArgs e)
        {
            flightnumber.Text = "";
        }
        private void Aircraft_Load(object sender, EventArgs e)
        {
            from.SelectedIndex = 0;
            to.SelectedIndex = 0;
            string conStr = "server = localhost; user id = root; password = As89149625780@;" +
                "persistsecurityinfo = True; database = session2_xx";
            MySqlConnection connection = new MySqlConnection(conStr);
            connection.Open();
            string sql = "SELECT IATACode from airports";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                from.Items.Add(reader[0].ToString());
                to.Items.Add(reader[0].ToString());
            }
            connection.Close();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "session2_xxDataSet1.airports". При необходимости она может быть перемещена или удалена.
            this.airportsTableAdapter.Fill(this.session2_xxDataSet1.airports);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "session2_xxDataSet1.aircrafts". При необходимости она может быть перемещена или удалена.
            this.aircraftsTableAdapter.Fill(this.session2_xxDataSet1.aircrafts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "session2_xxDataSet.schedules". При необходимости она может быть перемещена или удалена.
            this.schedulesTableAdapter.Fill(this.session2_xxDataSet.schedules);
        }
        private void SQL()
        {
            string fromm = from.Text;
            string too = to.Text;
            string outboundd = outbound.Text;
            string flightnum = flightnumber.Text;
            string order = sortby.Text;
            if (fromm != "[ Airport list ]")
            {
                if (too != "[ Airport list ]")
                {
                    if (outboundd != "")
                    {
                        if (flightnum != "")
                        {
                            if (order == "Date-Time")
                            {
                                state = "WHERE air1.IATACode = '" + fromm + "' AND air2.IATACode = '" + 
                                    too + "' AND `Date` = '" + outboundd + "' AND " +
                                    "FlightNumber = '" + flightnum + "' order by `Date`, `Time` asc";
                            }
                            else if (order == "Price-Econom")
                            {
                                state = "WHERE air1.IATACode = '" + fromm + "' AND air2.IATACode = '" +
                                    too + "' AND `Date` = '" + outboundd + "' AND " +
                                    "FlightNumber = '" + flightnum + "' order by EconomyPrice asc";
                            }
                            else
                            {
                                state = "WHERE air1.IATACode = '" + fromm + "' AND air2.IATACode = '" +
                                    too + "' AND `Date` = '" + outboundd + "' AND " +
                                    "FlightNumber = '" + flightnum + "' order by Confirmed asc";
                            }
                        }
                        else
                        {
                            if (order == "Date-Time")
                            {
                                state = "WHERE air1.IATACode = '" + fromm + "' AND air2.IATACode = '" +
                                    too + "' AND `Date` = '" + outboundd + "' order by `Date`, `Time` asc";
                            }
                            else if (order == "Price-Econom")
                            {
                                state = "WHERE air1.IATACode = '" + fromm + "' AND air2.IATACode = '" +
                                    too + "' AND `Date` = '" + outboundd + "' order by EconomyPrice asc";
                            }
                            else
                            {
                                state = "WHERE air1.IATACode = '" + fromm + "' AND air2.IATACode = '" +
                                    too + "' AND `Date` = '" + outboundd + "' order by Confirmed asc";
                            }
                        }
                    }
                    else
                    {
                        if (flightnum != "")
                        {
                            if (order == "Date-Time")
                            {
                                state = "WHERE air1.IATACode = '" + fromm + "' AND air2.IATACode = '" +
                                    too + "' AND " +
                                    "FlightNumber = '" + flightnum + "' order by `Date`, `Time` asc";
                            }
                            else if (order == "Price-Econom")
                            {
                                state = "WHERE air1.IATACode = '" + fromm + "' AND air2.IATACode = '" +
                                    too + "' AND " +
                                    "FlightNumber = '" + flightnum + "' order by EconomyPrice asc";
                            }
                            else
                            {
                                state = "WHERE air1.IATACode = '" + fromm + "' AND air2.IATACode = '" +
                                    too + "' AND " +
                                    "FlightNumber = '" + flightnum + "' order by Confirmed asc";
                            }
                        }
                        else
                        {
                            if (order == "Date-Time")
                            {
                                state = "WHERE air1.IATACode = '" + fromm + "' AND air2.IATACode = '" +
                                    too + "' order by `Date`, `Time` asc";
                            }
                            else if (order == "Price-Econom")
                            {
                                state = "WHERE air1.IATACode = '" + fromm + "' AND air2.IATACode = '" +
                                    too + "' order by EconomyPrice asc";
                            }
                            else
                            {
                                state = "WHERE air1.IATACode = '" + fromm + "' AND air2.IATACode = '" +
                                    too + "' order by Confirmed asc";
                            }
                        }
                    }
                }
                else
                {
                    if (outboundd != "")
                    {
                        if (flightnum != "")
                        {
                            if (order == "Date-Time")
                            {
                                state = "WHERE air1.IATACode = '" + fromm + "' AND `Date` = '" + outboundd + "' AND " +
                                    "FlightNumber = '" + flightnum + "' order by `Date`, `Time` asc";
                            }
                            else if (order == "Price-Econom")
                            {
                                state = "WHERE air1.IATACode = '" + fromm + "' AND `Date` = '" + outboundd + "' AND " +
                                    "FlightNumber = '" + flightnum + "' order by EconomyPrice asc";
                            }
                            else
                            {
                                state = "WHERE air1.IATACode = '" + fromm + "' AND `Date` = '" + outboundd + "' AND " +
                                    "FlightNumber = '" + flightnum + "' order by Confirmed asc";
                            }
                        }
                        else
                        {
                            if (order == "Date-Time")
                            {
                                state = "WHERE air1.IATACode = '" + fromm + "' AND `Date` = '" + outboundd + 
                                    "' order by `Date`, `Time` asc";
                            }
                            else if (order == "Price-Econom")
                            {
                                state = "WHERE air1.IATACode = '" + fromm + "' AND `Date` = '" + outboundd + 
                                    "' order by EconomyPrice asc";
                            }
                            else
                            {
                                state = "WHERE air1.IATACode = '" + fromm + "' AND `Date` = '" + outboundd + 
                                    "' order by Confirmed asc";
                            }
                        }
                    }
                    else
                    {
                        if (flightnum != "")
                        {
                            if (order == "Date-Time")
                            {
                                state = "WHERE air1.IATACode = '" + fromm + "' AND " +
                                    "FlightNumber = '" + flightnum + "' order by `Date`, `Time` asc";
                            }
                            else if (order == "Price-Econom")
                            {
                                state = "WHERE air1.IATACode = '" + fromm + "' AND " +
                                    "FlightNumber = '" + flightnum + "' order by EconomyPrice asc";
                            }
                            else
                            {
                                state = "WHERE air1.IATACode = '" + fromm + "' AND " +
                                    "FlightNumber = '" + flightnum + "' order by Confirmed asc";
                            }
                        }
                        else
                        {
                            if (order == "Date-Time")
                            {
                                state = "WHERE air1.IATACode = '" + fromm + "' order by `Date`, `Time` asc";
                            }
                            else if (order == "Price-Econom")
                            {
                                state = "WHERE air1.IATACode = '" + fromm + "' order by EconomyPrice asc";
                            }
                            else
                            {
                                state = "WHERE air1.IATACode = '" + fromm + "' order by Confirmed asc";
                            }
                        }
                    }
                }
            }
            else
            {
                if (too != "[ Airport list ]")
                {
                    if (outboundd != "")
                    {
                        if (flightnum != "")
                        {
                            if (order == "Date-Time")
                            {
                                state = "WHERE air2.IATACode = '" +
                                    too + "' AND `Date` = '" + outboundd + "' AND " +
                                    "FlightNumber = '" + flightnum + "' order by `Date`, `Time` asc";
                            }
                            else if (order == "Price-Econom")
                            {
                                state = "WHERE air2.IATACode = '" +
                                    too + "' AND `Date` = '" + outboundd + "' AND " +
                                    "FlightNumber = '" + flightnum + "' order by EconomyPrice asc";
                            }
                            else
                            {
                                state = "WHERE air2.IATACode = '" +
                                    too + "' AND `Date` = '" + outboundd + "' AND " +
                                    "FlightNumber = '" + flightnum + "' order by Confirmed asc";
                            }
                        }
                        else
                        {
                            if (order == "Date-Time")
                            {
                                state = "WHERE air2.IATACode = '" +
                                    too + "' AND `Date` = '" + outboundd + "' order by `Date`, `Time` asc";
                            }
                            else if (order == "Price-Econom")
                            {
                                state = "WHERE air2.IATACode = '" +
                                    too + "' AND `Date` = '" + outboundd + "' order by EconomyPrice asc";
                            }
                            else
                            {
                                state = "WHERE air2.IATACode = '" +
                                    too + "' AND `Date` = '" + outboundd + "' order by Confirmed asc";
                            }
                        }
                    }
                    else
                    {
                        if (flightnum != "")
                        {
                            if (order == "Date-Time")
                            {
                                state = "WHERE air2.IATACode = '" + too + "' AND " +
                                    "FlightNumber = '" + flightnum + "' order by `Date`, `Time` asc";
                            }
                            else if (order == "Price-Econom")
                            {
                                state = "WHERE air2.IATACode = '" + too + "' AND " +
                                    "FlightNumber = '" + flightnum + "' order by EconomyPrice asc";
                            }
                            else
                            {
                                state = "WHERE air2.IATACode = '" + too + "' AND " +
                                    "FlightNumber = '" + flightnum + "' order by Confirmed asc";
                            }
                        }
                        else
                        {
                            if (order == "Date-Time")
                            {
                                state = "WHERE air2.IATACode = '" + too + "' order by `Date`, `Time` asc";
                            }
                            else if (order == "Price-Econom")
                            {
                                state = "WHERE air2.IATACode = '" + too + "' order by EconomyPrice asc";
                            }
                            else
                            {
                                state = "WHERE air2.IATACode = '" + too + "' order by Confirmed asc";
                            }
                        }
                    }
                }
                else
                {
                    if (outboundd != "")
                    {
                        if (flightnum != "")
                        {
                            if (order == "Date-Time")
                            {
                                state = "WHERE `Date` = '" + outboundd + "' AND " +
                                    "FlightNumber = '" + flightnum + "' order by `Date`, `Time` asc";
                            }
                            else if (order == "Price-Econom")
                            {
                                state = "WHERE `Date` = '" + outboundd + "' AND " +
                                    "FlightNumber = '" + flightnum + "' order by EconomyPrice asc";
                            }
                            else
                            {
                                state = "WHERE `Date` = '" + outboundd + "' AND " +
                                    "FlightNumber = '" + flightnum + "' order by Confirmed asc";
                            }
                        }
                        else
                        {
                            if (order == "Date-Time")
                            {
                                state = "WHERE `Date` = '" + outboundd + "' order by `Date`, `Time` asc";
                            }
                            else if (order == "Price-Econom")
                            {
                                state = "WHERE `Date` = '" + outboundd + "' order by EconomyPrice asc";
                            }
                            else
                            {
                                state = "WHERE `Date` = '" + outboundd + "' order by Confirmed asc";
                            }
                        }
                    }
                    else
                    {
                        if (flightnum != "")
                        {
                            if (order == "Date-Time")
                            {
                                state = "WHERE FlightNumber = '" + flightnum + "' order by `Date`, `Time` asc";
                            }
                            else if (order == "Price-Econom")
                            {
                                state = "WHERE FlightNumber = '" + flightnum + "' order by EconomyPrice asc";
                            }
                            else
                            {
                                state = "WHERE FlightNumber = '" + flightnum + "' order by Confirmed asc";
                            }
                        }
                        else
                        {
                            if (order == "Date-Time")
                            {
                                state = "order by `Date`, `Time` asc";
                            }
                            else if (order == "Price-Econom")
                            {
                                state = "order by EconomyPrice asc";
                            }
                            else
                            {
                                state = "order by Confirmed asc";
                            }
                        }
                    }
                }
            }
        }
        private void UpdateRow()
        {
            string conStr = "server = localhost; user id = root; password = As89149625780@;" +
                "persistsecurityinfo = True; database = session2_xx";
            MySqlConnection connection = new MySqlConnection(conStr);
            connection.Open();
            SQL();
            string sql = "select `Date`, `Time`, air1.IATACode as `From`, air2.IATACode as `To`, " +
                "FlightNumber, aircrafts.`Name`, EconomyPrice, Confirmed " +
                "from schedules join aircrafts on (aircrafts.ID = AircraftID) " +
                "join routes rou on (rou.ID = RouteID) " +
                "inner join airports air1 on (rou.DepartureAirportID = air1.ID) " +
                "inner join airports air2 on (rou.ArrivalAirportID = air2.ID) " + state;
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string s = reader[0].ToString();
                string[] sp = s.Split(' ');
                string m = reader[6].ToString();
                int eco = Convert.ToInt32(m);
                int fi = Convert.ToInt32(eco + eco * 0.35);
                int bis = Convert.ToInt32(fi + fi * 0.3);
                dataGridView1.Rows.Add(sp[0], reader[1].ToString(), reader[2].ToString(),
                    reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), fi,
                    bis, reader[7].ToString());
            }
            connection.Close();
            return;
        }
        private void apply_Click(object sender, EventArgs e)
        {
            if (pressed == true)
            {
                dataGridView1.Rows.Clear();
            }
            UpdateRow();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[9].Value.ToString() == "False")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
            pressed = true;
        }
        private void to_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (to.SelectedIndex == from.SelectedIndex && to.SelectedIndex != 0)
            {
                DialogResult dialog = MessageBox.Show("Departure airport and Arrival airport" +
                    "must be different", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                to.SelectedIndex = 0;
            }
        }
        private void from_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (from.SelectedIndex == to.SelectedIndex && from.SelectedIndex != 0)
            {
                DialogResult dialog = MessageBox.Show("Departure airport and Arrival airport" +
                    "must be different", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                from.SelectedIndex = 0;
            }
        }
        private void cancelflight_Click(object sender, EventArgs e)
        {
            string date = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string[] d = date.Split('.');
            string d1 = d[2] + "-" + d[1] + "-" + d[0];
            string time = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string confirm = "";
            string connStr = "server=localhost;user=root;database=session2_xx;" +
                "password=As89149625780@;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "SELECT `Date`, `Time`, Confirmed FROM schedules WHERE `Date` = '" + 
                d1 + "' AND `Time` = '" + 
                dataGridView1.CurrentRow.Cells[1].Value.ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader readers = cmd.ExecuteReader();
            while (readers.Read())
            {
                confirm = readers[2].ToString();
            }
            readers.Close();
            if (confirm == "True")
            {
                string query = "UPDATE schedules SET Confirmed = 0 WHERE `Date` = '" + d1 +
                    "' AND `Time` = '" + time + "'";
                MySqlCommand commands = new MySqlCommand(query, conn);
                commands.ExecuteNonQuery();
                conn.Close();
            }
            else if (confirm == "False")
            {
                string query = "UPDATE schedules SET Confirmed = 1 WHERE `Date` = '" + d1 +
                    "' AND `Time` = '" + time + "'";
                MySqlCommand commands = new MySqlCommand(query, conn);
                commands.ExecuteNonQuery();
                conn.Close();
            }
            apply_Click(sender, e);
        }

        private void editflight_Click(object sender, EventArgs e)
        {
            string date = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string[] d = date.Split('.');
            string d1 = d[2] + "-" + d[1] + "-" + d[0];
            string time = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string departure = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string arrival = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string aircraft = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            Schedule_edit edit = new Schedule_edit(departure, arrival, aircraft, d1, time);
            edit.ShowDialog();
            apply_Click(sender, e);
        }
    }
}
