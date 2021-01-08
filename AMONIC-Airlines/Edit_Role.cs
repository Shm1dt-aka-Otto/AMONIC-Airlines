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
    public partial class Edit_Role : Form
    {
        public Edit_Role()
        {
            InitializeComponent();
        }

        private void Edit_Role_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "session1_xxDataSet1.offices". При необходимости она может быть перемещена или удалена.
            this.officesTableAdapter.Fill(this.session1_xxDataSet1.offices);

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            if (mail.Text == "" || first.Text == "" || last.Text == ""
                || off.Text == "" || (user.Checked == false && admin.Checked == false))
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
                string email = mail.Text;
                if (user.Checked)
                {
                    string query = "UPDATE users SET RoleID = 2 WHERE Email = '" + email + "'";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.ExecuteNonQuery();
                    conn.Close();
                    Close();
                }
                else if (admin.Checked)
                {
                    string query = "UPDATE users SET RoleID = 1 WHERE Email = '" + email + "'";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.ExecuteNonQuery();
                    conn.Close();
                    Close();
                }
            }
        }

        private void mail_Click(object sender, EventArgs e)
        {
            mail.Text = "";
        }

        private void first_Click(object sender, EventArgs e)
        {
            first.Text = "";
        }

        private void last_Click(object sender, EventArgs e)
        {
            last.Text = "";
        }
    }
}
