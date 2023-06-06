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
        public frmOrder()
        {
            InitializeComponent();
        }
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

        private void frmOrder_Key(object sender, KeyEventArgs e)
        {
            
            switch (e.KeyCode.ToString())
            {
                case "F1":
                    clearPlaceOrderPanel();
                    MessageBox.Show("F1 pressed");
                    break;
                case "F2":
                    MessageBox.Show("F2 pressed");
                    break;
                case "F3":
                    MessageBox.Show("F3 pressed");
                    break;
                case "F4":
                    MessageBox.Show("F4 pressed");
                    break;
                case "F5":
                    MessageBox.Show("F5 pressed");
                    break;
            }
        }

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
    }
}
