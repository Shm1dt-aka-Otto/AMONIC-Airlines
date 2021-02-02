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
    public partial class ResultSummary : Form
    {
        public ResultSummary()
        {
            InitializeComponent();
        }

        private void ResultSummary_Load(object sender, EventArgs e)
        {
            string connection_to_server = "server = localhost; user id = root; password = As89149625780@;" +
                        "persistsecurityinfo = True; database = amonic-airlines";
            MySqlConnection connection_to_database = new MySqlConnection(connection_to_server);
            connection_to_database.Open();
            int male = 0, female = 0, child = 0, young = 0, adult = 0, old = 0, economy = 0,
                business = 0, first = 0, auh = 0, bah = 0, doh = 0, ruh = 0, cai = 0, allPass = 0;
            string sqlOne = "SELECT COUNT(*) FROM survey";
            MySqlCommand commandOne = new MySqlCommand(sqlOne, connection_to_database);
            MySqlDataReader readerOne = commandOne.ExecuteReader();
            if (readerOne.Read())
            {
                allPass = Convert.ToInt32(readerOne[0].ToString());
                amountLabel.Text = "Sample Size: " + allPass.ToString() + " Adults";
            }
            readerOne.Close();
            string sqlTwo = "SELECT COUNT(*) FROM survey GROUP BY Gender";
            MySqlCommand commandTwo = new MySqlCommand(sqlTwo, connection_to_database);
            MySqlDataReader readerTwo = commandTwo.ExecuteReader();
            while (readerTwo.Read())
            {
                if (male == 0)
                {
                    male = Convert.ToInt32(readerTwo[0].ToString());
                }
                else
                {
                    female = Convert.ToInt32(readerTwo[0].ToString());
                    break;
                }
            }
            readerTwo.Close();
            string sqlThree = "SELECT COUNT(*) FROM survey GROUP BY Age ORDER BY Age ASC";
            MySqlCommand commandThree = new MySqlCommand(sqlThree, connection_to_database);
            MySqlDataReader readerThree = commandThree.ExecuteReader();
            int i = 0;
            while (readerThree.Read())
            {
                if (i == 0)
                {
                    i++;
                }
                else
                {
                    if (i < 8)
                    {
                        child += Convert.ToInt32(readerThree[0].ToString());
                        i++;
                    }
                    else if (i > 7 && i < 23 )
                    {
                        young += Convert.ToInt32(readerThree[0].ToString());
                        i++;
                    }
                    else if (i > 22 && i < 43)
                    {
                        adult += Convert.ToInt32(readerThree[0].ToString());
                        i++;
                    }
                    else
                    {
                        old += Convert.ToInt32(readerThree[0].ToString());
                        i++;
                    }
                }
            }
            readerThree.Close();
            string sqlFour = "SELECT COUNT(*) FROM survey GROUP BY CabinTypeID";
            MySqlCommand commandFour = new MySqlCommand(sqlFour, connection_to_database);
            MySqlDataReader readerFour= commandFour.ExecuteReader();
            i = 0;
            while (readerFour.Read())
            {
                if (i == 0)
                {
                    i++;
                }
                else
                {
                    if (economy == 0)
                    {
                        economy += Convert.ToInt32(readerFour[0].ToString());
                    }
                    else if (business == 0)
                    {
                        business += Convert.ToInt32(readerFour[0].ToString());
                    }
                    else
                    {
                        first += Convert.ToInt32(readerFour[0].ToString());
                    }
                }
            }
            readerFour.Close();
            string sqlFive = "SELECT COUNT(*) FROM survey GROUP BY RouteID";
            MySqlCommand commandFive = new MySqlCommand(sqlFive, connection_to_database);
            MySqlDataReader readerFive = commandFive.ExecuteReader();
            i = 0;
            while (readerFive.Read())
            {
                if (i == 0)
                {
                    i++;
                }
                else
                {
                    if (i == 2 || i == 4 || i == 6 || i == 8)
                    {
                        auh += Convert.ToInt32(readerFive[0].ToString());
                        i++;
                    }
                    else if (i == 1)
                    {
                        bah += Convert.ToInt32(readerFive[0].ToString());
                        i++;
                    }
                    else if (i == 3)
                    {
                        ruh += Convert.ToInt32(readerFive[0].ToString());
                        i++;
                    }
                    else if (i == 5)
                    {
                        doh += Convert.ToInt32(readerFive[0].ToString());
                        i++;
                    }
                    else
                    {
                        cai += Convert.ToInt32(readerFive[0].ToString());
                        i++;
                    }
                }
            }
            readerFive.Close();
            summaryGridView.Rows.Add(male, female, child, young, adult, old, economy, business, first,
                auh, bah, doh, ruh, cai);
            string firstMonth = "", lastMonth = "";
            string sqlSix = "SELECT Month, Year from survey order by month desc limit 1";
            MySqlCommand commandSix = new MySqlCommand(sqlSix, connection_to_database);
            MySqlDataReader readerSix = commandSix.ExecuteReader();
            if (readerSix.Read())
            {
                firstMonth = readerSix[0].ToString() + " " + readerSix[1].ToString();
            }
            readerSix.Close();
            string sqlSeven = "SELECT Month, Year from survey order by month asc limit 1";
            MySqlCommand commandSeven = new MySqlCommand(sqlSeven, connection_to_database);
            MySqlDataReader readerSeven = commandSeven.ExecuteReader();
            if (readerSeven.Read())
            {
                lastMonth = readerSeven[0].ToString() + " " + readerSeven[1].ToString();
            }
            readerSeven.Close();
            fieldworkLabel.Text = "Fieldwork: " + firstMonth + " - " + lastMonth;
            connection_to_database.Close();
        }
    }
}
