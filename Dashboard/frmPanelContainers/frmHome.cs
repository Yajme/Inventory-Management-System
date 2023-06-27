using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Inventory_Management_System.Dashboard.frmPanelContainers
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            chart1.Series.Add("Line");
            //chart1.Series["Line"].Points.Add(new DataPoint(1, 1));
            //chart1.Series["Line"].Points.Add(new DataPoint(3, 3));
            //chart1.Series["Line"].ChartType = SeriesChartType.Line;
            //db.db.Connection();
            DataTable dt = commands.saleReport();

            Axis XA = chart1.ChartAreas[0].AxisX;
            Axis YA = chart1.ChartAreas[0].AxisY;
            Series S1 = chart1.Series[0];


            Random R = new Random();

            List<DateTime> dates = new List<DateTime>();
            DateTime dtr = DateTime.Now;
            for (int i = 1; i < 12; i++)
            {
                dates.Add(new DateTime(dtr.Year, i, 1));
            }



            //foreach (DateTime d in dates)
            //{

            //    S1.Points.AddXY(d, R.Next(99) + 33);

            //}



            foreach (DataRow row in dt.Rows)
            {
                string dateString = row[1].ToString();
                string format = "dd/MM/yyyy";

                DateTime date;

                //// Using DateTime.ParseExact
                date = DateTime.ParseExact(dateString, format, CultureInfo.InvariantCulture);

                S1.Points.AddXY(date, row[0]);
                chart1.Series["Line"].ChartType = SeriesChartType.SplineArea;

            }


            S1.BorderWidth = 1;
            
            // show the year in the legend:
            S1.LegendText = "Year " + dtr.Year;
            // move to the bottom center:
            chart1.Legends[0].Docking = Docking.Bottom;
            chart1.Legends[0].Alignment = StringAlignment.Center;

            S1.XValueType = ChartValueType.Date;  // set the type
            XA.MajorGrid.Enabled = false;         // no gridlines
            XA.LabelStyle.Format = "MMM";         // show months as names


           
            XA.IntervalType = DateTimeIntervalType.Months;  // show axis labels.. 
            XA.Interval = 1;                                // ..every 1 months

            YA.LabelStyle.Format = "#,##0.00";  // for kilos etc you need to scale the y-values!


            YA.IsInterlaced = true;
            YA.MajorGrid.Enabled = false;
            YA.InterlacedColor = Color.FromArgb(31, Color.LightSeaGreen);

            

        }
    }
}
