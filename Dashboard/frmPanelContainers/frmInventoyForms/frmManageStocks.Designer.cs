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
            this.panel1.SuspendLayout();
            this.panelAdjustStock.SuspendLayout();
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
            this.btnViewWarehouseStock.Text = "[View WarehouseStock]";
            this.btnViewWarehouseStock.UseVisualStyleBackColor = true;
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
            this.btnAdjustStock.Text = "[Adjust Stock]";
            this.btnAdjustStock.UseVisualStyleBackColor = true;
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
            this.panelAdjustStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdjustStock.Location = new System.Drawing.Point(0, 42);
            this.panelAdjustStock.Name = "panelAdjustStock";
            this.panelAdjustStock.Size = new System.Drawing.Size(403, 284);
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
            this.cmbWarehouse.FormattingEnabled = true;
            this.cmbWarehouse.Location = new System.Drawing.Point(87, 30);
            this.cmbWarehouse.Name = "cmbWarehouse";
            this.cmbWarehouse.Size = new System.Drawing.Size(121, 21);
            this.cmbWarehouse.TabIndex = 0;
            // 
            // frmManageStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 326);
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
    }
}