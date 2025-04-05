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
    public partial class ManagePeople : Form
    {

        public ManagePeople()
        {
            InitializeComponent();

        }

        private DataTable dataTable;

        private void _LoaddDataGridView()
        {
            dataTable = clsContact.GetAllContacts();

            // Bind the DataTable to the DataGridView
            Dgv1.DataSource = dataTable;
            lRecNumber.Text = (dataTable.Rows.Count).ToString();
            Dgv1.AllowUserToAddRows = false;
            
        }

        private void _DeletePerson()
        {
            if (Dgv1.SelectedRows.Count > 0) // Ensure a row is selected
            {
                try
                {
                    // Extract the ContactID from the selected row
                    int PersonID = Convert.ToInt32(Dgv1.SelectedRows[0].Cells["PersonID"].Value);

                    // Call the DeleteContact method with the ContactID
                    bool isDeleted = clsContact.DeleteContact(PersonID);

                    if (isDeleted)
                    {
                        MessageBox.Show("Contact deleted successfully.");

                        // Refresh the DataGridView after deletion
                        Dgv1.DataSource = clsContact.GetAllContacts();
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
        private void ManagePeople_Load(object sender, EventArgs e)
        {
            _LoaddDataGridView();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _DeletePerson();
        }


        private void _FilterData()
        {
            if (dataTable != null && cb1.SelectedItem != null)
            {
                string filterColumn = cb1.SelectedItem.ToString(); // Get selected column name
                string searchText = Filterdtb.Text;

                if (!string.IsNullOrEmpty(searchText))
                {
                    // Apply filter using RowFilter property
                    dataTable.DefaultView.RowFilter = $"[{filterColumn}] LIKE '%{searchText}%'";
                }
                else
                {
                    // Clear filter
                    dataTable.DefaultView.RowFilter = string.Empty;
                }
            }
        }

        private void Filterdtb_TextChanged(object sender, EventArgs e)
        {
            _FilterData();
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb1.SelectedIndex != 0) { Filterdtb.Visible = true; }
            _FilterData();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowViewDetailsInNewWindow();
        }
        private void ShowViewDetailsInNewWindow()
        {
            int PersonID = (int)Dgv1.CurrentRow.Cells[0].Value;
            frmViewDetails frmViewDetails = new frmViewDetails(PersonID);
            frmViewDetails.ShowDialog();

        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            int ID = -1;
            AddEditPerson addEditPerson = new AddEditPerson(ID);
            addEditPerson.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int ID = -1;
            AddEditPerson addEditPerson = new AddEditPerson(ID);
            addEditPerson.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)Dgv1.CurrentRow.Cells[0].Value;
            AddEditPerson addEditPerson = new AddEditPerson(PersonID);
            addEditPerson.ShowDialog();
        }

    }

}

