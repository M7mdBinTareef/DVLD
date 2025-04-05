using System;
using System.Windows.Forms;
using PeopleBusinessLayer;

namespace DVLD.UserControls
{
    public partial class InterNationalLicenses : UserControl
    {

        public string isdetained = "";
        public string isactive = "";
        public int ClassID = 0;
        public int PersonID = 0;
        public string LicenseID = "";
        public DateTime ExpDate = DateTime.Now;
        public GroupBox GroupBox;
        public int search;
        public InterNationalLicenses()
        {
            InitializeComponent();
        }

        public void LoadDataWithoutSearch(int licenseID)
        {
            driverLicenseInfo1.ShowDataByLicenseID(licenseID);
            isdetained = driverLicenseInfo1.isdetained;
            isactive = driverLicenseInfo1.isactive;
            ClassID = driverLicenseInfo1.ClassID;
            PersonID = driverLicenseInfo1.PersonID;
            ExpDate = driverLicenseInfo1.expdate;
            LicenseID = licenseID.ToString();
            GroupBox = groupBox1;
            tbSearch.Text = search.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            
            if (!string.IsNullOrWhiteSpace(tbSearch.Text) && int.TryParse(tbSearch.Text, out search))
            {
                driverLicenseInfo1.ShowDataByLicenseID(search);
                isdetained = driverLicenseInfo1.isdetained;
                isactive = driverLicenseInfo1.isactive;
                ClassID = driverLicenseInfo1.ClassID;
                PersonID = driverLicenseInfo1.PersonID;
                ExpDate = driverLicenseInfo1.expdate;
                LicenseID = search.ToString();
                GroupBox = groupBox1;
            }
            else
            {
                MessageBox.Show("Please enter a valid license ID.");
            }
        }
    }
}
