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
using DVLD.Forms.Tests.Street_Test;
using PeopleBusinessLayer;

namespace DVLD.Forms.Tests
{
    public partial class frmManageStreetTestAppo : Form
    {

        int ldlAppID = 0;

        DataTable dt;


        public delegate void Appointments3DataUpdatedHandler(clsTestAppointments updatedAppointments);
        public event Appointments3DataUpdatedHandler AppointmentsDataUpdated3;

        public delegate void TestUpdate0DataUpdatedHandler(clsTestAppointments updatedAppointments, clsTest Test);
        public event TestUpdate0DataUpdatedHandler TestDataUpdated;
        public frmManageStreetTestAppo(int LDLAppID, int PassedTest)
        {
            InitializeComponent();
            this.ldlAppID = LDLAppID;
            applicationInfoTest1.LoadData(LDLAppID, PassedTest);
        }

        private void _LoadData()
        {
            dt = clsTestAppointments.GetAppointments(ldlAppID, 3);
            Dgv1.DataSource = dt;
            lRecNumber.Text = (dt.Rows.Count).ToString();
            Dgv1.AllowUserToAddRows = false;
        }


        private void frmManageStreetTestAppo_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Dgv1.SelectedRows.Count > 0)
            {
                int AppotimentID = Convert.ToInt32(Dgv1.SelectedRows[0].Cells["TestAppointmentID"].Value);

                AddEditSteetTest streetTest = new AddEditSteetTest(AppotimentID, ldlAppID, 3);
                streetTest.AppointmentsDataUpdated2 += StreetTest_AppointmentsDataUpdated2;
                streetTest.ShowDialog();    

            }
            else
            {
                MessageBox.Show("Select A Row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StreetTest_AppointmentsDataUpdated2(clsTestAppointments updatedAppointments)
        {
            _LoadData();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Dgv1.SelectedRows.Count > 0)
            {

                bool IsLocked = Convert.ToBoolean(Dgv1.SelectedRows[0].Cells["IsLocked"].Value);

                if (IsLocked == true)
                {
                    MessageBox.Show("Can't Take Test Because You Take it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int AppotimentID = Convert.ToInt32(Dgv1.SelectedRows[0].Cells["TestAppointmentID"].Value);

                TakeStreetTest streetTest = new TakeStreetTest(AppotimentID);
                streetTest.AppointmentsDataUpdated0 += StreetTest_AppointmentsDataUpdated0;
                streetTest.ShowDialog();

            }
            else
            {
                MessageBox.Show("Select A Row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StreetTest_AppointmentsDataUpdated0(clsTestAppointments updatedAppointments, clsTest Test)
        {
            TestDataUpdated?.Invoke(updatedAppointments, Test);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            int Appoitmentid = -1;

            int lastIndex = Dgv1.Rows.Count - 1;
            if (lastIndex >= 0)
            {
                bool IsLocked = Convert.ToBoolean(Dgv1.Rows[lastIndex].Cells["IsLocked"].Value);

                if (IsLocked == false)
                {
                    MessageBox.Show("Can't create a new test while another is active.", "Error");
                    return;
                }
            }

            AddEditSteetTest streetTest = new AddEditSteetTest(Appoitmentid,ldlAppID,3);
            streetTest.AppointmentsDataUpdated2 += StreetTest_AppointmentsDataUpdated2;
            streetTest.ShowDialog();

        }


    }
}
