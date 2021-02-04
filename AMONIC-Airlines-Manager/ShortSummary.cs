using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMONIC_Airlines_5
{
    public partial class ShortSummary : Form
    {
        public ShortSummary()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShortSummary_Load(object sender, EventArgs e)
        {
            Stopwatch stop = new Stopwatch();
            stop.Start();
            string connection_to_server = "server=localhost;user=root;database=amonic-airlines;" +
                    "password=As89149625780@;";
            MySqlConnection connection_to_database = new MySqlConnection(connection_to_server);
            connection_to_database.Open();
            string sqlCustomer = "select count(*), Firstname, Lastname BookingReference from tickets " +"" +
                "join schedules on (ScheduleID = schedules.ID) where Date between '2017-12-01' " +
                "and '2017-12-31' group by BookingReference order by count(1) desc limit 3";
            MySqlCommand commandCustomer = new MySqlCommand(sqlCustomer, connection_to_database);
            MySqlDataReader readerCustomer = commandCustomer.ExecuteReader();
            while (readerCustomer.Read())
            {
                if (firstCustomer.Text == "1) ")
                {
                    firstCustomer.Text += readerCustomer[1].ToString() + " " + readerCustomer[2] +
                        " (" + readerCustomer[0].ToString() + " Tickets)";
                }
                else if (secondCustomer.Text == "2) ")
                {
                    secondCustomer.Text += readerCustomer[1].ToString() + " " + readerCustomer[2] +
                        " (" + readerCustomer[0].ToString() + " Tickets)";
                }
                else
                {
                    thirdCustomer.Text += readerCustomer[1].ToString() + " " + readerCustomer[2] +
                        " (" + readerCustomer[0].ToString() + " Tickets)";
                }
            }
            readerCustomer.Close();
            string sqlFlight = "select count(*), Confirmed from schedules where Date between " +
                "'2017-12-01' and '2017-12-31' group by Confirmed";
            MySqlCommand commandFlight = new MySqlCommand(sqlFlight, connection_to_database);
            MySqlDataReader readerFlight = commandFlight.ExecuteReader();
            while (readerFlight.Read())
            {
                if (firstFlight.Text == "Number confirmed: ")
                {
                    firstFlight.Text += readerFlight[0].ToString();
                }
                else
                {
                    secondFlight.Text += readerFlight[0].ToString();
                }
            }
            readerFlight.Close();
            string sqlAvg = "select avg(FlightTime) from schedules join routes on (routes.ID = RouteID) " +
                "where Date between '2017-12-01' and '2017-12-31'";
            MySqlCommand commandAvg = new MySqlCommand(sqlAvg, connection_to_database);
            MySqlDataReader readerAvg = commandAvg.ExecuteReader();
            if (readerAvg.Read())
            {
                double avg = Math.Round(Convert.ToDouble(readerAvg[0].ToString()), 0);
                thirdFlight.Text += avg.ToString() + " minutes";
            }
            readerAvg.Close();
            string sqlBusy = "select count(*), Date from schedules where Date between " +
                "'2017-12-01' and '2017-12-31' group by Date order by count(1) desc";
            string sqlQuite = "select count(*), Date from schedules where Date between " +
                "'2017-12-01' and '2017-12-31' group by Date order by count(1) asc";
            MySqlCommand commandBusy = new MySqlCommand(sqlBusy, connection_to_database);
            MySqlCommand commandQuite = new MySqlCommand(sqlQuite, connection_to_database);
            MySqlDataReader readerBusy = commandBusy.ExecuteReader();
            if (readerBusy.Read())
            {
                string[] dateSplit = readerBusy[1].ToString().Split(' ');
                busyPassanger.Text += dateSplit[0] + " with " + readerBusy[0].ToString() + " flying";
            }
            readerBusy.Close();
            MySqlDataReader readerQuite = commandQuite.ExecuteReader();
            if (readerQuite.Read())
            {
                string[] dateSplit = readerQuite[1].ToString().Split(' ');
                quitePassanger.Text += dateSplit[0] + " with " + readerQuite[0].ToString() + " flying";
            }
            readerQuite.Close();
            string sqlOffice = "select count(*), offices.Title from tickets join users on (UserID = users.ID) " +
                "join offices on (OfficeID = offices.ID) join schedules on (ScheduleID = schedules.ID) where Date " +
                "between '2017-12-01' and '2017-12-31' group by offices.Title order by count(1) desc";
            MySqlCommand commandOffice = new MySqlCommand(sqlOffice, connection_to_database);
            MySqlDataReader readerOffice = commandOffice.ExecuteReader();
            while (readerOffice.Read())
            {
                if (firstOffice.Text == "1) ")
                {
                    firstOffice.Text += readerOffice[1].ToString();
                }
                else if (secondOffice.Text == "2) ")
                {
                    secondOffice.Text += readerOffice[1].ToString();
                }
                else
                {
                    thirdOffice.Text += readerOffice[1].ToString();
                }
            }
            readerOffice.Close();
            double revenue = 0;
            string sqlYesterday = "select EconomyPrice, CabinTypeID from tickets join schedules on " +
                "(ScheduleID = schedules.ID) where Date = '2017-12-28'";
            MySqlCommand commandYesterday = new MySqlCommand(sqlYesterday, connection_to_database);
            MySqlDataReader readerYesterday = commandYesterday.ExecuteReader();
            while (readerYesterday.Read())
            {
                double price = Math.Round(Convert.ToDouble(readerYesterday[0].ToString()), 0);
                if (readerYesterday[1].ToString() == "1")
                {
                    revenue += price;
                }
                else if (readerYesterday[1].ToString() == "2")
                {
                    price += price * 0.35;
                    revenue += price;
                }
                else
                {
                    price += price * 0.35;
                    price += price * 0.3;
                    revenue += price;
                }
            }
            readerYesterday.Close();
            yesterday.Text += Math.Round(revenue, 2);
            revenue = 0;
            string sqlTwoAgo = "select EconomyPrice, CabinTypeID from tickets join schedules on " +
                "(ScheduleID = schedules.ID) where Date = '2017-12-27'";
            MySqlCommand commandTwoAgo = new MySqlCommand(sqlTwoAgo, connection_to_database);
            MySqlDataReader readerTwoAgo = commandTwoAgo.ExecuteReader();
            while (readerTwoAgo.Read())
            {
                double price = Math.Round(Convert.ToDouble(readerTwoAgo[0].ToString()), 0);
                if (readerTwoAgo[1].ToString() == "1")
                {
                    revenue += price;
                }
                else if (readerTwoAgo[1].ToString() == "2")
                {
                    price += price * 0.35;
                    revenue += price;
                }
                else
                {
                    price += price * 0.35;
                    price += price * 0.3;
                    revenue += price;
                }
            }
            readerTwoAgo.Close();
            twoDaysAgo.Text += Math.Round(revenue, 2);
            revenue = 0;
            string sqlThreeAgo = "select EconomyPrice, CabinTypeID from tickets join schedules on " +
                "(ScheduleID = schedules.ID) where Date = '2017-12-26'";
            MySqlCommand commandThreeAgo = new MySqlCommand(sqlThreeAgo, connection_to_database);
            MySqlDataReader readerThreeAgo = commandThreeAgo.ExecuteReader();
            while (readerThreeAgo.Read())
            {
                double price = Math.Round(Convert.ToDouble(readerThreeAgo[0].ToString()), 0);
                if (readerThreeAgo[1].ToString() == "1")
                {
                    revenue += price;
                }
                else if (readerThreeAgo[1].ToString() == "2")
                {
                    price += price * 0.35;
                    revenue += price;
                }
                else
                {
                    price += price * 0.35;
                    price += price * 0.3;
                    revenue += price;
                }
            }
            readerThreeAgo.Close();
            threeDaysAgo.Text += Math.Round(revenue, 2);
            int seats = 0;
            string sqlThisPercent = "select count(*), AircraftID, Date from schedules where Date between " +
                "'2017-12-23' and '2017-12-29' group by AircraftID;";
            MySqlCommand commandThisPercent = new MySqlCommand(sqlThisPercent, connection_to_database);
            MySqlDataReader readerThisPercent = commandThisPercent.ExecuteReader();
            while (readerThisPercent.Read())
            {
                if (readerThisPercent[1].ToString() == "1")
                {
                    seats += 176 * Convert.ToInt32(readerThisPercent[0].ToString());
                }
                else
                {
                    seats += 169 * Convert.ToInt32(readerThisPercent[0].ToString());
                }
            }
            readerThisPercent.Close();
            string sqlThisWeek = "select count(*) from tickets join schedules on (schedules.ID = ScheduleID) " +
                "where Date between '2017-12-23' and '2017-12-29'";
            MySqlCommand commandThisWeek = new MySqlCommand(sqlThisWeek, connection_to_database);
            MySqlDataReader readerThisWeek = commandThisWeek.ExecuteReader();
            if (readerThisWeek.Read())
            {
                weekPercent.Text += Math.Round(100 - (Convert.ToDouble(readerThisWeek[0].ToString()) / seats) * 100, 2) + "%";
            }
            readerThisWeek.Close();
            seats = 0;
            string sqlAgoPercent = "select count(*), AircraftID, Date from schedules where Date between " +
                "'2017-12-16' and '2017-12-22' group by AircraftID;";
            MySqlCommand commandAgoPercent = new MySqlCommand(sqlAgoPercent, connection_to_database);
            MySqlDataReader readerAgoPercent = commandAgoPercent.ExecuteReader();
            while (readerAgoPercent.Read())
            {
                if (readerAgoPercent[1].ToString() == "1")
                {
                    seats += 176 * Convert.ToInt32(readerAgoPercent[0].ToString());
                }
                else
                {
                    seats += 169 * Convert.ToInt32(readerAgoPercent[0].ToString());
                }
            }
            readerAgoPercent.Close();
            string sqlAgoWeek = "select count(*) from tickets join schedules on (schedules.ID = ScheduleID) " +
                "where Date between '2017-12-16' and '2017-12-22'";
            MySqlCommand commandAgoWeek = new MySqlCommand(sqlAgoWeek, connection_to_database);
            MySqlDataReader readerAgoWeek = commandAgoWeek.ExecuteReader();
            if (readerAgoWeek.Read())
            {
                lastWeekPercent.Text += Math.Round(100 - (Convert.ToDouble(readerAgoWeek[0].ToString()) / seats) * 100, 2) + "%";
            }
            readerAgoWeek.Close();
            seats = 0;
            string sqlTwoAgoPercent = "select count(*), AircraftID, Date from schedules where Date between " +
                "'2017-12-23' and '2017-12-29' group by AircraftID;";
            MySqlCommand commandTwoAgoPercent = new MySqlCommand(sqlTwoAgoPercent, connection_to_database);
            MySqlDataReader readerTwoAgoPercent = commandTwoAgoPercent.ExecuteReader();
            while (readerTwoAgoPercent.Read())
            {
                if (readerTwoAgoPercent[1].ToString() == "1")
                {
                    seats += 176 * Convert.ToInt32(readerTwoAgoPercent[0].ToString());
                }
                else
                {
                    seats += 169 * Convert.ToInt32(readerTwoAgoPercent[0].ToString());
                }
            }
            readerTwoAgoPercent.Close();
            string sqlTwoAgoWeek = "select count(*) from tickets join schedules on (schedules.ID = ScheduleID) " +
                "where Date between '2017-12-23' and '2017-12-29'";
            MySqlCommand commandTwoAgoWeek = new MySqlCommand(sqlTwoAgoWeek, connection_to_database);
            MySqlDataReader readerTwoAgoWeek = commandTwoAgoWeek.ExecuteReader();
            if (readerTwoAgoWeek.Read())
            {
                twoWeeksAgoPercent.Text += Math.Round(100 - (Convert.ToDouble(readerTwoAgoWeek[0].ToString()) / seats) * 100, 2) + "%";
            }
            readerTwoAgoWeek.Close();
            connection_to_database.Close();
            stop.Stop();
            double mili = stop.Elapsed.TotalSeconds;
            generatedReport.Text += mili.ToString() + " seconds";
        }
    }
}
