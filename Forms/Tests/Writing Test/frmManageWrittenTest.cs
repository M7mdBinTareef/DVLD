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
namespace DVLD.Forms.Tests.Writing_Test
{
    public partial class frmManageWrittenTest : Form
    {
        int ldlAppID = 0;

        DataTable dt;

        public delegate void Appointments3DataUpdatedHandler(clsTestAppointments updatedAppointments);
        public event Appointments3DataUpdatedHandler AppointmentsDataUpdated3;


        public delegate void TestUpdate0DataUpdatedHandler(clsTestAppointments updatedAppointments, clsTest Test);
        public event TestUpdate0DataUpdatedHandler TestDataUpdated;

        public frmManageWrittenTest(int LDLAppID, int PassedTest)
        {
            InitializeComponent();
            this.ldlAppID = LDLAppID;
            applicationInfoTest1.LoadData(LDLAppID, PassedTest);
        }

        private void _LoadData()
        {
            dt = clsTestAppointments.GetAppointments(ldlAppID, 2);
            Dgv1.DataSource = dt;
            lRecNumber.Text = (dt.Rows.Count).ToString();
            Dgv1.AllowUserToAddRows = false;
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

            AddEditWrittenTest writtenTest = new AddEditWrittenTest(Appoitmentid,ldlAppID,2);
            writtenTest.AppointmentsDataUpdated2 += WrittenTest_AppointmentsDataUpdated2;
           
            writtenTest.ShowDialog();

        }

        private void WrittenTest_AppointmentsDataUpdated2(clsTestAppointments updatedAppointments)
        {
            _LoadData();
            AppointmentsDataUpdated3?.Invoke(updatedAppointments);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Dgv1.SelectedRows.Count > 0)
            {
                int AppotimentID = Convert.ToInt32(Dgv1.SelectedRows[0].Cells["TestAppointmentID"].Value);

                AddEditWrittenTest writtenTest = new AddEditWrittenTest(AppotimentID,ldlAppID, 2);
                writtenTest.AppointmentsDataUpdated2 += WrittenTest_AppointmentsDataUpdated2;
                writtenTest.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select A Row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                TakeWrittenTest writtenTest = new TakeWrittenTest(AppotimentID);
                writtenTest.AppointmentsDataUpdated0 += WrittenTest_AppointmentsDataUpdated0;
                writtenTest.ShowDialog();

            }
            else
            {
                MessageBox.Show("Select A Row" , "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WrittenTest_AppointmentsDataUpdated0(clsTestAppointments updatedAppointments, clsTest Test)
        {
            TestDataUpdated?.Invoke(updatedAppointments, Test);
        }

        private void frmManageWrittenTest_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
