using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

            lblRefund.Text = Credit.Amount.ToString();


            Credit.OrderID = commands.selectOrderID(orderitemID);
        }
        private void frmReturnExchangeAction_Load(object sender, EventArgs e)
        {
            //StringBuilder sb = new StringBuilder();
            //for (int i = 0; i < orderID.Length; i++)
            //{
            //    sb.Append(orderID[i] + "\n");
            //}

            //MessageBox.Show(sb.ToString() + "\n" + action);


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

        private void txtRemarks_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }
        private void actionReturn()
        {
            
                DialogResult result = MessageBox.Show("Refundable amount: " + Credit.Amount.ToString() + "\n\n" + "Press Ok to continue", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    try
                    {
                    string[] records = new string[3];
                    records[0] = txtOrderID.Text;
                    records[1] = "Return";
                    records[2] = txtRemarks.Text;

                    commands.returnItem(Credit.OrderID, records);
                    MessageBox.Show("Return Transaction Complete");
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
        private void recordAction()
        {

        }
        private void actionExchange()
        {
            double getdpi = devmode.GetWindowsScaling();
            int panelwidth = ((int)(getdpi * 345 / 100));
            //338width
            if (!Credit.Exchange)
            {
                DialogResult result = MessageBox.Show("Please add items according to the amount: " + Credit.Amount.ToString() + "\n\n" + "Press Ok to continue", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            }

                

        }
        private void itemEncode()
        {

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

        private DataTable orderID;
        public DataTable OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }
    }
}
