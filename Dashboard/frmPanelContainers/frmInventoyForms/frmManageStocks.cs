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
    public partial class frmManageStocks : Form
    {
        int quantity = 0;
        int max = 0;
        private const int CB_SETCUEBANNER = 0x1703;

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);
        public frmManageStocks()
        {
            InitializeComponent();

            SendMessage(this.cmbWarehouse.Handle, CB_SETCUEBANNER, 0, "Please select an item...");
            SendMessage(this.cmbViewWarehouse.Handle, CB_SETCUEBANNER, 0, "Please select an item...");
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
            ChangePanel(panelAdjustStock);
            loadWarehouse();
            txtQuantity.Text = "0";
            loadWarehouseStocks();
        }

        private void loadWarehouse()
        {
            cmbWarehouse.Items.Clear();
            commands.loadWarehouses();
            while (db.dr.Read())
            {
                cmbWarehouse.Items.Add(db.dr[1]);
                cmbViewWarehouse.Items.Add(db.dr[1]);
            }
            db.dr.Close();
            db.con.Close();
        }
       
        private bool maxlowquuantity(int number,string operation)
        {
            if(number <= max && operation == "+")//max
            {
                return true;
            }
            if(number >= quantity && operation == "-")
            {
                return true;
            }
            return false;
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtQuantity.Text) - 1;
            if (maxlowquuantity(number, "-"))
            {
                txtQuantity.Text = number.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtQuantity.Text) + 1;
            if (maxlowquuantity(number,"+"))
            {
                txtQuantity.Text = number.ToString();
            }
            else
            {
                MessageBox.Show("Quantity Exceed to Warehouse Stock");

            }
        }
        /*
         
        quantity = 5 -> 6
                 stock   new stock
                -6 instead of -1
                2 -> 5
               -5 instead of -3
          
        
         */
        private void selectProduct(string productid)
        {

            string[] itemfetched = commands.itemEncode(productid);
            string[] stock = new string[2];
            stock[0] = productid;
            stock[1] = commands.selectWarehouse(cmbWarehouse.Text).ToString();
            int query = commands.stockWarehouseValidator(stock);
            if (itemfetched != Array.Empty<string>() && query > 0)
            {
                txtProductName.Text = itemfetched[1];
                quantity = int.Parse(itemfetched[3]);
                txtQuantity.Text = quantity.ToString();
                max = query + quantity;
                //MessageBox.Show(max.ToString() + "\n\n" + stock[1]);
            }
            else
            {
                MessageBox.Show("Item Not Found\n\n Please check if warehouse has Item", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtProductID.Clear();
            }

        }

        private void txtProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                selectProduct(txtProductID.Text);
            }
        }
      
        private void MovementStock(string[] stock)
        {
            try
            {
                stock[2] = "-" + stock[2];
                commands.updateStocktoWarehouse(stock);
                commands.insertMovementStock(stock);
                MessageBox.Show("Stock Adjusted!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFields();
            }
            catch (SqlException exsql)
            {
                MessageBox.Show("Error in Database\n\n" + exsql.Message);
                commands.dbclose();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            int num;
            int mvtquantity = int.Parse(txtQuantity.Text);
            if (!int.TryParse(txtQuantity.Text, out num)) {
                MessageBox.Show("That is not a number!");
                txtQuantity.Text = quantity.ToString();
            }
            else
            {
                if (mvtquantity > max ||  mvtquantity < quantity)
                {
                    MessageBox.Show("Invalid Quantity");
                }
                else
                {
                    mvtquantity -= quantity;
                }
                
            }
            
            string[] stock = new string[4];
            stock[0] = txtProductID.Text;
            stock[1] = commands.selectWarehouse(cmbWarehouse.SelectedItem.ToString()).ToString();
            stock[2] = mvtquantity.ToString();
            stock[3] = "Outbound";
            MovementStock(stock);

        }
        private void loadWarehouseStocks()
        {
            dataGridView1.Rows.Clear();
            commands.viewWarehouseStock();
            while (db.dr.Read())
            {
                dataGridView1.Rows.Add(db.dr[0], db.dr[1], db.dr[3]);
            }
            db.dr.Close();
            db.con.Close();
        }

        private void btnChangePanel(object sender, EventArgs e)
        {
            string changepanel = ((Button)sender).Tag.ToString();
            switch (changepanel)
            {
                case "btnAdjustStock":
                    ChangePanel(panelAdjustStock);
                    break;
                case "btnViewWarehouse":
                    ChangePanel(panelViewWarehouseStock);
                    break;
            }
        }
        private void ChangePanel(Panel panel)
        {
            panelContainer.Controls.Clear();
            panel.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(panel);
            panel.Show();
        }

        private void frmManageStocks_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtProductID.Text != String.Empty)
            {
                DialogResult result = MessageBox.Show("are you sure to discard changes?","Discard changes?",MessageBoxButtons.YesNo,MessageBoxIcon.Question); 
                if(result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void clearFields()
        {
            txtProductID.Clear();
            txtProductName.Clear();
            txtQuantity.Text = "0";
            cmbWarehouse.Text = "";
        }
        private void btnDiscard_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text != String.Empty)
            {
                DialogResult result = MessageBox.Show("are you sure to discard changes?", "Discard changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    clearFields();
                }
            }
        }
    }
}
