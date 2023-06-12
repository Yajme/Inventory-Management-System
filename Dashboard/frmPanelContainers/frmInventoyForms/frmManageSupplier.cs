using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Inventory_Management_System.Dashboard.frmPanelContainers.frmInventoyForms
{
    public partial class frmManageSupplier : Form
    {
        public static double getdpi;
        public static int supplierid;
        public static bool update = false;
        public frmManageSupplier()
        {
            InitializeComponent();
        }
        private void showFields()
        {
            panel3.Height = (int)(260 * (getdpi/100));
            panel2.Height = 0;
            
        }
        private void hideFields()
        {
            panel3.Height = 0;
            btnShowField.Show();
            txtSupplierName.Clear();
            txtContactPerson.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            panel2.Height = (int)(39 * (getdpi / 100));
        }
        private void loadRecords()
        {
            dataGridView1.Rows.Clear();
            DataTable dt = commands.loadsuppliers();
            foreach(DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[4], row[3]);
            }
            
        }
        private void frmManageSupplier_Load(object sender, EventArgs e)
        {
            getdpi = devmode.GetWindowsScaling();
            loadRecords();
        }

        private void btnShowField_Click(object sender, EventArgs e)
        {
            showFields();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            hideFields();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string[] suppliers = new string[4];
                suppliers[0] = txtSupplierName.Text;
                suppliers[1] = txtContactPerson.Text;
                suppliers[2] = txtPhone.Text;
                suppliers[3] = txtEmail.Text;
                if (update == false)
                {
                    commands.insertsuppliers(suppliers);
                    MessageBox.Show("Supplier Added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    commands.updatesuppliers(suppliers, supplierid);
                    MessageBox.Show("Supplier Updated!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    update = false;
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
            hideFields();
            loadRecords();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            supplierid = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "colEdit")
            {
                update = true;
                txtSupplierName.Text  = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtContactPerson.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                
                showFields();
            }
            else if (colName == "colDelete")
            {
                DialogResult result = MessageBox.Show("Are you sure to Delete this Record?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        commands.deletesuppliers(supplierid);

                        MessageBox.Show("Record Deleted!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                     loadRecords();
                }

            }
        }
    }
}
