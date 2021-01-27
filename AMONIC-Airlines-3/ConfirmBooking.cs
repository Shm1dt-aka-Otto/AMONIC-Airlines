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
    public partial class ConfirmBooking : Form
    {
        string userId, idOutbound, nameCabin, idReturn;
        string[] passangerList;

        public ConfirmBooking(int summary, string idUser, string outboundId,
            string cabinType, string[] passangers, string returnId)
        {
            InitializeComponent();
            allPrice.Text = "$" + summary.ToString();
            userId = idUser;
            idOutbound = outboundId;
            nameCabin = cabinType;
            passangerList = passangers;
            idReturn = returnId;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void issueButton_Click(object sender, EventArgs e)
        {
            if (cardRadioButton.Checked != true && cashRadioButton.Checked != true &&
                voucherRadioButton.Checked != true)
            {
                DialogResult dialog = MessageBox.Show("Choose payment method",
                            "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (idReturn == "")
            {
                string connection_to_server = "server = localhost; user id = root; password = As89149625780@;" +
                        "persistsecurityinfo = True; database = amonic-airlines";
                MySqlConnection connection_to_database = new MySqlConnection(connection_to_server);
                connection_to_database.Open();
                for (int i = 0; i < passangerList.Length; i ++)
                {
                    string[] passanger = passangerList[i].Split(',');
                    string sqlOne = "SELECT ID FROM cabintypes where Name = '" + nameCabin + "'";
                    MySqlCommand commandOne = new MySqlCommand(sqlOne, connection_to_database);
                    MySqlDataReader readerOne = commandOne.ExecuteReader();
                    string cabinId = "0";
                    if (readerOne.Read())
                    {
                        cabinId = readerOne[0].ToString();
                    }
                    readerOne.Close();
                    string sqlTwo = "SELECT ID FROM countries where Name = '" + passanger[3] + "'";
                    MySqlCommand commandTwo = new MySqlCommand(sqlTwo, connection_to_database);
                    MySqlDataReader readerTwo = commandTwo.ExecuteReader();
                    string countryId = "0";
                    if (readerTwo.Read())
                    {
                        countryId = readerTwo[0].ToString();
                    }
                    readerTwo.Close();
                    string payment = "C";
                    if (cashRadioButton.Checked == true)
                    {
                        payment = "M";
                    }
                    else if (voucherRadioButton.Checked == true)
                    {
                        payment = "V";
                    }
                    Random rnd = new Random();
                    int randomNumber = rnd.Next(0, 9);
                    string bookingReference = passanger[0].Substring(0, 1) + randomNumber.ToString() +
                        passanger[1].Substring(1, 2) + payment + "O";
                    string queryOne = "INSERT INTO tickets (UserID, ScheduleID, CabinTypeID, Firstname," +
                        "Lastname, Phone, PassportNumber, PassportCountryID, BookingReference, Confirmed) VALUES (" +
                        userId + ", " + idOutbound + ", " + cabinId + ", '" + passanger[0] + "', '" +
                        passanger[1] + "', '" + passanger[4] + "', '" + passanger[2] + "', " + countryId +
                        ", '" + bookingReference.ToUpper() + "', '1')";
                    MySqlCommand commandThree = new MySqlCommand(queryOne, connection_to_database);
                    commandThree.ExecuteNonQuery();
                }
                connection_to_database.Close();
                Close();
            }
            else
            {
                string connection_to_server = "server = localhost; user id = root; password = As89149625780@;" +
                        "persistsecurityinfo = True; database = amonic-airlines";
                MySqlConnection connection_to_database = new MySqlConnection(connection_to_server);
                connection_to_database.Open();
                for (int i = 0; i < passangerList.Length; i++)
                {
                    string[] passanger = passangerList[i].Split(',');
                    string sqlOne = "SELECT ID FROM cabintypes where Name = '" + nameCabin + "'";
                    MySqlCommand commandOne = new MySqlCommand(sqlOne, connection_to_database);
                    MySqlDataReader readerOne = commandOne.ExecuteReader();
                    string cabinId = "0";
                    if (readerOne.Read())
                    {
                        cabinId = readerOne[0].ToString();
                    }
                    readerOne.Close();
                    string sqlTwo = "SELECT ID FROM countries where Name = '" + passanger[3] + "'";
                    MySqlCommand commandTwo = new MySqlCommand(sqlTwo, connection_to_database);
                    MySqlDataReader readerTwo = commandTwo.ExecuteReader();
                    string countryId = "0";
                    if (readerTwo.Read())
                    {
                        countryId = readerTwo[0].ToString();
                    }
                    readerTwo.Close();
                    string payment = "C";
                    if (cashRadioButton.Checked == true)
                    {
                        payment = "M";
                    }
                    else
                    {
                        payment = "V";
                    }
                    Random rnd = new Random();
                    int randomNumber = rnd.Next(0, 9);
                    string bookingReference = passanger[0].Substring(0, 1) + randomNumber.ToString() +
                        passanger[1].Substring(1, 2) + payment + "O";
                    string queryOne = "INSERT INTO tickets (UserID, ScheduleID, CabinTypeID, Firstname," +
                        "Lastname, Phone, PassportNumber, PassportCountryID, BookingReference, Confirmed) VALUES (" +
                        userId + ", " + idOutbound + ", " + cabinId + ", '" + passanger[0] + "', '" +
                        passanger[1] + "', '" + passanger[4] + "', '" + passanger[2] + "', " + countryId +
                        ", '" + bookingReference.ToUpper() + "', 1)";
                    MySqlCommand commandThree = new MySqlCommand(queryOne, connection_to_database);
                    commandThree.ExecuteNonQuery();
                    randomNumber = rnd.Next(0, 9);
                    bookingReference = passanger[0].Substring(0, 1) + randomNumber.ToString() +
                        passanger[1].Substring(1, 2) + payment + "R";
                    string queryTwo = "INSERT INTO tickets (UserID, ScheduleID, CabinTypeID, Firstname," +
                        "Lastname, Phone, PassportNumber, PassportCountryID, BookingReference, Confirmed) VALUES (" +
                        userId + ", " + idReturn + ", " + cabinId + ", '" + passanger[0] + "', '" +
                        passanger[1] + "', '" + passanger[4] + "', '" + passanger[2] + "', " + countryId +
                        ", '" + bookingReference.ToUpper() + "', 1)";
                    MySqlCommand commandFour = new MySqlCommand(queryTwo, connection_to_database);
                    commandFour.ExecuteNonQuery();
                }
                connection_to_database.Close();
                Close();
            }
        }
    }
}
