using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Forms.Licenses;
using DVLD.Forms.Local_App_Forms;
using PeopleBusinessLayer;

namespace DVLD.Forms.Detained_Licenses
{
    public partial class frmManageDetainedLicense : Form
    {
        private DataTable dt;
        public frmManageDetainedLicense()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LoadData()
        {
            dt = clsDetained.GetAllDetainedLicense();
            Dgv1.DataSource = dt;
            lRecNumber.Text = (dt.Rows.Count).ToString();
            Dgv1.AllowUserToAddRows = false;
        }

        private void frmManageDetainedLicense_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmDetainedLicense frm = new frmDetainedLicense();
            frm.ShowDialog();
            _LoadData();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmReleaseLicense frm = new frmReleaseLicense();
            frm.ShowDialog();
            _LoadData();
        }

        private void FilterdBox()
        {
            if (dt != null && cb1.SelectedItem != null)
            {
                string filterColumn = cb1.SelectedItem.ToString(); // Get selected column name
                string searchText = Filterdtb.Text;

                if (!string.IsNullOrEmpty(searchText))
                {
                    DataColumn column = dt.Columns[filterColumn];

                    if (column.DataType == typeof(int) || column.DataType == typeof(long) || column.DataType == typeof(double))
                    {
                        // Convert numeric column to string for filtering
                        dt.DefaultView.RowFilter = $"CONVERT([{filterColumn}], 'System.String') LIKE '%{searchText}%'";
                    }
                    else
                    {
                        // Directly apply filter for string columns
                        dt.DefaultView.RowFilter = $"[{filterColumn}] LIKE '%{searchText}%'";
                    }
                }
                else
                {
                    // Clear filter
                    dt.DefaultView.RowFilter = string.Empty;
                }
            }
        }
        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb1.SelectedIndex != 0) { Filterdtb.Visible = true; }
            FilterdBox();
        }


        private void Filterdtb_TextChanged(object sender, EventArgs e)
        {
            FilterdBox();
        }

        private void showLicenses_Click(object sender, EventArgs e)
        {
            int LicenseID = Convert.ToInt32(Dgv1.CurrentRow.Cells[1].Value);
            frmLicenseInfo licenseInfo = new frmLicenseInfo(-1, LicenseID);
            licenseInfo.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = Convert.ToInt32(Dgv1.CurrentRow.Cells[1].Value);
            clsLicense license = clsLicense.FindLicense(LicenseID);
            if (license != null)
            {
                PreviousLicense previousLicense = new PreviousLicense(license);
                previousLicense.ShowDialog();
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = Convert.ToInt32(Dgv1.CurrentRow.Cells[1].Value);
            clsLicense license = clsLicense.FindLicense(LicenseID);
            if (license != null)
            {
                clsDriver Driver = clsDriver.FindDriver(license.DriverID);
                if (Driver != null) { 
                
                    clsContact contact = clsContact.Find(Driver.PersonID);
                    if (contact != null) {

                        frmViewDetails viewDetails = new frmViewDetails(contact.ID);
                        viewDetails.ShowDialog();
                    }

                }

            }
        }

        private void PMenu_Opening(object sender, CancelEventArgs e)
        {
            bool IsReleased = Convert.ToBoolean(Dgv1.CurrentRow.Cells[2].Value);
            if (IsReleased) {

                releaseDetaineLicenseToolStripMenuItem.Enabled = false;
            }
            else
            {
                releaseDetaineLicenseToolStripMenuItem.Enabled = true;
            }
        }

        private void releaseDetaineLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = Convert.ToInt32(Dgv1.CurrentRow.Cells[1].Value);
            frmReleaseLicense frmReleaseLicense = new frmReleaseLicense(LicenseID);
            frmReleaseLicense.ShowDialog();
            _LoadData();
        }
    }
}
