using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Management_System.Dashboard.frmPanelContainers;
namespace Inventory_Management_System.Dashboard.frmPanelContainers.frmOrderForms
{
    public partial class frmProductInquiry : Form
    {
        public static frmProductInquiry instance;
        bool gridmode = false;
        Button newButton;
        public frmProductInquiry()
        {
            InitializeComponent();
            instance = this;
            this.TopMost = true;
        }

        private void frmProductInquiry_Load(object sender, EventArgs e)
        {
            loadProduct();
            loadItems();
            placePanel(panelDataGridView);
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
                frmOrder.instance.txtFormTextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                frmOrder.instance.SimulateEnterKeyPress();
            }
        }
        private void loadItems()
        {
            DataTable dt = commands.loadInventory();
            flowLayoutPanel1.Controls.Clear();
            int count = 0;
            foreach(DataRow row in dt.Rows)
            {
               newButton = new Button();
                newButton.BackColor = Color.FromArgb(46, 51, 73);
                newButton.ForeColor = Color.White;
                newButton.Size = new Size(200, 123);
                newButton.Text = row[2].ToString();
                newButton.Tag = row[0].ToString();
                newButton.Name = "btnItem" + count.ToString();
                newButton.FlatStyle = FlatStyle.Flat;
                newButton.FlatAppearance.BorderSize = 3;
                newButton.FlatAppearance.BorderColor = Color.White;


                flowLayoutPanel1.Controls.Add(newButton);
                count++;
                newButton.Click += DynamicButton_click;
            }
        }

        public void DynamicButton_click(object sender, EventArgs e)
        {
            frmOrder.instance.txtFormTextbox.Text = ((Button)sender).Tag.ToString();
            frmOrder.instance.SimulateEnterKeyPress();
        }
            private void placePanel(Panel panel)
        {
            panelContainer.Controls.Clear();
            panel.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(panel);
            panel.Show();
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if(gridmode) // switch to datagridmode
            {
                placePanel(panelDataGridView);
                gridmode = false;
            }
            else//else switch to grid
            {
                placePanel(panelGridMode);
                gridmode = true;
            }
        }

     
        private void frmProductInquiry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            
                this.Close();
            }
        }

    }
