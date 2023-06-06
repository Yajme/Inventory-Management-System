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
using System.Web;

namespace Inventory_Management_System.Dashboard.frmPanelContainers
{
    public partial class frmOrder : Form
    {
        public static double getdpi;
        public static double total = 0;
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
            int row = 0;
            string[] itemfetched = commands.itemEncode(query);
            total += Convert.ToDouble(itemfetched[2]);
            //commands.itemEncode(query);
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
                    dataGridView1.Rows.Add(row, itemfetched[0] ,itemfetched[1], itemfetched[2],1, string.Format("0", "#,##0.00"));
                }
            }
            else
            {
                row++;
                dataGridView1.Rows.Add(row,itemfetched[0], itemfetched[1], itemfetched[2], 1, string.Format("0", "#,##0.00"));
            }

            foreach (DataGridViewRow rows in dataGridView1.Rows)
            {
                rows.Cells[dataGridView1.Columns["colTotalPrice"].Index].Value = Convert.ToDouble(rows.Cells[dataGridView1.Columns["colUnitPrice"].Index].Value) * Convert.ToDouble(rows.Cells[dataGridView1.Columns["colQuantity"].Index].Value);
            }
            lblSaleTotal.Text = string.Format(total.ToString(), "#,##0.00");
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
        private int validateWarehouse(string warehousename)
        {
            int id = 0;


            return id;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = validateWarehouse(cmbWarehouse.SelectedItem.ToString());
            string[] stock = new string[3];
            stock[0] = txtProductID.Text;
            stock[1] = id.ToString();
            stock[2] = txtQuantity.Text;

            int query = commands.insertMovementStock(stock);


        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            loadHistoryandProducts();
        }

        private void btnEnterReplenish_Click(object sender, EventArgs e)
        {
            string[] item = commands.itemEncode(txtProductID.Text);
            if(item.Length > 0)
            {
                txtProductName.Text = item[1];
            }
            
        }

        private void btnScan_Click(object sender, EventArgs e)
        {

        }


        //replenishbutton

        // replenishloaddata
        private void loadHistoryandProducts()
        {
            txtProductID.Clear();
            txtProductName.Clear();
            txtQuantity.Clear();
            
            //datagridview2 = history
            //datagridview3 = product

            //product
            dataGridView3.Rows.Clear();
            commands.loadInventory();
            while (db.dr.Read())
            {
                dataGridView3.Rows.Add(db.dr[0], db.dr[1], db.dr[4]);
            }
           db.dr.Close();
           db.con.Close();
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


        // replenishloaddata


    }
}
