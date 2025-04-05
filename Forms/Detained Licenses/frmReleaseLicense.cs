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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD.Forms.Detained_Licenses
{
    public partial class frmReleaseLicense : Form
    {
        clsLicense license;
        clsDetained detained;
        clsApplication Application;
        clsApplicationTypes ApplicationTypes;
        int licenseID = -1;

        public frmReleaseLicense(int LicID)
        {
            InitializeComponent();
            ApplicationTypes = clsApplicationTypes.Find(5);
            licenseID = LicID;
            interNationalLicenses1.search = licenseID;
            interNationalLicenses1.LoadDataWithoutSearch(licenseID);
            interNationalLicenses1.GroupBox.Enabled = false;
        }

        public frmReleaseLicense()
        {
            InitializeComponent();
            ApplicationTypes = clsApplicationTypes.Find(5);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo licenseInfo = new frmLicenseInfo(-1, licenseID != -1 ? licenseID : Convert.ToInt32(interNationalLicenses1.LicenseID));
            licenseInfo.ShowDialog();
        }

        private void History_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int id = licenseID != -1 ? licenseID : Convert.ToInt32(interNationalLicenses1.LicenseID);
            license = clsLicense.FindLicense(id);
            new PreviousLicense(license).ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (licenseID != -1)
            {
                detained = clsDetained.FindByLicenseID(licenseID);

                lblDetainID.Text = detained.DetainID.ToString();
                DetDate.Text = detained.DetainDate.ToString();
                CreatedBy.Text = SessionManager.Instance.CurrentUser.clsUser.UserName;
                FineFees.Text = detained.FineFees.ToString();
                lblLicenseID.Text = licenseID.ToString();

                Application = new clsApplication();
                Application.ApplicationTypeID = 5;
                Application.ApplicationDate = DateTime.Now;
                Application.LastStatusDate = DateTime.Now;
                Application.ApplicationStatus = 3;
                Application.CreatedByUserID = SessionManager.Instance.CurrentUser.clsUser.UserID;
                Application.PaidFees = ApplicationTypes.ApplicationTypeFees;
                Appfees.Text = Application.PaidFees.ToString();
                TotalFees.Text = (Application.PaidFees + detained.FineFees).ToString();
                Application.PersonID = interNationalLicenses1.PersonID;

                if (Application.Save())
                {
                    MessageBox.Show("Successfully");

                    AppID.Text = Application.AppID.ToString();

                    if (detained.ReleaseDetained())
                    {
                        MessageBox.Show("Successfully Released");
                        btnSave.Enabled = false;
                        ShowLicense.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Cant Release the license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Cant Add Application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (licenseID == -1)
            {
                detained = clsDetained.FindByLicenseID(Convert.ToInt32(interNationalLicenses1.LicenseID));

                lblDetainID.Text = detained.DetainID.ToString();
                DetDate.Text = detained.DetainDate.ToString();
                CreatedBy.Text = SessionManager.Instance.CurrentUser.clsUser.UserName;
                FineFees.Text = detained.FineFees.ToString();
                lblLicenseID.Text = interNationalLicenses1.LicenseID;

                Application = new clsApplication();
                Application.ApplicationTypeID = 5;
                Application.ApplicationDate = DateTime.Now;
                Application.LastStatusDate = DateTime.Now;
                Application.ApplicationStatus = 3;
                Application.CreatedByUserID = SessionManager.Instance.CurrentUser.clsUser.UserID;
                Application.PaidFees = ApplicationTypes.ApplicationTypeFees;
                Appfees.Text = Application.PaidFees.ToString();
                TotalFees.Text = (Application.PaidFees + detained.FineFees).ToString();
                Application.PersonID = interNationalLicenses1.PersonID;

                if (Application.Save())
                {
                    MessageBox.Show("Successfully");

                    AppID.Text = Application.AppID.ToString();

                    if (detained.ReleaseDetained())
                    {
                        MessageBox.Show("Successfully Released");
                        btnSave.Enabled = false;
                        ShowLicense.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Cant Release the license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Cant Add Application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
