using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.Dashboard.frmPanelContainers.frmOrderForms
{
    public partial class frmReturnExchangeAction : Form
    {
        public static frmReturnExchangeAction instance;
        public DataTable orderTable;
        public string orderID;
        public string action;
        Credit Credit = new Credit();
        public frmReturnExchangeAction()
        {
            InitializeComponent();
            instance = this;
        }
        private void loadData()
        {
            dataGridView1.Rows.Clear();
            int[] orderitemID = new int[100];
            int i = 0;
            foreach(DataRow row in orderTable.Rows)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3]);
                orderitemID[i] = Convert.ToInt32(row[0]);
                i++;
                Credit.Amount += Convert.ToDouble(row[3]);
            }

            txtAction.Text = action;
            txtOrderID.Text = orderID;
            btnAction.Text = "["+action+"]";

            lblRefund.Text = Credit.Amount.ToString("#,##0.00");


            Credit.OrderID = commands.selectOrderID(orderitemID);
        }
        private void frmReturnExchangeAction_Load(object sender, EventArgs e)
        { 
            loadData();
        }

        private void txtRemarks_TextChanged(object sender, EventArgs e)
        {

            int characterremaining = 255 - txtRemarks.TextLength;
            if (characterremaining > -1)
            {
                lblCharacter.Text = characterremaining.ToString();
            }
            else
            {
                txtRemarks.Text = txtRemarks.Text.Substring(0, 255);
                txtRemarks.Select(txtRemarks.Text.Length, 0);
                MessageBox.Show("Maximum Character Length");
                
            }
        }
       
        private void frmReturnExchangeAction_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
        private void actionReturn()
        {
            
                DialogResult result = MessageBox.Show("Refundable amount: " + Credit.Amount.ToString("#,##0.00") + "\n\n" + "Press Ok to continue", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    try
                    {
                    actionRecord();

                    commands.returnItem(Credit.OrderID, Credit.Record);
                    MessageBox.Show("Return Transaction Complete");
                    this.Close();
                    }
                    catch(SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            
            
        }
      
        private void actionExchange()
        {
            double getdpi = devmode.GetWindowsScaling();
            int panelwidth = ((int)(getdpi * 345 / 100));
            //338width
            if (!Credit.Exchange)
            {
                DialogResult result = MessageBox.Show("Please add items according to the amount: " + Credit.Amount.ToString("#,##0.00") + "\n\n" + "Press Ok to continue", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    txtProduct.Focus();
                    panel2.Width = panelwidth;
                    dataGridView1.Hide();
                    Credit.Exchange = true;
                }
            }
            else 
            {
                
                DialogResult result = MessageBox.Show("Proceed to Exchange? \n\n\n"  + "Press Yes to continue", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(result == DialogResult.Yes)
                {
                    try
                    {
                        actionRecord();
                        DataTable dt = new DataTable();
                        dt.Columns.Add("ProductID");
                        dt.Columns.Add("Quantity");
                        dt.Columns.Add("Total");

                        DataRow dr = null;
                        int i = 0;
                        foreach (DataGridViewRow rows in dataGridView2.Rows)
                        {
                            dr = dt.NewRow();
                            dr["ProductID"] = Credit.ProductID[i];
                            dr["Quantity"] = rows.Cells["colExQty"].Value;
                            dr["Total"] = rows.Cells["colExPrice"].Value;
                            i++;
                        }
                        //product,productExchanged,record

                        commands.exchangeItem(Credit.OrderID, dt, Credit.Record);

                        Credit.Exchange = false;
                        MessageBox.Show("Exchange Transaction Complete");
                        this.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        

        }

        private void actionRecord()
        {
            Credit.Record = new string[3];
            Credit.Record[0] = txtOrderID.Text;
            Credit.Record[1] = action;
            Credit.Record[2] = txtRemarks.Text;
        }
        private void itemEncode()
        {
            string[] itemfetched = commands.itemEncode(txtProduct.Text);
            bool found = false;
            int row = dataGridView1.RowCount;
            if(Credit.Amount >= 0)
            {
                if (itemfetched != Array.Empty<string>())
                {
                    Credit.StoreCredit += Convert.ToDouble(itemfetched[2]);
                    Credit.ProductID[row] = itemfetched[0];
                    if (dataGridView2.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow rows in dataGridView2.Rows)
                        {
                            found = true;
                            rows.Cells[dataGridView2.Columns["colExQty"].Index].Value = Convert.ToInt32(rows.Cells[dataGridView2.Columns["colExQty"].Index].Value) + 1;
                        }

                        if (!found)
                        {
                            dataGridView2.Rows.Add(row, itemfetched[1], 1, itemfetched[2]);
                        }
                    }
                    else
                    {
                        dataGridView2.Rows.Add(row, itemfetched[1], 1, itemfetched[2]);
                    }

                    foreach (DataGridViewRow rows in dataGridView2.Rows)
                    {
                        rows.Cells[dataGridView2.Columns["colExPrice"].Index].Value = Convert.ToDouble(rows.Cells[dataGridView2.Columns["colExprice"].Index].Value) * Convert.ToDouble(rows.Cells[dataGridView2.Columns["colExQty"].Index].Value);
                    }
                    double total = Credit.Amount - Credit.StoreCredit;

                    lblRefund.Text = total.ToString("#,##0.00");
                }
                else
                {
                    MessageBox.Show("Item not Found!", "404", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txtProduct.Clear();
            }
            else
            {
                MessageBox.Show("Transaction Exceeded Store Credit!", "Amount Exceed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }
        private void btnAction_Click(object sender, EventArgs e)
        {
            
            
                if (action == "Return")
                {
                    actionReturn();
                }
                else if (action == "Exchange")
                {
                    actionExchange();
                }
            
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            itemEncode();
        }

        private void txtProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                itemEncode();
            }
        }
    }

    class Credit
    {
        private double amount;
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private bool exchange = false;

        public bool Exchange
        {
            get { return exchange; }
            set { exchange = value; }
        }
        public string[] ProductID { get; set; }
        private DataTable orderID;
        public DataTable OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }
        public double StoreCredit {get;set;}
        public string[] Record { get;set;}

    }
}
