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
    public partial class frmManageWarehouse : Form
    {
        bool update = false;
        int warehouseID = 0;
        public frmManageWarehouse()
        {
            InitializeComponent();
        }

        private void frmManageWarehouse_Load(object sender, EventArgs e)
        {
            loadWarehouse();
        }
        private void loadWarehouse()
        {
            dataGridView1.Rows.Clear();
            DataTable dt = commands.loadWarehouses();
            foreach(DataRow dr in dt.Rows)
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2]);
            }
        }

        private void resetFields()
        {
            if (update || txtLocation.Text != string.Empty || txtWarehouseName.Text != string.Empty)
            {
                DialogResult result = MessageBox.Show("Are you sure to discard changes?", "Discard", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    txtLocation.Clear();
                    txtWarehouseName.Clear();
                    loadWarehouse();
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] warehouse = new string[2];
            warehouse[0] = txtWarehouseName.Text;
            warehouse[1] = txtLocation.Text;
            
            
            DialogResult result = MessageBox.Show("Are you sure to Save changes?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (!update)
                    {
                        commands.insertWarehouse(warehouse);
                        MessageBox.Show("Warehouse Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        commands.updateWarehouse(warehouse,warehouseID);
                        MessageBox.Show("Warehouse Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        update = false;
                    }
                    loadWarehouse();
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            resetFields();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            warehouseID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if(colName == "colEdit")
            {
                
                MessageBox.Show(warehouseID.ToString());
                txtLocation.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtWarehouseName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                update = true;
            }else if(colName == "colDelete")
            {
                DialogResult result = MessageBox.Show("Are you sure to Delete Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        commands.deleteWarehouse(warehouseID);
                        MessageBox.Show("Record Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }catch(SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void frmManageWarehouse_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(txtLocation.Text != string.Empty || txtWarehouseName.Text != String.Empty)
            {
                DialogResult result = MessageBox.Show("Are you sure to discard changes?", "Discard", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
