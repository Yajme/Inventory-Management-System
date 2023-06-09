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
using Inventory_Management_System.Dashboard.frmPanelContainers.frmOrderForms;
using System.Windows.Media.Animation;
using System.Diagnostics;

namespace Inventory_Management_System.Dashboard.frmPanelContainers
{
    public partial class frmOrder : Form
    { 
        public static frmOrder instance;
        public TextBox txtFormTextbox;
        public int quantity; 
        public bool setQty = false; 

        Order Order = new Order();
        
        public frmOrder()
        {
            InitializeComponent();
            instance = this;
            txtFormTextbox = txtQuery;
        }

        /* <--FormControlsStart -->  */
        private void frmOrder_Load(object sender, EventArgs e)
        {
            clearPlaceOrderPanel();
            fillContainer(panelPlaceOrder);
        }
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            clearPlaceOrderPanel();
            fillContainer(panelPlaceOrder);
        }
        private void clearPlaceOrderPanel()
        {
            dataGridView1.Rows.Clear();
            Order.total = 0;
            txtQuery.Clear();
            txtCashTendered.Clear();

            lblSetQuantity.Text = "";
            lblProductID.Text = "";
            lblProductName.Text = "";
            lblPrice.Text = "";
            lblCash.Text = "0.00";
            lblChange.Text = "0.00";
            lblSubTotal.Text  = "0.00";
            lblVAT.Text = "0.00";
            lblTotal.Text = "0.00";
            lblSaleTotal.Text = "0.00";
            txtQuery.Focus();
        }
        private void btnReplenishInventory_Click(object sender, EventArgs e)
        {
            loadHistoryandProducts();
            fillContainer(panelReplenishInventory);
            
        }
        private void btnReturnExchange_Click(object sender, EventArgs e)
        {
            loadEligibleExchangeReturn();
            fillContainer(panelReturnExchange);

            
        }
        private void fillContainer(Panel panel)
        {
            panelContainer.Controls.Clear();
            panel.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(panel);
            panel.Show();
        }
        /* <--FormControlsEnd-->  */

