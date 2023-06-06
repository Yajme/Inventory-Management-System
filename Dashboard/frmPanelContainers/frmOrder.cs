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
        public frmOrder()
        {
            InitializeComponent();
        }
        private void frmOrder_Load(object sender, EventArgs e)
        {
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
            lblSaleTotal.Text = "0.00";

        }

        private void btnReplenishInventory_Click(object sender, EventArgs e)
        {

        }

        private void btnReturnExchange_Click(object sender, EventArgs e)
        {

        }

       private void fillContainer(Panel panel)
        {
            panelContainer.Controls.Clear();
            panel.Dock = DockStyle.Fill;
            panel.BringToFront();
            panel.Show();
        }
    }
}
