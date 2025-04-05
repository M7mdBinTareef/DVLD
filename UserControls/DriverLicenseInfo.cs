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
    public partial class DriverLicenseInfo : UserControl
    {
        clsContact Person;
        clsDriver Driver;
        clsLicense License;
        clsLicenseClass LicenseClass;
        clsLocalApplications LocalApplications;

        public string isdetained = "";
        public string isactive = "";
        public int ClassID = 0;
        public int PersonID = 0;
        public DateTime expdate = DateTime.Now;
        public DriverLicenseInfo()
        {
            InitializeComponent();
        }

        private void GetName()
        {
             Name.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
        }

        private void GetGendor()
        {
            if (Person.Gendor == 0)
            {
                Gendor.Text = "Male";
            }
            else if (Person.Gendor == 1)
            {
                Gendor.Text = "FeMale";
            }
        }

        private void GetImage() {

            if (Person.ImagePath != "")
            {
                PersonImage.Image = Image.FromFile(Person.ImagePath);
            }
            else
            {
                MessageBox.Show("There Is No Image To Show");
            }
        }

        private void ShowIssueReason()
        {
            if (License.IssueReason == 1)
            {
                IssueReason.Text = "New";
            }
            else if (License.IssueReason == 2)
            {
                IssueReason.Text = "Renew";
            }
            else if(License.IssueReason == 3)
            {
                IssueReason.Text = "Replacement For Lost";
            }
            else if (License.IssueReason == 4)
            {
                IssueReason.Text = "Replacement For Damage";
            }
        }

        public void ShowData(int LDLAppID)
        {
            LocalApplications = clsLocalApplications.FindLocalApp(LDLAppID);

            if (LocalApplications != null){
            
                License = clsLicense.FindLicenseByApplicationID(LocalApplications.ApplicationID);
                if (License != null){

                    LicenseClass = clsLicenseClass.FindLicenseClass(License.LicenseClass);
                    ClassName.Text = LicenseClass.ClassName.ToString();

                    DriverID.Text = License.DriverID.ToString();

                    LicenseID.Text = License.LicenseID.ToString();

                    IssueDate.Text = License.IssueDate.ToString("yyyy-MM-dd");

                    ShowIssueReason();

                    Note.Text = License.Notes;

                    Is_Active.Text = (License.IsActive == true) ? "Yes" : "No";

                    isactive = Is_Active.Text;

                    expDate.Text = License.ExpirationDate.ToString("yyyy-MM-dd");

                    IsDetained.Text = License.IsDetained;

                    isdetained = License.IsDetained;

                    Driver = clsDriver.FindDriver(License.DriverID);
                    if (Driver != null){


                        Person = clsContact.Find(Driver.PersonID);
                        if (Person != null)
                        {
                            GetName();
                            NationalID.Text = Person.NationalNo;
                            GetGendor();
                            Date_of_Birth.Text = Person.DateOfBirth.ToString("yyyy-MM-dd");
                            GetImage();
                        }

                    }
                }
            }
        }

        public void ShowDataByLicenseID(int licenseID)
        {
            License = clsLicense.FindLicense(licenseID);
            if (License != null)
            {
                LicenseClass = clsLicenseClass.FindLicenseClass(License.LicenseClass);

                ClassID = LicenseClass.LicenseClassID;

                ClassName.Text = LicenseClass.ClassName.ToString();

                DriverID.Text = License.DriverID.ToString();

                LicenseID.Text = License.LicenseID.ToString();

                IssueDate.Text = License.IssueDate.ToString("yyyy-MM-dd");

                ShowIssueReason();

                Note.Text = License.Notes;

                Is_Active.Text = (License.IsActive == true) ? "Yes" : "No";

                isactive = Is_Active.Text;

                expDate.Text = License.ExpirationDate.ToString("yyyy-MM-dd");

                expdate = License.ExpirationDate;


                IsDetained.Text = License.IsDetained;

                isdetained = License.IsDetained;

                Driver = clsDriver.FindDriver(License.DriverID);
                if (Driver != null)
                {

                    Person = clsContact.Find(Driver.PersonID);
                    if (Person != null)
                    {
                        GetName();
                        PersonID = Person.ID;
                        NationalID.Text = Person.NationalNo;
                        GetGendor();
                        Date_of_Birth.Text = Person.DateOfBirth.ToString("yyyy-MM-dd");
                        GetImage();
                    }

                }


            }
        }

    }
}
