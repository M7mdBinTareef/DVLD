﻿using System;
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
    public partial class ManageTestTypes : Form
    {
        DataTable dt;
        public ManageTestTypes()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _LoaddDataGridView()
        {
            dt = clsTestTypes.GetTestTypesData();

            // Bind the DataTable to the DataGridView
            Dgv1.DataSource = dt;
            lRecNumber.Text = (dt.Rows.Count).ToString();
            Dgv1.AllowUserToAddRows = false;

        }
        private void ManageTestTypes_Load(object sender, EventArgs e)
        {
            _LoaddDataGridView();
        }

        private void EditApplicationTypes_App(clsTestTypes Test)
        {
            _LoaddDataGridView();
        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestTypeID = (int)Dgv1.CurrentRow.Cells[0].Value;
            EditTestTypes editTestTypes = new EditTestTypes(TestTypeID);
            editTestTypes.Test += EditApplicationTypes_App;
            editTestTypes.ShowDialog();
        }
    }
}
