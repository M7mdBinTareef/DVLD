using System;
using System.Data;
using System.Windows.Forms;
using PeopleBusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DVLD.Forms
{
    public partial class frmNewLocalDriving : Form
    {

        private clsContact Person;

        private clsApplication PublicApplication;

        private PublicUser PublicUser;

        private clsLocalApplications LocalApplications;

        public delegate void LocalAppDataUpdatedHandler(clsContact updatedPerson, clsLocalApplications clsLocalApplications);
        public event LocalAppDataUpdatedHandler LocalAppDataUpdated;

        public enum enMode { AddNew = 0, Update = 1 };
        enMode _Mode = enMode.AddNew;

        private int LDLAppID;

        public frmNewLocalDriving() // New Mode
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
            LDLAppID = -1;
            InitializeForm();
        }

        // Constructor for Updating Existing Application
        public frmNewLocalDriving(int id) // Update Mode
        {
            InitializeComponent();
            _Mode = enMode.Update;
            LDLAppID = id;
            InitializeForm();
            LoadData();
        }

        private void InitializeForm()
        {
            ClassNameFill();
            Date.Text = DateTime.Today.ToString("yyyy-MM-dd");
            PublicUser = SessionManager.Instance.CurrentUser;
            lUser.Text = PublicUser.clsUser.UserName;
        }

        private void ClassNameFill()
        {
            DataTable dataTable = new DataTable();
            dataTable = clsLicenseClass.GetClassName();
            foreach (DataRow row in dataTable.Rows)
            {
                cbLC.Items.Add(row["ClassName"].ToString());
            }
        }

        private void LoadData()
        {
            if (_Mode == enMode.AddNew)
            {
                if (cbFilterd.SelectedIndex == 0 && !string.IsNullOrEmpty(FilterdBox.Text))
                {
                    int PersonID = Convert.ToInt32(FilterdBox.Text);
                    Person = clsContact.Find(PersonID);

                    if (Person != null)
                    {
                        viewDetails1.GetPersonInfo(PersonID);
                    }
                    else
                    {
                        MessageBox.Show("Person not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (cbFilterd.SelectedIndex == 1 && !string.IsNullOrEmpty(FilterdBox.Text))
                {
                    string NationalID = FilterdBox.Text;
                    Person = clsContact.Find(NationalID);

                    if (Person != null)
                    {
                        viewDetails1.GetPersonInfo(Person.ID);
                    }
                    else
                    {
                        MessageBox.Show("Person not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID = -1;
            AddEditPerson addEditPersonForm = new AddEditPerson(ID);
            addEditPersonForm.PersonDataUpdated += AddEditPersonForm_PersonDataUpdated;
            addEditPersonForm.ShowDialog();
        }

        private void AddEditPersonForm_PersonDataUpdated(clsContact updatedPerson)
        {
            viewDetails1.GetPersonInfo(updatedPerson.ID);
            Person = updatedPerson;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (LDLapp.SelectedIndex < LDLapp.TabCount - 1)
            {
                LDLapp.SelectedIndex++;
            }
            else
            {
                MessageBox.Show("You are already on the last tab.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Person == null || PublicUser == null)
            {
                MessageBox.Show("Error: Missing required data.");
                return;
            }

            if (cbLC.SelectedItem == null)
            {
                MessageBox.Show("Please select a License Class.");
                return;
            }

            int LicenseClassID = clsLicenseClass.GetClassDataOnName(cbLC.Text).LicenseClassID;

            if (clsLicense.IsLicenseExistByPersonID(Person.ID, LicenseClassID))
            {

                MessageBox.Show("Person already have a license with the same applied driving class, Choose diffrent driving class", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int ActiveApplicationID = clsApplication.GetActiveApplicationIDForLicenseClass(Person.ID, 1, LicenseClassID);

            if (ActiveApplicationID != -1)
            {
                MessageBox.Show("Choose another License Class, the selected Person Already have an active application for the selected class with id=" + ActiveApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbLC.Focus();
                return;
            }

            if (PublicApplication == null && LDLAppID == -1)
            {
                PublicApplication = new clsApplication();
                PublicApplication.PersonID = Person.ID;
                PublicApplication.ApplicationDate = DateTime.Now;
                PublicApplication.ApplicationTypeID = 1;
                PublicApplication.ApplicationStatus = 1;
                PublicApplication.LastStatusDate = DateTime.Now;
                PublicApplication.PaidFees = 15;
                PublicApplication.CreatedByUserID = PublicUser.UserID;

                if (PublicApplication.Save())
                {
                    MessageBox.Show("Application Added");
                    LocalApplications = new clsLocalApplications();
                    LocalApplications.ApplicationID = PublicApplication.AppID;
                    LocalApplications.LicenseClassID = clsLicenseClass.GetClassDataOnName(cbLC.Text).LicenseClassID;

                    if (LocalApplications.Save())
                    {
                        MessageBox.Show("Local Application Application Added");
                        LocalAppDataUpdated?.Invoke(Person,LocalApplications);
                    }
                    else
                    {
                        MessageBox.Show("Failed To Add Local Appliacion");
                    }
                }
                else
                {
                    MessageBox.Show("An Error occuered While Add Applicaion","error");
                }


            }

            else if (PublicApplication != null && LDLAppID != -1)
            {
                PublicApplication.LastStatusDate = DateTime.Now;
                if (PublicApplication.Save())
                {
                    MessageBox.Show("Application Update");
                    LocalApplications.LicenseClassID = clsLicenseClass.GetClassDataOnName(cbLC.Text).LicenseClassID;
                    if (LocalApplications.Save())
                    {
                        MessageBox.Show("Local Application Update");
                        LocalAppDataUpdated?.Invoke(Person, LocalApplications);
                    }
                    else
                    {
                        MessageBox.Show("Failed To Update Local Appliacion");
                    }
                }
            }

           
        }

        private void frmNewLocalDriving_Load(object sender, EventArgs e)
        {

            if (_Mode == enMode.Update)
            {
                groupBox1.Enabled = false;
                LocalApplications = clsLocalApplications.FindLocalApp(LDLAppID);
                if (LocalApplications != null)
                {
                    PublicApplication = clsApplication.Find(LocalApplications.ApplicationID);
                    if (PublicApplication != null)
                    {
                        Person = clsContact.Find(PublicApplication.PersonID);
                        if (Person != null)
                        {
                            viewDetails1.GetPersonInfo(Person.ID);
                            lMain.Text = $"Update Local Application For {LocalApplications.LDLAppID}";
                            dlID.Text = LocalApplications.LDLAppID.ToString();
                            Date.Text = PublicApplication.ApplicationDate.ToString();
                            cbLC.Text = clsLicenseClass.FindLicenseClass(LocalApplications.LicenseClassID).ClassName;
                        }
                    }
                }
            }


        }
    }
}
