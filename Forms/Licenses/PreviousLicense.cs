using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Forms.Local_App_Forms;
using PeopleBusinessLayer;

namespace DVLD.Forms.Licenses
{
    public partial class PreviousLicense : Form
    {
        DataTable dataTable;
        DataTable dataTable2;
        clsLicense License;
        public PreviousLicense(clsLicense license)
        {
            InitializeComponent();
            gbFilterd.Enabled = false;
            License = license;
            clsApplication app = clsApplication.Find(license.ApplicationID);
            if (app != null) {

                viewDetails1.GetPersonInfo(app.PersonID);
            }


        }

        private void _LoaddDataGridView()
        {
            dataTable = clsLicense.GetAllLicenseByDriverID(License.DriverID,License.LicenseClass);

            // Bind the DataTable to the DataGridView
            Dgv1.DataSource = dataTable;
            lRecNumber.Text = (dataTable.Rows.Count).ToString();
            Dgv1.AllowUserToAddRows = false;
        }

        private void _LoaddDataGridView2()
        {
            dataTable2 = clsInternationalLicenses.GetallInterNationalLicenseByID(License.DriverID);

            // Bind the DataTable to the DataGridView
            Dgv2.DataSource = dataTable2;
            lRecNumber.Text = (dataTable2.Rows.Count).ToString();
            Dgv2.AllowUserToAddRows = false;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Dgv1.SelectedRows.Count > 0)
            {
                int LicenseID = Convert.ToInt32(Dgv1.SelectedRows[0].Cells["LicenseID"].Value);
                frmLicenseInfo licenseInfo = new frmLicenseInfo(-1, LicenseID);
                licenseInfo.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select A Row ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                _LoaddDataGridView(); // Load data for the first tab
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                _LoaddDataGridView2(); // Load data for the second tab
            }
        }

        private void PreviousLicense_Load(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                _LoaddDataGridView(); // Load data for the first tab
            }
        }
    }
}
