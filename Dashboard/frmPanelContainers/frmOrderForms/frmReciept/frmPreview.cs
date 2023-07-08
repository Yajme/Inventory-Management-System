using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Management_System.Dashboard.frmPanelContainers.frmOrderForms.frmReciept.DataSetFiles;

namespace Inventory_Management_System.Dashboard.frmPanelContainers.frmOrderForms.frmReciept
{
    public partial class frmPreview : Form
    {
        public static frmPreview Instance;
        public string filePath;
        public double StoreCreditamount;
        public int transactionID;
        
        public frmPreview()
        {
            InitializeComponent();
            Instance = this;
        }
        private void ReportLoad()
        {
            
            ReportParameter filepath = new ReportParameter("barcodeLocation", new Uri(filePath).AbsoluteUri);
            ReportParameter transacID = new ReportParameter("transactionID", transactionID.ToString());
            ReportParameter amount = new ReportParameter("StoreCreditAmount", StoreCreditamount.ToString());

            DataSet1 ds = commands.selectExchangeItem(transactionID);
            
            ReportDataSource rptDataSource = new ReportDataSource("DataSet1", ds.Tables["StoreCredit"]);
            this.reportViewer1.LocalReport.DataSources.Add(rptDataSource);
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { filepath,transacID,amount });
        }

        private void frmPreview_Load(object sender, EventArgs e)
        {
            ReportLoad();

            this.reportViewer1.RefreshReport();
        }
    }
}
