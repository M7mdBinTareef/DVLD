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
using DVLD.Forms.Tests;
using DVLD.Forms.Tests.Writing_Test;
using PeopleBusinessLayer;

namespace DVLD.Forms
{
    public partial class frmManageLocalApplications : Form
    {
        private  DataTable dt;

        private clsLocalApplications localApplications;
        public frmManageLocalApplications()
        {
            InitializeComponent();
        }

        private void _LoadData()
        {
            dt = clsLocalApplications.GetAllApps(); 
            Dgv1.DataSource = dt;
            lRecNumber.Text = (dt.Rows.Count).ToString();
            Dgv1.AllowUserToAddRows = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void frmManageLocalApplications_Load(object sender, EventArgs e)
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
            
            frmNewLocalDriving NewLocal = new frmNewLocalDriving();
            NewLocal.LocalAppDataUpdated += NewLocal_LocalAppDataUpdated;
            NewLocal.ShowDialog();
        }

        private void NewLocal_LocalAppDataUpdated(clsContact updatedPerson, clsLocalApplications clsLocalApplications)
        {
            _LoadData();
        }

        private void canceledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Dgv1.SelectedRows.Count > 0)
            {
                int LDLAppID = Convert.ToInt32(Dgv1.SelectedRows[0].Cells["LDLApp"].Value);

                localApplications = clsLocalApplications.FindLocalApp(LDLAppID);

                if (clsApplication.CanceledStatus(localApplications.ApplicationID))
                {
                    MessageBox.Show("Canceled Successfully ");
                    _LoadData();
                }
                else
                {
                    MessageBox.Show("Cant Cancel");
                }

            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Dgv1.SelectedRows.Count > 0)
            {
                int LDLAppID = Convert.ToInt32(Dgv1.SelectedRows[0].Cells["LDLApp"].Value);
                int Appid = 0;
                localApplications = clsLocalApplications.FindLocalApp(LDLAppID);

                Appid = localApplications.ApplicationID;

                if (clsLocalApplications.RemoveLocalDrivingApplication(LDLAppID))
                {
                    if (clsApplication.DeleteApp(Appid))
                    {
                        MessageBox.Show("Application Deleted Successfully");
                        _LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Application Cant Be Deleted", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Local Application Cant Be Deleted","Error");
                }
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Dgv1.SelectedRows.Count > 0)
            {
                int LDLAppID = Convert.ToInt32(Dgv1.SelectedRows[0].Cells["LDLApp"].Value);
                localApplications = clsLocalApplications.FindLocalApp(LDLAppID);

                ApplicationInfo applicationInfo = new ApplicationInfo(localApplications.ApplicationID);
                applicationInfo.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select a Rows");
            }
        }

        private void showLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Dgv1.SelectedRows.Count > 0)
            {
                int LDLAppID = Convert.ToInt32(Dgv1.SelectedRows[0].Cells["LDLApp"].Value);
                localApplications = clsLocalApplications.FindLocalApp(LDLAppID);

                if (localApplications != null) { 
                    
                    clsLicense license  = clsLicense.FindLicenseByApplicationID(localApplications.ApplicationID);
                    if (license !=null)
                    {
                        frmLicenseInfo frmLicenseInfo = new frmLicenseInfo(localApplications.LDLAppID,-1);
                        frmLicenseInfo.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No License To Show", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a Rows");
            }
        }


        private void OrganizedPMenu()
        {
            if (Dgv1.CurrentRow != null)
            {
                string ApplicationStatus = (string)Dgv1.CurrentRow.Cells[6].Value;
                int PassedTest = Convert.ToInt32(Dgv1.CurrentRow.Cells[5].Value);

                if (ApplicationStatus == "Canceled")
                {
                    Canceled.Enabled = false;
                    Test.Enabled = false;
                    IssueLicense.Enabled = false;
                    showLicenses.Enabled = false;
                    editApplicatToolStripMenuItem.Enabled = false;
                }
                else if (ApplicationStatus == "New")
                {
                    IssueLicense.Enabled = false;
                    showLicenses.Enabled = false;
                    if (PassedTest == 0)
                    {
                        schduleWrittenTest.Enabled = false;
                        schduleStreetTest.Enabled = false;
                    }
                    else if (PassedTest == 1)
                    {
                        schduleVisionTest.Enabled = false;
                        schduleWrittenTest.Enabled = true;
                        schduleStreetTest.Enabled = false;
                    }
                    else if(PassedTest == 2)
                    {
                        schduleVisionTest.Enabled = false;
                        schduleWrittenTest.Enabled = false;
                        schduleStreetTest.Enabled = true;
                    }
                    else if (PassedTest == 3)
                    {
                        schduleVisionTest.Enabled = false;
                        schduleWrittenTest.Enabled = false;
                        schduleStreetTest.Enabled = false;
                        IssueLicense.Enabled = true;
                        showLicenses.Enabled = false;
                        editApplicatToolStripMenuItem.Enabled = false;
                        deleteToolStripMenuItem.Enabled = false;
                        Canceled.Enabled = false;
                    }
                } 
                else if (ApplicationStatus == "Completed")
                {

                    Canceled.Enabled = false;
                    Test.Enabled = false;
                    deleteToolStripMenuItem.Enabled = false;
                    IssueLicense.Enabled = false;
                    editApplicatToolStripMenuItem.Enabled=false;

                }
            }
            else
            {
                MessageBox.Show("Select a Rows","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void PMenu_Opening(object sender, CancelEventArgs e)
        {
            OrganizedPMenu();
        }

        private void editApplicatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Dgv1.SelectedRows.Count > 0)
            {
                int LDLAppID = Convert.ToInt32(Dgv1.SelectedRows[0].Cells["LDLApp"].Value);

                frmNewLocalDriving NewLocal = new frmNewLocalDriving(LDLAppID);
                NewLocal.LocalAppDataUpdated += NewLocal_LocalAppDataUpdated;
                NewLocal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select a Rows", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void schduleVisionTest_Click(object sender, EventArgs e)
        {
            if (Dgv1.SelectedRows.Count > 0)
            {
                int LDLAppID = Convert.ToInt32(Dgv1.SelectedRows[0].Cells["LDLApp"].Value);
                int PassedTest = Convert.ToInt32(Dgv1.CurrentRow.Cells[5].Value);

                VisionTestAppointments visionTest = new VisionTestAppointments(LDLAppID, PassedTest);
                visionTest.AppointmentsDataUpdated3 += Test_AppointmentsDataUpdated3;
                visionTest.TestDataUpdated += VisionTest_TestDataUpdated;
                visionTest.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select a Rows", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void schduleWrittenTest_Click(object sender, EventArgs e)
        {
            if (Dgv1.SelectedRows.Count > 0)
            {
                int LDLAppID = Convert.ToInt32(Dgv1.SelectedRows[0].Cells["LDLApp"].Value);
                int PassedTest = Convert.ToInt32(Dgv1.CurrentRow.Cells[5].Value);

                frmManageWrittenTest visionTest = new frmManageWrittenTest(LDLAppID, PassedTest);
                visionTest.AppointmentsDataUpdated3 += Test_AppointmentsDataUpdated3;
                visionTest.TestDataUpdated += VisionTest_TestDataUpdated;
                visionTest.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select A Row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VisionTest_TestDataUpdated(clsTestAppointments updatedAppointments, clsTest Test)
        {
            _LoadData();
        }

        private void Test_AppointmentsDataUpdated3(clsTestAppointments updatedAppointments)
        {
            _LoadData();
        }

        private void schduleStreetTest_Click(object sender, EventArgs e)
        {
            if (Dgv1.SelectedRows.Count > 0)
            {
                int LDLAppID = Convert.ToInt32(Dgv1.SelectedRows[0].Cells["LDLApp"].Value);
                int PassedTest = Convert.ToInt32(Dgv1.CurrentRow.Cells[5].Value);

                frmManageStreetTestAppo frmManageStreet = new frmManageStreetTestAppo(LDLAppID, PassedTest);
                frmManageStreet.AppointmentsDataUpdated3 += Test_AppointmentsDataUpdated3;
                frmManageStreet.TestDataUpdated += VisionTest_TestDataUpdated;
                frmManageStreet.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select A Row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IssueLicense_Click(object sender, EventArgs e)
        {
            if (Dgv1.SelectedRows.Count>0)
            {
                int LDLAppID = Convert.ToInt32(Dgv1.SelectedRows[0].Cells["LDLApp"].Value);
                int PassedTest = Convert.ToInt32(Dgv1.CurrentRow.Cells[5].Value);

                frmIssueLicense issueLicense = new frmIssueLicense(LDLAppID, PassedTest);
                issueLicense.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select A Row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Dgv1.SelectedRows.Count > 0)
            {
                int LDLAppID = Convert.ToInt32(Dgv1.SelectedRows[0].Cells["LDLApp"].Value);

                clsLocalApplications LocalApplications = clsLocalApplications.FindLocalApp(LDLAppID);
                if (LocalApplications != null)
                {
                    clsApplication app = clsApplication.Find(LocalApplications.ApplicationID);
                    if (app != null)
                    {
                        clsLicense license = clsLicense.FindLicenseByApplicationID(app.AppID);
                        if (license != null)
                        {
                            PreviousLicense previousLicense = new PreviousLicense(license);
                            previousLicense.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("No License To Show", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }
                }

            }
            else
            {
                MessageBox.Show("Select A Row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
