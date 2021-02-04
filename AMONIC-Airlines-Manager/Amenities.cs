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

namespace AMONIC_Airlines_5
{
    public partial class Amenities : Form
    {
        string fullname = "", passNum = "", schedule = "", cabintype = "";
        string Id = "";
        double amount = 0, taxe = 0, all = 0;

        private void firstBox_CheckedChanged(object sender, EventArgs e)
        {
            if (firstBox.Checked == true)
            {
                amount += 10;
                taxe = amount / 20;
                all = amount + taxe;
                itemLabel.Text = "Items selected: " + "$" + amount.ToString();
                taxesLabel.Text = "Duties and taxes: " + "$" + taxe.ToString();
                payableLabel.Text = "Total payable: " + "$" + all.ToString();
            }
            else
            {
                amount -= 10;
                taxe = amount / 20;
                all = amount + taxe;
                itemLabel.Text = "Items selected: " + "$" + amount.ToString();
                taxesLabel.Text = "Duties and taxes" + "$" + taxe.ToString();
                payableLabel.Text = "Total payable" + "$" + all.ToString();
            }
        }

        private void secondBox_CheckedChanged(object sender, EventArgs e)
        {
            if (secondBox.Checked == true)
            {
                amount += 30;
                taxe = amount / 20;
                all = amount + taxe;
                itemLabel.Text = "Items selected: " + "$" + amount.ToString();
                taxesLabel.Text = "Duties and taxes: " + "$" + taxe.ToString();
                payableLabel.Text = "Total payable: " + "$" + all.ToString();
            }
            else
            {
                amount -= 30;
                taxe = amount / 20;
                all = amount + taxe;
                itemLabel.Text = "Items selected: " + "$" + amount.ToString();
                taxesLabel.Text = "Duties and taxes" + "$" + taxe.ToString();
                payableLabel.Text = "Total payable" + "$" + all.ToString();
            }
        }

        private void thirdBox_CheckedChanged(object sender, EventArgs e)
        {
            if (thirdBox.Checked == true)
            {
                amount += 50;
                taxe = amount / 20;
                all = amount + taxe;
                itemLabel.Text = "Items selected: " + "$" + amount.ToString();
                taxesLabel.Text = "Duties and taxes: " + "$" + taxe.ToString();
                payableLabel.Text = "Total payable: " + "$" + all.ToString();
            }
            else
            {
                amount -= 50;
                taxe = amount / 20;
                all = amount + taxe;
                itemLabel.Text = "Items selected: " + "$" + amount.ToString();
                taxesLabel.Text = "Duties and taxes" + "$" + taxe.ToString();
                payableLabel.Text = "Total payable" + "$" + all.ToString();
            }
        }

        private void fourBox_CheckedChanged(object sender, EventArgs e)
        {
            if (fourBox.Checked == true)
            {
                amount += 12;
                taxe = amount / 20;
                all = amount + taxe;
                itemLabel.Text = "Items selected: " + "$" + amount.ToString();
                taxesLabel.Text = "Duties and taxes: " + "$" + taxe.ToString();
                payableLabel.Text = "Total payable: " + "$" + all.ToString();
            }
            else
            {
                amount -= 12;
                taxe = amount / 20;
                all = amount + taxe;
                itemLabel.Text = "Items selected: " + "$" + amount.ToString();
                taxesLabel.Text = "Duties and taxes" + "$" + taxe.ToString();
                payableLabel.Text = "Total payable" + "$" + all.ToString();
            }
        }

        private void fiveBox_CheckedChanged(object sender, EventArgs e)
        {
            if (fiveBox.Checked == true)
            {
                amount += 15;
                taxe = amount / 20;
                all = amount + taxe;
                itemLabel.Text = "Items selected: " + "$" + amount.ToString();
                taxesLabel.Text = "Duties and taxes: " + "$" + taxe.ToString();
                payableLabel.Text = "Total payable: " + "$" + all.ToString();
            }
            else
            {
                amount -= 15;
                taxe = amount / 20;
                all = amount + taxe;
                itemLabel.Text = "Items selected: " + "$" + amount.ToString();
                taxesLabel.Text = "Duties and taxes" + "$" + taxe.ToString();
                payableLabel.Text = "Total payable" + "$" + all.ToString();
            }
        }

