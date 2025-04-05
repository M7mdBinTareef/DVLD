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
    public partial class frmManageApplicationTypes : Form
    {
        DataTable dt;
        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LoaddDataGridView()
        {
            dt = clsApplicationTypes.GetApplicationTypesData();

            // Bind the DataTable to the DataGridView
            Dgv1.DataSource = dt;
            lRecNumber.Text = (dt.Rows.Count).ToString();
            Dgv1.AllowUserToAddRows = false;

        }
        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _LoaddDataGridView();
        }


        private void EditApplicationTypes_App(clsApplicationTypes App)
        {
            _LoaddDataGridView();
        }

        private void editApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ApplicationTypeID = (int)Dgv1.CurrentRow.Cells[0].Value;
            frmEditApplicationTypes editApplicationTypes = new frmEditApplicationTypes(ApplicationTypeID);
            editApplicationTypes.App += EditApplicationTypes_App;
            editApplicationTypes.ShowDialog();
        }
    }
}
