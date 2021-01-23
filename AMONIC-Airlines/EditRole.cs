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
            this.officesTableAdapter1.Fill(this._amonic_airlinesDataSet.offices);
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
                string connection_to_server = "server=localhost;user=root;database=amonic-airlines;" +
                "password=As89149625780@;";
                MySqlConnection connection_to_datebase = new MySqlConnection(connection_to_server);
                connection_to_datebase.Open();
                string email = emailBox.Text;
                if (userRadioButton.Checked)
                {
                    string queryOne = "UPDATE users SET RoleID = 2 WHERE Email = '" + email + "'";
                    MySqlCommand commandOne = new MySqlCommand(queryOne, connection_to_datebase);
                    commandOne.ExecuteNonQuery();
                    connection_to_datebase.Close();
                    Close();
                }
                else if (administratorRadioButton.Checked)
                {
                    string queryOne = "UPDATE users SET RoleID = 1 WHERE Email = '" + email + "'";
                    MySqlCommand commandOne = new MySqlCommand(queryOne, connection_to_datebase);
                    commandOne.ExecuteNonQuery();
                    connection_to_datebase.Close();
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
