using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Properties;
using PeopleBusinessLayer;
using System.IO;

namespace DVLD
{
    public partial class AddPerson : UserControl
    {



        private int PersonID;
        private string copiedImagePath;
        clsContact Person;
        public enum enMode { AddNew = 0, Update = 1 };
        enMode _Mode  = enMode.AddNew;
        public AddPerson()
        {
            InitializeComponent();
        }

        public AddPerson(int ID) :this()
        {
            Combobox1fill();
            Dt1MaxDateDate();
            this.PersonID = ID;

            if (this.PersonID == -1)
            {
                _Mode = enMode.AddNew;
                Person = new clsContact(); // Initialize for adding a new person
            }
            else
            {
                _Mode = enMode.Update;
                _LoadData(); // Load data for update
            }
        }


        private void _LoadData()
        {
            if (this.PersonID == -1) {
                Person = new clsContact();
                lMain.Text = "Add New Person";
                return;
            }

            Person = clsContact.Find(this.PersonID);

            if (Person == null) {

                MessageBox.Show("Erorr Dosent Exist");
            }


            lMain.Text = "Update Person : " + PersonID;
            tbNational.Text = Person.NationalNo;
            lPersonID.Text = Person.ID.ToString();
            tbFirst.Text = Person.FirstName;
            tbSecond.Text = Person.SecondName;
            tbThird.Text = Person.ThirdName;
            tbLast.Text = Person.LastName;
            tbNational.Text = Person.NationalNo;
            dt1.Value = Person.DateOfBirth;
            LoadGender(Person.Gendor);
            lPhone.Text = Person.Phone;
            tbEmail.Text = Person.Email;
            comboBox1.Text = clsCountry.Find(Person.NationalityCountryID).CountryName;
            richTextBox1.Text = Person.Address;
            

            if(Person.ImagePath != null)
            {
                PersonImage.Image = Image.FromFile(Person.ImagePath);
            }

        }

        

        private void LoadGender(int gender)
        {
            if (gender == 1)
            {
                rbFemale.Checked = true;
            }
            else if (gender == 0)
            {
                rbMale.Checked = true;
            }
        }

        private int InsertGender(RadioButton Female, RadioButton Male)
        {
            if (Female.Checked)
            {
                 return Person.Gendor = 1;
            }
            else if (Male.Checked)
            {
                 return  Person.Gendor = 0; 
            }
            return -1;
        }

        private void Dt1MaxDateDate()
        {
            dt1.MaxDate = DateTime.Now.AddYears(-18);
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
           PersonImage.Image = Image.FromFile(@"D:\Downloads\icons8-man-100.png"); 
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {  
           PersonImage.Image = Image.FromFile(@"D:\Downloads\icons8-woman-96.png"); 
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {

            string input = tbEmail.Text;

            // Validate email
            if (!IsValidEmail(input))
            {
                lblError.Visible = true; // Show error indicator
                lblError.Text = "X"; // Optional: Add text if needed

                // Prevent the user from leaving the TextBox
                e.Cancel = true;
            }
            else
            {
                lblError.Visible = false; // Hide error indicator
            }
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void Combobox1fill()
        {
            DataTable dataTable = new DataTable();
            dataTable = clsCountry.GetAllCountriesName();
            
            foreach (DataRow row in dataTable.Rows) {

                comboBox1.Items.Add(row["CountryName"].ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form ParentForm= this.FindForm();
            if (ParentForm !=null)
            {
                ParentForm.Close();
            }

        }

        private void richTextBox1_Validating(object sender, CancelEventArgs e)
        {
            string input = richTextBox1.Text;

            if (string.IsNullOrWhiteSpace(input))
            {
                lblAddressErr.Visible = true; // Show error indicator
                lblAddressErr.Text = "X"; // Optional: Add text if needed

                e.Cancel = true; // Prevent focus from leaving the TextBox
            }
            else
            {
                lblError.Visible = false; // Hide error indicator
            }
        }

        private void lSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select an Image";

                // Show the dialog and check if the user selected a file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string selectedFilePath = openFileDialog.FileName;
                        string destinationDirectory = @"D:\Images\";  // Adjust this path as needed
                        string destinationFilePath = Path.Combine(destinationDirectory, Path.GetFileName(selectedFilePath));

                        // Ensure the directory exists
                        if (!Directory.Exists(destinationDirectory))
                        {
                            Directory.CreateDirectory(destinationDirectory);
                        }

                        // Copy the selected image to the destination folder
                        File.Copy(selectedFilePath, destinationFilePath, true);  // The 'true' overwrites if the file exists

                        // Store the copied image path for later use
                        copiedImagePath = destinationFilePath;

                        // Load the selected image into the PictureBox
                        using (FileStream fs = new FileStream(copiedImagePath, FileMode.Open, FileAccess.Read))
                        {
                            PersonImage.Image = Image.FromStream(fs);
                        }

                        Remove.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions (e.g., invalid image file)
                        MessageBox.Show($"An error occurred: {ex.Message}",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Remove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            // Clear the image in the PictureBox
            if (PersonImage.Image != null)
            {
                PersonImage.Image.Dispose(); // Release the image resource
                PersonImage.Image = null;
            }

            // Delete the copied image file from the new location
            if (!string.IsNullOrEmpty(copiedImagePath) && File.Exists(copiedImagePath))
            {
                try
                {
                    File.Delete(copiedImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the image: {ex.Message}",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Optionally, reset the copiedImagePath
            copiedImagePath = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Person.NationalNo = tbNational.Text;
                Person.FirstName = tbFirst.Text;
                Person.SecondName = tbSecond.Text;
                Person.ThirdName = tbThird.Text;
                Person.LastName = tbLast.Text;
                Person.Email = tbEmail.Text;
                Person.Phone = lPhone.Text;
                Person.DateOfBirth = dt1.Value;
                InsertGender(rbFemale, rbMale);

                var country = clsCountry.Find(comboBox1.Text);
                if (country == null)
                {
                    MessageBox.Show("Please select a valid country.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Person.NationalityCountryID = country.ID;
                Person.Address = richTextBox1.Text;
                Person.ImagePath = copiedImagePath;

                if (Person.Save())
                {
                    MessageBox.Show("Person information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("An error occurred while saving the information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (_Mode == enMode.AddNew)
                {
                    ClearForm();
                }
                else
                {
                    _LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ClearForm()
        {
            // Reset text fields
            tbNational.Clear();
            tbFirst.Clear();
            tbSecond.Clear();
            tbThird.Clear();
            tbLast.Clear();
            tbEmail.Clear();
            lPhone.Text = string.Empty;
            richTextBox1.Clear();

            // Reset date picker
            dt1.Value = DateTime.Now.AddYears(-18); // Set to the default max age

            // Reset gender radio buttons
            rbMale.Checked = false;
            rbFemale.Checked = false;

            // Reset combo box
            comboBox1.SelectedIndex = -1; // Deselect any selected item

            // Reset image
            if (PersonImage.Image != null)
            {
                PersonImage.Image.Dispose();
                PersonImage.Image = null;
            }

            // Clear copied image path
            copiedImagePath = null;

            // Reset labels
            lMain.Text = "Add New Person";
            lPersonID.Text = string.Empty;

            // Hide error labels (if applicable)
            lblError.Visible = false;
            lblAddressErr.Visible = false;
        }

    }
}