        /* <--PlaceOrderStart -->  */
        public void SimulateEnterKeyPress()
        {
            txtQuery_KeyPress(this, new KeyPressEventArgs((char)Keys.Enter));
        }
        public void SetQuantity(int Quantity)
        {
            Order.SetQuantity = true;
            Order.Quantity = Quantity;
        }
        public void itemScan(string query)
        {
            bool found = false;
            int row = dataGridView1.RowCount;
            int itemQuantity = 1;
            string[] itemfetched = commands.itemEncode(query);
            
            

            if(Order.SetQuantity)
            {
                itemQuantity = Order.Quantity;
                Order.SetQuantity = false;
            }
           
            
            if (itemfetched != Array.Empty<string>()) {
                Order.total += Convert.ToDouble(itemfetched[2]) * itemQuantity; //SaleAmount
                lblSetQuantity.Text = "x" + itemQuantity.ToString();
                if (dataGridView1.Rows.Count > 0)
                {
                    foreach (DataGridViewRow rows in dataGridView1.Rows)
                    {
                        if (rows.Cells[dataGridView1.Columns["colID"].Index].Value.ToString() == txtQuery.Text)
                        {
                            found = true;
                            rows.Cells[dataGridView1.Columns["colQuantity"].Index].Value = Convert.ToInt32(rows.Cells[dataGridView1.Columns["colQuantity"].Index].Value) + itemQuantity;
                        }
                    }
                    if (!found)
                    {
                        row++;
                        dataGridView1.Rows.Add(row, itemfetched[0], itemfetched[1], itemfetched[2], itemQuantity, string.Format("0", "#,##0.00"));

                        lblProductID.Text = itemfetched[0];
                        lblProductName.Text = itemfetched[1];
                        lblPrice.Text = itemfetched[2];
                    }
                }
                else
                {
                    row++;
                    dataGridView1.Rows.Add(row, itemfetched[0], itemfetched[1], itemfetched[2], itemQuantity, string.Format("0", "#,##0.00"));
                    lblProductID.Text = itemfetched[0];
                    lblProductName.Text = itemfetched[1];
                    lblPrice.Text = itemfetched[2];
                }

                foreach (DataGridViewRow rows in dataGridView1.Rows)
                {
                    rows.Cells[dataGridView1.Columns["colTotalPrice"].Index].Value = (Convert.ToDouble(rows.Cells[dataGridView1.Columns["colUnitPrice"].Index].Value) * Convert.ToDouble(rows.Cells[dataGridView1.Columns["colQuantity"].Index].Value)).ToString("#,##0.00");
                }
                lblSaleTotal.Text = Order.total.ToString("#,##0.00");
                txtQuery.Clear();
            }
            else
            {
                txtQuery.Clear();
                MessageBox.Show("Item not Found!", "404", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            itemScan(txtQuery.Text);
        }
        private void frmOrder_Key(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "F1":
                    POSControls("NewTransaction");
                    break;
                case "F2":
                    POSControls("ProductInquiry");
                    break;
                case "F3":
                    POSControls("Settle");
                    break;
                case "F4":
                    POSControls("AddDiscount");
                    break;
                case "F5":
                    POSControls("VoidItem");
                    break;
                case "F6":
                    POSControls("SetQty");
                    break;
            }
        }
        private void btnPOSControls(object sender, EventArgs e)
        {
            POSControls(((Button)sender).Tag.ToString());
        }
        private void POSControls(string tag)
        {
            switch (tag)
            {
                case "NewTransaction":
                    if(dataGridView1.RowCount > 0)
                    {
                        DialogResult result = MessageBox.Show("Are you sure to reset transaction?", "Reset?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(result == DialogResult.Yes)
                        {
                            clearPlaceOrderPanel();
                        }
                    }
                    break;
                case "ProductInquiry":
                    frmProductInquiry frmNew = new frmProductInquiry();
                    frmNew.ShowDialog();
                    break;
                case "Settle":
                    panelCash.Visible = true;
                    txtCashTendered.Focus();
                    break;
                case "AddDiscount":

                    break;
                case "VoidItem":
                    if(dataGridView1.RowCount > 0)
                    {
                        frmVoidItem frmVoidItem = new frmVoidItem();
                        frmVoidItem.ShowDialog();
                        txtQuery.Focus();
                    }
                    break;
                case "SetQty":
                    frmSetQuantity frmNewQ = new frmSetQuantity();
                    frmNewQ.ShowDialog();
                    txtQuery.Focus();
                    break;
            }
        }
        private void txtQuery_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                itemScan(txtQuery.Text);
            }
        }
        public void itemVoid()
        {
            Order.total -= Convert.ToDouble(dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[5].Value);
            lblSaleTotal.Text = Order.total.ToString("#,##.00");
            dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
        }
        private void newSale()
        {
            string customer = "0";
            try
            {
                //OrderTable
                string[] Sale = new string[2];
                Sale[0] = customer;
                Sale[1] = Order.total.ToString("#,##0.00");

                //OrderItemTable
                DataTable dt = new DataTable();
                dt.Columns.Add("ProductID");
                dt.Columns.Add("Quantity");
                dt.Columns.Add("Total");

                DataRow dr = null;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dr = dt.NewRow();
                    dr["ProductID"] = row.Cells["colID"].Value;
                    dr["Quantity"] = row.Cells["colQuantity"].Value;
                    dr["Total"] = row.Cells["colTotalPrice"].Value;
                    dt.Rows.Add(dr);
                }

                commands.insertOrder(Sale, dt);
                MessageBox.Show("Thank you Shop Again!");
                clearPlaceOrderPanel();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database Error: " + ex.Message + " \n\n\n" + ex.Procedure);
            }
            catch (Exception ex)
            {
                MessageBox.Show("System Error: " + ex.Message + " \n\n\n" + ex.StackTrace.ToString());
            }

        }
        private void txtCashTendered_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                double cash = double.Parse(txtCashTendered.Text);
                double change = cash - Order.total;
                double subtotal = (Order.total / 112) * 100;
                double vat = Order.total - subtotal;

                lblSubTotal.Text = subtotal.ToString("#,##0.00");
                lblVAT.Text = vat.ToString("#,##0.00");
                lblTotal.Text = Order.total.ToString("#,##0.00");
                lblCash.Text = cash.ToString("#,##0.00");
                lblChange.Text = change.ToString("#,##0.00");
                panelCash.Visible = false;
                newSale();
                txtQuery.Focus();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                panelCash.Visible = false;
                txtQuery.Focus();
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }
        private void txtCashTendered_TextChanged(object sender, EventArgs e)
        {
            txtCashTendered.SelectionStart = txtCashTendered.Text.Length;
        }
        private void txtQuery_TextChanged(object sender, EventArgs e)
        {
            if (txtQuery.Text == "")
            {
                txtQuery.Focus();
            }
        }
        /* <-- Place Order End -->  */





        /* <--Replenish Inventory Start--> */

       
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cmbWarehouse.Text != "")
            {
                WarehouseStock warehouseStock = new WarehouseStock();

                warehouseStock.RecievingProducts = new DataTable();
                warehouseStock.RecievingProducts.Columns.Add("PurchaseID");
                DataRow dr = null;
                foreach (DataGridViewRow row in dataGridView6.Rows)
                {
                    if (row.Cells[4].Value != null)
                    {
                        dr = warehouseStock.RecievingProducts.NewRow();
                        dr["PurchaseID"] = row.Cells[0].Value;

                        warehouseStock.RecievingProducts.Rows.Add(dr);
                    }
                }

                StockMovement.CollectData(warehouseStock.RecievingProducts,warehouseStock.WarehouseID(cmbWarehouse.Text));

                MessageBox.Show("Goods Received!","Success!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                loadHistoryandProducts();
            }
            else
            {
                MessageBox.Show("Select Recieving Warehouse First!","Invalid Field",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }
        private void btnDiscard_Click(object sender, EventArgs e)
        {
            loadHistoryandProducts();
        }
        
        private void btnEnterReplenish_Click(object sender, EventArgs e)
        {
            //replenishFetch(txtProductID.Text);
        }
        private void resetTextbox()
        {
            //txtProductID.Clear();
            //txtProductName.Clear();
            //txtQuantity.Clear();

        }
        private void loadHistoryandProducts()
        {
            Order.Scan= false;
            //txtProductID.ReadOnly = false;
            //txtProductID.Focus();
            resetTextbox();
            //datagridview2 = history
            //datagridview3 = product

            //product
            dataGridView3.Rows.Clear();
            DataTable dt =  commands.loadInventory();
            foreach (DataRow row in dt.Rows)
            {
                dataGridView3.Rows.Add(row[0], row[2], row[4], row[7]);
            }
          
            //product


            //history
            //cmb
            cmbWarehouse.Items.Clear();
            
            DataTable warehouse = commands.loadWarehouses();
            foreach(DataRow row in warehouse.Rows)
            {
                cmbWarehouse.Items.Add(row[1]);
            }
            //cmb

            dataGridView2.Rows.Clear();

            DataTable warehousestock = commands.viewWarehouseStock();
            foreach (DataRow row in warehousestock.Rows)
            {
                dataGridView2.Rows.Add(row[0], row[2], row[1], row[3]);
            }
            //history


            dataGridView6.Rows.Clear();
            DataTable PurchaseOrder = commands.loadPurchaseOrder();
            foreach(DataRow row in PurchaseOrder.Rows)
            {
                dataGridView6.Rows.Add(row[0], row[2], row[1], "[View]");
            }
            dataGridView6.Columns[4].ReadOnly = false;
        }
        
        
        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private void btnMove_Click(object sender, EventArgs e)
        {
            if (panelDataGridView.Height > 0)
            {
                panelDataGridView.Height = 0;

                btnMove.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            }
            else if (panelDataGridView.Height < 191)
            {
                btnMove.IconChar = FontAwesome.Sharp.IconChar.AngleUp;
                panelDataGridView.Height = (int)(191 * Order.getDPI / 100);
            }
        }
        /* <--Replenish Inventory End--> */




        /* <--Exchange and Return Start -->  */

        //datagridview5 -> Eligible
        //DataGridView4 -> Actions or list of items

        private void loadEligibleExchangeReturn()
        {
            DataTable dt = commands.loadEligibleExchangeReturn();
            dataGridView5.Rows.Clear();
            foreach(DataRow row in dt.Rows)
            {
                dataGridView5.Rows.Add(row[0], row[1], row[2], "[View]");
            }
        }
        private void loadEligibleItems(int orderID)
        {
           DataTable dt = commands.loadEligbleItems(orderID);
            dataGridView4.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dataGridView4.Rows.Add(row[0], row[1], row[2], row[3]);
            }
            dataGridView4.Columns[4].ReadOnly = false;
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView5.Columns[e.ColumnIndex].Name;
            if(colName == "colView")
            {
                Order.orderID = (int)dataGridView5.Rows[e.RowIndex].Cells[0].Value;
                loadEligibleItems(Order.orderID);
                
            }
        }

        private void btnRESave_Click(object sender, EventArgs e)
        {
            if(dataGridView4.RowCount > 0)
            {
                if(cmbAction.Text != "")
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("orderItemID");
                    dt.Columns.Add("Description");
                    dt.Columns.Add("Quantity");
                    dt.Columns.Add("Total");
                    DataRow dr = null;
                    foreach (DataGridViewRow row in dataGridView4.Rows)
                    {
                        if (row.Cells[4].Value != null)
                        {
                            dr = dt.NewRow();
                            dr["orderItemID"] = row.Cells[0].Value;
                            dr["Description"] = row.Cells[1].Value;
                            dr["Quantity"] = row.Cells[2].Value;
                            dr["Total"] = row.Cells[3].Value;

                            dt.Rows.Add(dr);
                        }
                    }
                    frmReturnExchangeAction frmNew = new frmReturnExchangeAction();
                    frmReturnExchangeAction.instance.orderTable = dt;
                    frmReturnExchangeAction.instance.action = cmbAction.Text;
                    frmReturnExchangeAction.instance.orderID = Order.orderID.ToString();
                    frmNew.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Indicate Action!", "Invalid Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("No data!", "Invalid Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnREDicard_Click(object sender, EventArgs e)
        {

        }

        private void btnNewPurchase_Click(object sender, EventArgs e)
        {
            frmPurchaseOrder frmPurchase = new frmPurchaseOrder();
            frmPurchase.ShowDialog();
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView6.Columns[e.ColumnIndex].Name;

            if(colName == "colDetail")
            {
                int transactID = (int)dataGridView6.Rows[e.RowIndex].Cells[0].Value;
                string SupplierName = dataGridView6.Rows[e.RowIndex].Cells[2].Value.ToString();
                purchaseOrder.purchaseInvoice(transactID, SupplierName);
            }
        }

      

        /* <--Exchange and Return End -->  */
    }

    public class purchaseOrder
    {
        public static void purchaseInvoice(int TransactionID,string SupplierName)
        {
            DataTable dt = commands.selectPurchaseInvoice(TransactionID);
            frmPurchaseInvoice frmNew = new frmPurchaseInvoice();
            frmPurchaseInvoice.Instance.SupplierName.Text = SupplierName;
            frmPurchaseInvoice.Instance.Invoice = dt;

            frmNew.ShowDialog();

        }

        
    }
    public class StockMovement
    {
        public static void CollectData(DataTable purchaseID,int warehouseID)
        {
            //[0] -> ProductID
            //[1] -> WarehouseID
            //[2] -> Quantity
            //[3] -> MovementType


            Products = commands.selectProductInvoice(purchaseID);

            foreach (DataRow row in Products.Rows)
            {
                string[] stock = new string[4];
                stock[0] = row[0].ToString(); // productID
                stock[1] = warehouseID.ToString(); //warehouseID
                stock[2] = row[1].ToString(); // Quantity
                stock[3] = "Inbound";

                MovementStock(stock);
            }
            try
            {
                commands.updatePurchaseOrder(purchaseID);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }
        public static DataTable Products = new DataTable();
        public static void MovementStock(string[] stock)
        {
            try
            {
                int validator = commands.stockWarehouseValidator(stock);
                if (validator == -1) //new
                {
                    commands.insertStocktoWarehouse(stock);
                }
                else//existing record
                {
                    commands.updateStocktoWarehouse(stock);
                }
                commands.insertMovementStock(stock);

                
            }
            catch (SqlException exsql)
            {
                MessageBox.Show("Database Error\n\n" + exsql.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n\n" + ex.Message);
            }

        }
    }
    public class WarehouseStock
    {
        private int warehouseID;
        public int WarehouseID(string warehouseName)
        {
            return warehouseID = commands.selectWarehouse(warehouseName);
        }
        private DataTable recievingProducts;
        public DataTable RecievingProducts { get { return recievingProducts; } set { recievingProducts = value; } }
       
    }

    class Order
    {
        private bool search = false;
        public bool Search
        {
            get { return search; }
            set { search = value;}
        }
        public int orderID { get; set; }
        public double total { get;set; }
        private bool scan = false;
        public bool Scan {
            get { return scan; }
            set { scan = value; }
        }
        private double getdpi = devmode.GetWindowsScaling();
        public double getDPI { 
            get { return getdpi; } 
            set {getdpi = value;} 
        }

        private bool setQty = false;
        public bool SetQuantity { get { return setQty; } set { setQty = value; } }
        public  int Quantity { get; set; }
    }

    class Inventory
    {




    }
}
