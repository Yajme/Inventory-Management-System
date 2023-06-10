﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Inventory_Management_System.Dashboard.frmPanelContainers.frmInventoyForms;
namespace Inventory_Management_System.Dashboard.frmPanelContainers
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }
        private void LoadItems(string query, string filter)
        {
            dataGridView1.Rows.Clear();
            loadCategory();

            DataTable dt = new DataTable();
            if (query == "*" && filter == "*"){
                dt = commands.loadInventory();
            }else if(query == "*" && filter != "*")
            {
                dt = commands.filterCategory(filter);
            }
            else
            {
                dt = commands.searchInventory(query, filter);
            }

            foreach (DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6]);
            }
        }
        private void loadCategory()
        {
            cmbFilter.Items.Clear();

            DataTable dt = commands.loadcategories();
            foreach (DataRow row in dt.Rows)
            {
                cmbFilter.Items.Add(row[1]);
            }
        }
        private void frmInventory_Load(object sender, EventArgs e)
        {
            LoadItems("*", "*");
            
        }

        public void RemoveText(object sender, EventArgs e)
        {
            if(txtQuery.Text == "Search...")
            {
                txtQuery.Text = "";
                txtQuery.ForeColor = Color.Black;
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuery.Text))
              txtQuery.Text = "Search...";
              txtQuery.ForeColor = Color.DimGray;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddProduct frmNew = new frmAddProduct();
            frmNew.ShowDialog();
            frmInventory_Enter();

        }

        private void btnManageCategory_Click(object sender, EventArgs e)
        {
            frmManageCategory frmNew = new frmManageCategory();
            frmNew.ShowDialog();
            frmInventory_Enter();
        }

        private void btnManageSupplier_Click(object sender, EventArgs e)
        {
            frmManageSupplier frmNew = new frmManageSupplier();
            frmNew.ShowDialog();
            frmInventory_Enter();
        }

        private void btnManageStocks_Click(object sender, EventArgs e)
        {
            frmManageStocks frmNew = new frmManageStocks();
            frmNew.ShowDialog();
            frmInventory_Enter();
        }

        private void btnManageWarehouse_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadItems(txtQuery.Text, cmbFilter.SelectedItem.ToString());
        }


        private void frmInventory_Enter()
        {
            LoadItems("*", "*");
            
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadItems("*", cmbFilter.SelectedItem.ToString());
           
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtQuery.Text = "";
            cmbFilter.SelectedIndex = 0;
           
        }

        private void txtQuery_TextChanged(object sender, EventArgs e)
        {
            if (txtQuery.Text == String.Empty){
                LoadItems("*", "*");
            }

        }
    }
}
