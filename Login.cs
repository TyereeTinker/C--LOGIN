namespace C__LOGIN
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String user = Username.Text;
            String pass = Password.Text;

            if (user != "Admin" || pass != "PASS" )
            {
                MessageBox.Show("FAILED");
            } else
            {
                Register register = new Register();
                register.Show();
                this.Hide();
            }
        }
    }
}
