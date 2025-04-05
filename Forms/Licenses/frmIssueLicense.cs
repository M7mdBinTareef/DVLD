using System;
using System.Windows.Forms;
using PeopleBusinessLayer;

namespace DVLD.Forms.Licenses
{
    public partial class frmIssueLicense : Form
    {
        clsLicense License;
        clsDriver Driver;

        int ldlAppID = 0;
        public frmIssueLicense(int LDLAppID,int PassedTest)
        {
            InitializeComponent();
            ldlAppID = LDLAppID;
            applicationInfoTest1.LoadData(LDLAppID, PassedTest);
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsLocalApplications LocalApplications = clsLocalApplications.FindLocalApp(ldlAppID);
            if (LocalApplications != null) {
            
                clsApplication Application = clsApplication.Find(LocalApplications.ApplicationID);
                if (Application != null) { 
                    

                    Driver = new clsDriver();

                    Driver.PersonID = Application.PersonID;
                    Driver.CreatedDate = DateTime.Now;
                    Driver.CreatedByUserID = SessionManager.Instance.CurrentUser.clsUser.UserID;

                    if (Driver.AddNewDriver())
                    {
                        License = new clsLicense();

                        License.DriverID = Driver.DriverID;
                        License.IssueDate = DateTime.Now;
                        License.ExpirationDate = DateTime.Now.AddYears(10);
                        License.CreatedByUserID = SessionManager.Instance.CurrentUser.clsUser.UserID;
                        License.ApplicationID = Application.AppID;
                        License.Notes = NoteText.Text;
                        License.LicenseClass = clsLicenseClass.FindLicenseClass(LocalApplications.LicenseClassID).LicenseClassID;
                        License.PaidFees = clsLicenseClass.FindLicenseClass(LocalApplications.LicenseClassID).ClassFees;
                        License.IssueReason = 1;
                        License.IsActive = true;
                        
                        if (License.AddLicense())
                        {
                            Application.ApplicationStatus = 3;

                            if (Application.Save())
                            {
                                MessageBox.Show("License Added Successfully And The ID Is :" + License.LicenseID);
                            }
                        }
                        else
                        {
                            MessageBox.Show("License Issue Failed","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Driver Adding Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
    }
}
