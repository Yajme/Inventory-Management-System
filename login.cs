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
using FontAwesome.Sharp;
using Inventory_Management_System.Dashboard;
using static Inventory_Management_System.db.db;
namespace Inventory_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Authentication();
        }

       
        void Authentication()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Enter Username");
            }
            else if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Enter Password");
            }
            else
            {
                try
                {
                        con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM users WHERE username = @Username AND password = @Password", con))
                    {
                        command.Parameters.AddWithValue("@Username", txtUsername.Text);
                        command.Parameters.AddWithValue("@Password", txtPassword.Text);

                        dr = command.ExecuteReader();
                        if (dr.Read())
                        {
                            if (dr[3].ToString() == "1")
                            {
                                frmDashboard frmdb = new frmDashboard();
                                frmdb.Show();
                                Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password");
                        }
                    }
                    // Clear the input fields
                    txtPassword.Text = "";
                    txtUsername.Text = "";
                    dr.Close();
                    con.Close();
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {
            Connection();
        }

        private void keyPressEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Authentication();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Terminate the program
            }
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                btnShowPass.IconFont = IconFont.Solid;
            }else if (txtPassword.UseSystemPasswordChar == false)
            {
                btnShowPass.IconFont = IconFont.Regular;
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
