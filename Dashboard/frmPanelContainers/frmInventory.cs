using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Management_System.Dashboard.frmPanelContainers.frmInventoyForms;
using IronBarCode;
using IronSoftware.Drawing;
using Color = IronSoftware.Drawing.Color;

namespace Inventory_Management_System.Dashboard.frmPanelContainers
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
            
        }

        private void barcodegenerator()
        {
            

            // Creating a barcode is as simple as:
            var myBarcode = BarcodeWriter.CreateBarcode("12345", BarcodeWriterEncoding.EAN8);

            // Resize:
            myBarcode.ResizeTo(400, 100);

            // Set Margins and Color for Barcode
            myBarcode.SetMargins(5, 5, 5, 5);
            myBarcode.ChangeBarCodeColor(Color.Red);

            // And save our barcode as an image:
            myBarcode.SaveAsImage("EAN8.jpeg");

            // Another supported feature is MIL Sizing:
            // Barcode mils are used by the bar code scanner manufactures to state the minimum bar code bar width of one bar, and at what distance the barcode can be scanned.
            var barcodeResizeInMils = BarcodeWriter.CreateBarcode("5941623002802", BarcodeEncoding.Code128);

            // This will resize the Barcode with the MIL size 13 and the default height of 1 inch and default DPI of 96
            barcodeResizeInMils.ResizeToMil(13);
            // This will resize the Barcode with the MIL size 10 and the expected height of 1.5 inch and default DPI of 96
            barcodeResizeInMils.ResizeToMil(10, 1.5);
            // This will resize the Barcode with the MIL size 7.5 and the expected height of 2 inch and expected DPI of 200
            barcodeResizeInMils.ResizeToMil(7.5, 2, 200);
        }
        private void LoadItems(string query, string filter)
        {
            
            dataGridView1.Rows.Clear();
            

            DataTable dt = new DataTable();
            if (query == "*" && filter == "*"){
                dt = commands.loadInventory();
            }else if(query == "*" && filter != "*")
            {
                dt = commands.filterCategory(filter);
            }
            else if(query != "*" && filter == "*")
            {
                dt = commands.searchInventoryWOC(query);
            }
            else
            {
                dt = commands.searchInventory(query, filter);
            }
            if(dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6]);
                }
            }
            else
            {
                MessageBox.Show("Item Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuery.Clear();
                dataGridView1.Focus();
                cmbFilter.SelectedIndex = -1;
                LoadItems("*","*");
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
            frmInventory_Enter();
            loadCategory();
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
            {
                txtQuery.Text = "Search...";
                txtQuery.ForeColor = Color.DimGray;
            }
              
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
            frmManageWarehouse frmNew = new frmManageWarehouse();
            frmNew.ShowDialog();
            frmInventory_Enter();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtQuery.Text != String.Empty && cmbFilter.Text != String.Empty)
            {
                LoadItems(txtQuery.Text, cmbFilter.Text.ToString());
            }
            else if(cmbFilter.Text != String.Empty)
            {
                LoadItems(txtQuery.Text, "*");
            }
            
        }


        private void frmInventory_Enter()
        {
            dataGridView1.Focus();
            LoadItems("*", "*");
            
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbFilter.Text != "")
            {
                LoadItems("*", cmbFilter.Text);
            }
            
           
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            
            
            if (!string.IsNullOrWhiteSpace(txtQuery.Text))
            {
                txtQuery.Text = "Search...";
                txtQuery.ForeColor = Color.DimGray;
            }
            frmInventory_Enter();
            cmbFilter.SelectedIndex = -1;
           
        }

        private void txtQuery_TextChanged(object sender, EventArgs e)
        {
            if (txtQuery.Text == "Search...")
            {
                frmInventory_Enter();
            }

            

        }

        private void txtQuery_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if(cmbFilter.Text.ToString() == "")
                {
                    LoadItems(txtQuery.Text, "*");
                }
                else
                {
                    LoadItems(txtQuery.Text, cmbFilter.Text.ToString());

                }
                
            }
        }
    }
}
