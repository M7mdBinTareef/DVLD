using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Forms;
using PeopleBusinessLayer;

namespace DVLD
{
    public partial class ManageUsers : Form
    {
        private DataTable dataTable;
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LoaddDataGridView()
        {
            dataTable = clsUser.GetAllUsers();

            // Bind the DataTable to the DataGridView
            Dgv1.DataSource = dataTable;
            lRecNumber.Text = (dataTable.Rows.Count).ToString();
            Dgv1.AllowUserToAddRows = false;
            cb1.SelectedIndex = 0;
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            _LoaddDataGridView();

        }

        private void _DeletePerson()
        {
            if (Dgv1.SelectedRows.Count > 0) // Ensure a row is selected
            {
                try
                {
                    // Extract the ContactID from the selected row
                    int UserID = Convert.ToInt32(Dgv1.SelectedRows[0].Cells["UserID"].Value);

                    // Call the DeleteContact method with the ContactID
                    bool isDeleted = clsUser.DeleteUser(UserID);

                    if (isDeleted)
                    {
                        MessageBox.Show("Contact deleted successfully.");

                        // Refresh the DataGridView after deletion
                        Dgv1.DataSource = clsUser.GetAllUsers();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the contact.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
            _LoaddDataGridView();
        }

       

        private void Filterdtb_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cb1.Text)
            {
                case "UserID":
                    FilterColumn = "UserID";
                    break;
                case "UserName":
                    FilterColumn = "UserName";
                    break;

                case "PersonID":
                    FilterColumn = "PersonID";
                    break;


                case "FullName":
                    FilterColumn = "FullName";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            if (Filterdtb.Text.Trim() == "" || FilterColumn == "None")
            {
                dataTable.DefaultView.RowFilter = "";
                lRecNumber.Text = dataTable.Rows.Count.ToString();
                return;
            }

            if (FilterColumn != "FullName" && FilterColumn != "UserName")
                //in this case we deal with numbers not string.
                dataTable.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, Filterdtb.Text.Trim());
            else
                dataTable.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, Filterdtb.Text.Trim());

            lRecNumber.Text = dataTable.Rows.Count.ToString();

        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Show or hide the filter textbox based on selected column
            if (cb1.Text == "IsActive")
            {
                Filterdtb.Visible = false;
                cbActive.Visible = true;
                cbActive.Focus();
                cbActive.SelectedIndex = 0;
            }

            else {

                Filterdtb.Visible = (cb1.Text != "None");
                cbActive.Visible = false;

                if (cb1.Text == "None")
                {
                    Filterdtb.Enabled = false;
                }
                else
                    Filterdtb.Enabled = true;

                Filterdtb.Text = "";
                Filterdtb.Focus();

            }
        }

        private void cbActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbActive.Text;

            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }

            if (FilterValue == "All")
                dataTable.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                dataTable.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lRecNumber.Text = dataTable.Rows.Count.ToString();

        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soon");
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soon");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _DeletePerson();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Dgv1.SelectedRows.Count > 0)
            {
                try
                {
                    // Safely convert the cell values to integers
                    var userIDValue = Convert.ToInt32(Dgv1.SelectedRows[0].Cells["UserID"].Value);
                    var personIDValue = Convert.ToInt32(Dgv1.SelectedRows[0].Cells["PersonID"].Value);

                    // Create and show the frmViewUsers dialog
                    frmViewUsers frmViewUsers = new frmViewUsers(personIDValue, userIDValue);
                    frmViewUsers.ShowDialog();
                }
                catch (InvalidCastException)
                {
                    MessageBox.Show("Error: Invalid data type in 'UserID' or 'PersonID'.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error: Select a row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Dgv1.SelectedRows.Count > 0)
            {
                try
                {
                    var userIDValue = Convert.ToInt32(Dgv1.SelectedRows[0].Cells["UserID"].Value);
                    var personIDValue = Convert.ToInt32(Dgv1.SelectedRows[0].Cells["PersonID"].Value);

                    frmChangePassword frmChangePassword = new frmChangePassword(personIDValue, userIDValue);
                    frmChangePassword.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error: Select a row.");
            }
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
                try
                {
                    int userIDValue = -1;

                    AddUpdateUser addUpdateUser = new AddUpdateUser(userIDValue);
                    addUpdateUser.UserDataUpdated += AddEditUserForm_UserDataUpdated;
                    addUpdateUser.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int ID = -1;
            try
            {
                var userIDValue = Convert.ToInt32(ID);

                AddUpdateUser addUpdateUser = new AddUpdateUser(userIDValue);
                addUpdateUser.UserDataUpdated += AddEditUserForm_UserDataUpdated;
                addUpdateUser.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Dgv1.SelectedRows.Count > 0)
            {
                try
                {
                    var userIDValue = Convert.ToInt32(Dgv1.SelectedRows[0].Cells["UserID"].Value);

                    AddUpdateUser addUpdateUser = new AddUpdateUser(userIDValue);
                    addUpdateUser.UserDataUpdated += AddEditUserForm_UserDataUpdated;
                    addUpdateUser.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error: Select a row.");
            }
        }

        private void AddEditUserForm_UserDataUpdated(clsUser UpdatedUser)
        {
            // Call GetpersonInfo or update the UI with the new data
            _LoaddDataGridView();

        }

        private void Filterdtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cb1.Text == "PersonID" || cb1.Text == "UserID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
