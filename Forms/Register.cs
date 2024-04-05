using C__LOGIN.DataClasses;
using Google.Cloud.Firestore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__LOGIN
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (pass.Text != confirmpass.Text)
            {
                MessageBox.Show("PASSWORD DOES NOT MATCH");
            }
            else
            {
                try
                {
                    var db = FirestoreAccess.Database;

                    if (!checkUser())
                    {
                        MessageBox.Show("USERNAME IS TAKEN");
                        return;
                    }
                    
                    var data = writeData();
                    DocumentReference docRef = db.Collection("UserData").Document(data.userName);
                    docRef.SetAsync(data);
                    MessageBox.Show("ACCOUNT CREATED");

                    this.Hide();
                    Login log = new Login();
                    log.ShowDialog();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private UserData writeData()
        {
            string fullname = FullName.Text.Trim();
            string user = Username.Text.Trim();
            string pass = Encryption.Encrypt(confirmpass.Text.Trim());

            return new UserData()
            {
                fullName = fullname,
                userName = user,
                password = pass,
            };
        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPass.Checked)
            {
                pass.UseSystemPasswordChar = false;
            }
            else
            {
                pass.UseSystemPasswordChar = true;
            }
        }

        private bool checkUser()
        {
            string user = Username.Text.Trim();

            var db = FirestoreAccess.Database;
            DocumentReference docRef = db.Collection("UserData").Document(user);
            UserData data = docRef.GetSnapshotAsync().Result.ConvertTo<UserData>();

            if(data != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
