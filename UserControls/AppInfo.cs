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

namespace DVLD.UserControls
{
    public partial class AppInfo : UserControl
    {
        clsApplication app;
        public AppInfo()
        {
            InitializeComponent();
        }

        private void AppStatus()
        {
            if (app.ApplicationStatus == 1)
                {Status.Text = "New";}
            else if (app.ApplicationStatus == 2)
                {Status.Text = "Canceld";}
            else if (app.ApplicationStatus == 3) { Status.Text = "Completed"; }
        }


        private void Getype(){

            if (app.ApplicationTypeID == 1)
                 Type.Text =  "New Local Driving License Service";
            else if (app.ApplicationTypeID == 2)
                Type.Text = "Renew Driving License Service";
            else if (app.ApplicationTypeID == 3)
                Type.Text = "Replacement for a Lost Driving License";
            else if (app.ApplicationTypeID == 4)
                Type.Text = "Replacement for a Damaged Driving License";
            else if (app.ApplicationTypeID == 5)
                Type.Text = "Release Detained Driving License";
            else if (app.ApplicationTypeID == 6)
                Type.Text = "New International License";

        }

        private void GetFullName(){
        
            clsContact Contact = clsContact.Find(app.PersonID);
            if (Contact != null) 
            {
                Applicant.Text = Contact.FirstName + " " + Contact.SecondName + " " + Contact.ThirdName + " " + Contact.LastName;    
            }
        }

        private void CreatedBY()
        {
            clsUser user = clsUser.Find(app.CreatedByUserID);
            if (user != null)
            {
                Created_By.Text = user.UserName;
            }
        }

        public void GetAppInfo(int ApplicationID)
        {
            app = clsApplication.Find(ApplicationID);
            if (app != null)
            {
                ID.Text = app.AppID.ToString();
                AppStatus();
                Getype();
                GetFullName();
                Date.Text = app.ApplicationDate.ToString("yyyy-MM-dd");
                Status_Date.Text = app.LastStatusDate.ToString("yyyy-MM-dd");
                CreatedBY();
            }
            else
            {
                MessageBox.Show("Application Not Found", "Error");
            }
                
        }

        private void PersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmViewDetails ViewDetails = new frmViewDetails(app.PersonID);
            ViewDetails.ShowDialog();
        }
    }
}
