using System;
using System.Windows.Forms;
using DVLD.Forms;
using PeopleBusinessLayer;

namespace DVLD
{
    public partial class AddUpdateUser : Form
    {
        public delegate void UserDataUpdatedHandler(clsUser updatedUser);
        public event UserDataUpdatedHandler UserDataUpdated;

        private int UserID;
        private clsContact Person;
        private clsUser User;

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public AddUpdateUser(int userID)
        {
            InitializeComponent();
            UserID = userID;

            if (UserID == -1)
            {
                User = new clsUser();
                Mode = enMode.AddNew;
            }
            else // Update Mode
            {
                User = clsUser.Find(userID);
                if (User == null)
                {
                    MessageBox.Show("The user with the provided ID was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                lMain.Text = "Update User";
                gbFilterd.Enabled = false;
                lUserID.Text = User.UserID.ToString();
                lUserName.Text = User.UserName.ToString();
                cbIsActive.Checked = User.IsActive;
                Mode = enMode.Update;

                // Load the Person object using PersonID from User
                Person = clsContact.Find(User.PersonID);

                if (Person != null)
                {
                    viewDetails1.GetPersonInfo(Person.ID);
                }
                else
                {
                    MessageBox.Show("Associated person details could not be found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void LoadData()
        {
            if (cbFilterd.SelectedIndex == 0 && !string.IsNullOrEmpty(FilterdBox.Text))
            {
                int PersonID = Convert.ToInt32(FilterdBox.Text);
                Person = clsContact.Find(PersonID);

                if (Person != null)
                {
                    viewDetails1.GetPersonInfo(PersonID);
                }
                else
                {
                    MessageBox.Show("Person not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cbFilterd.SelectedIndex == 1 && !string.IsNullOrEmpty(FilterdBox.Text))
            {
                string NationalID = FilterdBox.Text;
                Person = clsContact.Find(NationalID);

                if (Person != null)
                {
                    viewDetails1.GetPersonInfo(Person.ID);
                }
                else
                {
                    MessageBox.Show("Person not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID = -1;
            AddEditPerson addEditPersonForm = new AddEditPerson(ID);
            addEditPersonForm.PersonDataUpdated += AddEditPersonForm_PersonDataUpdated;
            addEditPersonForm.ShowDialog();
        }

        private void AddEditPersonForm_PersonDataUpdated(clsContact updatedPerson)
        {
            viewDetails1.GetPersonInfo(updatedPerson.ID);
            Person = updatedPerson;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Person != null && Mode == enMode.AddNew)
            {
                if (clsUser.isUserExistPerID(Person.ID))
                {
                    MessageBox.Show("You Are Already a User in this System");
                    return;
                }
            }

            if (UserInfo.SelectedIndex < UserInfo.TabCount - 1)
            {
                UserInfo.SelectedIndex++;
            }
            else
            {
                MessageBox.Show("You are already on the last tab.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            parentForm?.Close();
        }

        private void UserInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserInfo.SelectedIndex == 1)
            {
                if (Person != null && Mode == enMode.AddNew)
                {
                    if (clsUser.isUserExistPerID(Person.ID))
                    {
                        MessageBox.Show("You Are Already a User in this System");
                        UserInfo.SelectedIndex--;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (User == null || Person == null)
                {
                    MessageBox.Show("Unable to save. User or Person object is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                User.PersonID = Person.ID;
                User.UserName = lUserName.Text;
                User.Password = tbPassword.Text;
                User.IsActive = cbIsActive.Checked;

                if (tbPassword.Text == tbConfirm.Text)
                {
                    if (User.Save())
                    {
                        UserDataUpdated?.Invoke(User);
                        MessageBox.Show("Person information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while saving the information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
