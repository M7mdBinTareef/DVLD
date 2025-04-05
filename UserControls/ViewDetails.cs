using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Forms;
using PeopleBusinessLayer;

namespace DVLD
{
    public partial class ViewDetails : UserControl
    {
        private int _PersonID;
        private clsContact _Person;
        public int PersonID
        {
            get { return _PersonID; }
        }
        public ViewDetails()
        {
            InitializeComponent();
        }


        public void GetPersonInfo(int PersonID)
        {
            // Debugging: Log the PersonID to ensure it's correct

            try
            {
                // Attempt to find the person based on the PersonID
                _Person = clsContact.Find(Convert.ToInt32(PersonID));
                
                if (_Person != null)
                {
                    // Construct the full name
                    string FullName = $"{_Person.FirstName} {_Person.SecondName} {_Person.ThirdName} {_Person.LastName}";
                    _PersonID = _Person.ID;

                    // Update the labels with the person’s information
                    lPersonlD.Text = _Person.ID.ToString();
                    lName.Text = FullName;
                    lNationalNo.Text = _Person.NationalNo;
                    lGendor.Text = (_Person.Gendor == 0) ? "Male" : "Female"; // Gender check
                    lEmail.Text = _Person.Email;
                    lAddress.Text = _Person.Address;
                    lDate.Text = _Person.DateOfBirth.ToString("d");
                    lPhone.Text = _Person.Phone;
                    lCountry.Text = clsCountry.Find(_Person.NationalityCountryID)?.CountryName ?? "Unknown"; // Country name check

                    Image image = Image.FromFile(_Person.ImagePath);

                    // Check if the image is not null
                    if (!string.IsNullOrEmpty(_Person.ImagePath) && System.IO.File.Exists(_Person.ImagePath))
                    {
                        PersonImage.Image = Image.FromFile(_Person.ImagePath);
                    }
                    else
                    {
                        PersonImage.Image = null; // Clear the image if not found
                    }


                }
                else
                {
                    MessageBox.Show("Person not found for ID: " + PersonID);
                }
            }
            catch (Exception ex)
            {
                // Catch and log any exceptions that occur during the search
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Close();
            }
        }

        private void lEditInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddEditPerson addEditPerson = new AddEditPerson(_PersonID);
            addEditPerson.ShowDialog();

            GetPersonInfo(_PersonID);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Close();
            }
        }


    }
}