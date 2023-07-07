using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Management_System.Dashboard.frmPanelContainers.frmOrderForms.frmReciept;
using IronBarCode;
using IronSoftware.Drawing;

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

        public void SaveStreamAsFile(string filePath, Stream inputStream, string fileName)
        {
            DirectoryInfo info = new DirectoryInfo(filePath);
            if (!info.Exists)
            {
                info.Create();
            }

            string path = Path.Combine(filePath, fileName);
            using (FileStream outputFileStream = new FileStream(path, FileMode.Create))
            {
                inputStream.CopyTo(outputFileStream);
            }
        }
        private void GenerateStoreCredit()
      {
            Credit.exchangeBarcode = EAN13Generator.GenerateRandomEAN13();
            var barcode = BarcodeWriter.CreateBarcode(Credit.exchangeBarcode, BarcodeEncoding.EAN13).AddBarcodeValueTextBelowBarcode().SetMargins(5,5,5,5).ToStream(); // Create barcode number from generated barcode

            
            //SaveStreamAsFile(filepath, barcode, fileName);
            Credit.imagePath = "D:\\Users\\spart\\Source\\Repos\\Inventory-Management-System\\Dashboard\\frmPanelContainers\\frmOrderForms\\frmReciept\\" + Credit.exchangeBarcode + ".Jpeg";

            barcodeContainer.Image = Image.FromStream(barcode);
            barcodeContainer.SizeMode = PictureBoxSizeMode.StretchImage;
            barcodeContainer.Image.Save(Credit.imagePath, ImageFormat.Jpeg);

            Credit.ExchangeRecord = new string[2];
            Credit.ExchangeRecord[0] = Credit.Amount.ToString();
            Credit.ExchangeRecord[1] = Credit.exchangeBarcode;

            //MessageBox.Show(Credit.ExchangeRecord[0] + "\n\n\n\n" + Credit.ExchangeRecord[1]);
        }
        
        private void actionExchange()
        {
            double getdpi = devmode.GetWindowsScaling();
            int panelwidth = ((int)(getdpi * 345 / 100));
            //338width
            if (!Credit.Exchange)
            {
               
                    
                    panel2.Width = panelwidth;
                    GenerateStoreCredit();
                    dataGridView1.Hide();
                    Credit.Exchange = true;
                
            }
            else 
            {


                try
                {
                    actionRecord();

                    Credit.transactionID = commands.exchangeItem(Credit.ExchangeRecord, Credit.Record);
                    Credit.Exchange = false;
                    MessageBox.Show("You can close this dialog");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //WIP 
            frmPreview frmNew = new frmPreview();
            frmPreview.Instance.filePath = Credit.imagePath;
            frmPreview.Instance.transactionID = Credit.transactionID;
            frmPreview.Instance.StoreCreditamount = Credit.Amount;
            
            frmNew.ShowDialog();
        }
    }
    public class EAN13Generator
    {
        private static Random random = new Random();

        public static string GenerateRandomEAN13()
        {
            // Generate 12 random digits
            StringBuilder barcodeBuilder = new StringBuilder();
            for (int i = 0; i < 12; i++)
            {
                barcodeBuilder.Append(random.Next(0, 10));
            }

            string barcodeWithoutCheckDigit = barcodeBuilder.ToString();
            int checkDigit = CalculateEAN13CheckDigit(barcodeWithoutCheckDigit);

            // Append the check digit to the barcode
            string barcode = barcodeWithoutCheckDigit + checkDigit.ToString();

            return barcode;
        }

        private static int CalculateEAN13CheckDigit(string barcode)
        {
            int sum = 0;
            for (int i = 0; i < barcode.Length; i++)
            {
                int digit = int.Parse(barcode[i].ToString());
                sum += (i % 2 == 0) ? digit : digit * 3;
            }

            int checkDigit = (10 - (sum % 10)) % 10;
            return checkDigit;
        }
    }


    class Credit

    {
        public string imagePath { get; set; }
        private int TransactionID = 0;
        public int transactionID {
            get { return TransactionID; }
            set { TransactionID = value; } }
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
        public double StoreCredit { get; set; }
        public string[] Record { get; set; }

        public string exchangeBarcode {get;set;}

        public string[] ExchangeRecord { get; set; }
    }
}
