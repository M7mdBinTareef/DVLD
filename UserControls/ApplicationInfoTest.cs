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
namespace DVLD.UserControls
{
    public partial class ApplicationInfoTest : UserControl
    {
        
        clsLocalApplications LocalApplications;
        
        public ApplicationInfoTest()
        {
            InitializeComponent();
        }

        public void LoadData(int ldlAppID, int passedTest)
        {
            LocalApplications = clsLocalApplications.FindLocalApp(ldlAppID);

            appInfo1.GetAppInfo(LocalApplications.ApplicationID);


            if (LocalApplications != null)
            {
                LDLAppID.Text = LocalApplications.LDLAppID.ToString();
                LicenseClassName.Text = clsLicenseClass.FindLicenseClass(LocalApplications.LicenseClassID).ClassName;
                PTest.Text =   passedTest.ToString() + "/3";
            }
            else {

                MessageBox.Show("Error No Local Application Found", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
;            }

        }
    }
}
