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

namespace DVLD.Forms.Licenses
{
    public partial class frmViewInterNationalLicense : Form
    {
        clsInternationalLicenses internationalLicenses;
        public frmViewInterNationalLicense(clsInternationalLicenses InternationalLicenses)
        {
            InitializeComponent();
            internationalLicenses = InternationalLicenses;
        }

        private void frmViewInterNationalLicense_Load(object sender, EventArgs e)
        {
            viewInterNationalLicense1.LoadData(internationalLicenses);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
