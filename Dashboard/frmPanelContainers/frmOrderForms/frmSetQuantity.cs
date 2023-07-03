using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.Dashboard.frmPanelContainers.frmOrderForms
{
    public partial class frmSetQuantity : Form
    {
        public static frmSetQuantity instance;
        public frmSetQuantity()
        {
            InitializeComponent();
            instance = this;
        }

        private void frmSetQuantity_Load(object sender, EventArgs e)
        {
            txtQuantity.Focus();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                
                frmOrder.instance.quantity = Convert.ToInt32(txtQuantity.Text);
                frmOrder.instance.setQty = true;
                
                this.Close();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
