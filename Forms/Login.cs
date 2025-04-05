using System;
using System.Windows.Forms;
using PeopleBusinessLayer;
using Microsoft.Win32;
using System.Security.Cryptography;
using System.Text;
namespace DVLD
{
    public partial class Login : Form
    {
        clsUser User;

        string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";

        string ValueUserName = "UserName";
        string ValuePassword = "Password";
        string password;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbRemember_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRemember.Checked)
            {
                try
                {
                    Registry.SetValue(KeyPath, ValueUserName, tbUser.Text, RegistryValueKind.String);
                    Registry.SetValue(KeyPath, ValuePassword, tbPassword.Text, RegistryValueKind.String);
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    
                }
            }

        }

        private void LoadLoginData()
        {
            try
            {
                string UserNameValue = Registry.GetValue(KeyPath, ValueUserName, null) as string;
                string PasswordValue = Registry.GetValue(KeyPath, ValuePassword, null) as string;

                tbUser.Text = UserNameValue;
                tbPassword.Text = PasswordValue;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            LoadLoginData();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            password = clsglobal.ComputeHash(tbPassword.Text);
            User = clsUser.isUserExist(tbUser.Text, password);

            if (User !=null)
            {

                PublicUser loggedInUser = new PublicUser(User);

                // Store the user in the session
                SessionManager.Instance.SetUser(loggedInUser);

                // Hide the login form
                this.Hide();

                // Show the main form as a modal window
                Main main = new Main();
                main.ShowDialog();

                this.Show(); // Show the Login form again when the Main form is closed (optional)
            }
            else
            {
                MessageBox.Show("Error: Username or Password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
