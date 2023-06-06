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

        private void panelReplenishInventory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
