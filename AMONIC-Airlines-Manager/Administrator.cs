using AMONIC_Airlines_2;
using AMONIC_Airlines_3;
using AMONIC_Airlines_4;
using AMONIC_Airlines_5;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMONIC_Airlines
{
    public partial class Administrator : Form
    {
        string emailAdministrator, enterDateTime;
        public Administrator(string email) //complete
        {
            InitializeComponent();
            emailAdministrator = email;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) //complete
        {
            Close();
        }
        private void UpdateTable() //complete
        {
            string connection_to_server = "server=localhost;user=root;database=amonic-airlines;" +
                "password=As89149625780@;";
            MySqlConnection connection_to_datebase = new MySqlConnection(connection_to_server);
            connection_to_datebase.Open();
            string office = officeBox.Text;
            if (office == "All offices")
            {
                string sqlTwo = "SELECT FirstName as `First Name`, LastName as `Last Name`, Birthdate as `Date`, " +
                    "roles.Title as `User Role`, " +
                    "Email as `Email address`, offices.Title as `Office`, Active FROM users JOIN offices on " +
                    "(offices.ID = OfficeID) " +
                    "join roles on (roles.ID = RoleID)";
                MySqlDataAdapter adapterTwo = new MySqlDataAdapter(sqlTwo, connection_to_server);
                DataTable dataTable = new DataTable();
                adapterTwo.Fill(dataTable);
                connection_to_datebase.Close();
                administratorGridView.DataSource = dataTable;
                int ageColumn_Index = administratorGridView.Columns[2].DisplayIndex;
                DataColumn age = dataTable.Columns.Add("Age", typeof(int));
                int dateColumn_Index = administratorGridView.Columns[7].DisplayIndex;
                administratorGridView.Columns[2].DisplayIndex = dateColumn_Index;
                administratorGridView.Columns[7].DisplayIndex = ageColumn_Index;
                administratorGridView.Columns[7].Width = 70;
                foreach (DataGridViewRow row in administratorGridView.Rows)
                {
                    string birthdate = row.Cells[2].Value.ToString();
                    string[] birthdateSplit = birthdate.Split(' ');
                    var dateUser = DateTime.ParseExact(birthdateSplit[0], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    var ageUser = DateTime.Now.Year - dateUser.Year;
                    if (DateTime.Now.Month < dateUser.Month ||
                        (DateTime.Now.Month == dateUser.Month && DateTime.Now.Day < dateUser.Day)) ageUser--;
                    row.Cells[7].Value = ageUser.ToString();
                }
                PaintRow();
            }
            else
            {
                string sqlTwo = "SELECT FirstName as `First Name`, LastName as `Last Name`, Birthdate as `Date`, " +
                    "roles.Title as `User Role`, " +
                    "Email as `Email address`, offices.Title as `Office`, Active FROM users JOIN offices on (offices.ID = OfficeID) " +
                    "join roles on (roles.ID = RoleID) WHERE offices.Title = '" + office + "'";
                MySqlDataAdapter adapterTwo = new MySqlDataAdapter(sqlTwo, connection_to_server);
                DataTable dataTable = new DataTable();
                adapterTwo.Fill(dataTable);
                connection_to_datebase.Close();
                administratorGridView.DataSource = dataTable;
                int ageColumn_Index = administratorGridView.Columns[2].DisplayIndex;
                DataColumn age = dataTable.Columns.Add("Age", typeof(int));
                int dateColumn_Index = administratorGridView.Columns[7].DisplayIndex;
                administratorGridView.Columns[2].DisplayIndex = dateColumn_Index;
                administratorGridView.Columns[7].DisplayIndex = ageColumn_Index;
                administratorGridView.Columns[7].Width = 70;
                foreach (DataGridViewRow row in administratorGridView.Rows)
                {
                    string birthdate = row.Cells[2].Value.ToString();
                    string[] birthdateSplit = birthdate.Split(' ');
                    var dateUser = DateTime.ParseExact(birthdateSplit[0], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    var ageUser = DateTime.Now.Year - dateUser.Year;
                    if (DateTime.Now.Month < dateUser.Month ||
                        (DateTime.Now.Month == dateUser.Month && DateTime.Now.Day < dateUser.Day)) ageUser--;
                    row.Cells[7].Value = ageUser.ToString();
                }
                PaintRow();
            }
        }
        private void Administrator_Load(object sender, EventArgs e) //complete
        {
            officeBox.SelectedIndex = 0;
            string connection_to_server = "server=localhost;user=root;database=amonic-airlines;" +
                "password=As89149625780@;";
            MySqlConnection connection_to_datebase = new MySqlConnection(connection_to_server);
            connection_to_datebase.Open();
            string sqlOne = "SELECT FirstName as `First Name`, LastName as `Last Name`, Birthdate as `Date`, " +
                    "roles.Title as `User Role`, " +
                    "Email as `Email address`, offices.Title as `Office`, Active FROM users JOIN offices on " +
                    "(offices.ID = OfficeID) " +
                    "join roles on (roles.ID = RoleID)";
            MySqlDataAdapter adapterOne = new MySqlDataAdapter(sqlOne, connection_to_server);
            DataTable dataTable = new DataTable();
            adapterOne.Fill(dataTable);
            connection_to_datebase.Close();
            administratorGridView.DataSource = dataTable;
            administratorGridView.Columns[6].Visible = false;
            int ageColumn_Index = administratorGridView.Columns[2].DisplayIndex;
            DataColumn age = dataTable.Columns.Add("Age", typeof(int));
            int dateColumn_Index = administratorGridView.Columns[7].DisplayIndex;
            administratorGridView.Columns[2].DisplayIndex = dateColumn_Index;
            administratorGridView.Columns[7].DisplayIndex = ageColumn_Index;
            administratorGridView.Columns[2].Visible = false;
            administratorGridView.Columns[0].Width = 94;
            administratorGridView.Columns[1].Width = 94;
            administratorGridView.Columns[7].Width = 70;
            administratorGridView.Columns[3].Width = 100;
            administratorGridView.Columns[4].Width = 169;
            administratorGridView.Columns[5].Width = 120;
            foreach (DataGridViewRow row in administratorGridView.Rows)
            {
                string birthdate = row.Cells[2].Value.ToString();
                string[] birthdateSplit = birthdate.Split(' ');
                var dateUser = DateTime.ParseExact(birthdateSplit[0], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                var ageUser = DateTime.Now.Year - dateUser.Year;
                if (DateTime.Now.Month < dateUser.Month ||
                    (DateTime.Now.Month == dateUser.Month && DateTime.Now.Day < dateUser.Day)) ageUser--;
                row.Cells[7].Value = ageUser.ToString();
            }
            PaintRow();
        }
        private void PaintRow() //complete
        {
            foreach (DataGridViewRow row in administratorGridView.Rows)
            {
                if (row.Cells[3].Value.ToString() == "Administrator")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                if (row.Cells[6].Value.ToString() == "False")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
        private void addUserToolStripMenuItem_Click(object sender, EventArgs e) //complete
        {
            Add_usercs add = new Add_usercs();
            add.ShowDialog();
            UpdateTable();
        }
        private void officeBox_SelectedIndexChanged(object sender, EventArgs e) //complete
        {
            UpdateTable();
        }
        private void changeRoleButton_Click(object sender, EventArgs e) //complete
        {
            EditRole edit = new EditRole();
            edit.ShowDialog();
            UpdateTable();
        }
        private void enableDisableButton_Click(object sender, EventArgs e) //complete
        {
            string connection_to_server = "server=localhost;user=root;database=amonic-airlines;" +
                "password=As89149625780@;";
            MySqlConnection connection_to_datebase = new MySqlConnection(connection_to_server);
            connection_to_datebase.Open();
            string sqlThree = "SELECT ID, Active FROM users WHERE Email = '" + administratorGridView.CurrentRow.Cells[4].Value.ToString() + "'";
            MySqlCommand commandOne = new MySqlCommand(sqlThree, connection_to_datebase);
            MySqlDataReader readerOne = commandOne.ExecuteReader();
            readerOne.Read();
            string id = readerOne[0].ToString();
            string active = readerOne[1].ToString();
            readerOne.Close();
            if (active == "True")
            {
                string queryOne = "UPDATE users SET Active = 0 WHERE ID = " + id +
                    " AND Email = '" + administratorGridView.CurrentRow.Cells[4].Value.ToString() + "'";
                MySqlCommand commandTwo = new MySqlCommand(queryOne, connection_to_datebase);
                commandTwo.ExecuteNonQuery();
                connection_to_datebase.Close();
            }
            else if (active == "False")
            {
                string queryOne = "UPDATE users SET Active = 1 WHERE ID = " + id +
                    " AND Email = '" + administratorGridView.CurrentRow.Cells[4].Value.ToString() + "'";
                MySqlCommand commandTwo = new MySqlCommand(queryOne, connection_to_datebase);
                commandTwo.ExecuteNonQuery();
                connection_to_datebase.Close();
            }
            UpdateTable();
        }

        private void manageFlightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageFlight manage = new ManageFlight();
            manage.ShowDialog();
        }

        private void addSurveyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSurvey survey = new AddSurvey();
            survey.ShowDialog();
        }

        private void summaryResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultSummary result = new ResultSummary();
            result.ShowDialog();
        }

        private void detailResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetailResult detail = new DetailResult();
            detail.ShowDialog();
        }

        private void amenitiesResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AmenitiesSurvey amenities = new AmenitiesSurvey();
            amenities.ShowDialog();
        }

        private void shortResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShortSummary shortsummary = new ShortSummary();
            shortsummary.ShowDialog();
        }

        private void Administrator_FormClosing(object sender, FormClosingEventArgs e) //complete
        {
            string connection_to_server = "server=localhost;user=root;" +
                "database=amonic-airlines;password=As89149625780@;";
            MySqlConnection connection_to_datebase = new MySqlConnection(connection_to_server);
            connection_to_datebase.Open();
            string sqlFour = "SELECT ID FROM trecking WHERE Email = '" + emailAdministrator + "'";
            MySqlCommand commandThree = new MySqlCommand(sqlFour, connection_to_datebase);
            MySqlDataReader readerTwo = commandThree.ExecuteReader();
            while (readerTwo.Read())
            {
                enterDateTime = readerTwo[0].ToString();
            }
            readerTwo.Close();
            string queryTwo = "UPDATE trecking SET Logout_date = CURDATE(), Logout_time = CURTIME() " +
                "WHERE Email = '" + emailAdministrator + "' AND ID = " + enterDateTime;
            MySqlCommand commandFive = new MySqlCommand(queryTwo, connection_to_datebase);
            commandFive.ExecuteNonQuery();
            connection_to_datebase.Close();
        }
    }
}