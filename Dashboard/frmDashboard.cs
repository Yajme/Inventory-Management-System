using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Management_System;
namespace Inventory_Management_System.Dashboard
{
    public partial class frmDashboard : Form
    {
        public static bool logout = false;
        public frmDashboard()
        {
            InitializeComponent();
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
        }
    }
}
