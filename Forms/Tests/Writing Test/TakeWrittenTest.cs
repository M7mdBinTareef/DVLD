using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeopleBusinessLayer;
namespace DVLD.Forms.Tests.Writing_Test
{
    public partial class TakeWrittenTest : Form
    {
        int TestAppontimentID;


        clsTest Test;

        public delegate void Appointments0DataUpdatedHandler(clsTestAppointments updatedAppointments, clsTest Test);
        public event Appointments0DataUpdatedHandler AppointmentsDataUpdated0;

        public TakeWrittenTest(int TestAppID)
        {
            InitializeComponent();

            this.TestAppontimentID = TestAppID;
            takeTest1.PrePareData(TestAppID);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsTestAppointments TestAppointments = clsTestAppointments.Find(TestAppontimentID);

            if (TestAppointments != null)
            {
                TestAppointments.UpdateAppointment(TestAppointments.TestAppointmentID, TestAppointments.AppointmentDate, true);
            }

            Test = new clsTest();

            if (rbPass.Checked)
            {
                Test.TestResult = true;
            }
            else if (rbFail.Checked)
            {
                Test.TestResult = false;
            }

            Test.TestAppointmentID = TestAppontimentID;

            Test.Notes = Note.Text;

            Test.CreatedByUserID = SessionManager.Instance.CurrentUser.clsUser.UserID;

            if (Test.AddTakeTest())
            {
                MessageBox.Show("صلاااااااوات على محمد وال محمد ");
                AppointmentsDataUpdated0?.Invoke(TestAppointments, Test);
            }
            else
            {
                MessageBox.Show("nooooooooooooooooo");
            }
        }
    }
}
