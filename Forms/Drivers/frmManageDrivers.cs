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

namespace DVLD.Forms.Drivers
{
    public partial class frmManageDrivers : Form
    {
        DataTable dt;
        public frmManageDrivers()
        {
            InitializeComponent();
        }



        private void FilterdBox()
        {
            if (dt != null && cb1.SelectedItem != null)
            {
                string filterColumn = cb1.SelectedItem.ToString(); // Get selected column name
                string searchText = Filterdtb.Text;

                if (!string.IsNullOrEmpty(searchText))
                {
                    DataColumn column = dt.Columns[filterColumn];

                    if (column.DataType == typeof(int) || column.DataType == typeof(long) || column.DataType == typeof(double))
                    {
                        // Convert numeric column to string for filtering
                        dt.DefaultView.RowFilter = $"CONVERT([{filterColumn}], 'System.String') LIKE '%{searchText}%'";
                        lRecNumber.Text = (dt.DefaultView.Count).ToString();
                    }
                    else
                    {
                        // Directly apply filter for string columns
                        dt.DefaultView.RowFilter = $"[{filterColumn}] LIKE '%{searchText}%'";
                        lRecNumber.Text = (dt.DefaultView.Count).ToString();
                    }
                }
                else
                {
                    // Clear filter
                    dt.DefaultView.RowFilter = string.Empty;
                }

            }
            
        }



        private void _LoadData()
        {
            dt = clsDriver.GetAllDrivers();
            Dgv1.DataSource = dt;
            lRecNumber.Text = (dt.Rows.Count).ToString();
            Dgv1.AllowUserToAddRows = false;
        }

        private void frmManageDrivers_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Filterdtb_TextChanged(object sender, EventArgs e)
        {
            FilterdBox();
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb1.SelectedIndex != 0) { Filterdtb.Visible = true; }
            FilterdBox();
        }
    }
}