        private void sixBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sixBox.Checked == true)
            {
                amount += 25;
                taxe = amount / 20;
                all = amount + taxe;
                itemLabel.Text = "Items selected: " + "$" + amount.ToString();
                taxesLabel.Text = "Duties and taxes: " + "$" + taxe.ToString();
                payableLabel.Text = "Total payable: " + "$" + all.ToString();
            }
            else
            {
                amount -= 25;
                taxe = amount / 20;
                all = amount + taxe;
                itemLabel.Text = "Items selected: " + "$" + amount.ToString();
                taxesLabel.Text = "Duties and taxes" + "$" + taxe.ToString();
                payableLabel.Text = "Total payable" + "$" + all.ToString();
            }
        }

        private void eightBox_CheckedChanged(object sender, EventArgs e)
        {
            if (eightBox.Checked == true)
            {
                amount += 5;
                taxe = amount / 20;
                all = amount + taxe;
                itemLabel.Text = "Items selected: " + "$" + amount.ToString();
                taxesLabel.Text = "Duties and taxes: " + "$" + taxe.ToString();
                payableLabel.Text = "Total payable: " + "$" + all.ToString();
            }
            else
            {
                amount -= 5;
                taxe = amount / 20;
                all = amount + taxe;
                itemLabel.Text = "Items selected: " + "$" + amount.ToString();
                taxesLabel.Text = "Duties and taxes" + "$" + taxe.ToString();
                payableLabel.Text = "Total payable" + "$" + all.ToString();
            }
        }

        private void nineBox_CheckedChanged(object sender, EventArgs e)
        {
            if (nineBox.Checked == true)
            {
                amount += 15;
                taxe = amount / 20;
                all = amount + taxe;
                itemLabel.Text = "Items selected: " + "$" + amount.ToString();
                taxesLabel.Text = "Duties and taxes: " + "$" + taxe.ToString();
                payableLabel.Text = "Total payable: " + "$" + all.ToString();
            }
            else
            {
                amount -= 15;
                taxe = amount / 20;
                all = amount + taxe;
                itemLabel.Text = "Items selected: " + "$" + amount.ToString();
                taxesLabel.Text = "Duties and taxes" + "$" + taxe.ToString();
                payableLabel.Text = "Total payable" + "$" + all.ToString();
            }
        }

        private void tenBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tenBox.Checked == true)
            {
                amount += 10;
                taxe = amount / 20;
                all = amount + taxe;
                itemLabel.Text = "Items selected: " + "$" + amount.ToString();
                taxesLabel.Text = "Duties and taxes: " + "$" + taxe.ToString();
                payableLabel.Text = "Total payable: " + "$" + all.ToString();
            }
            else
            {
                amount -= 10;
                taxe = amount / 20;
                all = amount + taxe;
                itemLabel.Text = "Items selected: " + "$" + amount.ToString();
                taxesLabel.Text = "Duties and taxes" + "$" + taxe.ToString();
                payableLabel.Text = "Total payable" + "$" + all.ToString();
            }
        }

        private void twelveBox_CheckedChanged(object sender, EventArgs e)
        {
            if (twelveBox.Checked == true)
            {
                amount += 25;
                taxe = amount / 20;
                all = amount + taxe;
                itemLabel.Text = "Items selected: " + "$" + amount.ToString();
                taxesLabel.Text = "Duties and taxes: " + "$" + taxe.ToString();
                payableLabel.Text = "Total payable: " + "$" + all.ToString();
            }
            else
            {
                amount -= 25;
                taxe = amount / 20;
                all = amount + taxe;
                itemLabel.Text = "Items selected: " + "$" + amount.ToString();
                taxesLabel.Text = "Duties and taxes" + "$" + taxe.ToString();
                payableLabel.Text = "Total payable" + "$" + all.ToString();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (referenceBox.Text == "")
            {
                DialogResult dialogError = MessageBox.Show("Add booking reference!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string connection_to_server = "server=localhost;user=root;database=amonic-airlines;" +
                    "password=As89149625780@;";
            MySqlConnection connection_to_database = new MySqlConnection(connection_to_server);
            connection_to_database.Open();
            string queryOne = "DELETE FROM amenitiestickets WHERE TicketID = '" + Id + "'";
            MySqlCommand commandOne = new MySqlCommand(queryOne, connection_to_database);
            commandOne.ExecuteNonQuery();
            string query = "";
            if (firstBox.Checked == true)
            {
                try
                {
                    query = "Insert into amenitiestickets values (1" + ", " + Id + ", 10)";
                    MySqlCommand command = new MySqlCommand(query, connection_to_database);
                    command.ExecuteNonQuery();
                }
                catch (Exception) { };
            }
            if (secondBox.Checked == true)
            {
                try
                {
                    query = "Insert into amenitiestickets values (2" + ", " + Id + ", 30)";
                    MySqlCommand command = new MySqlCommand(query, connection_to_database);
                    command.ExecuteNonQuery();
                }
                catch (Exception) { };
            }
            if (thirdBox.Checked == true)
            {
                try
                {
                    query = "Insert into amenitiestickets values (3" + ", " + Id + ", 50)";
                    MySqlCommand command = new MySqlCommand(query, connection_to_database);
                    command.ExecuteNonQuery();
                }
                catch (Exception) { };
            }
            if (fourBox.Checked == true)
            {
                try
                {
                    query = "Insert into amenitiestickets values (4" + ", " + Id + ", 12)";
                    MySqlCommand command = new MySqlCommand(query, connection_to_database);
                    command.ExecuteNonQuery();
                }
                catch (Exception) { };
            }
            if (fiveBox.Checked == true)
            {
                try
                {
                    query = "Insert into amenitiestickets values (5" + ", " + Id + ", 15)";
                    MySqlCommand command = new MySqlCommand(query, connection_to_database);
                    command.ExecuteNonQuery();
                }
                catch (Exception) { };
            }
            if (sixBox.Checked == true)
            {
                try
                {
                    query = "Insert into amenitiestickets values (6" + ", " + Id + ", 25)";
                    MySqlCommand command = new MySqlCommand(query, connection_to_database);
                    command.ExecuteNonQuery();
                }
                catch (Exception) { };
            }
            if (sevenBox.Checked == true)
            {
                try
                {
                    query = "Insert into amenitiestickets values (7" + ", " + Id + ", 0)";
                    MySqlCommand command = new MySqlCommand(query, connection_to_database);
                    command.ExecuteNonQuery();
                }
                catch (Exception) { };
            }
            if (eightBox.Checked == true)
            {
                try
                {
                    query = "Insert into amenitiestickets values (8" + ", " + Id + ", 5)";
                    MySqlCommand command = new MySqlCommand(query, connection_to_database);
                    command.ExecuteNonQuery();
                }
                catch (Exception) { };
            }
            if (nineBox.Checked == true)
            {
                try
                {
                    query = "Insert into amenitiestickets values (9" + ", " + Id + ", 15)";
                    MySqlCommand command = new MySqlCommand(query, connection_to_database);
                    command.ExecuteNonQuery();
                }
                catch (Exception) { };
            }
            if (tenBox.Checked == true)
            {
                try
                {
                    query = "Insert into amenitiestickets values (10" + ", " + Id + ", 10)";
                    MySqlCommand command = new MySqlCommand(query, connection_to_database);
                    command.ExecuteNonQuery();
                }
                catch (Exception) { };
            }
            if (elevenBox.Checked == true)
            {
                try
                {
                    query = "Insert into amenitiestickets values (11" + ", " + Id + ", 0)";
                    MySqlCommand command = new MySqlCommand(query, connection_to_database);
                    command.ExecuteNonQuery();
                }
                catch (Exception) { };
            }
            if (twelveBox.Checked == true)
            {
                try
                {
                    query = "Insert into amenitiestickets values (12" + ", " + Id + ", 25)";
                    MySqlCommand command = new MySqlCommand(query, connection_to_database);
                    command.ExecuteNonQuery();
                }
                catch (Exception) { };
            }
            connection_to_database.Close();
            Close();
        }

        public Amenities()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void amenitiesButton_Click(object sender, EventArgs e)
        {
            if (referenceBox.Text == "")
            {
                DialogResult dialogError = MessageBox.Show("Add booking reference!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cabintype == "Economy")
            {
                sevenBox.Checked = true;
                sevenBox.Enabled = false;
                elevenBox.Checked = true;
                elevenBox.Enabled = false;
                amount = taxe = all = 0;
                itemLabel.Text = "Items selected: " + "$" + amount.ToString();
                taxesLabel.Text = "Duties and taxes" + "$" + taxe.ToString();
                payableLabel.Text = "Total payable" + "$" + all.ToString();
            }
            else if (cabintype == "Business")
            {
                firstBox.Checked = true;
                firstBox.Enabled = false;
                fourBox.Checked = true;
                fourBox.Enabled = false;
                sixBox.Checked = true;
                sixBox.Enabled = false;
                sevenBox.Checked = true;
                sevenBox.Enabled = false;
                elevenBox.Checked = true;
                elevenBox.Enabled = false;
                amount = taxe = all = 0;
                itemLabel.Text = "Items selected: " + "$" + amount.ToString();
                taxesLabel.Text = "Duties and taxes" + "$" + taxe.ToString();
                payableLabel.Text = "Total payable" + "$" + all.ToString();
            }
            else
            {
                firstBox.Checked = true;
                firstBox.Enabled = false;
                fourBox.Checked = true;
                fourBox.Enabled = false;
                fiveBox.Checked = true;
                fiveBox.Enabled = false;
                sixBox.Checked = true;
                sixBox.Enabled = false;
                sevenBox.Checked = true;
                sevenBox.Enabled = false;
                eightBox.Checked = true;
                eightBox.Enabled = false;
                nineBox.Checked = true;
                nineBox.Enabled = false;
                twelveBox.Checked = true;
                twelveBox.Enabled = false;
                amount = taxe = all = 0;
                itemLabel.Text = "Items selected: " + "$" + amount.ToString();
                taxesLabel.Text = "Duties and taxes" + "$" + taxe.ToString();
                payableLabel.Text = "Total payable" + "$" + all.ToString();
            }
            nameLabel.Text = "Full name: " + fullname;
            nameLabel.Visible = true;
            passportLabel.Text = "Passport number: " + passNum;
            passportLabel.Visible = true;
            cabinLabel.Text = "Your cabin class is: " + cabintype;
            cabinLabel.Visible = true;
            amonicGroupBox.Visible = true;
            itemLabel.Visible = true;
            taxesLabel.Visible = true;
            payableLabel.Visible = true;
            string connection_to_server = "server=localhost;user=root;database=amonic-airlines;" +
                    "password=As89149625780@;";
            MySqlConnection connection_to_database = new MySqlConnection(connection_to_server);
            connection_to_database.Open();
            string sqlThree = "SELECT AmenityID, Price from amenitiestickets where TicketID = '" + Id + "'";
            MySqlCommand commandThree = new MySqlCommand(sqlThree, connection_to_database);
            MySqlDataReader readerThree = commandThree.ExecuteReader();
            while (readerThree.Read())
            {
                switch (readerThree[0].ToString())
                {
                    case "1":
                        {
                            firstBox.Checked = true;
                            break;
                        }
                    case "2":
                        {
                            secondBox.Checked = true;
                            break;
                        }
                    case "3":
                        {
                            thirdBox.Checked = true;
                            break;
                        }
                    case "4":
                        {
                            fourBox.Checked = true;
                            break;
                        }
                    case "5":
                        {
                            fiveBox.Checked = true;
                            break;
                        }
                    case "6":
                        {
                            sixBox.Checked = true;
                            break;
                        }
                    case "8":
                        {
                            eightBox.Checked = true;
                            break;
                        }
                    case "9":
                        {
                            nineBox.Checked = true;
                            break;
                        }
                    case "10":
                        {
                            tenBox.Checked = true;
                            break;
                        }
                    case "12":
                        {
                            twelveBox.Checked = true;
                            break;
                        }
                }
            }
            readerThree.Close();
            itemLabel.Text = "Items selected: " + "$" + amount.ToString();
            taxesLabel.Text = "Duties and taxes: " + "$" + taxe.ToString();
            payableLabel.Text = "Total payable: " + "$" + all.ToString();
            connection_to_database.Close();
        }

        private void Amenities_Load(object sender, EventArgs e)
        {
            itemLabel.Text = "$0";
            taxesLabel.Text = "$0";
            payableLabel.Text = "$0";
            nameLabel.Visible = false;
            cabinLabel.Visible = false;
            passportLabel.Visible = false;
            amonicGroupBox.Visible = false;
            itemLabel.Visible = false;
            taxesLabel.Visible = false;
            payableLabel.Visible = false;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            itemLabel.Text = "$0";
            taxesLabel.Text = "$0";
            payableLabel.Text = "$0";
            nameLabel.Visible = false;
            cabinLabel.Visible = false;
            passportLabel.Visible = false;
            amonicGroupBox.Visible = false;
            itemLabel.Visible = false;
            taxesLabel.Visible = false;
            payableLabel.Visible = false;
            firstBox.Checked = false;
            firstBox.Enabled = true;
            secondBox.Checked = false;
            secondBox.Enabled = true;
            thirdBox.Checked = false;
            thirdBox.Enabled = true;
            fourBox.Checked = false;
            fourBox.Enabled = true;
            fiveBox.Checked = false;
            fiveBox.Enabled = true;
            sixBox.Checked = false;
            sixBox.Enabled = true;
            sevenBox.Checked = false;
            sevenBox.Enabled = true;
            eightBox.Checked = false;
            eightBox.Enabled = true;
            nineBox.Checked = false;
            nineBox.Enabled = true;
            tenBox.Checked = false;
            tenBox.Enabled = true;
            elevenBox.Checked = false;
            elevenBox.Enabled = true;
            twelveBox.Checked = false;
            twelveBox.Enabled = true;
            amount = taxe = all = 0;
            itemLabel.Text = "Items selected: " + "$" + amount.ToString();
            taxesLabel.Text = "Duties and taxes" + "$" + taxe.ToString();
            payableLabel.Text = "Total payable" + "$" + all.ToString();
            flightBox.Items.Clear();
            if (referenceBox.Text == "")
            {
                DialogResult dialogError = MessageBox.Show("Add booking reference!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            string connection_to_server = "server=localhost;user=root;database=amonic-airlines;" +
                    "password=As89149625780@;";
            MySqlConnection connection_to_database = new MySqlConnection(connection_to_server);
            connection_to_database.Open();
            try
            {
                string sqlOne = "SELECT ScheduleID, cabintypes.Name, Firstname, Lastname, PassportNumber, tickets.ID" +
                    " FROM tickets join cabintypes on (CabinTypeID = cabintypes.ID) WHERE BookingReference = '" + referenceBox.Text + "'";
                MySqlCommand commandOne = new MySqlCommand(sqlOne, connection_to_database);
                MySqlDataReader readerOne = commandOne.ExecuteReader();
                while (readerOne.Read())
                {
                    fullname = readerOne[2].ToString() + " " + readerOne[3].ToString();
                    passNum = readerOne[4].ToString();
                    schedule = readerOne[0].ToString();
                    cabintype = readerOne[1].ToString();
                    Id = readerOne[5].ToString();
                }
                readerOne.Close();
            }
            catch (Exception)
            {
                DialogResult dialogError = MessageBox.Show("Invalid Reference",
                            "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string sqlTwo = "SELECT FlightNumber, air1.IATACode, air2.IATACode, Date, Time from schedules " +
                "join routes rou on (rou.ID = RouteID) inner join airports air1 on (rou.DepartureAirportID = air1.ID) " +
                "inner join airports air2 on (rou.ArrivalAirportID = air2.ID) where schedules.ID = " + schedule;
                MySqlCommand commandTwo = new MySqlCommand(sqlTwo, connection_to_database);
                MySqlDataReader readerTwo = commandTwo.ExecuteReader();
                if (readerTwo.Read())
                {
                    flightBox.Items.Add(readerTwo[0].ToString() + ", " + readerTwo[1].ToString() + "-" + readerTwo[2].ToString() +
                        ", " + readerTwo[3].ToString() + ", " + readerTwo[4].ToString());
                }
                flightBox.SelectedIndex = 0;
                readerTwo.Close();
            }
            catch (Exception)
            {
                DialogResult dialogError = MessageBox.Show("Invalid Reference",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            connection_to_database.Close();
        }
    }
}
