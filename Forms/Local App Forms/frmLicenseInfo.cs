using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Forms.Local_App_Forms
{
    public partial class frmLicenseInfo : Form
    {
        public frmLicenseInfo(int LocalAppID, int licenseID)
        {
            InitializeComponent();
            if (LocalAppID != -1)
            {
                driverLicenseInfo1.ShowData(LocalAppID);
            }
            else if(licenseID !=-1) { 
            
                driverLicenseInfo1.ShowDataByLicenseID(licenseID);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
