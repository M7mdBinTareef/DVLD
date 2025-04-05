using System;
using System.Linq;
using System.Windows.Forms;
using PeopleBusinessLayer;

namespace DVLD
{
    public partial class ViewUser : UserControl
    {
        private int UserID;
        private clsUser User;

        public ViewUser()
        {
            InitializeComponent();
        }

        public ViewUser(int UserID) : this()
        {
            this.UserID = UserID;
        }
        public void LoadPersonData(int UserID)
        {
            User = clsUser.Find(UserID);
            if (User != null)
            {
                lUserID.Text = User.UserID.ToString();
                lUserName.Text = User.UserName;
                lStatus.Text = User.IsActive ? "Yes" : "No";
            }
            else
            {
                MessageBox.Show("User not found!");
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
    }
}
