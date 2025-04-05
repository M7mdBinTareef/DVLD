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
    public partial class ApplicationInfo : Form
    {
        public ApplicationInfo(int AppID)
        {
            InitializeComponent();
            appInfo1.GetAppInfo(AppID);
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
