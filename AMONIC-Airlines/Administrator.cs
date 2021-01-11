using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        string mail, enter;
        public Administrator(string email)
        {
            InitializeComponent();
            mail = email;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) //complete
        {
            Close();
        }
        private void UpdateTable() //complete
        {
            string connStr = "server=localhost;user=root;database=session1_xx;" +
                "password=As89149625780@;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string off = officeBox.Text;
            if (off == "All offices")
            {
                string sql = "SELECT FirstName as `First Name`, LastName as `Last Name`, Birthdate as `Date`, " +
                    "roles.Title as `User Role`, " +
                    "Email as `Email address`, offices.Title as `Office`, Active FROM users JOIN offices on " +
                    "(offices.ID = OfficeID) " +
                    "join roles on (roles.ID = RoleID)";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connStr);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();
                dataGridView1.DataSource = dt;
                int ageColumn_Index = dataGridView1.Columns[2].DisplayIndex;
                DataColumn age = dt.Columns.Add("Age", typeof(int));
                int dateColumn_Index = dataGridView1.Columns[7].DisplayIndex;
                dataGridView1.Columns[2].DisplayIndex = dateColumn_Index;
                dataGridView1.Columns[7].DisplayIndex = ageColumn_Index;
                dataGridView1.Columns[7].Width = 70;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string dates = row.Cells[2].Value.ToString();
                    string[] datesp = dates.Split(' ');
                    var date = DateTime.ParseExact(datesp[0], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    var ages = DateTime.Now.Year - date.Year;
                    if (DateTime.Now.Month < date.Month ||
                        (DateTime.Now.Month == date.Month && DateTime.Now.Day < date.Day)) ages--;
                    row.Cells[7].Value = ages.ToString();
                }
                PaintRow();
            }
            else
            {
                string sql = "SELECT FirstName as `First Name`, LastName as `Last Name`, Birthdate as `Date`, " +
                    "roles.Title as `User Role`, " +
                    "Email as `Email address`, offices.Title as `Office`, Active FROM users JOIN offices on (offices.ID = OfficeID) " +
                    "join roles on (roles.ID = RoleID) WHERE offices.Title = '" + off + "'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connStr);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();
                dataGridView1.DataSource = dt;
                int ageColumn_Index = dataGridView1.Columns[2].DisplayIndex;
                DataColumn age = dt.Columns.Add("Age", typeof(int));
                int dateColumn_Index = dataGridView1.Columns[7].DisplayIndex;
                dataGridView1.Columns[2].DisplayIndex = dateColumn_Index;
                dataGridView1.Columns[7].DisplayIndex = ageColumn_Index;
                dataGridView1.Columns[7].Width = 70;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string dates = row.Cells[2].Value.ToString();
                    string[] datesp = dates.Split(' ');
                    var date = DateTime.ParseExact(datesp[0], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    var ages = DateTime.Now.Year - date.Year;
                    if (DateTime.Now.Month < date.Month ||
                        (DateTime.Now.Month == date.Month && DateTime.Now.Day < date.Day)) ages--;
                    row.Cells[7].Value = ages.ToString();
                }
                PaintRow();
            }
        }
        private void Administrator_Load(object sender, EventArgs e) //complete
        {
            officeBox.SelectedIndex = 0;
            string connStr = "server=localhost;user=root;database=session1_xx;" +
                "password=As89149625780@;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "SELECT FirstName as `First Name`, LastName as `Last Name`, Birthdate as `Date`, " +
                "roles.Title as `User Role`, " +
                    "Email as `Email address`, offices.Title as `Office`, Active FROM users JOIN offices on " +
                    "(offices.ID = OfficeID) " +
                    "join roles on (roles.ID = RoleID)";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connStr);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[6].Visible = false;
            int ageColumn_Index = dataGridView1.Columns[2].DisplayIndex;
            DataColumn age = dt.Columns.Add("Age", typeof(int));
            int dateColumn_Index = dataGridView1.Columns[7].DisplayIndex;
            dataGridView1.Columns[2].DisplayIndex = dateColumn_Index;
            dataGridView1.Columns[7].DisplayIndex = ageColumn_Index;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[0].Width = 94;
            dataGridView1.Columns[1].Width = 94;
            dataGridView1.Columns[7].Width = 70;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 169;
            dataGridView1.Columns[5].Width = 120;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string dates = row.Cells[2].Value.ToString();
                string[] datesp = dates.Split(' ');
                var date = DateTime.ParseExact(datesp[0], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                var ages = DateTime.Now.Year - date.Year;
                if (DateTime.Now.Month < date.Month ||
                    (DateTime.Now.Month == date.Month && DateTime.Now.Day < date.Day)) ages--;
                row.Cells[7].Value = ages.ToString();
            }
            PaintRow();
        }
        private void PaintRow() //complete
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
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
        private void changerole_Click(object sender, EventArgs e) //complete
        {
            Edit_Role edit = new Edit_Role();
            edit.ShowDialog();
            UpdateTable();
        }
        private void enabledisable_Click(object sender, EventArgs e) //complete
        {
            string connStr = "server=localhost;user=root;database=session1_xx;" +
                "password=As89149625780@;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "SELECT ID, Active FROM users WHERE Email = '" + dataGridView1.CurrentRow.Cells[4].Value.ToString() + "'";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string id = reader[0].ToString();
            string active = reader[1].ToString();
            reader.Close();
            if (active == "True")
            {
                string query = "UPDATE users SET Active = 0 WHERE ID = " + id +
                    " AND Email = '" + dataGridView1.CurrentRow.Cells[4].Value.ToString() + "'";
                MySqlCommand commands = new MySqlCommand(query, conn);
                commands.ExecuteNonQuery();
                conn.Close();
            }
            else if (active == "False")
            {
                string query = "UPDATE users SET Active = 1 WHERE ID = " + id +
                    " AND Email = '" + dataGridView1.CurrentRow.Cells[4].Value.ToString() + "'";
                MySqlCommand commands = new MySqlCommand(query, conn);
                commands.ExecuteNonQuery();
                conn.Close();
            }
            UpdateTable();
        }

        private void Administrator_FormClosing(object sender, FormClosingEventArgs e)
        {
            string connection_to_server = "server=localhost;user=root;" +
                "database=session1_xx;password=As89149625780@;";
            MySqlConnection connection_to_datebase = new MySqlConnection(connection_to_server);
            connection_to_datebase.Open();
            string sql = "SELECT ID FROM trecking WHERE Email = '" + mail + "'";
            MySqlCommand cmnd = new MySqlCommand(sql, connection_to_datebase);
            MySqlDataReader reader = cmnd.ExecuteReader();
            while (reader.Read())
            {
                enter = reader[0].ToString();
            }
            reader.Close();
            string query = "UPDATE trecking SET Logout_date = CURDATE(), Logout_time = CURTIME() " +
                "WHERE Email = '" + mail + "' AND ID = " + enter;
            MySqlCommand command = new MySqlCommand(query, connection_to_datebase);
            command.ExecuteNonQuery();
            connection_to_datebase.Close();
        }
    }
}