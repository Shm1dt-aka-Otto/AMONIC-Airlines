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
    public partial class Bookingconfirmation : Form
    {
        int checkForBlock;
        public Bookingconfirmation(string fromOut, string toOut, string dateOut,
            string numberOut, string cabinType, string fromRe, string toRe,
            string dateRe, string numberRe, int countPassanger)
        {
            InitializeComponent();
            checkForBlock = countPassanger;
            iataOutboundFrom.Text = fromOut;
            iataOutboundTo.Text = toOut;
            cabinTypeOutbound.Text = cabinType;
            dateOutbound.Text = dateOut;
            flightNumberOutbound.Text = numberOut;
            if (fromRe == "")
            {
                returnDetailBox.Visible = false;
            }
            else
            {
                iataReturnFrom.Text = fromRe;
                iataReturnTo.Text = toRe;
                cabinTypeReturn.Text = cabinType;
                dateReturn.Text = dateRe;
                flightNumberReturn.Text = numberRe;
            }
        }

        private void addPassengerButton_Click(object sender, EventArgs e)
        {
            if (firstNameText.Text == "" || lastNameText.Text == "" || phoneText.Text == "   -   -"
                || passCountryBox.SelectedIndex == 0 || birthDateText.Text == "    -  -")
            {
                DialogResult dialog = MessageBox.Show("All fields must be filled!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (birthDateText.Text == "    -  -")
            {
                string check = birthDateText.Text;
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
                            "1) Birth date format must be yyyy-mm-dd\n" +
                            "2) Birth date must be correct",
                            "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            string firstName = firstNameText.Text;
            string lastName = lastNameText.Text;
            string phoneNumber = phoneText.Text;
            string passportNumber = passNumText.Text;
            string passportCountry = passCountryBox.Text;
            string datePassanger = birthDateText.Text;


        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in passlistGridView.SelectedRows)
            {
                passlistGridView.Rows.RemoveAt(row.Index);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {

        }

        private void Bookingconfirmation_Load(object sender, EventArgs e)
        {
            passCountryBox.SelectedIndex = 0;
            string connection_to_server = "server = localhost; user id = root; password = As89149625780@;" +
                        "persistsecurityinfo = True; database = amonic-airlines";
            MySqlConnection connection_to_database = new MySqlConnection(connection_to_server);
            connection_to_database.Open();
            string sqlOne = "SELECT Name from countries";
            MySqlCommand commandOne = new MySqlCommand(sqlOne, connection_to_database);
            MySqlDataReader readerOne = commandOne.ExecuteReader();
            while (readerOne.Read())
            {
                passCountryBox.Items.Add(readerOne[0].ToString());
            }
            readerOne.Close();
            connection_to_database.Close();
        }
    }
}
