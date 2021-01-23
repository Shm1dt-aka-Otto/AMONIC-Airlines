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
            this.officesTableAdapter.Fill(this.session1_xxDataSet1.offices);
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
                        DialogResult dialog = MessageBox.Show("Something wrong! Check:\n 1) Date format must be yyyy-mm-dd\n" +
                            "2) Date must be correct",
                            "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            if (emailBox.Text != "")
            {
                string connStr = "server=localhost;user=root;database=session1_xx;" +
                    "password=As89149625780@;";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string sqlr = "select Email from users where Email = '" + emailBox.Text + "'";
                MySqlCommand cmnd = new MySqlCommand(sqlr, conn);
                MySqlDataReader rds = cmnd.ExecuteReader();
                while (rds.Read())
                {
                    if (rds[0].ToString() == emailBox.Text)
                    {
                        DialogResult dialog = MessageBox.Show("This email is already exist",
                            "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        emailBox.Text = "";
                    }
                }
                rds.Close();
                conn.Close();
                return;
            }
            else
            {
                string connection = "server=localhost;user=root;database=session1_xx;" +
                "password=As89149625780@;";
                MySqlConnection db = new MySqlConnection(connection);
                db.Open();
                string sq = "SELECT COUNT(ID) FROM users";
                MySqlCommand commands = new MySqlCommand(sq, db);
                MySqlDataReader reader = commands.ExecuteReader();
                reader.Read();
                string id = reader[0].ToString();
                db.Close();
                string email = emailBox.Text;
                string fname = firstNameBox.Text;
                string lname = lastNameBox.Text;
                string office = officeBox.Text;
                string bdate = birthdateBox.Text;
                string word = passwordBox.Text;
                db.Open();
                string sql = "SELECT ID from offices WHERE Title = '" + office + "'";
                MySqlCommand command = new MySqlCommand(sql, db);
                MySqlDataReader readers = command.ExecuteReader();
                readers.Read();
                office = readers[0].ToString();
                db.Close();
                string query = "INSERT INTO users (ID, RoleID, Email, Password, FirstName," +
                    "LastName, OfficeID, Birthdate, Active) VALUES (" +
                    id + ", " + 2 + ", '" + email + "', " + "MD5('" + word + "'), '" + fname +
                    "', '" + lname + "', " +
                     office + ", '" + bdate + "', " + 1 + ")";
                MySqlCommand command1 = new MySqlCommand(query, db);
                command1.ExecuteNonQuery();
                db.Close();
                Close();
            }
        }
        private void cancelButton_Click(object sender, EventArgs e) //complete
        {
            Close();
        }
    }
}
