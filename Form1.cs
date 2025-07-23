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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            label1.Parent = gradientPanel1;
            label2.Parent = gradientPanel1;
            RegisterLabel.Parent = gradientPanel1;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            RegisterLabel.BackColor = Color.Transparent;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
