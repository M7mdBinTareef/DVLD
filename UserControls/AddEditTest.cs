using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeopleBusinessLayer;
namespace DVLD.UserControls
{
    public partial class AddEditTest : UserControl
    {

        public delegate void AppointmentsDataUpdatedHandler(clsTestAppointments updatedAppointments);
        public event AppointmentsDataUpdatedHandler AppointmentsDataUpdated;

        clsLocalApplications localApplication;
        clsApplication application;
        clsContact Person;
        clsTestAppointments appointments;
        int CreatedUserID;
        int Testid = 0;
        public AddEditTest()
        {
            InitializeComponent();
        }

        public void LoadData(int TestAppoitment)
         {
            if (TestAppoitment != -1)
            {
                appointments = clsTestAppointments.Find(TestAppoitment);
                if (appointments != null)
                {
                    if (appointments.IsLocked == true)
                    {
                        Date.Enabled = false;
                        btnSave.Enabled = false;
                    }
                    
                    localApplication = clsLocalApplications.FindLocalApp(appointments.LocalDrivingLicenseApplicationID);
                    if (localApplication != null)
                    {

                        ldlAppID.Text = localApplication.LDLAppID.ToString();
                        Class.Text = clsLicenseClass.FindLicenseClass(localApplication.LicenseClassID).ClassName;
                        application = clsApplication.Find(localApplication.ApplicationID);

                        if (application != null)
                        {
                            Person = clsContact.Find(application.PersonID);
                            if (Person != null)
                            {

                                Name.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
                            }
                        }
                        Trial.Text = clsTestAppointments.Trails(appointments.LocalDrivingLicenseApplicationID,appointments.TestTypeID,localApplication.LicenseClassID).ToString();

                        Date.Value = appointments.AppointmentDate;

                        fees.Text = clsTestTypes.Find(appointments.TestTypeID).TestTypeFees.ToString();

                        if (int.TryParse(Trial.Text, out int trialValue) && trialValue >= 1)
                        {
                            retake.Enabled = true;

                            decimal retakeFees = 5; // Directly assign instead of using RetakeTestFees.Text
                            RetakeTestFees.Text = retakeFees.ToString();

                            decimal Fees;
                            if (decimal.TryParse(fees.Text, out Fees))
                            {
                                TotalFees.Text = (retakeFees + Fees).ToString();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Test Type Fees.");
                            }
                        }

                        else
                        {
                            retake.Enabled = false; // Optional: Disable if condition isn't met
                        }
                    }
                }
            }

        }

        public void LoadDataForAdding(int LDLAppID, int TestTypeID)
        {
            CreatedUserID = SessionManager.Instance.CurrentUser.clsUser.UserID;
            Testid = TestTypeID;

            localApplication = clsLocalApplications.FindLocalApp(LDLAppID);
            if (localApplication != null) {

                ldlAppID.Text = localApplication.LDLAppID.ToString();
                Class.Text = clsLicenseClass.FindLicenseClass(localApplication.LicenseClassID).ClassName;
                application = clsApplication.Find(localApplication.ApplicationID);

                if (application != null)
                {
                    Person = clsContact.Find(application.PersonID);
                    if (Person != null)
                    {

                        Name.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
                    }
                }

                Trial.Text = clsTestAppointments.Trails(LDLAppID, TestTypeID, localApplication.LicenseClassID).ToString();
                
                Date.MinDate = DateTime.Now;

                fees.Text = clsTestTypes.Find(Testid).TestTypeFees.ToString();

                if (int.TryParse(Trial.Text, out int trialValue) && trialValue >= 1)
                {
                    retake.Enabled = true;

                    decimal retakeFees = 5; // Directly assign instead of using RetakeTestFees.Text
                    RetakeTestFees.Text = retakeFees.ToString();

                    decimal Fees;
                    if (decimal.TryParse(fees.Text, out Fees))
                    {
                        TotalFees.Text = (retakeFees + Fees).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Test Type Fees.");
                    }
                }

                else
                {
                    TotalFees.Text = fees.Text;
                    retake.Enabled = false; // Optional: Disable if condition isn't met
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (appointments !=null) // Update Status
            {
                appointments.AppointmentDate = Date.Value;

                if (appointments.UpdateAppointment(appointments.TestAppointmentID,Date.Value, appointments.IsLocked))
                {
                    AppointmentsDataUpdated?.Invoke(appointments);
                    MessageBox.Show("Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Can't Update Appoitment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else // Add Status
            {
                appointments = new clsTestAppointments();
                appointments.AppointmentDate = Date.Value;
                appointments.PaidFees = Convert.ToDecimal(TotalFees.Text);
                appointments.CreatedByUserID = CreatedUserID;
                appointments.IsLocked = false;
                appointments.TestTypeID = Testid;
                appointments.LocalDrivingLicenseApplicationID = localApplication.LDLAppID;

                if (appointments.AddNewTestAppoitment(appointments.TestTypeID, appointments.LocalDrivingLicenseApplicationID,appointments.PaidFees,
                    appointments.CreatedByUserID,appointments.IsLocked,appointments.AppointmentDate))
                {
                    MessageBox.Show("Added Successfully");
                    AppointmentsDataUpdated?.Invoke(appointments);
                }
                else
                {
                    MessageBox.Show("Can't Add Appoitment","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
        }
    }
}
