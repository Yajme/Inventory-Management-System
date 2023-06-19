using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Management_System.Dashboard.frmPanelContainers;
using static Inventory_Management_System.Dashboard.frmPanelContainers.frmOrder;
namespace Inventory_Management_System.Dashboard.frmPanelContainers.frmOrderForms
{
    public partial class frmProductInquiry : Form
    {
        public static frmProductInquiry instance;
        public frmProductInquiry()
        {
            InitializeComponent();
            instance = this;
        }

        private void frmProductInquiry_Load(object sender, EventArgs e)
        {
            loadProduct();
        }
        private void loadProduct()
        {
            DataTable dt = commands.loadInventory();
            dataGridView1.Rows.Clear();


            foreach(DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(row[0], row[2], row[5]);
            }
        }
        private void searchProduct()
        {
            dataGridView1.Rows.Clear();
            DataTable dt = commands.searchInventoryWOC(txtProductID.Text);

            foreach (DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(row[0], row[2], row[5]);
            }
        }
        private void txtProductID_TextChanged(object sender, EventArgs e)
        {
            if(txtProductID.Text == string.Empty || txtProductID.Text == "")
            {
                loadProduct();
            }
        }

        private void txtProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter && txtProductID.Text != string.Empty)
            {
                searchProduct();
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if(colName == "colAdd")
            {
               // MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                frmOrder.instance.txtFormTextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                frmOrder.instance.SimulateEnterKeyPress();
                //itemScan(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }
    }
}
