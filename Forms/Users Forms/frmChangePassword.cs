using System;
using System.Windows.Forms;
using PeopleBusinessLayer;

namespace DVLD.Forms
{
    public partial class frmChangePassword : Form
    {
        clsUser User;
        private int _UserID;
        public frmChangePassword(int PersonID, int UserID)
        {
            InitializeComponent();
            viewDetails1.GetPersonInfo(PersonID);
            viewUser1.LoadPersonData(UserID);
            this._UserID = UserID;
        }

        private void UpdatePassword()
        {
            User = clsUser.Find(_UserID);

            if (string.IsNullOrWhiteSpace(tbCurrent.Text) || string.IsNullOrWhiteSpace(tbNew.Text) || string.IsNullOrWhiteSpace(tbConfirm.Text))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (User != null)
            {
                    if (tbNew.Text == tbConfirm.Text)
                    {
                        if (tbNew.Text != tbCurrent.Text)
                        {
                            User.Password = tbNew.Text;
                            if (User.Save())
                            {
                                MessageBox.Show("Password saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                tbCurrent.Clear();
                                tbNew.Clear();
                                tbConfirm.Clear();
                            }
                            else
                            {
                                MessageBox.Show("An error occurred while saving the password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("New password cannot be the same as the current password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The new password and confirmation do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            
            else
            {
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdatePassword();
        }
    }
}
