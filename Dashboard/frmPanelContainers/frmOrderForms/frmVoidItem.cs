using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static Inventory_Management_System.db.db;
using System.Data.Odbc;

namespace Inventory_Management_System.Dashboard.frmPanelContainers.frmOrderForms
{
    public partial class frmVoidItem : Form
    {
        public static frmVoidItem instance;
        public frmVoidItem()
        {
            InitializeComponent();
            instance = this;
        }
        private bool authentication(string username, string password)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM users WHERE username= @username AND password= @password", con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
            
            return false;
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //MessageBox.Show(username + "\n\n" + txtPassword.Text);
                if(authentication(username, txtPassword.Text))
                {
                    frmOrder.instance.itemVoid();
                }
                else
                {
                    MessageBox.Show("Invalid Password!","Invalid Password",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
               
                this.Close();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
