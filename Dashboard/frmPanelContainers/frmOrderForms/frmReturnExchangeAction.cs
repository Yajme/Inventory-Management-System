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
    public partial class frmReturnExchangeAction : Form
    {
        public static frmReturnExchangeAction instance;
        public string[] orderID;
        public string action;
        public frmReturnExchangeAction()
        {
            InitializeComponent();
            instance = this;
        }

        private void frmReturnExchangeAction_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < orderID.Length; i++)
            {
                sb.Append(orderID[i] + "\n");
            }

            //MessageBox.Show(sb.ToString() + "\n" + action);
        }
    }
}
