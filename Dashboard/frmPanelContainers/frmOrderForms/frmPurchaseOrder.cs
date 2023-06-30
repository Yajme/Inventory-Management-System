using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.Dashboard.frmPanelContainers.frmOrderForms
{
    public partial class frmPurchaseOrder : Form
    {
        private Itemsupplier GetItemsupplier = new Itemsupplier();
        public frmPurchaseOrder()
        {
            InitializeComponent();
        }

        private void frmPurchaseOrder_Load(object sender, EventArgs e)
        {
            loadSuppliers();
        }
        private void loadSuppliers()
        {
            DataTable dt = commands.loadsuppliers();
            foreach(DataRow row in dt.Rows)
            {
                cboSuppliers.Items.Add(row[1]);
            }
        }
        private void itemEncode(string productID)
        {
            string suppliername = GetItemsupplier.Name;
            if(suppliername != null)
            {
                DataTable product = commands.searchInventoryWOC(productID);
                if (product.Rows.Count > 0)
                {
                    foreach (DataRow row in product.Rows)
                    {
                        if (row[6].ToString() == suppliername)
                        {
                            txtProductName.Text = row[2].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Supplier must match to Product's supplier!", "Supplier Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Item Not Found!", "404", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProductID.Clear();
                    cboSuppliers.SelectedIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("Select Supplier First!","Supplier not found",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            

        }
        private void clearFields()
        {
            txtAuthorization.Clear();
            txtProductID.Clear();
            txtProductName.Clear();
            txtQuantity.Clear();
            dataGridView1.Rows.Clear();
        }
        private void txtProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                itemEncode(txtProductID.Text);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            itemEncode(txtProductID.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int rowcount = dataGridView1.RowCount+1;
            bool found = false;
            if(dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[dataGridView1.Columns["colProductID"].Index].Value.ToString() == txtProductID.Text)
                    {
                        row.Cells[dataGridView1.Columns["colQuantity"].Index].Value = Convert.ToInt32(row.Cells[dataGridView1.Columns["colQuantity"].Index].Value) + Convert.ToInt32(txtQuantity.Text);
                        found = true;
                    }
                }
                if (!found)
                {
                    dataGridView1.Rows.Add(rowcount, txtProductID.Text, txtProductName.Text, txtQuantity.Text);
                }

            }
            else
            {
                dataGridView1.Rows.Add(rowcount, txtProductID.Text, txtProductName.Text, txtQuantity.Text);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if(colName == "colDelete")
            {
                DialogResult result = MessageBox.Show("Are you sure to delete item?", "delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void cboSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetItemsupplier.Name = cboSuppliers.Text;
        }


        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    class Itemsupplier
    {
        private string name;

        public string Name { get { return name; } set { name = value; } }
    }
}
