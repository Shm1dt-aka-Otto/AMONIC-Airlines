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
        public Administrator(string email)
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            this.rolesTableAdapter.Fill(this.session1_xxDataSet1.roles);
            this.officesTableAdapter.Fill(this.session1_xxDataSet1.offices);
            this.usersTableAdapter.Fill(this.session1_xxDataSet1.users);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[3].Value.ToString() == "1")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                if (row.Cells[6].Value.ToString() == "False")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_usercs add = new Add_usercs();
            add.Owner = this;
            add.Show();
            usersTableAdapter.Update(session1_xxDataSet1.users);
            dataGridView1.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=session1_xx;" +
                "password=As89149625780@;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string off = comboBox1.Text;
            string sql = "SELECT FirstName, LastName, Birthdate, RoleID, " +
                "Email, OfficeID, Active FROM users JOIN offices on (offices.ID = OfficeID) " +
                "join roles on (roles.ID = RoleID) WHERE offices.Title = '" + off + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connStr);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[3].Value.ToString() == "1")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                if (row.Cells[6].Value.ToString() == "False")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void changerole_Click(object sender, EventArgs e)
        {
            Edit_Role edit = new Edit_Role();
            edit.Owner = this;
            edit.Show();
            usersTableAdapter.Update(session1_xxDataSet1.users);
            dataGridView1.Refresh();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[3].Value.ToString() == "1")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                if (row.Cells[6].Value.ToString() == "False")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void enabledisable_Click(object sender, EventArgs e)
        {
            string mail = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string connStr = "server=localhost;user=root;database=session1_xx;" +
                "password=As89149625780@;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "SELECT ID FROM users WHERE Email = '" + mail + "'";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string id = reader[0].ToString();
            conn.Close();
            conn.Open();
            string sqls = "SELECT Active FROM users WHERE Email = '" + mail + "'";
            MySqlCommand commander = new MySqlCommand(sqls, conn);
            MySqlDataReader readers = commander.ExecuteReader();
            readers.Read();
            string active = readers[0].ToString();
            conn.Close();
            conn.Open();
            if (active == "true")
            {
                string query = "UPDATE users SET Active = 0 WHERE ID = '" + id +
                    "' AND Email = '" + mail + "'";
                MySqlCommand commands = new MySqlCommand(query, conn);
                commands.ExecuteNonQuery();
                conn.Close();
            }
            else if (active == "false")
            {
                string query = "UPDATE users SET Active = 1 WHERE ID = '" + id +
                    "' AND Email = '" + mail + "'";
                MySqlCommand commands = new MySqlCommand(query, conn);
                commands.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
