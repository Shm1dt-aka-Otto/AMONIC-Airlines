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

namespace AMONIC_Airlines
{
    public partial class Add_usercs : Form
    {
        public Add_usercs()
        {
            InitializeComponent();
        }
        private void Add_usercs_Load(object sender, EventArgs e) //complete
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_amonic_airlinesDataSet.offices". При необходимости она может быть перемещена или удалена.
            this.officesTableAdapter.Fill(this._amonic_airlinesDataSet.offices);
        }
        private void saveButton_Click(object sender, EventArgs e) //complete
        {
            if (emailBox.Text == "" || firstNameBox.Text == "" || lastNameBox.Text == "" ||
                officeBox.Text == "" || passwordBox.Text == "")
            {
                DialogResult dialog = MessageBox.Show("You must fill every statements " +
                        "into fields",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (birthdateBox.Text == "    -  -")
            {
                DialogResult dialog = MessageBox.Show("Add Birthdate",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (birthdateBox.Text != "    -  -")
            {
                string check = birthdateBox.Text;
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
            if (emailBox.Text != "")
            {
                string connection_to_server = "server=localhost;user=root;database=amonic-airlines;" +
                    "password=As89149625780@;";
                MySqlConnection connection_to_database = new MySqlConnection(connection_to_server);
                connection_to_database.Open();
                string sqlOne = "select Email from users where Email = '" + emailBox.Text + "'";
                MySqlCommand commandOne = new MySqlCommand(sqlOne, connection_to_database);
                MySqlDataReader readerOne = commandOne.ExecuteReader();
                while (readerOne.Read())
                {
                    if (readerOne[0].ToString() == emailBox.Text)
                    {
                        DialogResult dialog = MessageBox.Show("This email is already exist",
                            "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        emailBox.Text = "";
                    }
                }
                readerOne.Close();
                connection_to_database.Close();
                return;
            }
            else
            {
                string connection_to_server = "server=localhost;user=root;database=amonic-airlines;" +
                "password=As89149625780@;";
                MySqlConnection connection_to_database = new MySqlConnection(connection_to_server);
                connection_to_database.Open();
                string sqlOne = "SELECT COUNT(ID) FROM users";
                MySqlCommand commandOne = new MySqlCommand(sqlOne, connection_to_database);
                MySqlDataReader readerOne = commandOne.ExecuteReader();
                readerOne.Read();
                string id = readerOne[0].ToString();
                connection_to_database.Close();
                string email = emailBox.Text;
                string firstName = firstNameBox.Text;
                string lastName = lastNameBox.Text;
                string office = officeBox.Text;
                string birthdate = birthdateBox.Text;
                string password = passwordBox.Text;
                readerOne.Close();
                connection_to_database.Open();
                string sqlTwo = "SELECT ID from offices WHERE Title = '" + office + "'";
                MySqlCommand commandTwo = new MySqlCommand(sqlTwo, connection_to_database);
                MySqlDataReader readerTwo = commandTwo.ExecuteReader();
                readerTwo.Read();
                office = readerTwo[0].ToString();
                readerTwo.Close();
                connection_to_database.Close();
                string queryOne = "INSERT INTO users (ID, RoleID, Email, Password, FirstName," +
                    "LastName, OfficeID, Birthdate, Active) VALUES (" +
                    id + ", " + 2 + ", '" + email + "', " + "MD5('" + password + "'), '" + firstName +
                    "', '" + lastName + "', " +
                     office + ", '" + birthdate + "', " + 1 + ")";
                MySqlCommand commandThree = new MySqlCommand(queryOne, connection_to_database);
                commandThree.ExecuteNonQuery();
                connection_to_database.Close();
                Close();
            }
        }
        private void cancelButton_Click(object sender, EventArgs e) //complete
        {
            Close();
        }
    }
}
