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
    public partial class frmPurchaseInvoice : Form
    {
        public static frmPurchaseInvoice Instance;
        public DataTable Invoice;
        public Label SupplierName;
        public frmPurchaseInvoice()
        {
            InitializeComponent();
            Instance = this;
            SupplierName = lblSupplier;
        }

        private void frmPurchaseInvoice_Load(object sender, EventArgs e)
        {
            
            InvoiceData.loadInvoice(dataGridView1, Invoice);
        }
    }

    public class InvoiceData
    {
        public static void loadInvoice(DataGridView invoice, DataTable Invoice)
        {
            foreach(DataRow row in Invoice.Rows)
            {
                invoice.Rows.Add(row[0], row[1], row[2]); 
            }
        }
    }
}
