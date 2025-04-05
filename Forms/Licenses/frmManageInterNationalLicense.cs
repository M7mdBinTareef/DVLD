using System;
using System.Data;
using System.Windows.Forms;
using PeopleBusinessLayer;

namespace DVLD.Forms.Licenses
{
    public partial class frmManageInterNationalLicense : Form
    {
        private DataTable dt;

        public frmManageInterNationalLicense()
        {
            InitializeComponent();
        }


        private void _LoadData()
        {
            dt = clsInternationalLicenses.GetAllLicense();
            Dgv1.DataSource = dt;
            lRecNumber.Text = (dt.Rows.Count).ToString();
            Dgv1.AllowUserToAddRows = false;
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


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageInterNationalLicense_Load(object sender, EventArgs e)
        {
            _LoadData();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmIssueInternationalLicense internationalLicense = new frmIssueInternationalLicense();
            internationalLicense.ShowDialog();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Dgv1.SelectedRows.Count > 0)
            {
                int ApplicationID = Convert.ToInt32(Dgv1.SelectedRows[0].Cells["ApplicationID"].Value);

                clsApplication Application = clsApplication.Find(ApplicationID);
                if (Application != null){
                
                    frmViewDetails viewDetails = new frmViewDetails(Application.PersonID);
                    viewDetails.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No Application Found","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Select a Row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Dgv1.SelectedRows.Count > 0)
            {
                int LocalLicense = Convert.ToInt32(Dgv1.SelectedRows[0].Cells["LocalLicense"].Value);
                clsLicense license = clsLicense.FindLicense(LocalLicense);
                if (license != null) { 

                    PreviousLicense previousLicense = new PreviousLicense(license);
                    previousLicense.ShowDialog();

                }
                else
                {
                    MessageBox.Show("No License Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {

                MessageBox.Show("Select a Row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void showLicenses_Click(object sender, EventArgs e)
        {
            if (Dgv1.SelectedRows.Count > 0)
            {
                int LocalLicense = Convert.ToInt32(Dgv1.SelectedRows[0].Cells["LocalLicense"].Value);
                clsInternationalLicenses internationalLicenses = clsInternationalLicenses.GetInternationalLicenseByLocalID(LocalLicense);
                if (internationalLicenses !=null)
                {
                    frmViewInterNationalLicense ViewInterNationalLicense = new frmViewInterNationalLicense(internationalLicenses);
                    ViewInterNationalLicense.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Select a Row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
