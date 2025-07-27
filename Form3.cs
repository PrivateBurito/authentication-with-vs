using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form3 : Form
    {

        string userID;
        public Form3(string UserLogged)
        {
            InitializeComponent();
            userID = UserLogged;

        }

        private void Form3_Load(object sender, EventArgs e)
        {

            setupLabels();
            connectDatabase();
            opacityPanel();

        }
        private void setupLabels()
        {
            Color backColor = Color.Transparent;
            Color foreColor = Color.White;

            UserLabel.Parent = UserInfoPanel;
            FullnameLabel.Parent = UserInfoPanel;
            BirthdayLabel.Parent = UserInfoPanel;
            label1.Parent = UserInfoPanel;
            WelcomePanel.Parent = UserInfoPanel;

            UserLabel.BackColor = backColor;
            FullnameLabel.BackColor = backColor;
            BirthdayLabel.BackColor = backColor;
            label1.BackColor = backColor;
            WelcomePanel.BackColor = backColor;

            UserLabel.ForeColor = foreColor;
            FullnameLabel.ForeColor = foreColor;
            BirthdayLabel.ForeColor = foreColor;
            label1.ForeColor = foreColor;
            WelcomePanel.ForeColor = foreColor;
        }

        private void connectDatabase()
        {
            string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Kenneth\Documents\Visual Studio 2022\Projects\LoginForm\Accounts.accdb";
            string query = "SELECT * FROM Users WHERE Username = ?";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {

                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                {
                    // gives the query where Username is asking for "?" and the code directly below gives
                    // the "?" the value of userID which came from 'UserLogged' parameter of the Form3 constrcutor(?)
                    cmd.Parameters.AddWithValue("?", userID);
                    try
                    {
                        connection.Open();
                        OleDbDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            // it workssss!! might not be the best implementation but whatever
                            // ignore indentation, no auto format :(
                            /*
                             * i have no idea how reader works but from my understanding, it reads the Username that was given
                             * from userID and checks the column 'Username' on the DB and reads its row of origin.
                             */

                            UserLabel.Text = (string)reader["Username"];
                            FullnameLabel.Text = (string)reader["FirstName"] + " " + (string)reader["MiddleName"] + " " + (string)reader["LastName"];
                            BirthdayLabel.Text = (string)reader["Birthday"];



                        }
                        else
                        {
                            UserLabel.Text = "not found";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private void opacityPanel()
        {
            int colorOpacity = 75;
            Color panelColor = Color.DarkBlue;

            UserInfoPanel.BackColor = Color.FromArgb(colorOpacity, panelColor);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginPage = new LoginForm();
            loginPage.Show();
            this.Close();
        }
    }
}
