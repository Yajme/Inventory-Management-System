using System;
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

            if(query == "*" && filter == "*")
            {
                commands.loadInventory();
            }

           
            while (db.dr.Read())
            {
                dataGridView1.Rows.Add(db.dr[0], db.dr[1], db.dr[2], db.dr[3], db.dr[4], db.dr[5], db.dr[6]);
            }

            db.dr.Close();
            db.con.Close();
        }
        private void loadCategory()
        {
            commands.loadcategories();
            while (db.dr.Read())
            {
                cmbFilter.Items.Add(db.dr[1]);
            }
            db.dr.Close();
            db.con.Close();
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

        }

        private void btnScan_Click(object sender, EventArgs e)
        {

        }

        private void frmInventory_Enter()
        {
            LoadItems("*", "*");
            
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            db.con.Open();
            db.cmd = new SqlCommand("SELECT Products.ProductID, Products.ProductName, Products.Description, Categories.CategoryName, Products.QuantityInStock, Products.UnitPrice, Suppliers.SupplierName\r\nFROM Products\r\nJOIN Categories ON Products.CategoryID = Categories.CategoryID\r\nJOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID WHERE Categories.CategoryName= @CategoryName", db.con);
            db.cmd.Parameters.AddWithValue("@CategoryName", cmbFilter.SelectedItem.ToString());
            db.dr = db.cmd.ExecuteReader();

            while (db.dr.Read())
            {
                dataGridView1.Rows.Add(db.dr[0], db.dr[1], db.dr[2], db.dr[3], db.dr[4], db.dr[5], db.dr[6]);
            }

            db.dr.Close();
            db.con.Close();
        }
    }
}
