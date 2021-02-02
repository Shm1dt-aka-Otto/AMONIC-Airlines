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

namespace AMONIC_Airlines_4
{
    public partial class AddSurvey : Form
    {
        public AddSurvey()
        {
            InitializeComponent();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            if (monthText.Text == "" &&  yearText.Text == "")
            {
                DialogResult dialogError = MessageBox.Show("Input Month and Year",
                            "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string connection_to_server = "server=localhost;user=root;database=amonic-airlines;" +
                    "password=As89149625780@;";
            MySqlConnection connection_to_database = new MySqlConnection(connection_to_server);
            connection_to_database.Open();
            string file = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files(*.csv)|*.csv";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileText.Text = dialog.FileName;
                file = System.IO.File.ReadAllText(fileText.Text);
            }
            string[] dataImport = file.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 1; i < dataImport.Length; i++)
            {
                string routeID = "0";
                string[] import = dataImport[i].Split(',');
                if (import[0] == "" || import[1] == "")
                {
                    routeID = "0";
                }
                else
                {
                    string sqlOne = "SELECT routes.ID FROM routes join airports air1 on (DepartureAirportID = air1.ID)" +
                        " join airports air2 on (ArrivalAirportID = air2.ID) WHERE air1.IATACode = '" + import[0] + 
                        "' AND air2.IATACode = '" + import[1] + "'";
                    MySqlCommand commandOne = new MySqlCommand(sqlOne, connection_to_database);
                    MySqlDataReader readerOne = commandOne.ExecuteReader();
                    if (readerOne.Read())
                    {
                        routeID = readerOne[0].ToString();
                    }
                    readerOne.Close();
                }
                string age = "0";
                if (import[2] == "")
                {
                    age = "0";
                }
                else
                {
                    age = import[2];
                }
                string sex = "0";
                if (import[3] == "")
                {
                    sex = "0";
                }
                else
                {
                    sex = import[3];
                }
                string cabinType = "0";
                if (import[4] == "")
                {
                    cabinType = "0";
                }
                else
                {
                    if (import[4] == "First")
                    {
                        import[4] = "First Class";
                    }
                    string sqlTwo = "SELECT ID FROM cabintypes WHERE Name = '" + import[4] + "'";
                    MySqlCommand commandTwo = new MySqlCommand(sqlTwo, connection_to_database);
                    MySqlDataReader readerTwo = commandTwo.ExecuteReader();
                    if (readerTwo.Read())
                    {
                        cabinType = readerTwo[0].ToString();
                    }
                    readerTwo.Close();
                }
                string queryOne = "INSERT INTO survey (RouteID, Age, Gender, CabinTypeID, QuestionOne, QuestionTwo, QuestionThree, " +
                    "QuestionFour, Month, Year) VALUES ('" + routeID + "', '" + age + "', '" + sex + "', '" + cabinType + "', '" + import[5] + "', '" +
                    import[6] + "', '" + import[7] + "', '" + import[8] + "', '" + monthText.Text + "', '" + yearText.Text + "')";
                MySqlCommand commandThree = new MySqlCommand(queryOne, connection_to_database);
                commandThree.ExecuteNonQuery();
            }
            successLabel.Visible = true;
            connection_to_database.Close();
        }

        private void AddSurvey_Load(object sender, EventArgs e)
        {
            successLabel.Visible = false;
        }
    }
}
