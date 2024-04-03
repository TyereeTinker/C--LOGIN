using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;

namespace C__LOGIN
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "iXIpQuOOw61dlKIvaqjmTXtjHC1i6AxEUMxdRsbv",
            BasePath = "https://login-signup-system-eb9a0-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;


        private void LoginButton_Click(object sender, EventArgs e)
        {
            String user = Username.Text;
            String pass = Password.Text;

            if (user != "Admin" || pass != "PASS")
            {
                MessageBox.Show("FAILED");
            }
            else
            {
                MessageBox.Show("Found");
            }
        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "CHECK CONNECTION");
            }
        }
    }
}

