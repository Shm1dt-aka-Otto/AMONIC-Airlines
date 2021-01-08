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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "session2_xxDataSet1.airports". При необходимости она может быть перемещена или удалена.
            this.airportsTableAdapter.Fill(this.session2_xxDataSet1.airports);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "session2_xxDataSet1.aircrafts". При необходимости она может быть перемещена или удалена.
            this.aircraftsTableAdapter.Fill(this.session2_xxDataSet1.aircrafts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "session2_xxDataSet.schedules". При необходимости она может быть перемещена или удалена.
            this.schedulesTableAdapter.Fill(this.session2_xxDataSet.schedules);
        }

        private void apply_Click(object sender, EventArgs e)
        {
            string conStr = "server = localhost; user id = root; password = As89149625780@;" +
                "persistsecurityinfo = True; database = session2_xx";
            MySqlConnection connection = new MySqlConnection(conStr);
            connection.Open();
            string fromm = from.Text;
            string too = to.Text;
            string outboundd = outbound.Text;
            string flightnum = flightnumber.Text;
            string order = sortby.Text;
            if (fromm != "")
            {
                if (too != "")
                {
                    if (outboundd != "")
                    {
                        if (flightnum != "")
                        {
                            string sql = "SELECT Date, Time, airports.Name, airports.Name, aircrafts.Name, " +
                                "EconomyPrice, Confirmed FROM schedules JOIN routes ON (RoteID = routes.ID) " +
                                "JOIN airports ON (routes.ID = airports.ID) JOIN aircrafts ON (AircraftID = " +
                                "aircrafts.ID) WHERE DepartureAirportID = " + fromm + "AND ArrivelAirportID = " +
                                too + "AND Date = " + outboundd + "AND FlightNumber = " + flightnum;
                        }
                    }
                }
            }
            connection.Close();

        }
    }
}
