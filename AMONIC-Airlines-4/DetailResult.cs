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
    public partial class DetailResult : Form
    {
        public DetailResult()
        {
            InitializeComponent();
        }
        private void PaintRows()
        {
            foreach (DataGridViewRow row in detailGridView.Rows)
            {
                if (Convert.ToInt32(row.Index) % 2 == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }
        private void FillTable(string str, string trg1, string trg2)
        {
            string connection_to_server = "server = localhost; user id = root; password = As89149625780@;" +
               "persistsecurityinfo = True; database = amonic-airlines";
            MySqlConnection connection_to_database = new MySqlConnection(connection_to_server);
            connection_to_database.Open();
            int male = 0, female = 0, child = 0, young = 0, adult = 0, old = 0, economy = 0,
                business = 0, first = 0, auh = 0, bah = 0, doh = 0, ruh = 0, cai = 0, total = 0;
            string sqlOne = "SELECT COUNT(*) FROM survey " + str + " GROUP BY Gender";
            MySqlCommand commandOne = new MySqlCommand(sqlOne, connection_to_database);
            MySqlDataReader readerOne = commandOne.ExecuteReader();
            while (readerOne.Read())
            {
                if (trg1 != "")
                {
                    if (trg1 == "M")
                    {
                        male = Convert.ToInt32(readerOne[0].ToString());
                        break;
                    }
                    else
                    {
                        female = Convert.ToInt32(readerOne[0].ToString());
                        break;
                    }
                }
                else
                {
                    if (male == 0)
                    {
                        male = Convert.ToInt32(readerOne[0].ToString());
                    }
                    else
                    {
                        female = Convert.ToInt32(readerOne[0].ToString());
                        break;
                    }
                }
            }
            readerOne.Close();
            string sqlTwo = "SELECT COUNT(*) FROM survey " + str + " GROUP BY Age ORDER BY Age ASC";
            MySqlCommand commandTwo = new MySqlCommand(sqlTwo, connection_to_database);
            MySqlDataReader readerTwo = commandTwo.ExecuteReader();
            int i = 0;
            while (readerTwo.Read())
            {
                if (trg2 != "")
                {
                    if (trg2 == "18-24")
                    {
                        child += Convert.ToInt32(readerTwo[0].ToString());
                    }
                    else if (trg2 == "25-39")
                    {
                        young += Convert.ToInt32(readerTwo[0].ToString());
                    }
                    else if (trg2 == "40-59")
                    {
                        adult += Convert.ToInt32(readerTwo[0].ToString());
                    }
                    else
                    {
                        old += Convert.ToInt32(readerTwo[0].ToString());
                    }
                }
                else
                {
                    if (i == 0)
                    {
                        i++;
                    }
                    else
                    {
                        if (i < 8)
                        {
                            child += Convert.ToInt32(readerTwo[0].ToString());
                            i++;
                        }
                        else if (i > 7 && i < 23)
                        {
                            young += Convert.ToInt32(readerTwo[0].ToString());
                            i++;
                        }
                        else if (i > 22 && i < 43)
                        {
                            adult += Convert.ToInt32(readerTwo[0].ToString());
                            i++;
                        }
                        else
                        {
                            old += Convert.ToInt32(readerTwo[0].ToString());
                            i++;
                        }
                    }
                }
            }
            readerTwo.Close();
            string sqlThree = "SELECT COUNT(*) FROM survey " + str + " GROUP BY CabinTypeID";
            MySqlCommand commandThree = new MySqlCommand(sqlThree, connection_to_database);
            MySqlDataReader readerThree = commandThree.ExecuteReader();
            i = 0;
            while (readerThree.Read())
            {
                if (i == 0)
                {
                    i++;
                }
                else
                {
                    if (economy == 0)
                    {
                        economy += Convert.ToInt32(readerThree[0].ToString());
                    }
                    else if (business == 0)
                    {
                        business += Convert.ToInt32(readerThree[0].ToString());
                    }
                    else
                    {
                        first += Convert.ToInt32(readerThree[0].ToString());
                    }
                }
            }
            readerThree.Close();
            string sqlFour = "SELECT COUNT(*) FROM survey " + str + " GROUP BY RouteID";
            MySqlCommand commandFour = new MySqlCommand(sqlFour, connection_to_database);
            MySqlDataReader readerFour = commandFour.ExecuteReader();
            i = 0;
            while (readerFour.Read())
            {
                if (i == 0)
                {
                    i++;
                }
                else
                {
                    if (i == 2 || i == 4 || i == 6 || i == 8)
                    {
                        auh += Convert.ToInt32(readerFour[0].ToString());
                        i++;
                    }
                    else if (i == 1)
                    {
                        bah += Convert.ToInt32(readerFour[0].ToString());
                        i++;
                    }
                    else if (i == 3)
                    {
                        ruh += Convert.ToInt32(readerFour[0].ToString());
                        i++;
                    }
                    else if (i == 5)
                    {
                        doh += Convert.ToInt32(readerFour[0].ToString());
                        i++;
                    }
                    else
                    {
                        cai += Convert.ToInt32(readerFour[0].ToString());
                        i++;
                    }
                }
            }
            readerFour.Close();
            string sqlFive = "SELECT COUNT(*) FROM survey " + str;
            MySqlCommand commandFive = new MySqlCommand(sqlFive, connection_to_database);
            MySqlDataReader readerFive = commandFive.ExecuteReader();
            if (readerFive.Read())
            {
                total = Convert.ToInt32(readerFive[0].ToString());
            }
            readerFive.Close();
            detailGridView.Rows.Add(total, male, female, child, young, adult, old, economy, business,
                first, auh, bah, doh, ruh, cai);
            connection_to_database.Close();
            PaintRows();
        }
        private void ArgumentsForFill()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    string require = "";
                    string triggerOne = "", triggerTwo = "";
                    if (timeBox.Text != "All time")
                    {
                        string[] split = timeBox.Text.Split(' ');
                        require = "WHERE Month = '" + split[0] + "' AND Year = '" + split[1] + "'";
                    }
                    if (genderCheck.Checked == true && genderCombo.Text != "All genders")
                    {
                        string substring = genderCombo.Text.Substring(0, 1);
                        if (require != "")
                        {
                            require += " AND Gender = '" + substring.ToUpper() + "'";
                            triggerOne = substring.ToUpper();
                        }
                        else
                        {
                            require = "WHERE Gender = '" + substring.ToUpper() + "'";
                            triggerOne = substring.ToUpper();
                        }
                    }
                    if (ageCheck.Checked == true && ageCombo.Text != "All ages")
                    {
                        if (require != "")
                        {
                            if (ageCombo.Text == "18-24")
                            {
                                triggerTwo = "18-24";
                                require += " AND Age BETWEEN 18 AND 24";
                            }
                            else if (ageCombo.Text == "25-39")
                            {
                                triggerTwo = "25-39";
                                require += " AND Age BETWEEN 25 AND 39";
                            }
                            else if (ageCombo.Text == "40-59")
                            {
                                triggerTwo = "40-59";
                                require += " AND Age BETWEEN 40 AND 59";
                            }
                            else
                            {
                                triggerTwo = "60+";
                                require += " AND Age BETWEEN 60 AND 150";
                            }
                        }
                        else
                        {
                            if (ageCombo.Text == "18-24")
                            {
                                triggerTwo = "18-24";
                                require = "WHERE Age BETWEEN 18 AND 24";
                            }
                            else if (ageCombo.Text == "25-39")
                            {
                                triggerTwo = "25-39";
                                require = "WHERE Age BETWEEN 25 AND 39";
                            }
                            else if (ageCombo.Text == "40-59")
                            {
                                triggerTwo = "40-59";
                                require = "WHERE Age BETWEEN 40 AND 59";
                            }
                            else
                            {
                                triggerTwo = "60+";
                                require = "WHERE Age BETWEEN 60 AND 150";
                            }
                        }
                    }
                    if (i == 1)
                    {
                        if (require != "")
                        {
                            require += " AND QuestionOne = '" + j.ToString() + "'";
                            FillTable(require, triggerOne, triggerTwo);
                        }
                        else
                        {
                            require = "WHERE QuestionOne = '" + j.ToString() + "'";
                            FillTable(require, triggerOne, triggerTwo);
                        }
                    }
                    else if (i == 2)
                    {
                        if (require != "")
                        {
                            require += " AND QuestionTwo = '" + j.ToString() + "'";
                            FillTable(require, triggerOne, triggerTwo);
                        }
                        else
                        {
                            require = "WHERE QuestionTwo = '" + j.ToString() + "'";
                            FillTable(require, triggerOne, triggerTwo);
                        }
                    }
                    else if (i == 3)
                    {
                        if (require != "")
                        {
                            require += " AND QuestionThree = '" + j.ToString() + "'";
                            FillTable(require, triggerOne, triggerTwo);
                        }
                        else
                        {
                            require = "WHERE QuestionThree = '" + j.ToString() + "'";
                            FillTable(require, triggerOne, triggerTwo);
                        }
                    }
                    else
                    {
                        if (require != "")
                        {
                            require += " AND QuestionFour = '" + j.ToString() + "'";
                            FillTable(require, triggerOne, triggerTwo);
                        }
                        else
                        {
                            require = "WHERE QuestionFour = '" + j.ToString() + "'";
                            FillTable(require, triggerOne, triggerTwo);
                        }
                    }
                }
                detailGridView.Rows.Add("", "", "", "", "", "", "", "", "", "", "", "",
                    "", "");
            }
        }
        private void DetailResult_Load(object sender, EventArgs e)
        {
            timeBox.SelectedIndex = 0;
            genderCombo.SelectedIndex = 0;
            ageCombo.SelectedIndex = 0;
            string connection_to_server = "server = localhost; user id = root; password = As89149625780@;" +
                        "persistsecurityinfo = True; database = amonic-airlines";
            MySqlConnection connection_to_database = new MySqlConnection(connection_to_server);
            connection_to_database.Open();
            string sqlOne = "SELECT Month, Year from survey group by Month order by Month desc";
            MySqlCommand commandOne = new MySqlCommand(sqlOne, connection_to_database);
            MySqlDataReader readerOne = commandOne.ExecuteReader();
            while (readerOne.Read())
            {
                timeBox.Items.Add(readerOne[0].ToString() + " " + readerOne[1].ToString());
            }
            readerOne.Close();
            connection_to_database.Close();
            ArgumentsForFill();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            detailGridView.Rows.Clear();
            ArgumentsForFill();
        }
    }
}
