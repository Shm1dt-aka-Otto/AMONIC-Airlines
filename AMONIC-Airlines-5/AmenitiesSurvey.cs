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

namespace AMONIC_Airlines_5
{
    public partial class AmenitiesSurvey : Form
    {
        public AmenitiesSurvey()
        {
            InitializeComponent();
        }

        private void AmenitiesSurvey_Load(object sender, EventArgs e)
        {
            string connection_to_server = "server=localhost;user=root;database=amonic-airlines;" +
                    "password=As89149625780@;";
            MySqlConnection connection_to_database = new MySqlConnection(connection_to_server);
            connection_to_database.Open();
            string sql = "SELECT Date from schedules";
            MySqlCommand command = new MySqlCommand(sql, connection_to_database);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string[] dateSplit = reader[0].ToString().Split(' ');
                if (dateBox.Items.Contains(dateSplit[0])) { }
                else
                {
                    dateBox.Items.Add(dateSplit[0]);
                }
            }
            reader.Close();
            connection_to_database.Close();
        }

        private void dateBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            scheduleBox.Enabled = true;
            scheduleBox.Items.Clear();
            string connection_to_server = "server=localhost;user=root;database=amonic-airlines;" +
                    "password=As89149625780@;";
            MySqlConnection connection_to_database = new MySqlConnection(connection_to_server);
            connection_to_database.Open();
            string[] dateSplit = dateBox.Text.Split('.');
            string require = dateSplit[2] + dateSplit[1] + dateSplit[0];
            string sql = "SELECT ID from schedules where Date = '" + require + "'";
            MySqlCommand command = new MySqlCommand(sql, connection_to_database);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                scheduleBox.Items.Add(reader[0].ToString());
            }
            reader.Close();
            connection_to_database.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (dateBox.Text == "")
            {
                DialogResult dialogError = MessageBox.Show("Add date!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (scheduleBox.Enabled == true && scheduleBox.Text != "")
            {
                surveyGridView.Rows.Clear();
                string connection_to_server = "server=localhost;user=root;database=amonic-airlines;" +
                    "password=As89149625780@;";
                MySqlConnection connection_to_database = new MySqlConnection(connection_to_server);
                connection_to_database.Open();
                for (int i = 0; i < 3; i++)
                {
                    string one = "0", two = "0", three = "0", four = "0", five = "0", six = "0", seven = "0", eight = "0",
                        nine = "0", ten = "0", eleven = "0", twelve = "0";
                    string sql = "", cabin = "";
                    if (i == 0)
                    {
                        sql = "select count(*), AmenityID from amenitiestickets join tickets on (tickets.ID = TicketID)" +
                            "join cabintypes on(CabinTypeID = cabintypes.ID) where ScheduleID = '" + scheduleBox.Text + "' " +
                            "and cabintypes.Name = 'Economy' group by AmenityID";
                        cabin = "Economy";
                    }
                    else if (i == 1)
                    {
                        sql = "select count(*), AmenityID from amenitiestickets join tickets on (tickets.ID = TicketID)" +
                            "join cabintypes on(CabinTypeID = cabintypes.ID) where ScheduleID = '" + scheduleBox.Text + "' " +
                            "and cabintypes.Name = 'Business' group by AmenityID";
                        cabin = "Business";
                    }
                    else
                    {
                        sql = "select count(*), AmenityID from amenitiestickets join tickets on (tickets.ID = TicketID)" +
                            "join cabintypes on(CabinTypeID = cabintypes.ID) where ScheduleID = '" + scheduleBox.Text + "' " +
                            "and cabintypes.Name = 'First Class' group by AmenityID";
                        cabin = "First Class";
                    }
                    MySqlCommand command = new MySqlCommand(sql, connection_to_database);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        switch (reader[1].ToString())
                        {
                            case "1":
                                {
                                    one = reader[0].ToString();
                                    break;
                                }
                            case "2":
                                {
                                    two = reader[0].ToString();
                                    break;
                                }
                            case "3":
                                {
                                    three = reader[0].ToString();
                                    break;
                                }
                            case "4":
                                {
                                    four = reader[0].ToString();
                                    break;
                                }
                            case "5":
                                {
                                    five = reader[0].ToString();
                                    break;
                                }
                            case "6":
                                {
                                    six = reader[0].ToString();
                                    break;
                                }
                            case "7":
                                {
                                    seven = reader[0].ToString();
                                    break;
                                }
                            case "8":
                                {
                                    eight = reader[0].ToString();
                                    break;
                                }
                            case "9":
                                {
                                    nine = reader[0].ToString();
                                    break;
                                }
                            case "10":
                                {
                                    ten = reader[0].ToString();
                                    break;
                                }
                            case "11":
                                {
                                    eleven = reader[0].ToString();
                                    break;
                                }
                            case "12":
                                {
                                    twelve = reader[0].ToString();
                                    break;
                                }
                        }
                    }
                    reader.Close();
                    surveyGridView.Rows.Add(cabin, one, two, three, four, five, six, seven,
                        eight, nine, ten, eleven, twelve);
                }
                connection_to_database.Close();
            }
            else
            {
                string connection_to_server = "server=localhost;user=root;database=amonic-airlines;" +
                    "password=As89149625780@;";
                MySqlConnection connection_to_database = new MySqlConnection(connection_to_server);
                connection_to_database.Open();
                int[] economy = new int[12];
                int[] business = new int[12];
                int[] first = new int[12];
                for (int i = 0; i < scheduleBox.Items.Count; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        string sql = "";
                        if (j == 0)
                        {
                            sql = "select count(*), AmenityID from amenitiestickets join tickets on (tickets.ID = TicketID)" +
                            "join cabintypes on(CabinTypeID = cabintypes.ID) where ScheduleID = '" + scheduleBox.Items[i].ToString() +
                            "' and cabintypes.Name = 'Economy' group by AmenityID";
                        }
                        else if (j == 1)
                        {
                            sql = "select count(*), AmenityID from amenitiestickets join tickets on (tickets.ID = TicketID)" +
                            "join cabintypes on(CabinTypeID = cabintypes.ID) where ScheduleID = '" + scheduleBox.Items[i].ToString() +
                            "' and cabintypes.Name = 'Business' group by AmenityID";
                        }
                        else
                        {
                            sql = "select count(*), AmenityID from amenitiestickets join tickets on (tickets.ID = TicketID)" +
                            "join cabintypes on(CabinTypeID = cabintypes.ID) where ScheduleID = '" + scheduleBox.Items[i].ToString() +
                            "' and cabintypes.Name = 'First Class' group by AmenityID";
                        }
                        MySqlCommand command = new MySqlCommand(sql, connection_to_database);
                        MySqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            switch (reader[1].ToString())
                            {
                                case "1":
                                    {
                                        if (j == 0)
                                        {
                                            economy[0] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                        else if (j == 1)
                                        {
                                            business[0] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                        else
                                        {
                                            first[0] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                    }
                                case "2":
                                    {
                                        if (j == 0)
                                        {
                                            economy[1] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                        else if (j == 1)
                                        {
                                            business[1] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                        else
                                        {
                                            first[1] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                    }
                                case "3":
                                    {
                                        if (j == 0)
                                        {
                                            economy[2] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                        else if (j == 1)
                                        {
                                            business[2] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                        else
                                        {
                                            first[2] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                    }
                                case "4":
                                    {
                                        if (j == 0)
                                        {
                                            economy[3] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                        else if (j == 1)
                                        {
                                            business[3] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                        else
                                        {
                                            first[3] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                    }
                                case "5":
                                    {
                                        if (j == 0)
                                        {
                                            economy[4] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                        else if (j == 1)
                                        {
                                            business[4] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                        else
                                        {
                                            first[4] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                    }
                                case "6":
                                    {
                                        if (j == 0)
                                        {
                                            economy[5] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                        else if (j == 1)
                                        {
                                            business[5] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                        else
                                        {
                                            first[5] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                    }
                                case "7":
                                    {
                                        if (j == 0)
                                        {
                                            economy[6] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                        else if (j == 1)
                                        {
                                            business[6] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                        else
                                        {
                                            first[6] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                    }
                                case "8":
                                    {
                                        if (j == 0)
                                        {
                                            economy[7] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                        else if (j == 1)
                                        {
                                            business[7] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                        else
                                        {
                                            first[7] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                    }
                                case "9":
                                    {
                                        if (j == 0)
                                        {
                                            economy[8] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                        else if (j == 1)
                                        {
                                            business[8] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                        else
                                        {
                                            first[8] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                    }
                                case "10":
                                    {
                                        if (j == 0)
                                        {
                                            economy[9] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                        else if (j == 1)
                                        {
                                            business[9] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                        else
                                        {
                                            first[9] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                    }
                                case "11":
                                    {
                                        if (j == 0)
                                        {
                                            economy[10] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                        else if (j == 1)
                                        {
                                            business[10] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                        else
                                        {
                                            first[10] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                    }
                                case "12":
                                    {
                                        if (j == 0)
                                        {
                                            economy[11] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                        else if (j == 1)
                                        {
                                            business[11] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                        else
                                        {
                                            first[11] = Convert.ToInt32(reader[0].ToString());
                                            break;
                                        }
                                    }
                            }
                        }
                        reader.Close();
                    }
                }
                surveyGridView.Rows.Add("Economy", economy[0], economy[1], economy[2], economy[3], economy[4],
                    economy[5], economy[6], economy[7], economy[8], economy[9], economy[10], economy[11]);
                surveyGridView.Rows.Add("Business", business[0], business[1], business[2], business[3], business[4],
                    business[5], business[6], business[7], business[8], business[9], business[10], business[11]);
                surveyGridView.Rows.Add("First Class", first[0], first[1], first[2], first[3], first[4],
                    first[5], first[6], first[7], first[8], first[9], first[10], first[11]);
                connection_to_database.Close();
            }
        }
    }
}
