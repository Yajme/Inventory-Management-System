namespace Inventory_Management_System.Dashboard.frmPanelContainers.frmInventoyForms
{
    partial class frmManageStocks
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewWarehouseStock = new FontAwesome.Sharp.IconButton();
            this.btnAdjustStock = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.panelAdjustStock = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnScan = new FontAwesome.Sharp.IconButton();
            this.btnDiscard = new FontAwesome.Sharp.IconButton();
            this.btnMinus = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.cmbWarehouse = new System.Windows.Forms.ComboBox();
            this.panelViewWarehouseStock = new System.Windows.Forms.Panel();
            this.btnScanView = new FontAwesome.Sharp.IconButton();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbViewWarehouse = new System.Windows.Forms.ComboBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelAdjustStock.SuspendLayout();
            this.panelViewWarehouseStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.btnViewWarehouseStock);
            this.panel1.Controls.Add(this.btnAdjustStock);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 42);
            this.panel1.TabIndex = 0;
            // 
            // btnViewWarehouseStock
            // 
            this.btnViewWarehouseStock.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnViewWarehouseStock.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnViewWarehouseStock.IconColor = System.Drawing.Color.Black;
            this.btnViewWarehouseStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnViewWarehouseStock.Location = new System.Drawing.Point(90, 0);
            this.btnViewWarehouseStock.Name = "btnViewWarehouseStock";
            this.btnViewWarehouseStock.Size = new System.Drawing.Size(143, 42);
            this.btnViewWarehouseStock.TabIndex = 2;
            this.btnViewWarehouseStock.Tag = "btnViewWarehouse";
            this.btnViewWarehouseStock.Text = "[View WarehouseStock]";
            this.btnViewWarehouseStock.UseVisualStyleBackColor = true;
            this.btnViewWarehouseStock.Click += new System.EventHandler(this.btnChangePanel);
            // 
            // btnAdjustStock
            // 
            this.btnAdjustStock.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdjustStock.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAdjustStock.IconColor = System.Drawing.Color.Black;
            this.btnAdjustStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdjustStock.Location = new System.Drawing.Point(0, 0);
            this.btnAdjustStock.Name = "btnAdjustStock";
            this.btnAdjustStock.Size = new System.Drawing.Size(90, 42);
            this.btnAdjustStock.TabIndex = 1;
            this.btnAdjustStock.Tag = "btnAdjustStock";
            this.btnAdjustStock.Text = "[Adjust Stock]";
            this.btnAdjustStock.UseVisualStyleBackColor = true;
            this.btnAdjustStock.Click += new System.EventHandler(this.btnChangePanel);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnExit.IconColor = System.Drawing.Color.Black;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.Location = new System.Drawing.Point(328, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 42);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "[Exit]";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelAdjustStock
            // 
            this.panelAdjustStock.Controls.Add(this.label4);
            this.panelAdjustStock.Controls.Add(this.label3);
            this.panelAdjustStock.Controls.Add(this.label2);
            this.panelAdjustStock.Controls.Add(this.label1);
            this.panelAdjustStock.Controls.Add(this.btnScan);
            this.panelAdjustStock.Controls.Add(this.btnDiscard);
            this.panelAdjustStock.Controls.Add(this.btnMinus);
            this.panelAdjustStock.Controls.Add(this.btnAdd);
            this.panelAdjustStock.Controls.Add(this.txtQuantity);
            this.panelAdjustStock.Controls.Add(this.txtProductName);
            this.panelAdjustStock.Controls.Add(this.btnSave);
            this.panelAdjustStock.Controls.Add(this.txtProductID);
            this.panelAdjustStock.Controls.Add(this.cmbWarehouse);
            this.panelAdjustStock.Location = new System.Drawing.Point(403, 277);
            this.panelAdjustStock.Name = "panelAdjustStock";
            this.panelAdjustStock.Size = new System.Drawing.Size(403, 235);
            this.panelAdjustStock.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "ProductName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ProductID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Warehouse";
            // 
            // btnScan
            // 
            this.btnScan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnScan.IconColor = System.Drawing.Color.Black;
            this.btnScan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnScan.Location = new System.Drawing.Point(314, 54);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 8;
            this.btnScan.Text = "[Scan]";
            this.btnScan.UseVisualStyleBackColor = true;
            // 
            // btnDiscard
            // 
            this.btnDiscard.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDiscard.IconColor = System.Drawing.Color.Black;
            this.btnDiscard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDiscard.Location = new System.Drawing.Point(235, 188);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(73, 37);
            this.btnDiscard.TabIndex = 7;
            this.btnDiscard.Text = "[Discard]";
            this.btnDiscard.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            this.btnMinus.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinus.IconColor = System.Drawing.Color.Black;
            this.btnMinus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinus.IconSize = 20;
            this.btnMinus.Location = new System.Drawing.Point(87, 109);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(40, 20);
            this.btnMinus.TabIndex = 6;
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 20;
            this.btnAdd.Location = new System.Drawing.Point(268, 109);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 20);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(133, 109);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(129, 20);
            this.txtQuantity.TabIndex = 4;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(87, 83);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(221, 20);
            this.txtProductName.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSave.IconColor = System.Drawing.Color.Black;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.Location = new System.Drawing.Point(314, 188);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 37);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "[Save]";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(87, 57);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(221, 20);
            this.txtProductID.TabIndex = 1;
            this.txtProductID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductID_KeyPress);
            // 
            // cmbWarehouse
            // 
            this.cmbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWarehouse.FormattingEnabled = true;
            this.cmbWarehouse.Location = new System.Drawing.Point(87, 30);
            this.cmbWarehouse.Name = "cmbWarehouse";
            this.cmbWarehouse.Size = new System.Drawing.Size(121, 21);
            this.cmbWarehouse.TabIndex = 0;
            // 
            // panelViewWarehouseStock
            // 
            this.panelViewWarehouseStock.Controls.Add(this.btnScanView);
            this.panelViewWarehouseStock.Controls.Add(this.txtQuery);
            this.panelViewWarehouseStock.Controls.Add(this.dataGridView1);
            this.panelViewWarehouseStock.Controls.Add(this.cmbViewWarehouse);
            this.panelViewWarehouseStock.Location = new System.Drawing.Point(403, 277);
            this.panelViewWarehouseStock.Name = "panelViewWarehouseStock";
            this.panelViewWarehouseStock.Size = new System.Drawing.Size(403, 235);
            this.panelViewWarehouseStock.TabIndex = 2;
            // 
            // btnScanView
            // 
            this.btnScanView.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnScanView.IconColor = System.Drawing.Color.Black;
            this.btnScanView.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnScanView.Location = new System.Drawing.Point(325, -1);
            this.btnScanView.Name = "btnScanView";
            this.btnScanView.Size = new System.Drawing.Size(75, 20);
            this.btnScanView.TabIndex = 2;
            this.btnScanView.Text = "[Scan]";
            this.btnScanView.UseVisualStyleBackColor = true;
            // 
            // txtQuery
            // 
            this.txtQuery.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtQuery.Location = new System.Drawing.Point(0, 0);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(233, 20);
            this.txtQuery.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colProductID,
            this.colQuantity});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(403, 215);
            this.dataGridView1.TabIndex = 0;
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colID.HeaderText = "#";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 39;
            // 
            // colProductID
            // 
            this.colProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProductID.HeaderText = "ProductID";
            this.colProductID.MinimumWidth = 6;
            this.colProductID.Name = "colProductID";
            this.colProductID.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.MinimumWidth = 6;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.Width = 71;
            // 
            // cmbViewWarehouse
            // 
            this.cmbViewWarehouse.FormattingEnabled = true;
            this.cmbViewWarehouse.Location = new System.Drawing.Point(239, -1);
            this.cmbViewWarehouse.Name = "cmbViewWarehouse";
            this.cmbViewWarehouse.Size = new System.Drawing.Size(83, 21);
            this.cmbViewWarehouse.TabIndex = 3;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 42);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(403, 235);
            this.panelContainer.TabIndex = 3;
            // 
            // frmManageStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 277);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelViewWarehouseStock);
            this.Controls.Add(this.panelAdjustStock);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageStocks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageStocks";
            this.Load += new System.EventHandler(this.frmManageStocks_Load);
            this.panel1.ResumeLayout(false);
            this.panelAdjustStock.ResumeLayout(false);
            this.panelAdjustStock.PerformLayout();
            this.panelViewWarehouseStock.ResumeLayout(false);
            this.panelViewWarehouseStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnViewWarehouseStock;
        private FontAwesome.Sharp.IconButton btnAdjustStock;
        private System.Windows.Forms.Panel panelAdjustStock;
        private System.Windows.Forms.ComboBox cmbWarehouse;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtProductName;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.TextBox txtProductID;
        private FontAwesome.Sharp.IconButton btnMinus;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnScan;
        private FontAwesome.Sharp.IconButton btnDiscard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelViewWarehouseStock;
        private FontAwesome.Sharp.IconButton btnScanView;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbViewWarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.Panel panelContainer;
    }
}