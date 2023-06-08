using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.Dashboard.frmPanelContainers.frmInventoyForms
{
    public partial class frmManageStocks : Form
    {
        private const int CB_SETCUEBANNER = 0x1703;

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);
        public frmManageStocks()
        {
            InitializeComponent();

            SendMessage(this.cmbWarehouse.Handle, CB_SETCUEBANNER, 0, "Please select an item...");
        }
        //stockmovements -> products
        //quantity -> outgoing -> quantity
        /* 
        ------------------                                                   ------------------
        | StockMovements |                                                   | StockMovements  |
        ------------------                                                   ------------------
        |Quantity|MvtType|  -> /ManageStocks(AddStockstoInventory, 5);/ - >  |Quantity|MvtType |  
        ------------------                                                   ------------------
        |   10   |Ingoing|                                                   |   10   |Ingoing |
        ------------------                                                   |   5    |Outgoing| 
                                                                             -------------------  
        
           -------------------------                                        -------------------------
           |       Products        |                                        |       Products        | 
           -------------------------                                        -------------------------
           |QtyInStock|ReorderLevel|                                        |QtyInStock|ReorderLevel|
           -------------------------  /ManageStocks(AdjustStock)/ ->       -------------------------
           |    5     |    LowStock |                                       |    10     |    0       |
           -------------------------                                        -------------------------
        
        
        */
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageStocks_Load(object sender, EventArgs e)
        {
            loadWarehouse();
            txtQuantity.Text = "0";
            
        }

        private void loadWarehouse()
        {
            cmbWarehouse.Items.Clear();
            commands.loadWarehouses();
            while (db.dr.Read())
            {
                cmbWarehouse.Items.Add(db.dr[1]);
            }
            db.dr.Close();
            db.con.Close();
        }
        private void selectWarehouse(string productID)
        {
            //WHERE warehouse.WarehouseName = @name AND Products.ProductID = @name
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtQuantity.Text) - 1;
            txtQuantity.Text = number.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtQuantity.Text) + 1;
            txtQuantity.Text = number.ToString();
        }

        private void selectProduct(string productid)
        {
            string[] itemfetched = commands.itemEncode(productid);
            if (itemfetched != Array.Empty<string>())
            {
                txtProductName.Text = itemfetched[1];
                txtQuantity.Text = itemfetched[3];
            }
            else
            {
                MessageBox.Show("Item Not Found\n\n Please check if warehouse has Item", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                selectProduct(txtProductID.Text);
            }
        }
        private void warehouseStockCheck(string[] stock)
        {
           
        }

        private int warehouseID(string warehouse)
        {
            int id = 0;


            return id;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] stock = new string[3];
            stock[0] = txtProductID.Text;
            stock[1] = warehouseID(cmbWarehouse.SelectedItem.ToString()).ToString();
            stock[2] = txtQuantity.Text;



        }
    }
}
