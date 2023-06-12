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
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            clearPlaceOrderPanel();
            fillContainer(panelPlaceOrder);
            txtQuery.Focus();

        }
        private void clearPlaceOrderPanel()
        {
            dataGridView1.Rows.Clear();
            total = 0;
            txtQuery.Clear();
            lblSaleTotal.Text = "0.00";

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

        /// placeorder
        
        private void itemScan(string query)
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
                    rows.Cells[dataGridView1.Columns["colTotalPrice"].Index].Value = Convert.ToDouble(rows.Cells[dataGridView1.Columns["colUnitPrice"].Index].Value) * Convert.ToDouble(rows.Cells[dataGridView1.Columns["colQuantity"].Index].Value);
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
            MessageBox.Show(tag);
        }
        //placeorder

        //replenishbutton
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = commands.selectWarehouse(cmbWarehouse.SelectedItem.ToString());
            

            string[] stock = new string[4];
            stock[0] = txtProductID.Text;//productid
            stock[1] = id.ToString(); //warehouseid
            stock[2] = txtQuantity.Text;
            stock[3] = "Inbound";

            /*
            int query2 = commands.stockWarehouseValidator(stock);
            int query3;
            if (query2 < 1)//new
            {
                query3 = commands.insertStocktoWarehouse(stock);
            }
            else//update
            {
                query3 = commands.updateStocktoWarehouse(stock);
            }
            int query1 = commands.insertMovementStock(stock);
            if (query1 == 1 && query3 == 1)
            {
                MessageBox.Show("Record Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
            loadHistoryandProducts();
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            loadHistoryandProducts();
        }
        private void replenishFetch(string id)
        {
            if(!scan)
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
                dataGridView3.Rows.Add(row[0], row[1], row[4]);
            }
          
            //product


            //history
            //cmb
            cmbWarehouse.Items.Clear();
            commands.loadWarehouses();
            while (db.dr.Read())
            {
                cmbWarehouse.Items.Add(db.dr[1]);
            }
            db.dr.Close();
            db.con.Close();
            //cmb
            dataGridView2.Rows.Clear();
            commands.loadMovementStock();
            while (db.dr.Read())
            {
                dataGridView2.Rows.Add(db.dr[0], db.dr[1], db.dr[2], db.dr[3], db.dr[4], db.dr[5]);
            }
            db.dr.Close();
            db.con.Close();
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
            
        }


        // replenishloaddata


    }
}
