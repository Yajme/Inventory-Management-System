using System.Windows.Media.Animation;

namespace Inventory_Management_System.Dashboard.frmPanelContainers
{
    partial class frmInventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClearFilter = new FontAwesome.Sharp.IconButton();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnManageWarehouse = new FontAwesome.Sharp.IconButton();
            this.btnManageStocks = new FontAwesome.Sharp.IconButton();
            this.btnManageSupplier = new FontAwesome.Sharp.IconButton();
            this.btnManageCategory = new FontAwesome.Sharp.IconButton();
            this.btnAddProduct = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCatergory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 61);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.btnClearFilter);
            this.panel3.Controls.Add(this.cmbFilter);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(557, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.MaximumSize = new System.Drawing.Size(328, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(328, 61);
            this.panel3.TabIndex = 2;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.ForeColor = System.Drawing.Color.White;
            this.btnClearFilter.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClearFilter.IconColor = System.Drawing.Color.Black;
            this.btnClearFilter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClearFilter.Location = new System.Drawing.Point(97, 30);
            this.btnClearFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(87, 31);
            this.btnClearFilter.TabIndex = 8;
            this.btnClearFilter.Text = "[Clear]";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // cmbFilter
            // 
            this.cmbFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(195, 30);
            this.cmbFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(133, 21);
            this.cmbFilter.TabIndex = 7;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.Location = new System.Drawing.Point(0, 30);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 31);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "[Search]";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.txtQuery);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(328, 30);
            this.panel5.TabIndex = 0;
            // 
            // txtQuery
            // 
            this.txtQuery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuery.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuery.ForeColor = System.Drawing.Color.DimGray;
            this.txtQuery.Location = new System.Drawing.Point(0, 0);
            this.txtQuery.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(328, 30);
            this.txtQuery.TabIndex = 4;
            this.txtQuery.Text = "Search...";
            this.txtQuery.TextChanged += new System.EventHandler(this.txtQuery_TextChanged);
            this.txtQuery.GotFocus += new System.EventHandler(this.RemoveText);
            this.txtQuery.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuery_KeyPress);
            this.txtQuery.LostFocus += new System.EventHandler(this.AddText);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.btnManageWarehouse);
            this.panel2.Controls.Add(this.btnManageStocks);
            this.panel2.Controls.Add(this.btnManageSupplier);
            this.panel2.Controls.Add(this.btnManageCategory);
            this.panel2.Controls.Add(this.btnAddProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 61);
            this.panel2.TabIndex = 1;
            // 
            // btnManageWarehouse
            // 
            this.btnManageWarehouse.AutoSize = true;
            this.btnManageWarehouse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnManageWarehouse.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnManageWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageWarehouse.ForeColor = System.Drawing.Color.White;
            this.btnManageWarehouse.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnManageWarehouse.IconColor = System.Drawing.Color.White;
            this.btnManageWarehouse.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnManageWarehouse.Location = new System.Drawing.Point(398, 0);
            this.btnManageWarehouse.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageWarehouse.Name = "btnManageWarehouse";
            this.btnManageWarehouse.Size = new System.Drawing.Size(122, 61);
            this.btnManageWarehouse.TabIndex = 4;
            this.btnManageWarehouse.Text = "[Manage Warehouse]";
            this.btnManageWarehouse.UseVisualStyleBackColor = true;
            this.btnManageWarehouse.Click += new System.EventHandler(this.btnManageWarehouse_Click);
            // 
            // btnManageStocks
            // 
            this.btnManageStocks.AutoSize = true;
            this.btnManageStocks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnManageStocks.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnManageStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageStocks.ForeColor = System.Drawing.Color.White;
            this.btnManageStocks.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnManageStocks.IconColor = System.Drawing.Color.White;
            this.btnManageStocks.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnManageStocks.Location = new System.Drawing.Point(298, 0);
            this.btnManageStocks.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageStocks.Name = "btnManageStocks";
            this.btnManageStocks.Size = new System.Drawing.Size(100, 61);
            this.btnManageStocks.TabIndex = 3;
            this.btnManageStocks.Text = "[Manage Stocks]";
            this.btnManageStocks.UseVisualStyleBackColor = true;
            this.btnManageStocks.Click += new System.EventHandler(this.btnManageStocks_Click);
            // 
            // btnManageSupplier
            // 
            this.btnManageSupplier.AutoSize = true;
            this.btnManageSupplier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnManageSupplier.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnManageSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageSupplier.ForeColor = System.Drawing.Color.White;
            this.btnManageSupplier.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnManageSupplier.IconColor = System.Drawing.Color.White;
            this.btnManageSupplier.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnManageSupplier.Location = new System.Drawing.Point(193, 0);
            this.btnManageSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageSupplier.Name = "btnManageSupplier";
            this.btnManageSupplier.Size = new System.Drawing.Size(105, 61);
            this.btnManageSupplier.TabIndex = 2;
            this.btnManageSupplier.Text = "[Manage Supplier]";
            this.btnManageSupplier.UseVisualStyleBackColor = true;
            this.btnManageSupplier.Click += new System.EventHandler(this.btnManageSupplier_Click);
            // 
            // btnManageCategory
            // 
            this.btnManageCategory.AutoSize = true;
            this.btnManageCategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnManageCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnManageCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCategory.ForeColor = System.Drawing.Color.White;
            this.btnManageCategory.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnManageCategory.IconColor = System.Drawing.Color.White;
            this.btnManageCategory.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnManageCategory.Location = new System.Drawing.Point(84, 0);
            this.btnManageCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageCategory.Name = "btnManageCategory";
            this.btnManageCategory.Size = new System.Drawing.Size(109, 61);
            this.btnManageCategory.TabIndex = 1;
            this.btnManageCategory.Text = "[Manage Category]";
            this.btnManageCategory.UseVisualStyleBackColor = true;
            this.btnManageCategory.Click += new System.EventHandler(this.btnManageCategory_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.AutoSize = true;
            this.btnAddProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddProduct.IconColor = System.Drawing.Color.White;
            this.btnAddProduct.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAddProduct.Location = new System.Drawing.Point(0, 0);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(84, 61);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "[Add Product]";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // panel4
            // 
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 61);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(885, 461);
            this.panel4.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductID,
            this.colProductName,
            this.colDesc,
            this.colCatergory,
            this.colQuantity,
            this.colPrice,
            this.colSupplier,
            this.colEdit,
            this.colDelete});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(885, 461);
            this.dataGridView1.TabIndex = 0;
            // 
            // colProductID
            // 
            this.colProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProductID.HeaderText = "ProductID";
            this.colProductID.MinimumWidth = 8;
            this.colProductID.Name = "colProductID";
            this.colProductID.ReadOnly = true;
            // 
            // colProductName
            // 
            this.colProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colProductName.HeaderText = "ProductName";
            this.colProductName.MinimumWidth = 8;
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            this.colProductName.Width = 97;
            // 
            // colDesc
            // 
            this.colDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDesc.HeaderText = "Description";
            this.colDesc.MinimumWidth = 8;
            this.colDesc.Name = "colDesc";
            this.colDesc.ReadOnly = true;
            // 
            // colCatergory
            // 
            this.colCatergory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colCatergory.HeaderText = "Category";
            this.colCatergory.MinimumWidth = 8;
            this.colCatergory.Name = "colCatergory";
            this.colCatergory.ReadOnly = true;
            this.colCatergory.Width = 74;
            // 
            // colQuantity
            // 
            this.colQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.MinimumWidth = 8;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.Width = 71;
            // 
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colPrice.HeaderText = "UnitPrice";
            this.colPrice.MinimumWidth = 8;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 75;
            // 
            // colSupplier
            // 
            this.colSupplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colSupplier.HeaderText = "Supplier";
            this.colSupplier.MinimumWidth = 8;
            this.colSupplier.Name = "colSupplier";
            this.colSupplier.ReadOnly = true;
            this.colSupplier.Width = 70;
            // 
            // colEdit
            // 
            this.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colEdit.HeaderText = "";
            this.colEdit.Image = ((System.Drawing.Image)(resources.GetObject("colEdit.Image")));
            this.colEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colEdit.MinimumWidth = 8;
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Width = 8;
            // 
            // colDelete
            // 
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colDelete.HeaderText = "";
            this.colDelete.Image = ((System.Drawing.Image)(resources.GetObject("colDelete.Image")));
            this.colDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colDelete.MinimumWidth = 8;
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Width = 8;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 8;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(885, 522);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInventory";
            this.Text = "frmInventory";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnManageWarehouse;
        private FontAwesome.Sharp.IconButton btnManageStocks;
        private FontAwesome.Sharp.IconButton btnManageSupplier;
        private FontAwesome.Sharp.IconButton btnManageCategory;
        private FontAwesome.Sharp.IconButton btnAddProduct;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCatergory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplier;
        private System.Windows.Forms.DataGridViewImageColumn colEdit;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.TextBox txtQuery;
        private FontAwesome.Sharp.IconButton btnClearFilter;
    }
}