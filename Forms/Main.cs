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
using DVLD.Forms.Detained_Licenses;
using DVLD.Forms.Drivers;
using DVLD.Forms.Licenses;
using DVLD.Forms.Local_App_Forms;
using PeopleBusinessLayer;

namespace DVLD
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void mPeople_Click(object sender, EventArgs e)
        {
            ManagePeople managePeople = new ManagePeople();
            managePeople.Show();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SessionManager.Instance.Logout();
            this.Close();
        }

        private void mUsers_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.Show();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int UserID = Convert.ToInt32(SessionManager.Instance.CurrentUser.clsUser.UserID);
                int PersonID = Convert.ToInt32(SessionManager.Instance.CurrentUser.clsUser.PersonID);

                frmViewUsers frmViewUsers = new frmViewUsers(PersonID,UserID);
                frmViewUsers.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                int UserID = Convert.ToInt32(SessionManager.Instance.CurrentUser.clsUser.UserID);
                int PersonID = Convert.ToInt32(SessionManager.Instance.CurrentUser.clsUser.PersonID);

                frmChangePassword frmChangePassword = new frmChangePassword(PersonID, UserID);
                frmChangePassword.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void manageApplicationsTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes frm = new frmManageApplicationTypes();
            frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTestTypes frm = new ManageTestTypes();
            frm.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = -1;
            frmNewLocalDriving frmNewLocalDriving = new frmNewLocalDriving(ID);
            frmNewLocalDriving.ShowDialog();
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageLocalApplications frm = new frmManageLocalApplications();
            frm.ShowDialog();
        }

        private void mDrivers_Click(object sender, EventArgs e)
        {
            frmManageDrivers drivers = new frmManageDrivers(); 
            drivers.ShowDialog();
        }

        private void inernationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueInternationalLicense internationalLicense = new frmIssueInternationalLicense();
            internationalLicense.ShowDialog();
        }

        private void internationalLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageInterNationalLicense manageInterNationalLicense = new frmManageInterNationalLicense();
            manageInterNationalLicense.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewLocalDrivingLicense renew = new frmRenewLocalDrivingLicense();
            renew.ShowDialog();
        }

        private void replacementForLostOrDamagedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewDamageOrLostLicense replacement = new frmRenewDamageOrLostLicense();
            replacement.ShowDialog();
        }

        private void detainedLiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetainedLicense frmDetainedLicense = new frmDetainedLicense();
            frmDetainedLicense.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseLicense frmReleaseLicense = new frmReleaseLicense();
            frmReleaseLicense.ShowDialog();
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageDetainedLicense detainedLicense = new frmManageDetainedLicense();
            detainedLicense.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageLocalApplications localApplications = new frmManageLocalApplications();
            localApplications.ShowDialog();
        }

        private void releaseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseLicense releaseLicense = new frmReleaseLicense();
            releaseLicense.ShowDialog();
        }
    }
}
