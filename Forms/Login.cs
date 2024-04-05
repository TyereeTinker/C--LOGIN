using C__LOGIN.DataClasses;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using Google.Cloud.Firestore;

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
            if (Username.Text == null || Password.Text == null)
            {
                MessageBox.Show("ALL FIELDS REQUIRED");
            }
            else
            {
                string user = Username.Text.Trim();
                string password = Password.Text;

                var db = FirestoreAccess.Database;
                DocumentReference docRef = db.Collection("UserData").Document(user);
                UserData data = docRef.GetSnapshotAsync().Result.ConvertTo<UserData>();

                if (data != null)
                {
                    if (password == Encryption.Decrypt(data.password))
                    {
                        string message = "Name: " + data.fullName + "\nUsername: " + data.userName + "\n\n ACCOUNT FOUND";
                        
                        MessageBox.Show(message);
                    }
                    else
                    {
                        MessageBox.Show("INCORRECT PASSWORD");
                    }

                }else
                {
                    MessageBox.Show("NO ACCOUNT FOUND");
                }
            }
        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
            this.Close();
        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPass.Checked)
            {
                Password.UseSystemPasswordChar = false;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
            }
        }
    }
}

