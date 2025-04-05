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
    public partial class frmRenewDamageOrLostLicense : Form
    {
        clsApplication Application;
        clsApplicationTypes ApplicationTypes;
        clsLicense license;
        public frmRenewDamageOrLostLicense()
        {
            InitializeComponent();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void History_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {     
            license = clsLicense.FindLicense(Convert.ToInt32(interNationalLicenses1.LicenseID));
            PreviousLicense previousLicense = new PreviousLicense(license);
            previousLicense.ShowDialog();
        }

        private void ShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            license = clsLicense.FindLicense(Convert.ToInt32(NewLicense.Text));
            frmLicenseInfo licenseInfo = new frmLicenseInfo(-1, license.LicenseID);
            licenseInfo.ShowDialog();
        }

        private void IssueReason(clsLicense reason)
        {
            if (rbDamaged.Checked)
            {
                reason.IssueReason = 4;
            }
            else if (rbLost.Checked)
            {
                reason.IssueReason = 3;
            } 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (interNationalLicenses1.isactive == "Yes")
            {
                OldLicense.Text = interNationalLicenses1.LicenseID;

                Application = new clsApplication();

                Application.ApplicationTypeID = ApplicationTypes.ApplicationID;
                Application.ApplicationDate = DateTime.Now;
                Application.LastStatusDate = DateTime.Now;
                Application.ApplicationStatus = 3;
                Application.CreatedByUserID = SessionManager.Instance.CurrentUser.clsUser.UserID;
                Application.PaidFees = ApplicationTypes.ApplicationTypeFees;
                Application.PersonID = interNationalLicenses1.PersonID;

                if (Application.Save())
                {
                    MessageBox.Show("Successfully");

                    RLApplicationID.Text = Application.AppID.ToString();

                    clsLicense license = new clsLicense();

                    license.ApplicationID = Application.AppID;
                    license.IssueDate = DateTime.Now;
                    license.ExpirationDate = DateTime.Now.AddYears(10);
                    license.CreatedByUserID = SessionManager.Instance.CurrentUser.clsUser.UserID;
                    license.Notes = "";
                    IssueReason(license);
                    license.IsActive = true;
                    clsLicense license2 = clsLicense.FindLicense(Convert.ToInt32(OldLicense.Text));
                    if (license2 != null)
                    {

                        license.DriverID = license2.DriverID;
                        license.PaidFees = license2.PaidFees;
                        license.LicenseClass = license2.LicenseClass;
                        license2.IsActive = false;
                    }
                    else
                    {
                        MessageBox.Show("Faild To Find License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (license.AddLicense() && license2.UpdateLicense())
                    {
                        MessageBox.Show("Successfully Added");
                        NewLicense.Text = license.LicenseID.ToString();
                        ShowLicense.Enabled = true;
                        History.Enabled = true;
                        btnSave.Enabled = false;
                        replacement.Enabled = false;
                        interNationalLicenses1.GroupBox.Enabled = false;
                    }

                }

            }
            else
            {
                MessageBox.Show("Error License Is Active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void rbDamaged_CheckedChanged(object sender, EventArgs e)
        {
            ApplicationTypes = clsApplicationTypes.Find(4);
            AppDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            CreatedBy.Text = SessionManager.Instance.CurrentUser.clsUser.UserName;
            Appfees.Text = ApplicationTypes.ApplicationTypeFees.ToString();
        }

        private void rbLost_CheckedChanged(object sender, EventArgs e)
        {
            ApplicationTypes = clsApplicationTypes.Find(3);
            AppDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            CreatedBy.Text = SessionManager.Instance.CurrentUser.clsUser.UserName;
            Appfees.Text = ApplicationTypes.ApplicationTypeFees.ToString();
        }
    }
}
