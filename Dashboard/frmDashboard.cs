using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Management_System;
using Inventory_Management_System.Dashboard.frmPanelContainers;

namespace Inventory_Management_System.Dashboard
{
    public partial class frmDashboard : Form
    {
        public static bool logout = false;
        public Form lastForm;
        public frmDashboard()
        {
            InitializeComponent();
        }
        private void btnPanel(object sender, EventArgs e)
        {
            ChangeMenu(((Button)sender).Tag.ToString());
        }

        

        public void ChangeMenu(string menu)
        {
            if (panelContainer.Controls.Contains(lastForm))
            {
                lastForm.Close();
            }

            switch (menu)
            {
                case "btnHome":
                    AddForm(new frmHome());
                    break;
                case "btnSalesReport":
                    AddForm(new frmSalesReport());
                    break; 
                case "btnInventory":
                    AddForm(new frmInventory());
                    break;
                case "btnOrder":
                    AddForm(new frmOrder());
                    break;
                
            }
        }

        private void AddForm(Form frm)
        {
            panelContainer.Controls.Clear();

            frm.TopMost = true;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(frm);
            frm.Show();

            lastForm = frm;
        }


        private void frmDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(logout == false)
            {
                DialogResult result = MessageBox.Show("Do you want to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.ExitThread(); // Terminate the program
                }
                else
                {
                    e.Cancel = true; //prevent closing
                }
            }
            
        }
        private void hideText()
        {
            btnHome.Text = "";
            btnInventory.Text = "";
            btnOrder.Text = "";
            btnSalesReport.Text = "";

            btnSettings.Text = "";
            btnLogout.Text = "";
            btnExit.Text = "";

        }
        private void showText()
        {
            btnHome.Text = "Home";
            btnInventory.Text = "Inventory";
            btnOrder.Text = "Order";
            btnSalesReport.Text = "Sales Report";

            btnSettings.Text = "Settings";
            btnLogout.Text = "Logout";
            btnExit.Text = "Exit";
        }
        private void btnShowHidePanel_Click(object sender, EventArgs e)
        {
            
            if(sidePanel.Width > 56)
            {
                hideText();
                panelSideTop.Height = 46;
                sidePanel.Width = 56;
                btnShowHidePanel.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            }else if(sidePanel.Width < 320)
            {
                showText();
                panelSideTop.Height = 289;
                sidePanel.Width = 320;
                btnShowHidePanel.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                logout = true;
                this.Dispose();
                Login frmLogin = new Login();
                frmLogin.ShowDialog();
                    
            }
            
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            logout = false;
            ChangeMenu("btnHome");
        }
    }
}
