using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Inventory_Management_System.Dashboard.frmPanelContainers.frmInventoyForms
{
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            clearItems();
            loadcombobox();
        }

        private void clearItems()
        {
            txtDescription.Text = "";
            txtProductID.Text = "";
            txtProductName.Text = "";
            txtUnitPrice.Text = "";

            cmbCategory.Items.Clear();
            cmbSupplier.Items.Clear();
        }
        public void loadcombobox()
        {
            //Supplier_start
            commands.loadsuppliers();
            while (db.dr.Read())
            {
                cmbSupplier.Items.Add(db.dr[1]);
            }
            db.dr.Close();
            db.con.Close();
            //supplier_End
            // Category__start
            DataTable dt = commands.loadcategories();
            foreach (DataRow row in dt.Rows)
            {
                cmbCategory.Items.Add(row[1]);
            }
            //category_End
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            try
            {
                int categoryid = commands.categoryValidator(cmbCategory.Text);
                int supplierid = commands.supplierValidator(cmbSupplier.Text);
                string[] products = new string[6];
                products[0] = txtProductID.Text;
                products[1] = txtProductName.Text;
                products[2] = txtDescription.Text;
                products[3] = categoryid.ToString();
                products[4] = supplierid.ToString();
                products[5] = txtUnitPrice.Text;
                commands.insertInventory(products);
                MessageBox.Show("Product Added!");
                clearItems();
                this.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error in database: " + ex.Message);
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
               
            
            
           
            
        }
    }
}
