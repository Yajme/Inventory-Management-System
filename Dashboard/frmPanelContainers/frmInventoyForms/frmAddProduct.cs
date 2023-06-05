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
            commands.loadcategories();
            while (db.dr.Read())
            {
                cmbCategory.Items.Add(db.dr[1]);
            }
            db.dr.Close();
            db.con.Close();
            //category_End
        }
    }
}
