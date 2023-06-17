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
namespace Inventory_Management_System.Dashboard.frmPanelContainers
{
    public partial class frmOrder : Form
    {
        public static double getdpi;
        public static double total = 0;
        public static bool scan = false;
        string lastID = "";
        public frmOrder()
        {
            InitializeComponent();
            
        }
        //formcontrol
        private void frmOrder_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmOrder_Key);
            getdpi = devmode.GetWindowsScaling();
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
            total = 0;
            txtQuery.Clear();
            txtCashTendered.Clear();
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
            fillContainer(panelReplenishInventory);
            loadHistoryandProducts();
        }

        private void btnReturnExchange_Click(object sender, EventArgs e)
        {

        }

        private void fillContainer(Panel panel)
        {
            panelContainer.Controls.Clear();
            panel.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(panel);
            panel.Show();
        }



        //formcontrol

        //placeorder
       
        public static void ProductInquiry(DataGridView dataGridView1, string query)
        {
            bool found = false;
            int row = dataGridView1.RowCount;
            string[] itemfetched = commands.itemEncode(query);

            //commands.itemEncode(query);
            if (itemfetched != Array.Empty<string>())
            {
                total += Convert.ToDouble(itemfetched[2]);
                if (dataGridView1.Rows.Count > 0)
                {
                    foreach (DataGridViewRow rows in dataGridView1.Rows)
                    {
                        if (rows.Cells[dataGridView1.Columns["colID"].Index].Value.ToString() == txtQuery.Text)
                        {
                            found = true;
                            rows.Cells[dataGridView1.Columns["colQuantity"].Index].Value = Convert.ToInt32(rows.Cells[dataGridView1.Columns["colQuantity"].Index].Value) + 1;
                        }
                    }
                    if (!found)
                    {
                        row++;
                        dataGridView1.Rows.Add(row, itemfetched[0], itemfetched[1], itemfetched[2], 1, string.Format("0", "#,##0.00"));
                    }
                }
                else
                {
                    row++;
                    dataGridView1.Rows.Add(row, itemfetched[0], itemfetched[1], itemfetched[2], 1, string.Format("0", "#,##0.00"));
                }

                foreach (DataGridViewRow rows in dataGridView1.Rows)
                {
                    rows.Cells[dataGridView1.Columns["colTotalPrice"].Index].Value = (Convert.ToDouble(rows.Cells[dataGridView1.Columns["colUnitPrice"].Index].Value) * Convert.ToDouble(rows.Cells[dataGridView1.Columns["colQuantity"].Index].Value)).ToString("#,##0.00");
                }
                lblSaleTotal.Text = total.ToString("#,##0.00");
                txtQuery.Clear();
            }
            else
            {
                txtQuery.Clear();
                MessageBox.Show("Item not Found!", "404", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void itemScan(string query)
        {
            bool found = false;
            int row = dataGridView1.RowCount;
            string[] itemfetched = commands.itemEncode(query);
            
            //commands.itemEncode(query);
            if (itemfetched != Array.Empty<string>()) {
                total += Convert.ToDouble(itemfetched[2]);
                if (dataGridView1.Rows.Count > 0)
                {
                    foreach (DataGridViewRow rows in dataGridView1.Rows)
                    {
                        if (rows.Cells[dataGridView1.Columns["colID"].Index].Value.ToString() == txtQuery.Text)
                        {
                            found = true;
                            rows.Cells[dataGridView1.Columns["colQuantity"].Index].Value = Convert.ToInt32(rows.Cells[dataGridView1.Columns["colQuantity"].Index].Value) + 1;
                        }
                    }
                    if (!found)
                    {
                        row++;
                        dataGridView1.Rows.Add(row, itemfetched[0], itemfetched[1], itemfetched[2], 1, string.Format("0", "#,##0.00"));
                    }
                }
                else
                {
                    row++;
                    dataGridView1.Rows.Add(row, itemfetched[0], itemfetched[1], itemfetched[2], 1, string.Format("0", "#,##0.00"));
                }

                foreach (DataGridViewRow rows in dataGridView1.Rows)
                {
                    rows.Cells[dataGridView1.Columns["colTotalPrice"].Index].Value = (Convert.ToDouble(rows.Cells[dataGridView1.Columns["colUnitPrice"].Index].Value) * Convert.ToDouble(rows.Cells[dataGridView1.Columns["colQuantity"].Index].Value)).ToString("#,##0.00");
                }
                lblSaleTotal.Text = total.ToString("#,##0.00");
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
            }
        }

        private void btnPOSControls(object sender, EventArgs e)
        {
            POSControls(((Button)sender).Tag.ToString());
        }
        private void POSControls(string tag)
        {
            //MessageBox.Show(tag);

            switch (tag)
            {
                case "NewTransaction":
                    clearPlaceOrderPanel();
                    break;
                case "ProductInquiry":
                    frmProductInquiry frmNew = new frmProductInquiry();
                    frmNew.Show();
                    break;
                case "Settle":
                    panelCash.Visible = true;
                    txtCashTendered.Focus();
                    break;
                case "AddDiscount":

                    break;
                case "VoidItem":

                    break;

            }
        }
        //placeorder

        //replenishbutton
        private void movementStock(string[] stock)
        {
            try
            {
                int validator = commands.stockWarehouseValidator(stock);
                if (validator == 0) //new
                {
                    commands.insertStocktoWarehouse(stock);
                }
                else//existing record
                {
                    commands.updateStocktoWarehouse(stock);
                }
                commands.insertMovementStock(stock);
                MessageBox.Show("Goods received!", "Done!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch(SqlException exsql)
            {
                MessageBox.Show("Database Error\n\n" + exsql.Message);
                
            }catch(Exception ex)
            {
                MessageBox.Show("Error\n\n" + ex.Message);
            }
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int outbound;
            if (string.IsNullOrWhiteSpace(txtQuantity.Text) || !int.TryParse(txtQuantity.Text, out outbound))
            {
                MessageBox.Show("Invalid Quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
            }else if(cmbWarehouse.Text == string.Empty)
            {
                MessageBox.Show("Please Select Warehouse!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (!scan)
            {
                MessageBox.Show("Indicate Product!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductID.Focus();
            }
            else
            {
                int id = commands.selectWarehouse(cmbWarehouse.Text);

                string[] stock = new string[4];
                stock[0] = txtProductID.Text;//productid
                stock[1] = id.ToString(); //warehouseid
                stock[2] = txtQuantity.Text;
                stock[3] = "Inbound";
                movementStock(stock);


                loadHistoryandProducts();
            }
            
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            loadHistoryandProducts();
        }
        private void replenishFetch(string id)
        {
            if(txtProductID.Text != string.Empty)
            {
                if (!scan)
                {
                    string[] item = commands.itemEncode(txtProductID.Text);
                    if (item.Length > 0)
                    {
                        txtProductName.Text = item[1];
                    }
                    txtProductID.ReadOnly = true;
                    scan = true;
                }
            }
            else
            {
                MessageBox.Show("Enter Product ID!" ,"Invalid Field", MessageBoxButtons.OK,MessageBoxIcon.Error);

            }



        }
        private void btnEnterReplenish_Click(object sender, EventArgs e)
        {
            replenishFetch(txtProductID.Text);
        }

        


        //replenishbutton

        // replenishloaddata
        private void resetTextbox()
        {
            txtProductID.Clear();
            txtProductName.Clear();
            txtQuantity.Clear();

        }
        private void loadHistoryandProducts()
        {
            scan = false;
            txtProductID.ReadOnly = false;
            txtProductID.Focus();
            resetTextbox();
            //datagridview2 = history
            //datagridview3 = product

            //product
            dataGridView3.Rows.Clear();
            DataTable dt =  commands.loadInventory();
            foreach (DataRow row in dt.Rows)
            {
                dataGridView3.Rows.Add(row[0], row[2], row[4]);
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
            DataTable history = commands.loadMovementStock();
            foreach(DataRow row in history.Rows)
            {
                dataGridView2.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
            }
            
            //history

        }

        private void frmOrder_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtQuery_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                itemScan(txtQuery.Text);
            }
        }

        private void txtProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.Enter)
            {
                lastID = txtProductID.Text;
                replenishFetch(txtProductID.Text);
            }
        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {
            if(txtProductID.Text == "")
            {
                resetTextbox();
            }
        }

        private void newSale()
        {
            string customer = "0";
            try
            {
                //OrderTable
                string[] Sale = new string[2];
                Sale[0] = customer;
                Sale[1] = total.ToString("#,##0.00");

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
                double change = cash - total;
                double subtotal = (total/112) * 100;
                double vat = total - subtotal;

                lblSubTotal.Text = subtotal.ToString("#,##0.00");
                lblVAT.Text = vat.ToString("#,##0.00");
                lblTotal.Text = total.ToString("#,##0.00"); 
                lblCash.Text = cash.ToString("#,##0.00");
                lblChange.Text = change.ToString("#,##0.00");
                panelCash.Visible = false;
                newSale();
                txtQuery.Focus();
            }
            else if(e.KeyChar == (char)Keys.Escape)
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
            /*
            if (txtCashTendered.Text == "" || txtCashTendered.Text == "0") return;
            decimal number;
            number = decimal.Parse(txtCashTendered.Text, System.Globalization.NumberStyles.Currency);
            txtCashTendered.Text = number.ToString("#,#");
            txtCashTendered.SelectionStart = txtCashTendered.Text.Length;
            */
        }

        private void txtQuery_TextChanged(object sender, EventArgs e)
        {
            if(txtQuery.Text == "")
            {
                Focus();
            }
        }


        // replenishloaddata


    }
}
