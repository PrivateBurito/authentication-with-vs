using System.Data;
using System.Data.OleDb;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LoginForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerWindow = new RegisterForm();
            registerWindow.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) //login button
        {
            string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Kenneth\Documents\Visual Studio 2022\Projects\LoginForm\Accounts.accdb";

            using (OleDbConnection connection = new OleDbConnection(connectionString)) {

                try
                {
                    connection.Open();

                    string query = "Select * from Users where Username = '" + usernameIn.Text.Trim() + "'and Pword ='" + passwordIn.Text.Trim() + "'";
                    OleDbDataAdapter sda = new OleDbDataAdapter(query, connection);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);

                    if (dtbl.Rows.Count == 1)
                    {
                        string userLogged = usernameIn.Text.Trim();
                        Form3 form = new Form3(userLogged);
                        this.Hide();
                        form.Show();
                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Check Your Username and Password!");
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("something went wrong! " + ex.Message);
                }
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Color forColor = Color.White;
            label1.Parent = gradientPanel1;
            label2.Parent = gradientPanel1;
            RegisterLabel.Parent = gradientPanel1;

            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            RegisterLabel.BackColor = Color.Transparent;

            label1.ForeColor = forColor;
            label2.ForeColor = forColor;
            RegisterLabel.ForeColor = forColor;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
