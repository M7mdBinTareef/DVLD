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
    public partial class frmDetainedLicense : Form
    {
        clsLicense license;
        clsDetained detained;
        public frmDetainedLicense()
        {
            InitializeComponent();
        }

        private void PrePareData()
        {
            DetDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            CreatedBy.Text = SessionManager.Instance.CurrentUser.clsUser.UserName;
            lblLicenseID.Text = interNationalLicenses1.LicenseID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo licenseInfo = new frmLicenseInfo(-1, Convert.ToInt32(interNationalLicenses1.LicenseID));
            licenseInfo.ShowDialog();
        }

        private void History_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            license = clsLicense.FindLicense(Convert.ToInt32(interNationalLicenses1.LicenseID));
            PreviousLicense previousLicense = new PreviousLicense(license);
            previousLicense.ShowDialog();
        }

        private void interNationalLicenses1_Load(object sender, EventArgs e)
        {
            PrePareData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (interNationalLicenses1.isactive == "Yes")
            {
                detained = clsDetained.FindByLicenseID(Convert.ToInt32(interNationalLicenses1.LicenseID));
                if (detained != null && detained.IsReleased == false)
                {
                    MessageBox.Show("This License Is Detained", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                detained = new clsDetained();

                detained.LicenseID = Convert.ToInt32(interNationalLicenses1.LicenseID);
                detained.ReleaseApplicationID = null;
                detained.ReleaseDate = null;
                detained.ReleasedByUserID = null;
                detained.CreatedByUserID = SessionManager.Instance.CurrentUser.clsUser.UserID;
                detained.DetainDate = DateTime.Now;
                detained.FineFees = Convert.ToDecimal(tbFineFees.Text);
                detained.IsReleased = false;

                if (detained.Add())
                {
                    MessageBox.Show("Added Successfully");
                    btnSave.Enabled = false;
                    ShowLicense.Enabled = true;
                    History.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Failed To Detain License ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
