using System;
using System.Windows.Forms;
using PeopleBusinessLayer;

namespace DVLD.Forms.Licenses
{
    public partial class frmIssueInternationalLicense : Form
    {
        clsApplication Application;
        clsApplicationTypes ApplicationTypes;
        clsLicense license;
        clsInternationalLicenses internationalLicenses;
        public frmIssueInternationalLicense()
        {
            InitializeComponent();
        }

        private void PrePareData()
        {
            ApplicationTypes = clsApplicationTypes.Find(6);
            AppDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            IssueDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            expDate.Text = DateTime.Now.AddYears(10).ToString("yyyy-MM-dd");
            CreatedBy.Text = SessionManager.Instance.CurrentUser.clsUser.UserName;
            fees.Text = ApplicationTypes.ApplicationTypeFees.ToString();
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (interNationalLicenses1.isactive == "Yes" && interNationalLicenses1.isdetained == "No" && interNationalLicenses1.ClassID == 3)
            {
                internationalLicenses = clsInternationalLicenses.GetInternationalLicenseByLocalID(Convert.ToInt32(interNationalLicenses1.LicenseID));
                if (internationalLicenses !=null)
                {
                    MessageBox.Show("Failed to Add InterNational License Because He/She Have A International License ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                LocalLicenseID.Text = interNationalLicenses1.LicenseID;

                Application = new clsApplication();

                Application.ApplicationTypeID = 6;
                Application.ApplicationDate = DateTime.Now;
                Application.LastStatusDate = DateTime.Now;
                Application.ApplicationStatus = 3;
                Application.CreatedByUserID = SessionManager.Instance.CurrentUser.clsUser.UserID;
                Application.PaidFees = ApplicationTypes.ApplicationTypeFees;
                Application.PersonID = interNationalLicenses1.PersonID;

                if (Application.Save())
                {
                    MessageBox.Show("Successfully");

                    ILApplicationID.Text = Application.AppID.ToString();

                    internationalLicenses = new clsInternationalLicenses();

                    internationalLicenses.ApplicationID = Application.AppID;
                    internationalLicenses.ExpirationDate = DateTime.Now.AddYears(10);
                    internationalLicenses.IssueDate = DateTime.Now;
                    internationalLicenses.CreatedByUserID = SessionManager.Instance.CurrentUser.clsUser.UserID;
                    internationalLicenses.IsActive = true;
                    
                    license = clsLicense.FindLicense(Convert.ToInt32(interNationalLicenses1.LicenseID));
                    if (license != null)
                    {
                        internationalLicenses.DriverID = license.DriverID;
                        internationalLicenses.IssuedUsingLocalLicenseID = license.LicenseID;
                    }

                    if (internationalLicenses.AddNewinternationalLicense())
                    {
                        MessageBox.Show("Successfully InterNational Added");
                        ILlicenseID.Text = internationalLicenses.InternationalLicenseID.ToString();
                        ShowLicense.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("Failed to Add InterNational License","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void frmIssueInternationalLicense_Load(object sender, EventArgs e)
        {
            PrePareData();
        }

        private void History_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            license = clsLicense.FindLicense(Convert.ToInt32(interNationalLicenses1.LicenseID));
            PreviousLicense previousLicense = new PreviousLicense(license);
            previousLicense.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmViewInterNationalLicense interNationalLicense = new frmViewInterNationalLicense(internationalLicenses);
            interNationalLicense.ShowDialog();
        }
    }
}
