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
            db.con.Open();

            if(query == "*" && filter == "*")
            {
                db.cmd = new SqlCommand("SELECT Products.ProductID, Products.ProductName, Products.Description, Categories.CategoryName, Products.QuantityInStock, Products.UnitPrice, Suppliers.SupplierName\r\nFROM Products\r\nJOIN Categories ON Products.CategoryID = Categories.CategoryID\r\nJOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID", db.con);
            }

            db.dr = db.cmd.ExecuteReader();
            while (db.dr.Read())
            {
                dataGridView1.Rows.Add(db.dr[0], db.dr[1], db.dr[2], db.dr[3], db.dr[4], db.dr[5], db.dr[6]);
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

        }

        private void btnManageCategory_Click(object sender, EventArgs e)
        {

        }

        private void btnManageSupplier_Click(object sender, EventArgs e)
        {

        }

        private void btnManageStocks_Click(object sender, EventArgs e)
        {

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
    }
}
