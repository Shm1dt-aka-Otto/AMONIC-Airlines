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
    public partial class EditRole : Form
    {
        public EditRole() //complete
        {
            InitializeComponent();
        }
        private void Edit_Role_Load(object sender, EventArgs e) //complete
        {
            this.officesTableAdapter.Fill(this.session1_xxDataSet1.offices);
        }
        private void applyButton_Click(object sender, EventArgs e) //complete
        {
            if (emailBox.Text == "" || firstNameBox.Text == "" || lastNameBox.Text == ""
                || officeBox.Text == "" || (userRadioButton.Checked == false && administratorRadioButton.Checked == false))
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
                string email = emailBox.Text;
                if (userRadioButton.Checked)
                {
                    string query = "UPDATE users SET RoleID = 2 WHERE Email = '" + email + "'";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.ExecuteNonQuery();
                    conn.Close();
                    Close();
                }
                else if (administratorRadioButton.Checked)
                {
                    string query = "UPDATE users SET RoleID = 1 WHERE Email = '" + email + "'";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.ExecuteNonQuery();
                    conn.Close();
                    Close();
                }
            }
        }
        private void cancelButton_Click(object sender, EventArgs e) //complete
        {
            Close();
        }
    }
}
