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

        private void Save_Click(object sender, EventArgs e) //complete
        {
            if (mail.Text == "" || first.Text == "" || last.Text == "" ||
                off.Text == "" || date.Text == "" || pass.Text == "")
            {
                DialogResult dialog = MessageBox.Show("You must fill every statements " +
                        "into fields",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string connStr = "server=localhost;user=root;database=session1_xx;" +
                "password=As89149625780@;";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string sq = "SELECT COUNT(ID) FROM users";
                MySqlCommand commands = new MySqlCommand(sq, conn);
                MySqlDataReader reader = commands.ExecuteReader();
                reader.Read();
                string id = reader[0].ToString();
                conn.Close();
                string email = mail.Text;
                string fname = first.Text;
                string lname = last.Text;
                string office = off.Text;
                string bdate = date.Text;
                string word = pass.Text;
                conn.Open();
                string sql = "SELECT ID from offices WHERE Title = '" + office + "'";
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader readers = command.ExecuteReader();
                readers.Read();
                office = readers[0].ToString();
                conn.Close();
                conn.Open();
                string query = "INSERT INTO users (ID, RoleID, Email, Password, FirstName," +
                    "LastName, OfficeID, Birthdate, Active) VALUES (" +
                    id + ", " + 2 + ", '" + email + "', " + "MD5('" + word + "'), '" + fname +
                    "', '" + lname + "', " +
                     office + ", '" + bdate + "', " + 1 + ")";
                MySqlCommand command1 = new MySqlCommand(query, conn);
                command1.ExecuteNonQuery();
                conn.Close();
                Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e) //complete
        {
            Close();
        }

        private void Add_usercs_Load(object sender, EventArgs e) //complete
        {
            this.officesTableAdapter.Fill(this.session1_xxDataSet1.offices);
        }

        private void date_Click(object sender, EventArgs e) //complete
        {
            date.Text = "";
        }
    }
}
