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
    public partial class ApplyChanges : Form
    {
        int success = 0;
        int duplicate = 0;
        int mistake = 0;
        public ApplyChanges()
        {
            InitializeComponent();
        }
        private void importButton_Click(object sender, EventArgs e)
        {
            string fileText = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files(*.csv)|*.csv";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                importBox.Text = dialog.FileName;
                fileText = System.IO.File.ReadAllText(importBox.Text);
            }
            string[] dataImport = fileText.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < dataImport.Length; i++)
            {
                string connection_to_server = "server=localhost;user=root;database=amonic-airlines;" +
                    "password=As89149625780@;";
                MySqlConnection connection_to_database = new MySqlConnection(connection_to_server);
                connection_to_database.Open();
                string[] import = dataImport[i].Split(',');
                while (true)
                {
                    if (import.Length < 9 || import.Length > 9)
                    {
                        mistake += 1;
                        recordCountLabel.Text = mistake.ToString();
                        i++;
                    }
                    if (i > dataImport.Length)
                    {
                        break;
                    }
                    import = dataImport[i].Split(',');
                    if (import.Length == 9)
                    {
                        break;
                    }
                }
                if (i > dataImport.Length)
                {
                    connection_to_database.Close();
                    break;
                }
                import = dataImport[i].Split(',');
                int checkDuplicate = duplicate;
                int checkMistake = mistake;
                string date = import[1];
                string time = import[2];
                string aircraftId = import[6];
                string routeId = "";
                string sqlOne = "select routes.ID from routes join airports air1 on (DepartureAirportID = air1.ID) " +
                    "join airports air2 on(ArrivalAirportID = air2.ID) where air1.IATACode = '" + import[4] +
                    "' and air2.IATACode = '" + import[5] + "'";
                MySqlCommand commandOne = new MySqlCommand(sqlOne, connection_to_database);
                MySqlDataReader readerOne = commandOne.ExecuteReader();
                if (readerOne.Read())
                {
                    routeId = readerOne[0].ToString();
                    readerOne.Close();
                }
                string economyPrice = import[7];
                if (import[8] == "OK")
                {
                    import[8] = "1";
                }
                else
                {
                    import[8] = "0";
                }
                string confirmed = import[8];
                string flightNumber = import[3];
                if (import[0] == "ADD")
                {
                    try
                    {
                        string queryOne = "INSERT INTO schedules (`Date`, `Time`, AircraftID, RouteID, EconomyPrice, Confirmed," +
                                "FlightNumber) VALUES('" + date + "', '" + time + "', " + aircraftId + ", " + routeId +
                                ", " + economyPrice + ", " + confirmed + ", " + flightNumber + ")";
                        MySqlCommand commandTwo = new MySqlCommand(queryOne, connection_to_database);
                        commandTwo.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        mistake += 1;
                        recordCountLabel.Text = mistake.ToString();
                    }
                    if (checkMistake == mistake)
                    {
                        string sqlThree = "SELECT ID FROM schedules WHERE `Date` = '" + date + "' and `Time` = '" +
                                time + "' and AircraftID = " + aircraftId + " and RouteID = " + routeId + " and " +
                                "FlightNumber = " + flightNumber;
                        MySqlCommand commandThree = new MySqlCommand(sqlThree, connection_to_database);
                        MySqlDataReader readerThree = commandThree.ExecuteReader();
                        string idDuplicate = "";
                        int countRows = 0;
                        while (readerThree.Read())
                        {
                            idDuplicate = readerThree[0].ToString();
                            countRows += 1;
                        }
                        readerThree.Close();
                        if (countRows != 1)
                        {
                            string queryTwo = "DELETE FROM schedules WHERE ID = " + idDuplicate;
                            MySqlCommand commandFour = new MySqlCommand(queryTwo, connection_to_database);
                            commandFour.ExecuteNonQuery();
                            duplicate += 1;
                            duplicateCountLabel.Text = duplicate.ToString();
                        }
                    }
                    if (checkDuplicate == duplicate && checkMistake == mistake)
                    {
                        success += 1;
                        successfulCountLabel.Text = success.ToString();
                    }
                }
                if (import[0] == "EDIT")
                {
                    try
                    {
                        string queryThree = "UPDATE schedules SET `Time` = '" + time + "', RouteID = " + routeId +
                            ", EconomyPrice = " + economyPrice + ", Confirmed = " + confirmed + ", FlightNumber = " +
                            flightNumber + " WHERE `Date` = '" + date + "' and AircraftID = " + aircraftId;
                        MySqlCommand commandFive = new MySqlCommand(queryThree, connection_to_database);
                        commandFive.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        mistake += 1;
                        recordCountLabel.Text = mistake.ToString();
                    }
                    if (checkMistake == mistake)
                    {
                        success += 1;
                        successfulCountLabel.Text = success.ToString();
                    }
                }
                connection_to_database.Close();
            }
        }
        private void ApplyChanges_Load(object sender, EventArgs e)
        {
            successfulCountLabel.Text = success.ToString();
            duplicateCountLabel.Text = duplicate.ToString();
            recordCountLabel.Text = mistake.ToString();
        }
    }
}
