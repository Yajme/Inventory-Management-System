using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.Dashboard.frmPanelContainers
{
    public partial class frmSalesReport : Form
    {
        StockMovements stockMovements = new StockMovements();

        public frmSalesReport()
        {
            InitializeComponent();
            
        }

       
        private void frmSalesReport_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.HorizontalScroll.Visible = false;


            stockMovements.LoadStockMovemnt(dataGridStockMovement,cboStockMovement_Warehouse);
        }

        private void frmSalesReport_Resize(object sender, EventArgs e)
        {
            panel2.Width = flowLayoutPanel1.Width - 50;
            panel3.Width = flowLayoutPanel1.Width - 50;
            panel4.Width = flowLayoutPanel1.Width - 50;
            panel5.Width = flowLayoutPanel1.Width - 50;

            //groupBox1.Width = 952 - 706 + panel2.Width;
        }

        private void btnStockMovement_Search_Click(object sender, EventArgs e)
        {
            stockMovements.searchProductID(txtStockMovement_ProductID.Text, cboStockMovement_Warehouse.Text, cboStockMovement_Movement.Text,dataGridStockMovement);
        }

        private void btnStockMovement_ClearFilters_Click(object sender, EventArgs e)
        {

        }
    }


    public class StockMovements
    {
        //Filter by Warehouse
        //Search by productID
        //Filter by date
        //Filter by movement type 

        private DataTable stockMovement;
        public  DataTable StockMovement {
            get { return stockMovement; }
            set { stockMovement = value; } 
        }
        private DataTable warehouses;
        public DataTable Warehouses { get { return warehouses; } set { warehouses = value; } }
        public void LoadStockMovemnt(DataGridView data, ComboBox Warehouse)
        {
            StockMovement = commands.loadMovementStock();
            data.Rows.Clear();
            foreach(DataRow row in StockMovement.Rows)
            {
                data.Rows.Add(row[0], row[1], row[2], row[3],row[4], row[5]);
            }

            Warehouses = commands.loadWarehouses();
            Warehouse.Items.Clear();
            foreach(DataRow row in Warehouses.Rows)
            {
                Warehouse.Items.Add(row[1]);
            }
        }
        
        public void searchProductID(string ProductID, string Warehouse,string MovementType,DataGridView data)
        {
            if(Warehouse == String.Empty && MovementType == String.Empty && ProductID == String.Empty)
            {
                MessageBox.Show("Fill Fields!");
            }
            else
            {
                if(ProductID != string.Empty) 
                {
                    if (Warehouse == String.Empty && MovementType == String.Empty)// Search by ProductID
                    {
                        StockMovement = commands.searchMovementStock(ProductID);
                    }
                    else if (MovementType != String.Empty && Warehouse == String.Empty)// Search by ProductID && MovementType
                    {
                        StockMovement = commands.searchMovementStock(ProductID, MovementType);
                    }
                    else if (MovementType != String.Empty && Warehouse != String.Empty) // search all
                    {
                        StockMovement = commands.searchMovementStock(ProductID, MovementType, Warehouse);
                    }
                    else if (MovementType == String.Empty && Warehouse != String.Empty) //Filter by Warehouse and ProductID
                    {
                        StockMovement = commands.filterMovementStock_Warehouse(Warehouse, ProductID);
                    }
                }else if(Warehouse != String.Empty)
                {
                    if(MovementType != string.Empty)
                    {
                        stockMovement = commands.filterMovementStock(MovementType, Warehouse);
                    }
                    else
                    {
                        StockMovement = commands.filterMovementStock_Warehouse(Warehouse);
                    }
                }else if(MovementType != String.Empty)
                {
                    stockMovement = commands.filterMovementStock(MovementType);
                }
                
                filterStockMovement(StockMovement,data);   
            }



        }

        private void filterStockMovement(DataTable dt, DataGridView data)
        {
            data.Rows.Clear();
            foreach(DataRow row in dt.Rows)
            {
                data.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
            }
        }


    }
}
