using System.Windows.Forms;
using PeopleBusinessLayer;
namespace DVLD.UserControls
{
    public partial class TakeTest : UserControl
    {
        clsTestAppointments testAppointments;
        public TakeTest()
        {
            InitializeComponent();
        }

        public void PrePareData(int TestAppID)
        {
            testAppointments = clsTestAppointments.Find(TestAppID);
            if (testAppointments != null)
            {
                clsLocalApplications localApplication = clsLocalApplications.FindLocalApp(testAppointments.LocalDrivingLicenseApplicationID);
                if (localApplication != null) {

                    ldlAppID.Text = localApplication.LDLAppID.ToString();
                    Class.Text = clsLicenseClass.FindLicenseClass(localApplication.LicenseClassID).ClassName;
                    clsApplication application = clsApplication.Find(localApplication.ApplicationID);

                    if (application != null)
                    {
                       clsContact Person = clsContact.Find(application.PersonID);
                        if (Person != null)
                        {

                            Name.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
                        }
                    }

                    Trial.Text = clsTestAppointments.Trails(testAppointments.LocalDrivingLicenseApplicationID, testAppointments.TestTypeID, localApplication.LicenseClassID).ToString();

                    fees.Text = clsTestTypes.Find(testAppointments.TestTypeID).TestTypeFees.ToString();

                    Date.Text = testAppointments.AppointmentDate.ToString();
                }
            }
        }


    }
}
