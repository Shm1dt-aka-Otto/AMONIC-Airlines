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

namespace AMONIC_Airlines_3
{
    public partial class SearchFlight : Form
    {
        string dateReturnBetweenBefore = "";
        string dateReturnBetweenAfter = "";
        string dateOutboundBetweenBefore = "";
        string dateOutboundBetweenAfter = "";
        string scheduleIdOutbound = "";
        string scheduleIdReturn = "";
        int totalAmount = 0;
        string idUser = "";
        public SearchFlight(string userId)
        {
            InitializeComponent();
            idUser = userId;
        }
        private void Searchflight_Load(object sender, EventArgs e)
        {
            fromBox.SelectedIndex = 0;
            toBox.SelectedIndex = 0;
            cabinBox.SelectedIndex = 0;
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
            connection_to_database.Close();
        }
        private void fromBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fromBox.SelectedIndex == toBox.SelectedIndex && fromBox.SelectedIndex != 0)
            {
                DialogResult dialog = MessageBox.Show("Departure airport and Arrival airport" +
                    "must be different", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fromBox.SelectedIndex = 0;
            }
        }
        private void toBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toBox.SelectedIndex == fromBox.SelectedIndex && toBox.SelectedIndex != 0)
            {
                DialogResult dialog = MessageBox.Show("Departure airport and Arrival airport" +
                    "must be different", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                toBox.SelectedIndex = 0;
            }
        }
        private void onewayButton_CheckedChanged(object sender, EventArgs e)
        {
            returnFlightLabel.Visible = false;
            returnGridView.Visible = false;
            returnCheck.Visible = false;
            returnLabel.Visible = false;
            returnText.Visible = false;
        }
        private void returnButton_CheckedChanged(object sender, EventArgs e)
        {
            returnFlightLabel.Visible = true;
            returnGridView.Visible = true;
            returnCheck.Visible = true;
            returnLabel.Visible = true;
            returnText.Visible = true;
        }
        private void bookButton_Click(object sender, EventArgs e)
        {
            totalAmount = 0;
            if (returnGridView.Visible == false)
            {
                if (fromBox.Text == "[ All airports ]" || toBox.Text == "[ All airports ]"
                    || outboundText.Text == "    -  -")
                {
                    DialogResult dialog = MessageBox.Show("All fields must be filled!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int selectedIndex = 0;
                foreach (DataGridViewRow row in outboundGridView.SelectedRows)
                {
                    selectedIndex = row.Index;
                }
                string from = outboundGridView.Rows[selectedIndex].Cells[0].Value.ToString();
                string to = outboundGridView.Rows[selectedIndex].Cells[1].Value.ToString();
                string date = outboundGridView.Rows[selectedIndex].Cells[2].Value.ToString();
                string number = outboundGridView.Rows[selectedIndex].Cells[4].Value.ToString();
                string cabin = cabinBox.Text;
                if (passangerText.Text == "")
                {
                    DialogResult dialog = MessageBox.Show("Add number of passanger", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fromBox.SelectedIndex = 0;
                    return;
                }
                int passanger = Convert.ToInt32(passangerText.Text);
                totalAmount += Convert.ToInt32(outboundGridView.Rows[selectedIndex].Cells[5].Value);
                Bookingconfirmation book = new Bookingconfirmation(idUser, from, to, date, number, cabin, "", "",
                    "", "", passanger, totalAmount, scheduleIdOutbound, "");
                book.ShowDialog();
            }
            else
            {
                if (returnText.Text == "" || fromBox.Text == "[ All airports ]" ||
                   toBox.Text == "[ All airports ]" || outboundText.Text == "    -  -" ||
                   returnText.Text == "    -  -")
                {
                    DialogResult dialog = MessageBox.Show("All fields must be filled in!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int returnSelInd = 0;
                int outboundSelInd = 0;
                foreach (DataGridViewRow row in outboundGridView.SelectedRows)
                {
                    outboundSelInd = row.Index;
                }
                foreach (DataGridViewRow row in returnGridView.SelectedRows)
                {
                    returnSelInd = row.Index;
                }
                string fromOutbound = outboundGridView.Rows[outboundSelInd].Cells[0].Value.ToString();
                string toOutbound = outboundGridView.Rows[outboundSelInd].Cells[1].Value.ToString();
                string dateOutbound = outboundGridView.Rows[outboundSelInd].Cells[2].Value.ToString();
                string numberOutbound = outboundGridView.Rows[outboundSelInd].Cells[4].Value.ToString();
                string cabin = cabinBox.Text;
                string fromReturn = returnGridView.Rows[returnSelInd].Cells[0].Value.ToString();
                string toReturn = returnGridView.Rows[returnSelInd].Cells[1].Value.ToString();
                string dateReturn = returnGridView.Rows[returnSelInd].Cells[2].Value.ToString();
                string numberReturn = returnGridView.Rows[returnSelInd].Cells[4].Value.ToString();
                if (passangerText.Text == "")
                {
                    DialogResult dialog = MessageBox.Show("Add number of passanger", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fromBox.SelectedIndex = 0;
                    return;
                }
                int passanger = Convert.ToInt32(passangerText.Text);
                totalAmount += Convert.ToInt32(outboundGridView.Rows[returnSelInd].Cells[5].Value);
                totalAmount += Convert.ToInt32(returnGridView.Rows[returnSelInd].Cells[5].Value);
                Bookingconfirmation book = new Bookingconfirmation(idUser, fromOutbound, toOutbound, dateOutbound,
                    numberOutbound, cabin, fromReturn, toReturn, dateReturn, numberReturn, passanger
                    , totalAmount, scheduleIdOutbound, scheduleIdReturn);
                book.ShowDialog();
            }
        }
        private void applyButton_Click(object sender, EventArgs e)
        {
            if (returnButton.Checked)
            {
                outboundGridView.Rows.Clear();
                returnGridView.Rows.Clear();
                if (returnText.Text == "" || fromBox.Text == "[ All airports ]" ||
                    toBox.Text == "[ All airports ]" || outboundText.Text == "    -  -" || 
                    returnText.Text == "    -  -")
                {
                    DialogResult dialog = MessageBox.Show("All fields must be filled in!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (outboundText.Text != "    -  -")
                {
                    string check = outboundText.Text;
                    string[] check_date = check.Split('-');
                    string parse = check_date[2] + " " + check_date[1] + " " + check_date[0];
                    if (check_date[1] == "02" && check_date[2] == "29")
                    {
                        DialogResult dialog = MessageBox.Show("Incorrect outbound date, there is no 29th of " +
                            "February in this year",
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
                                "1) Outbound date format must be yyyy-mm-dd\n" +
                                "2) Outbound date must be correct",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                else if (returnText.Text != "    -  -")
                {
                    string check = returnText.Text;
                    string[] check_date = check.Split('-');
                    string parse = check_date[2] + " " + check_date[1] + " " + check_date[0];
                    if (check_date[1] == "02" && check_date[2] == "29")
                    {
                        DialogResult dialog = MessageBox.Show("Incorrect return date, there is no 29th of " +
                            "February in this year",
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
                                "1) Return date format must be yyyy-mm-dd\n" +
                                "2) Return date must be correct",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                if (returnText.Text != "" && fromBox.Text != "[ All airports ]" &&
                    toBox.Text != "[ All airports ]" && outboundText.Text != "    -  -" &&
                    returnText.Text != "    -  -")
                {
                    if (returnCheck.Checked == true && outboundCheck.Checked == true)
                    {
                        outboundGridView.Columns[0].Width = 81;
                        outboundGridView.Columns[1].Width = 81;
                        returnGridView.Columns[0].Width = 81;
                        returnGridView.Columns[1].Width = 81;
                        string connection_to_server = "server = localhost; user id = root; password = As89149625780@;" +
                        "persistsecurityinfo = True; database = amonic-airlines";
                        MySqlConnection connection_to_database = new MySqlConnection(connection_to_server);
                        connection_to_database.Open();
                        string dateReturn = returnText.Text;
                        string[] dateReturnSplit = dateReturn.Split('-');
                        DateTime dateReturnBefore = new DateTime(Convert.ToInt32(dateReturnSplit[0]),
                            Convert.ToInt32(dateReturnSplit[1]), Convert.ToInt32(dateReturnSplit[2]), 0, 0, 0);
                        DateTime dateReturnAfter = new DateTime(Convert.ToInt32(dateReturnSplit[0]),
                            Convert.ToInt32(dateReturnSplit[1]), Convert.ToInt32(dateReturnSplit[2]), 0, 0, 0);
                        dateReturnBetweenBefore = dateReturnBefore.AddDays(-3).ToShortDateString();
                        dateReturnBetweenAfter = dateReturnAfter.AddDays(3).ToShortDateString();
                        string dateOutbound = outboundText.Text;
                        string[] dateOutboundSplit = dateOutbound.Split('-');
                        DateTime dateOutboundBefore = new DateTime(Convert.ToInt32(dateOutboundSplit[0]),
                            Convert.ToInt32(dateOutboundSplit[1]), Convert.ToInt32(dateOutboundSplit[2]), 0, 0, 0);
                        DateTime dateOutboundAfter = new DateTime(Convert.ToInt32(dateOutboundSplit[0]),
                            Convert.ToInt32(dateOutboundSplit[1]), Convert.ToInt32(dateOutboundSplit[2]), 0, 0, 0);
                        dateOutboundBetweenBefore = dateOutboundBefore.AddDays(-3).ToShortDateString();
                        dateOutboundBetweenAfter = dateOutboundAfter.AddDays(3).ToShortDateString();
                        string[] dateBeforeOutbound = dateOutboundBetweenBefore.Split('.');
                        string[] dateAfterOutbound = dateOutboundBetweenAfter.Split('.');
                        string[] dateBeforeReturn = dateReturnBetweenBefore.Split('.');
                        string[] dateAfterReturn = dateReturnBetweenAfter.Split('.');
                        string realOutboundBefore = dateBeforeOutbound[2] + dateBeforeOutbound[1] +
                            dateBeforeOutbound[0];
                        string realOutboundAfter = dateAfterOutbound[2] + dateAfterOutbound[1] +
                            dateAfterOutbound[0];
                        string realReturnBefore = dateBeforeReturn[2] + dateBeforeReturn[1] +
                            dateBeforeReturn[0];
                        string realReturnAfter = dateAfterReturn[2] + dateAfterReturn[1] +
                            dateAfterReturn[0];
                        string sqlTwo = "select air1.IATACode as `From`, air2.IATACode as `To`, " +
                        "`Date`, `Time`, FlightNumber, EconomyPrice, schedules.ID " +
                        "from schedules join routes rou on (rou.ID = RouteID) " +
                        "inner join airports air1 on (rou.DepartureAirportID = air1.ID) " +
                        "inner join airports air2 on (rou.ArrivalAirportID = air2.ID) where air1.IATACode = '" +
                        fromBox.Text + "' and air2.IATACode = '" + toBox.Text + "' and `Date` BETWEEN '" +
                        realOutboundBefore + "' AND '" + realOutboundAfter + "'";
                        MySqlCommand commandTwo = new MySqlCommand(sqlTwo, connection_to_database);
                        MySqlDataReader readerTwo = commandTwo.ExecuteReader();
                        while (readerTwo.Read())
                        {
                            scheduleIdOutbound = readerTwo[6].ToString();
                            string date = readerTwo[2].ToString();
                            string[] dateSplit = date.Split(' ');
                            string price = readerTwo[5].ToString();
                            double economyPrice = Math.Round(Convert.ToDouble(price), 0);
                            double bisinessPrice = Math.Round(Convert.ToDouble(economyPrice + economyPrice * 0.35), 0);
                            double firstClassPrice = Math.Round(Convert.ToDouble(bisinessPrice + bisinessPrice * 0.3), 0);
                            if (cabinBox.Text == "Economy")
                            {
                                outboundGridView.Rows.Add(readerTwo[0].ToString(), readerTwo[1].ToString(), dateSplit[0],
                                    readerTwo[3].ToString(), readerTwo[4].ToString(), economyPrice, 0);
                            }
                            else if (cabinBox.Text == "Business")
                            {
                                outboundGridView.Rows.Add(readerTwo[0].ToString(), readerTwo[1].ToString(), dateSplit[0],
                                    readerTwo[3].ToString(), readerTwo[4].ToString(), bisinessPrice, 0);
                            }
                            else
                            {
                                outboundGridView.Rows.Add(readerTwo[0].ToString(), readerTwo[1].ToString(), dateSplit[0],
                                    readerTwo[3].ToString(), readerTwo[4].ToString(), firstClassPrice, 0);
                            }
                        }
                        readerTwo.Close();
                        string sqlThree = "select air1.IATACode as `From`, air2.IATACode as `To`, " +
                        "`Date`, `Time`, FlightNumber, EconomyPrice, schedules.ID " +
                        "from schedules join routes rou on (rou.ID = RouteID) " +
                        "inner join airports air1 on (rou.DepartureAirportID = air1.ID) " +
                        "inner join airports air2 on (rou.ArrivalAirportID = air2.ID) where air2.IATACode = '" +
                        fromBox.Text + "' and air1.IATACode = '" + toBox.Text + "' and `Date` BETWEEN '" +
                        realReturnBefore + "' AND '" + realReturnAfter + "'";
                        MySqlCommand commandThree = new MySqlCommand(sqlThree, connection_to_database);
                        MySqlDataReader readerThree = commandThree.ExecuteReader();
                        while (readerThree.Read())
                        {
                            scheduleIdReturn = readerThree[6].ToString();
                            string date = readerThree[2].ToString();
                            string[] dateSplit = date.Split(' ');
                            string price = readerThree[5].ToString();
                            double economyPrice = Math.Round(Convert.ToDouble(price), 0);
                            double bisinessPrice = Math.Round(Convert.ToDouble(economyPrice + economyPrice * 0.35), 0);
                            double firstClassPrice = Math.Round(Convert.ToDouble(bisinessPrice + bisinessPrice * 0.3), 0);
                            if (cabinBox.Text == "Economy")
                            {
                                returnGridView.Rows.Add(readerThree[0].ToString(), readerThree[1].ToString(), dateSplit[0],
                                    readerThree[3].ToString(), readerThree[4].ToString(), economyPrice, 0);
                            }
                            else if (cabinBox.Text == "Business")
                            {
                                returnGridView.Rows.Add(readerThree[0].ToString(), readerThree[1].ToString(), dateSplit[0],
                                    readerThree[3].ToString(), readerThree[4].ToString(), bisinessPrice, 0);
                            }
                            else
                            {
                                returnGridView.Rows.Add(readerThree[0].ToString(), readerThree[1].ToString(), dateSplit[0],
                                    readerThree[3].ToString(), readerThree[4].ToString(), firstClassPrice, 0);
                            }
                        }
                        readerThree.Close();
                        connection_to_database.Close();
                        return;
                    }
                    if (returnCheck.Checked == false && outboundCheck.Checked == true)
                    {
                        outboundGridView.Columns[0].Width = 81;
                        outboundGridView.Columns[1].Width = 81;
                        returnGridView.Columns[0].Width = 81;
                        returnGridView.Columns[1].Width = 81;
                        string connection_to_server = "server = localhost; user id = root; password = As89149625780@;" +
                        "persistsecurityinfo = True; database = amonic-airlines";
                        MySqlConnection connection_to_database = new MySqlConnection(connection_to_server);
                        connection_to_database.Open();
                        string dateOutbound = outboundText.Text;
                        string[] dateOutboundSplit = dateOutbound.Split('-');
                        DateTime dateOutboundBefore = new DateTime(Convert.ToInt32(dateOutboundSplit[0]),
                            Convert.ToInt32(dateOutboundSplit[1]), Convert.ToInt32(dateOutboundSplit[2]), 0, 0, 0);
                        DateTime dateOutboundAfter = new DateTime(Convert.ToInt32(dateOutboundSplit[0]),
                            Convert.ToInt32(dateOutboundSplit[1]), Convert.ToInt32(dateOutboundSplit[2]), 0, 0, 0);
                        dateOutboundBetweenBefore = dateOutboundBefore.AddDays(-3).ToShortDateString();
                        dateOutboundBetweenAfter = dateOutboundAfter.AddDays(3).ToShortDateString();
                        string[] dateBeforeOutbound = dateOutboundBetweenBefore.Split('.');
                        string[] dateAfterOutbound = dateOutboundBetweenAfter.Split('.');
                        string realOutboundBefore = dateBeforeOutbound[2] + dateBeforeOutbound[1] +
                            dateBeforeOutbound[0];
                        string realOutboundAfter = dateAfterOutbound[2] + dateAfterOutbound[1] +
                            dateAfterOutbound[0];
                        string sqlTwo = "select air1.IATACode as `From`, air2.IATACode as `To`, " +
                        "`Date`, `Time`, FlightNumber, EconomyPrice, schedules.ID " +
                        "from schedules join routes rou on (rou.ID = RouteID) " +
                        "inner join airports air1 on (rou.DepartureAirportID = air1.ID) " +
                        "inner join airports air2 on (rou.ArrivalAirportID = air2.ID) where air1.IATACode = '" +
                        fromBox.Text + "' and air2.IATACode = '" + toBox.Text + "' and `Date` BETWEEN '" +
                        realOutboundBefore + "' AND '" + realOutboundAfter + "'";
                        MySqlCommand commandTwo = new MySqlCommand(sqlTwo, connection_to_database);
                        MySqlDataReader readerTwo = commandTwo.ExecuteReader();
                        while (readerTwo.Read())
                        {
                            string date = readerTwo[2].ToString();
                            string[] dateSplit = date.Split(' ');
                            string price = readerTwo[5].ToString();
                            double economyPrice = Math.Round(Convert.ToDouble(price), 0);
                            double bisinessPrice = Math.Round(Convert.ToDouble(economyPrice + economyPrice * 0.35), 0);
                            double firstClassPrice = Math.Round(Convert.ToDouble(bisinessPrice + bisinessPrice * 0.3), 0);
                            if (cabinBox.Text == "Economy")
                            {
                                outboundGridView.Rows.Add(readerTwo[0].ToString(), readerTwo[1].ToString(), dateSplit[0],
                                    readerTwo[3].ToString(), readerTwo[4].ToString(), economyPrice, 0);
                            }
                            else if (cabinBox.Text == "Business")
                            {
                                outboundGridView.Rows.Add(readerTwo[0].ToString(), readerTwo[1].ToString(), dateSplit[0],
                                    readerTwo[3].ToString(), readerTwo[4].ToString(), bisinessPrice, 0);
                            }
                            else
                            {
                                outboundGridView.Rows.Add(readerTwo[0].ToString(), readerTwo[1].ToString(), dateSplit[0],
                                    readerTwo[3].ToString(), readerTwo[4].ToString(), firstClassPrice, 0);
                            }
                        }
                        readerTwo.Close();
                        string sqlThree = "select air1.IATACode as `From`, air1.IATACode as `To`, " +
                            "`Date`, `Time`, FlightNumber, EconomyPrice, schedules.ID " +
                            "from schedules join routes rou on (rou.ID = RouteID) " +
                            "inner join airports air1 on (rou.DepartureAirportID = air1.ID) " +
                            "inner join airports air2 on (rou.ArrivalAirportID = air2.ID) where air2.IATACode = '" +
                            fromBox.Text + "' and air1.IATACode = '" + toBox.Text + "' and `Date` = '" + returnText.Text + "'";
                        MySqlCommand commandThree = new MySqlCommand(sqlThree, connection_to_database);
                        MySqlDataReader readerThree = commandThree.ExecuteReader();
                        while (readerThree.Read())
                        {
                            scheduleIdReturn = readerThree[6].ToString();
                            string date = readerThree[2].ToString();
                            string[] dateSplit = date.Split(' ');
                            string price = readerThree[5].ToString();
                            double economyPrice = Math.Round(Convert.ToDouble(price), 0);
                            double bisinessPrice = Math.Round(Convert.ToDouble(economyPrice + economyPrice * 0.35), 0);
                            double firstClassPrice = Math.Round(Convert.ToDouble(bisinessPrice + bisinessPrice * 0.3), 0);
                            if (cabinBox.Text == "Economy")
                            {
                                returnGridView.Rows.Add(readerThree[0].ToString(), readerThree[1].ToString(), dateSplit[0],
                                    readerThree[3].ToString(), readerThree[4].ToString(), economyPrice, 0);
                            }
                            else if (cabinBox.Text == "Business")
                            {
                                returnGridView.Rows.Add(readerThree[0].ToString(), readerThree[1].ToString(), dateSplit[0],
                                    readerThree[3].ToString(), readerThree[4].ToString(), bisinessPrice, 0);
                            }
                            else
                            {
                                returnGridView.Rows.Add(readerThree[0].ToString(), readerThree[1].ToString(), dateSplit[0],
                                    readerThree[3].ToString(), readerThree[4].ToString(), firstClassPrice, 0);
                            }
                        }
                        readerThree.Close();
                        connection_to_database.Close();
                        return;
                    }
                    else if (returnCheck.Checked == true && outboundCheck.Checked == false)
                    {
                        outboundGridView.Columns[0].Width = 81;
                        outboundGridView.Columns[1].Width = 81;
                        returnGridView.Columns[0].Width = 81;
                        returnGridView.Columns[1].Width = 81;
                        string connection_to_server = "server = localhost; user id = root; password = As89149625780@;" +
                        "persistsecurityinfo = True; database = amonic-airlines";
                        MySqlConnection connection_to_database = new MySqlConnection(connection_to_server);
                        connection_to_database.Open();
                        string dateReturn = returnText.Text;
                        string[] dateReturnSplit = dateReturn.Split('-');
                        DateTime dateReturnBefore = new DateTime(Convert.ToInt32(dateReturnSplit[0]),
                            Convert.ToInt32(dateReturnSplit[1]), Convert.ToInt32(dateReturnSplit[2]), 0, 0, 0);
                        DateTime dateReturnAfter = new DateTime(Convert.ToInt32(dateReturnSplit[0]),
                            Convert.ToInt32(dateReturnSplit[1]), Convert.ToInt32(dateReturnSplit[2]), 0, 0, 0);
                        dateReturnBetweenBefore = dateReturnBefore.AddDays(-3).ToShortDateString();
                        dateReturnBetweenAfter = dateReturnAfter.AddDays(3).ToShortDateString();
                        string[] dateBeforeReturn = dateReturnBetweenBefore.Split('.');
                        string[] dateAfterReturn = dateReturnBetweenAfter.Split('.');
                        string realReturnBefore = dateBeforeReturn[2] + dateBeforeReturn[1] +
                            dateBeforeReturn[0];
                        string realReturnAfter = dateAfterReturn[2] + dateAfterReturn[1] +
                            dateAfterReturn[0];
                        string sqlTwo = "select air1.IATACode as `From`, air2.IATACode as `To`, " +
                        "`Date`, `Time`, FlightNumber, EconomyPrice, schedules.ID " +
                        "from schedules join routes rou on (rou.ID = RouteID) " +
                        "inner join airports air1 on (rou.DepartureAirportID = air1.ID) " +
                        "inner join airports air2 on (rou.ArrivalAirportID = air2.ID) where air1.IATACode = '" +
                        fromBox.Text + "' and air2.IATACode = '" + toBox.Text + "' and `Date` = '" + outboundText.Text + "'";
                        MySqlCommand commandTwo = new MySqlCommand(sqlTwo, connection_to_database);
                        MySqlDataReader readerTwo = commandTwo.ExecuteReader();
                        while (readerTwo.Read())
                        {
                            scheduleIdOutbound = readerTwo[6].ToString();
                            string date = readerTwo[2].ToString();
                            string[] dateSplit = date.Split(' ');
                            string price = readerTwo[5].ToString();
                            double economyPrice = Math.Round(Convert.ToDouble(price), 0);
                            double bisinessPrice = Math.Round(Convert.ToDouble(economyPrice + economyPrice * 0.35), 0);
                            double firstClassPrice = Math.Round(Convert.ToDouble(bisinessPrice + bisinessPrice * 0.3), 0);
                            if (cabinBox.Text == "Economy")
                            {
                                outboundGridView.Rows.Add(readerTwo[0].ToString(), readerTwo[1].ToString(), dateSplit[0],
                                    readerTwo[3].ToString(), readerTwo[4].ToString(), economyPrice, 0);
                            }
                            else if (cabinBox.Text == "Business")
                            {
                                outboundGridView.Rows.Add(readerTwo[0].ToString(), readerTwo[1].ToString(), dateSplit[0],
                                    readerTwo[3].ToString(), readerTwo[4].ToString(), bisinessPrice, 0);
                            }
                            else
                            {
                                outboundGridView.Rows.Add(readerTwo[0].ToString(), readerTwo[1].ToString(), dateSplit[0],
                                    readerTwo[3].ToString(), readerTwo[4].ToString(), firstClassPrice, 0);
                            }
                        }
                        readerTwo.Close();
                        string sqlThree = "select air1.IATACode as `From`, air2.IATACode as `To`, " +
                        "`Date`, `Time`, FlightNumber, EconomyPrice, schedules.ID " +
                        "from schedules join routes rou on (rou.ID = RouteID) " +
                        "inner join airports air1 on (rou.DepartureAirportID = air1.ID) " +
                        "inner join airports air2 on (rou.ArrivalAirportID = air2.ID) where air2.IATACode = '" +
                        fromBox.Text + "' and air1.IATACode = '" + toBox.Text + "' and `Date` BETWEEN '" +
                        realReturnBefore + "' AND '" + realReturnAfter + "'";
                        MySqlCommand commandThree = new MySqlCommand(sqlThree, connection_to_database);
                        MySqlDataReader readerThree = commandThree.ExecuteReader();
                        while (readerThree.Read())
                        {
                            scheduleIdReturn = readerThree[6].ToString();
                            string date = readerThree[2].ToString();
                            string[] dateSplit = date.Split(' ');
                            string price = readerThree[5].ToString();
                            double economyPrice = Math.Round(Convert.ToDouble(price), 0);
                            double bisinessPrice = Math.Round(Convert.ToDouble(economyPrice + economyPrice * 0.35), 0);
                            double firstClassPrice = Math.Round(Convert.ToDouble(bisinessPrice + bisinessPrice * 0.3), 0);
                            if (cabinBox.Text == "Economy")
                            {
                                returnGridView.Rows.Add(readerThree[0].ToString(), readerThree[1].ToString(), dateSplit[0],
                                    readerThree[3].ToString(), readerThree[4].ToString(), economyPrice, 0);
                            }
                            else if (cabinBox.Text == "Business")
                            {
                                returnGridView.Rows.Add(readerThree[0].ToString(), readerThree[1].ToString(), dateSplit[0],
                                    readerThree[3].ToString(), readerThree[4].ToString(), bisinessPrice, 0);
                            }
                            else
                            {
                                returnGridView.Rows.Add(readerThree[0].ToString(), readerThree[1].ToString(), dateSplit[0],
                                    readerThree[3].ToString(), readerThree[4].ToString(), firstClassPrice, 0);
                            }
                        }
                        readerThree.Close();
                        connection_to_database.Close();
                        return;
                    }
                    else
                    {
                        outboundGridView.Columns[0].Width = 90;
                        outboundGridView.Columns[1].Width = 90;
                        returnGridView.Columns[0].Width = 90;
                        returnGridView.Columns[1].Width = 90;
                        string connection_to_server = "server = localhost; user id = root; password = As89149625780@;" +
                        "persistsecurityinfo = True; database = amonic-airlines";
                        MySqlConnection connection_to_database = new MySqlConnection(connection_to_server);
                        connection_to_database.Open();
                        string sqlTwo = "select air1.IATACode as `From`, air2.IATACode as `To`, " +
                        "`Date`, `Time`, FlightNumber, EconomyPrice, schedules.ID " +
                        "from schedules join routes rou on (rou.ID = RouteID) " +
                        "inner join airports air1 on (rou.DepartureAirportID = air1.ID) " +
                        "inner join airports air2 on (rou.ArrivalAirportID = air2.ID) where air1.IATACode = '" +
                        fromBox.Text + "' and air2.IATACode = '" + toBox.Text + "' and `Date` = '" + outboundText.Text + "'";
                        MySqlCommand commandTwo = new MySqlCommand(sqlTwo, connection_to_database);
                        MySqlDataReader readerTwo = commandTwo.ExecuteReader();
                        while (readerTwo.Read())
                        {
                            scheduleIdOutbound = readerTwo[6].ToString();
                            string date = readerTwo[2].ToString();
                            string[] dateSplit = date.Split(' ');
                            string price = readerTwo[5].ToString();
                            double economyPrice = Math.Round(Convert.ToDouble(price), 0);
                            double bisinessPrice = Math.Round(Convert.ToDouble(economyPrice + economyPrice * 0.35), 0);
                            double firstClassPrice = Math.Round(Convert.ToDouble(bisinessPrice + bisinessPrice * 0.3), 0);
                            if (cabinBox.Text == "Economy")
                            {
                                outboundGridView.Rows.Add(readerTwo[0].ToString(), readerTwo[1].ToString(), dateSplit[0],
                                    readerTwo[3].ToString(), readerTwo[4].ToString(), economyPrice, 0);
                            }
                            else if (cabinBox.Text == "Business")
                            {
                                outboundGridView.Rows.Add(readerTwo[0].ToString(), readerTwo[1].ToString(), dateSplit[0],
                                    readerTwo[3].ToString(), readerTwo[4].ToString(), bisinessPrice, 0);
                            }
                            else
                            {
                                outboundGridView.Rows.Add(readerTwo[0].ToString(), readerTwo[1].ToString(), dateSplit[0],
                                    readerTwo[3].ToString(), readerTwo[4].ToString(), firstClassPrice, 0);
                            }
                        }
                        readerTwo.Close();
                        string sqlThree = "select air1.IATACode as `From`, air2.IATACode as `To`, " +
                            "`Date`, `Time`, FlightNumber, EconomyPrice, schedules.ID " +
                            "from schedules join routes rou on (rou.ID = RouteID) " +
                            "inner join airports air1 on (rou.DepartureAirportID = air1.ID) " +
                            "inner join airports air2 on (rou.ArrivalAirportID = air2.ID) where air2.IATACode = '" +
                            fromBox.Text + "' and air1.IATACode = '" + toBox.Text + "' and `Date` = '" + returnText.Text + "'";
                        MySqlCommand commandThree = new MySqlCommand(sqlThree, connection_to_database);
                        MySqlDataReader readerThree = commandThree.ExecuteReader();
                        while (readerThree.Read())
                        {
                            scheduleIdReturn = readerThree[6].ToString();
                            string date = readerThree[2].ToString();
                            string[] dateSplit = date.Split(' ');
                            string price = readerThree[5].ToString();
                            double economyPrice = Math.Round(Convert.ToDouble(price), 0);
                            double bisinessPrice = Math.Round(Convert.ToDouble(economyPrice + economyPrice * 0.35), 0);
                            double firstClassPrice = Math.Round(Convert.ToDouble(bisinessPrice + bisinessPrice * 0.3), 0);
                            if (cabinBox.Text == "Economy")
                            {
                                returnGridView.Rows.Add(readerThree[0].ToString(), readerThree[1].ToString(), dateSplit[0],
                                    readerThree[3].ToString(), readerThree[4].ToString(), economyPrice, 0);
                            }
                            else if (cabinBox.Text == "Business")
                            {
                                returnGridView.Rows.Add(readerThree[0].ToString(), readerThree[1].ToString(), dateSplit[0],
                                    readerThree[3].ToString(), readerThree[4].ToString(), bisinessPrice, 0);
                            }
                            else
                            {
                                returnGridView.Rows.Add(readerThree[0].ToString(), readerThree[1].ToString(), dateSplit[0],
                                    readerThree[3].ToString(), readerThree[4].ToString(), firstClassPrice, 0);
                            }
                        }
                        readerThree.Close();
                        connection_to_database.Close();
                        return;
                    }
                }
            }
            if (oneWayButton.Checked)
            {
                outboundGridView.Rows.Clear();
                if (fromBox.Text == "[ All airports ]" || toBox.Text == "[ All airports ]"
                    || outboundText.Text == "    -  -")
                {
                    DialogResult dialog = MessageBox.Show("All fields must be filled!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (outboundText.Text != "    -  -")
                {
                    string check = outboundText.Text;
                    string[] check_date = check.Split('-');
                    string parse = check_date[2] + " " + check_date[1] + " " + check_date[0];
                    if (check_date[1] == "02" && check_date[2] == "29")
                    {
                        DialogResult dialog = MessageBox.Show("Incorrect outbound date, there is no 29th of " +
                            "February in this year",
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
                                "1) Outbound date format must be yyyy-mm-dd\n" +
                                "2) Outbound date must be correct",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                if (fromBox.Text != "[ All airports ]" && toBox.Text != "[ All airports ]"
                    && outboundText.Text != "    -  -")
                {
                    if (outboundCheck.Checked == true)
                    {
                        outboundGridView.Columns[0].Width = 81;
                        outboundGridView.Columns[1].Width = 81;
                        string connection_to_server = "server = localhost; user id = root; password = As89149625780@;" +
                            "persistsecurityinfo = True; database = amonic-airlines";
                        MySqlConnection connection_to_database = new MySqlConnection(connection_to_server);
                        connection_to_database.Open();
                        string dateOutbound = outboundText.Text;
                        string[] dateOutboundSplit = dateOutbound.Split('-');
                        DateTime dateOutboundBefore = new DateTime(Convert.ToInt32(dateOutboundSplit[0]),
                            Convert.ToInt32(dateOutboundSplit[1]), Convert.ToInt32(dateOutboundSplit[2]), 0, 0, 0);
                        DateTime dateOutboundAfter = new DateTime(Convert.ToInt32(dateOutboundSplit[0]),
                            Convert.ToInt32(dateOutboundSplit[1]), Convert.ToInt32(dateOutboundSplit[2]), 0, 0, 0);
                        dateOutboundBetweenBefore = dateOutboundBefore.AddDays(-3).ToShortDateString();
                        dateOutboundBetweenAfter = dateOutboundAfter.AddDays(3).ToShortDateString();
                        string[] dateBeforeOutbound = dateOutboundBetweenBefore.Split('.');
                        string[] dateAfterOutbound = dateOutboundBetweenAfter.Split('.');
                        string realOutboundBefore = dateBeforeOutbound[2] + dateBeforeOutbound[1] +
                            dateBeforeOutbound[0];
                        string realOutboundAfter = dateAfterOutbound[2] + dateAfterOutbound[1] +
                            dateAfterOutbound[0];
                        string sqlTwo = "select air1.IATACode as `From`, air2.IATACode as `To`, " +
                        "`Date`, `Time`, FlightNumber, EconomyPrice, schedules.ID " +
                        "from schedules join routes rou on (rou.ID = RouteID) " +
                        "inner join airports air1 on (rou.DepartureAirportID = air1.ID) " +
                        "inner join airports air2 on (rou.ArrivalAirportID = air2.ID) where air1.IATACode = '" +
                        fromBox.Text + "' and air2.IATACode = '" + toBox.Text + "' and `Date` BETWEEN '" +
                        realOutboundBefore + "' AND '" + realOutboundAfter + "'";
                        MySqlCommand commandTwo = new MySqlCommand(sqlTwo, connection_to_database);
                        MySqlDataReader readerTwo = commandTwo.ExecuteReader();
                        while (readerTwo.Read())
                        {
                            scheduleIdOutbound = readerTwo[6].ToString();
                            string date = readerTwo[2].ToString();
                            string[] dateSplit = date.Split(' ');
                            string price = readerTwo[5].ToString();
                            double economyPrice = Math.Round(Convert.ToDouble(price), 0);
                            double bisinessPrice = Math.Round(Convert.ToDouble(economyPrice + economyPrice * 0.35), 0);
                            double firstClassPrice = Math.Round(Convert.ToDouble(bisinessPrice + bisinessPrice * 0.3), 0);
                            if (cabinBox.Text == "Economy")
                            {
                                outboundGridView.Rows.Add(readerTwo[0].ToString(), readerTwo[1].ToString(), dateSplit[0],
                                    readerTwo[3].ToString(), readerTwo[4].ToString(), economyPrice, 0);
                            }
                            else if (cabinBox.Text == "Business")
                            {
                                outboundGridView.Rows.Add(readerTwo[0].ToString(), readerTwo[1].ToString(), dateSplit[0],
                                    readerTwo[3].ToString(), readerTwo[4].ToString(), bisinessPrice, 0);
                            }
                            else
                            {
                                outboundGridView.Rows.Add(readerTwo[0].ToString(), readerTwo[1].ToString(), dateSplit[0],
                                    readerTwo[3].ToString(), readerTwo[4].ToString(), firstClassPrice, 0);
                            }
                        }
                        readerTwo.Close();
                        connection_to_database.Close();
                        return;
                    }
                    else
                    {
                        outboundGridView.Columns[0].Width = 90;
                        outboundGridView.Columns[1].Width = 90;
                        string connection_to_server = "server = localhost; user id = root; password = As89149625780@;" +
                        "persistsecurityinfo = True; database = amonic-airlines";
                        MySqlConnection connection_to_database = new MySqlConnection(connection_to_server);
                        connection_to_database.Open();
                        string sqlTwo = "select air1.IATACode as `From`, air2.IATACode as `To`, " +
                            "`Date`, `Time`, FlightNumber, EconomyPrice, schedules.ID " +
                            "from schedules join routes rou on (rou.ID = RouteID) " +
                            "inner join airports air1 on (rou.DepartureAirportID = air1.ID) " +
                            "inner join airports air2 on (rou.ArrivalAirportID = air2.ID) where air1.IATACode = '" +
                            fromBox.Text + "' and air2.IATACode = '" + toBox.Text + "' and `Date` = '" + outboundText.Text + "'";
                        MySqlCommand commandTwo = new MySqlCommand(sqlTwo, connection_to_database);
                        MySqlDataReader readerTwo = commandTwo.ExecuteReader();
                        while (readerTwo.Read())
                        {
                            scheduleIdOutbound = readerTwo[6].ToString();
                            string date = readerTwo[2].ToString();
                            string[] dateSplit = date.Split(' ');
                            string price = readerTwo[5].ToString();
                            double economyPrice = Math.Round(Convert.ToDouble(price), 0);
                            double bisinessPrice = Math.Round(Convert.ToDouble(economyPrice + economyPrice * 0.35), 0);
                            double firstClassPrice = Math.Round(Convert.ToDouble(bisinessPrice + bisinessPrice * 0.3), 0);
                            if (cabinBox.Text == "Economy")
                            {
                                outboundGridView.Rows.Add(readerTwo[0].ToString(), readerTwo[1].ToString(), dateSplit[0],
                                    readerTwo[3].ToString(), readerTwo[4].ToString(), economyPrice, 0);
                            }
                            else if (cabinBox.Text == "Business")
                            {
                                outboundGridView.Rows.Add(readerTwo[0].ToString(), readerTwo[1].ToString(), dateSplit[0],
                                    readerTwo[3].ToString(), readerTwo[4].ToString(), bisinessPrice, 0);
                            }
                            else
                            {
                                outboundGridView.Rows.Add(readerTwo[0].ToString(), readerTwo[1].ToString(), dateSplit[0],
                                    readerTwo[3].ToString(), readerTwo[4].ToString(), firstClassPrice, 0);
                            }
                        }
                        readerTwo.Close();
                        connection_to_database.Close();
                        return;
                    }
                }
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
