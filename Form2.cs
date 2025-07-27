using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LoginForm
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            this.Close();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Kenneth\Documents\Visual Studio 2022\Projects\LoginForm\Accounts.accdb";



            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Users (LastName, FirstName, MiddleName, Birthday, PhoneNumber, Email, Username, PWord) " +
                        " VALUES (?, ?, ?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("?", LastNameIn.Text);
                        cmd.Parameters.AddWithValue("?", FirstNameIn.Text);
                        cmd.Parameters.AddWithValue("?", MiddleNameIn.Text);
                        cmd.Parameters.AddWithValue("?", BirthdayIn.Text);
                        cmd.Parameters.AddWithValue("?", PhoneIn.Text);
                        cmd.Parameters.AddWithValue("?", EmailIn.Text);
                        cmd.Parameters.AddWithValue("?", UsernameIn.Text);
                        cmd.Parameters.AddWithValue("?", PasswordIn.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Registration Complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        LoginForm loginForm = new LoginForm();
                        loginForm.Show();
                        this.Close();
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    // fix this
                    MessageBox.Show("Something went wrong!" + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // This is to make lables be transparent \/
            // Will change later
            label10.Parent = gradientPanel1;
            groupBox1.Parent = gradientPanel1;
            groupBox2.Parent = gradientPanel1;
            groupBox3.Parent = gradientPanel1;

            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            groupBox1.BackColor = Color.Transparent;
            groupBox2.BackColor = Color.Transparent;
            groupBox3.BackColor = Color.Transparent;
        }
    }
}
