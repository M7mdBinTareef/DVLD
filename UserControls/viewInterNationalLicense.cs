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

namespace DVLD.Forms.Users_Forms
{
    public partial class viewInterNationalLicense : UserControl
    {
        clsContact Person;
        public viewInterNationalLicense()
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

        private void GetImage()
        {

            if (Person.ImagePath != "")
            {
                PersonImage.Image = Image.FromFile(Person.ImagePath);
            }
            else
            {
                MessageBox.Show("There Is No Image To Show");
            }
        }

        public void LoadData(clsInternationalLicenses internationalLicenses)
        {
            clsApplication application = clsApplication.Find(internationalLicenses.ApplicationID);
            if (application != null){

                DriverID.Text = internationalLicenses.DriverID.ToString();

                InterID.Text = internationalLicenses.InternationalLicenseID.ToString();

                IssueDate.Text = internationalLicenses.IssueDate.ToString("yyyy-MM-dd");

                expDate.Text = internationalLicenses.ExpirationDate.ToString("yyyy-MM-dd");

                Isactive.Text = (internationalLicenses.IsActive == true) ? "Yes" : "No";

                licenseID.Text = internationalLicenses.IssuedUsingLocalLicenseID.ToString();

                AppId.Text = internationalLicenses.ApplicationID.ToString();

                Person = clsContact.Find(application.PersonID);
                if (Person !=null)
                {
                    GetName();
                    GetImage();
                    GetGendor();
                    Date_of_Birth.Text = Person.DateOfBirth.ToString("yyyy-MM-dd");
                }
            }
        }
    }
}
