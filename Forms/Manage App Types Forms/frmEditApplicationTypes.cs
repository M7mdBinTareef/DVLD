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

namespace DVLD
{
    public partial class frmEditApplicationTypes : Form
    {
        private int AppID;
        clsApplicationTypes ApplicationTypes;

        public delegate void TypesDataUpdatedHandler(clsApplicationTypes App);
        public event TypesDataUpdatedHandler App;
        public frmEditApplicationTypes(int ID)
        {
            InitializeComponent();
            this.AppID = ID;
            ApplicationTypes = clsApplicationTypes.Find(ID);
            lableID.Text = ApplicationTypes.ApplicationID.ToString();
            tbTitle.Text = ApplicationTypes.ApplicationTypeTitle;
            tbFees.Text = ApplicationTypes.ApplicationTypeFees.ToString();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ApplicationTypes  = new clsApplicationTypes();

            ApplicationTypes.ApplicationID = Convert.ToInt32(lableID.Text);
            ApplicationTypes.ApplicationTypeTitle = tbTitle.Text;
            ApplicationTypes.ApplicationTypeFees = Convert.ToDecimal(tbFees.Text);

            if (ApplicationTypes.UpdateApp())
            {
                MessageBox.Show("Application Type Updated");
                App?.Invoke(ApplicationTypes);
            }
            else
            {
                MessageBox.Show("Error while Updating Application Type");

            }

        }
    }
}
