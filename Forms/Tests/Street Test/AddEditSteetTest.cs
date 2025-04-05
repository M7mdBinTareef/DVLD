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

namespace DVLD.Forms.Tests.Street_Test
{
    public partial class AddEditSteetTest : Form
    {
        public delegate void Appointments2DataUpdatedHandler(clsTestAppointments updatedAppointments);
        public event Appointments2DataUpdatedHandler AppointmentsDataUpdated2;

        public AddEditSteetTest(int AppoitmentID, int LDLAppID, int TestTypeID)
        {
            InitializeComponent();
            if (AppoitmentID != -1)
            {
                addEditTest1.LoadData(AppoitmentID);
                addEditTest1.AppointmentsDataUpdated += AddEditTest1_AppointmentsDataUpdated;
            }
            else
            {
                addEditTest1.LoadDataForAdding(LDLAppID, TestTypeID);
                addEditTest1.AppointmentsDataUpdated += AddEditTest1_AppointmentsDataUpdated;
            }
        }

        private void AddEditTest1_AppointmentsDataUpdated(clsTestAppointments updatedAppointments)
        {
            AppointmentsDataUpdated2?.Invoke(updatedAppointments);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
