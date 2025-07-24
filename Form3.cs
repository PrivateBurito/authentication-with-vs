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
                        Fullname.Text = (string)reader["FirstName"] + " " + (string)reader["MiddleName"] + " " + (string)reader["LastName"];
                    } else
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
    }
}
