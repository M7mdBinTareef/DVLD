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
namespace DVLD.Forms
{
    public partial class EditTestTypes : Form
    {
        private int TestID;
        clsTestTypes clsTestTypes;

        public delegate void TypesDataUpdatedHandler(clsTestTypes Test);
        public event TypesDataUpdatedHandler Test;

        public EditTestTypes(int ID)
        {
            InitializeComponent();

            TestID = ID;
            clsTestTypes = clsTestTypes.Find(TestID);
            lableID.Text = clsTestTypes.TestID.ToString();
            rbDescription.Text = clsTestTypes.TestDescrption;
            tbTitle.Text = clsTestTypes.TestTypeTitle;
            tbFees.Text = clsTestTypes.TestTypeFees.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsTestTypes = new clsTestTypes();

            clsTestTypes.TestID = Convert.ToInt32(lableID.Text);
            clsTestTypes.TestTypeTitle = tbTitle.Text;
            clsTestTypes.TestDescrption = rbDescription.Text;
            clsTestTypes.TestTypeFees = Convert.ToDecimal(tbFees.Text);

            if (clsTestTypes.UpdateTest())
            {
                MessageBox.Show("Test Type Updated");
                Test?.Invoke(clsTestTypes);
            }
            else
            {
                MessageBox.Show("Error while Updating Test Type");

            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
