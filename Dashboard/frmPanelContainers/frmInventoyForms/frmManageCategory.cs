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

namespace Inventory_Management_System.Dashboard.frmPanelContainers.frmInventoyForms
{
    public partial class frmManageCategory : Form
    {
        public static bool update = false;
        public static double getdpi;
        public static int categoryid;
        public frmManageCategory()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtCategory.Clear();
            ShowNewRecord(); 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text != string.Empty)
            {
                DialogResult result = MessageBox.Show("Are you sure to discard changes?", "Discard", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    txtCategory.Clear();
                    HideNewRecord();
                }
                else if (result == DialogResult.No)
                {
                    txtCategory.Focus();
                }
            }
            else
            {
                HideNewRecord();
            }
            
        }
        private void HideNewRecord()
        {
            loadRecords();
            btnNew.Show();
            panel3.Height = 0;
        }
        private void ShowNewRecord()
        {
            btnNew.Hide();
            panel3.Height = (int)(180 * (getdpi/100));
        }
        
        private void frmManageCategory_Load(object sender, EventArgs e)
        {
            getdpi = devmode.GetWindowsScaling();
            HideNewRecord();
            loadRecords();
        }
        private void loadRecords()
        {
            dataGridView1.Rows.Clear();
            DataTable dt = commands.loadcategories();
            foreach (DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(row[0], row[1]);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (update == false)
                {
                    commands.insertcategories(txtCategory.Text);
                    MessageBox.Show("Category Added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    commands.updatecategories(txtCategory.Text, categoryid);
                    MessageBox.Show("Updated!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    update = false;
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }

                HideNewRecord();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            categoryid = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if(colName == "colEdit")
            {
                ShowNewRecord();
                txtCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                
                update = true;
            }
            else if(colName == "colDelete")
            {
                DialogResult result = MessageBox.Show("Are you sure to Delete this Record?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    try
                    {
                        commands.deletecategories(categoryid);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Database error: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error: " + ex.Message);
                    }


                    loadRecords();
                }

            }
        }
    }
}
