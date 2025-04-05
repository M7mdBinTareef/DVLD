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
using PeopleBusinessLayer;

namespace DVLD.Forms.Local_App_Forms
{
    public partial class frmRenewLocalDrivingLicense : Form
    {
        clsApplication Application;
        clsApplicationTypes ApplicationTypes;
        clsLicense license;
        public frmRenewLocalDrivingLicense()
        {
            InitializeComponent();
            
        }

        private void PrePareData()
        {
            ApplicationTypes = clsApplicationTypes.Find(2);
            AppDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            IssueDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            CreatedBy.Text = SessionManager.Instance.CurrentUser.clsUser.UserName;
            Appfees.Text = ApplicationTypes.ApplicationTypeFees.ToString();
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
            frmLicenseInfo licenseInfo = new frmLicenseInfo(-1,license.LicenseID);
            licenseInfo.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (interNationalLicenses1.ExpDate < DateTime.Now)
            {
                OldLicense.Text = interNationalLicenses1.LicenseID;

                Application = new clsApplication();

                Application.ApplicationTypeID = 2;
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
                    expDate.Text = license.ExpirationDate.ToString();
                    license.CreatedByUserID = SessionManager.Instance.CurrentUser.clsUser.UserID;
                    license.Notes = rtNote.Text;
                    license.IssueReason = 2;
                    license.IsActive = true;

                     
                    clsLicense license2 = clsLicense.FindLicense(Convert.ToInt32(OldLicense.Text));
                    if (license2 != null) { 
                    
                        license.DriverID = license2.DriverID;
                        license.PaidFees = license2.PaidFees;
                        LicenseFees.Text = license2.PaidFees.ToString();
                        Total.Text = (license.PaidFees + ApplicationTypes.ApplicationTypeFees).ToString();
                        license.LicenseClass = license2.LicenseClass;
                        license2.IsActive = false;
                    }
                    else
                    {
                        MessageBox.Show("Faild To Find License","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

                    }

                    if (license.AddLicense() && license2.UpdateLicense())
                    {
                        MessageBox.Show("Successfully Added");
                        NewLicense.Text = license.LicenseID.ToString();
                        ShowLicense.Enabled = true;
                        History.Enabled = true;
                        btnSave.Enabled = false;
                        interNationalLicenses1.GroupBox.Enabled = false;
                    }


                }
            }
        }

        private void frmRenewLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            PrePareData();
        }
    }
}
