namespace Inventory_Management_System.Dashboard.frmPanelContainers
{
    partial class frmOrder
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelCash = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCashTendered = new System.Windows.Forms.TextBox();
            this.btnReturnExchange = new FontAwesome.Sharp.IconButton();
            this.btnReplenishInventory = new FontAwesome.Sharp.IconButton();
            this.btnPlaceOrder = new FontAwesome.Sharp.IconButton();
            this.panelPlaceOrder = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelOrderTop = new System.Windows.Forms.Panel();
            this.btnEnter = new FontAwesome.Sharp.IconButton();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.panelOrderControls = new System.Windows.Forms.Panel();
            this.btnVoidItem = new FontAwesome.Sharp.IconButton();
            this.btnAddDiscount = new FontAwesome.Sharp.IconButton();
            this.btnSettle = new FontAwesome.Sharp.IconButton();
            this.btnProductInquiry = new FontAwesome.Sharp.IconButton();
            this.btnNewTransaction = new FontAwesome.Sharp.IconButton();
            this.panelPlaceOrderSide = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSaleTotalContaine = new System.Windows.Forms.Panel();
            this.lblSaleTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblVAT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCash = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblChange = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelReplenishInventory = new System.Windows.Forms.Panel();
            this.cmbWarehouse = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDiscard = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEnterReplenish = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.colMovementID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductIDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMovementType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMovementDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantityH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelCash.SuspendLayout();
            this.panelPlaceOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelOrderTop.SuspendLayout();
            this.panelOrderControls.SuspendLayout();
            this.panelPlaceOrderSide.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelSaleTotalContaine.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.panelReplenishInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panelTop.Controls.Add(this.panelCash);
            this.panelTop.Controls.Add(this.btnReturnExchange);
            this.panelTop.Controls.Add(this.btnReplenishInventory);
            this.panelTop.Controls.Add(this.btnPlaceOrder);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1095, 73);
            this.panelTop.TabIndex = 0;
            // 
            // panelCash
            // 
            this.panelCash.Controls.Add(this.label12);
            this.panelCash.Controls.Add(this.txtCashTendered);
            this.panelCash.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCash.Location = new System.Drawing.Point(493, 0);
            this.panelCash.Name = "panelCash";
            this.panelCash.Size = new System.Drawing.Size(602, 73);
            this.panelCash.TabIndex = 4;
            this.panelCash.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 25);
            this.label12.TabIndex = 4;
            this.label12.Text = "Cash:";
            // 
            // txtCashTendered
            // 
            this.txtCashTendered.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCashTendered.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashTendered.Location = new System.Drawing.Point(0, 0);
            this.txtCashTendered.Name = "txtCashTendered";
            this.txtCashTendered.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCashTendered.Size = new System.Drawing.Size(602, 62);
            this.txtCashTendered.TabIndex = 3;
            this.txtCashTendered.TextChanged += new System.EventHandler(this.txtCashTendered_TextChanged);
            this.txtCashTendered.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCashTendered_KeyPress);
            // 
            // btnReturnExchange
            // 
            this.btnReturnExchange.AutoSize = true;
            this.btnReturnExchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnExchange.ForeColor = System.Drawing.Color.White;
            this.btnReturnExchange.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnReturnExchange.IconColor = System.Drawing.Color.Black;
            this.btnReturnExchange.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturnExchange.Location = new System.Drawing.Point(292, 11);
            this.btnReturnExchange.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturnExchange.Name = "btnReturnExchange";
            this.btnReturnExchange.Size = new System.Drawing.Size(162, 56);
            this.btnReturnExchange.TabIndex = 2;
            this.btnReturnExchange.Text = "[Return and Exchanges]";
            this.btnReturnExchange.UseVisualStyleBackColor = true;
            this.btnReturnExchange.Click += new System.EventHandler(this.btnReturnExchange_Click);
            // 
            // btnReplenishInventory
            // 
            this.btnReplenishInventory.AutoSize = true;
            this.btnReplenishInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplenishInventory.ForeColor = System.Drawing.Color.White;
            this.btnReplenishInventory.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnReplenishInventory.IconColor = System.Drawing.Color.Black;
            this.btnReplenishInventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReplenishInventory.Location = new System.Drawing.Point(143, 11);
            this.btnReplenishInventory.Margin = new System.Windows.Forms.Padding(2);
            this.btnReplenishInventory.Name = "btnReplenishInventory";
            this.btnReplenishInventory.Size = new System.Drawing.Size(145, 56);
            this.btnReplenishInventory.TabIndex = 1;
            this.btnReplenishInventory.Text = "[Replenish Inventory]";
            this.btnReplenishInventory.UseVisualStyleBackColor = true;
            this.btnReplenishInventory.Click += new System.EventHandler(this.btnReplenishInventory_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.AutoSize = true;
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPlaceOrder.IconColor = System.Drawing.Color.Black;
            this.btnPlaceOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlaceOrder.Location = new System.Drawing.Point(36, 11);
            this.btnPlaceOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(103, 56);
            this.btnPlaceOrder.TabIndex = 0;
            this.btnPlaceOrder.Text = "[Place Order]";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // panelPlaceOrder
            // 
            this.panelPlaceOrder.Controls.Add(this.dataGridView1);
            this.panelPlaceOrder.Controls.Add(this.panelOrderTop);
            this.panelPlaceOrder.Controls.Add(this.panelOrderControls);
            this.panelPlaceOrder.Controls.Add(this.panelPlaceOrderSide);
            this.panelPlaceOrder.Location = new System.Drawing.Point(0, 0);
            this.panelPlaceOrder.Name = "panelPlaceOrder";
            this.panelPlaceOrder.Size = new System.Drawing.Size(819, 238);
            this.panelPlaceOrder.TabIndex = 1;
            this.panelPlaceOrder.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRow,
            this.colID,
            this.colDesc,
            this.colUnitPrice,
            this.colQuantity,
            this.colTotalPrice});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(582, 174);
            this.dataGridView1.TabIndex = 5;
            // 
            // colRow
            // 
            this.colRow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colRow.HeaderText = "#";
            this.colRow.MinimumWidth = 6;
            this.colRow.Name = "colRow";
            this.colRow.ReadOnly = true;
            this.colRow.Width = 39;
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colDesc
            // 
            this.colDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDesc.HeaderText = "Description";
            this.colDesc.MinimumWidth = 6;
            this.colDesc.Name = "colDesc";
            this.colDesc.ReadOnly = true;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colUnitPrice.HeaderText = "Price";
            this.colUnitPrice.MinimumWidth = 6;
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.ReadOnly = true;
            this.colUnitPrice.Width = 56;
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
            // colTotalPrice
            // 
            this.colTotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colTotalPrice.HeaderText = "Total";
            this.colTotalPrice.MinimumWidth = 6;
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.ReadOnly = true;
            this.colTotalPrice.Width = 56;
            // 
            // panelOrderTop
            // 
            this.panelOrderTop.Controls.Add(this.btnEnter);
            this.panelOrderTop.Controls.Add(this.txtQuery);
            this.panelOrderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOrderTop.Location = new System.Drawing.Point(0, 0);
            this.panelOrderTop.Name = "panelOrderTop";
            this.panelOrderTop.Size = new System.Drawing.Size(582, 27);
            this.panelOrderTop.TabIndex = 6;
            // 
            // btnEnter
            // 
            this.btnEnter.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEnter.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEnter.IconColor = System.Drawing.Color.Black;
            this.btnEnter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEnter.Location = new System.Drawing.Point(368, 0);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(65, 27);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuery.Location = new System.Drawing.Point(0, 0);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(368, 26);
            this.txtQuery.TabIndex = 4;
            this.txtQuery.TextChanged += new System.EventHandler(this.txtQuery_TextChanged);
            this.txtQuery.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuery_KeyPress);
            // 
            // panelOrderControls
            // 
            this.panelOrderControls.Controls.Add(this.btnVoidItem);
            this.panelOrderControls.Controls.Add(this.btnAddDiscount);
            this.panelOrderControls.Controls.Add(this.btnSettle);
            this.panelOrderControls.Controls.Add(this.btnProductInquiry);
            this.panelOrderControls.Controls.Add(this.btnNewTransaction);
            this.panelOrderControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOrderControls.Location = new System.Drawing.Point(0, 201);
            this.panelOrderControls.Name = "panelOrderControls";
            this.panelOrderControls.Size = new System.Drawing.Size(582, 37);
            this.panelOrderControls.TabIndex = 4;
            // 
            // btnVoidItem
            // 
            this.btnVoidItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVoidItem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVoidItem.IconColor = System.Drawing.Color.Black;
            this.btnVoidItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVoidItem.Location = new System.Drawing.Point(463, 0);
            this.btnVoidItem.Name = "btnVoidItem";
            this.btnVoidItem.Size = new System.Drawing.Size(110, 37);
            this.btnVoidItem.TabIndex = 4;
            this.btnVoidItem.Tag = "VoidItem";
            this.btnVoidItem.Text = "[F5] - Void Item";
            this.btnVoidItem.UseVisualStyleBackColor = true;
            this.btnVoidItem.Click += new System.EventHandler(this.btnPOSControls);
            // 
            // btnAddDiscount
            // 
            this.btnAddDiscount.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddDiscount.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddDiscount.IconColor = System.Drawing.Color.Black;
            this.btnAddDiscount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddDiscount.Location = new System.Drawing.Point(353, 0);
            this.btnAddDiscount.Name = "btnAddDiscount";
            this.btnAddDiscount.Size = new System.Drawing.Size(110, 37);
            this.btnAddDiscount.TabIndex = 3;
            this.btnAddDiscount.Tag = "AddDiscount";
            this.btnAddDiscount.Text = "[F4] - Add Discount";
            this.btnAddDiscount.UseVisualStyleBackColor = true;
            this.btnAddDiscount.Click += new System.EventHandler(this.btnPOSControls);
            // 
            // btnSettle
            // 
            this.btnSettle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSettle.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSettle.IconColor = System.Drawing.Color.Black;
            this.btnSettle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettle.Location = new System.Drawing.Point(263, 0);
            this.btnSettle.Name = "btnSettle";
            this.btnSettle.Size = new System.Drawing.Size(90, 37);
            this.btnSettle.TabIndex = 2;
            this.btnSettle.Tag = "Settle";
            this.btnSettle.Text = "[F3] - Settle";
            this.btnSettle.UseVisualStyleBackColor = true;
            this.btnSettle.Click += new System.EventHandler(this.btnPOSControls);
            // 
            // btnProductInquiry
            // 
            this.btnProductInquiry.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnProductInquiry.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnProductInquiry.IconColor = System.Drawing.Color.Black;
            this.btnProductInquiry.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductInquiry.Location = new System.Drawing.Point(146, 0);
            this.btnProductInquiry.Name = "btnProductInquiry";
            this.btnProductInquiry.Size = new System.Drawing.Size(117, 37);
            this.btnProductInquiry.TabIndex = 1;
            this.btnProductInquiry.Tag = "ProductInquiry";
            this.btnProductInquiry.Text = "[F2] - Product Inquiry";
            this.btnProductInquiry.UseVisualStyleBackColor = true;
            this.btnProductInquiry.Click += new System.EventHandler(this.btnPOSControls);
            // 
            // btnNewTransaction
            // 
            this.btnNewTransaction.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNewTransaction.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNewTransaction.IconColor = System.Drawing.Color.Black;
            this.btnNewTransaction.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNewTransaction.Location = new System.Drawing.Point(0, 0);
            this.btnNewTransaction.Name = "btnNewTransaction";
            this.btnNewTransaction.Size = new System.Drawing.Size(146, 37);
            this.btnNewTransaction.TabIndex = 0;
            this.btnNewTransaction.Tag = "NewTransaction";
            this.btnNewTransaction.Text = "[F1] - New Transaction";
            this.btnNewTransaction.UseVisualStyleBackColor = true;
            this.btnNewTransaction.Click += new System.EventHandler(this.btnPOSControls);
            // 
            // panelPlaceOrderSide
            // 
            this.panelPlaceOrderSide.Controls.Add(this.panel1);
            this.panelPlaceOrderSide.Controls.Add(this.panelSaleTotalContaine);
            this.panelPlaceOrderSide.Controls.Add(this.panel2);
            this.panelPlaceOrderSide.Controls.Add(this.panel3);
            this.panelPlaceOrderSide.Controls.Add(this.panel4);
            this.panelPlaceOrderSide.Controls.Add(this.panel5);
            this.panelPlaceOrderSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPlaceOrderSide.Location = new System.Drawing.Point(582, 0);
            this.panelPlaceOrderSide.Name = "panelPlaceOrderSide";
            this.panelPlaceOrderSide.Size = new System.Drawing.Size(237, 238);
            this.panelPlaceOrderSide.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSubTotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 40);
            this.panel1.TabIndex = 6;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.Black;
            this.lblSubTotal.Location = new System.Drawing.Point(110, 11);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(44, 20);
            this.lblSubTotal.TabIndex = 2;
            this.lblSubTotal.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "SUB TOTAL:";
            // 
            // panelSaleTotalContaine
            // 
            this.panelSaleTotalContaine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.panelSaleTotalContaine.Controls.Add(this.lblSaleTotal);
            this.panelSaleTotalContaine.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSaleTotalContaine.Location = new System.Drawing.Point(0, 0);
            this.panelSaleTotalContaine.Name = "panelSaleTotalContaine";
            this.panelSaleTotalContaine.Size = new System.Drawing.Size(237, 40);
            this.panelSaleTotalContaine.TabIndex = 0;
            // 
            // lblSaleTotal
            // 
            this.lblSaleTotal.AutoSize = true;
            this.lblSaleTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSaleTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleTotal.ForeColor = System.Drawing.Color.White;
            this.lblSaleTotal.Location = new System.Drawing.Point(0, 0);
            this.lblSaleTotal.Name = "lblSaleTotal";
            this.lblSaleTotal.Size = new System.Drawing.Size(88, 39);
            this.lblSaleTotal.TabIndex = 0;
            this.lblSaleTotal.Text = "0.00";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblVAT);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 40);
            this.panel2.TabIndex = 7;
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVAT.ForeColor = System.Drawing.Color.Black;
            this.lblVAT.Location = new System.Drawing.Point(56, 9);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(44, 20);
            this.lblVAT.TabIndex = 3;
            this.lblVAT.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "VAT:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 40);
            this.panel3.TabIndex = 7;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(72, 10);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 20);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "TOTAL:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblCash);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 158);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(237, 40);
            this.panel4.TabIndex = 7;
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.ForeColor = System.Drawing.Color.Black;
            this.lblCash.Location = new System.Drawing.Point(67, 10);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(44, 20);
            this.lblCash.TabIndex = 5;
            this.lblCash.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "CASH:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblChange);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 198);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(237, 40);
            this.panel5.TabIndex = 8;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.ForeColor = System.Drawing.Color.Black;
            this.lblChange.Location = new System.Drawing.Point(94, 10);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(44, 20);
            this.lblChange.TabIndex = 6;
            this.lblChange.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "CHANGE:";
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panelReplenishInventory);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 73);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1095, 576);
            this.panelContainer.TabIndex = 2;
            // 
            // panelReplenishInventory
            // 
            this.panelReplenishInventory.Controls.Add(this.cmbWarehouse);
            this.panelReplenishInventory.Controls.Add(this.label11);
            this.panelReplenishInventory.Controls.Add(this.btnDiscard);
            this.panelReplenishInventory.Controls.Add(this.panelPlaceOrder);
            this.panelReplenishInventory.Controls.Add(this.btnSave);
            this.panelReplenishInventory.Controls.Add(this.label9);
            this.panelReplenishInventory.Controls.Add(this.dataGridView3);
            this.panelReplenishInventory.Controls.Add(this.btnEnterReplenish);
            this.panelReplenishInventory.Controls.Add(this.label8);
            this.panelReplenishInventory.Controls.Add(this.txtQuantity);
            this.panelReplenishInventory.Controls.Add(this.label7);
            this.panelReplenishInventory.Controls.Add(this.txtProductID);
            this.panelReplenishInventory.Controls.Add(this.label6);
            this.panelReplenishInventory.Controls.Add(this.txtProductName);
            this.panelReplenishInventory.Controls.Add(this.dataGridView2);
            this.panelReplenishInventory.Controls.Add(this.panel6);
            this.panelReplenishInventory.Location = new System.Drawing.Point(1095, 649);
            this.panelReplenishInventory.Name = "panelReplenishInventory";
            this.panelReplenishInventory.Size = new System.Drawing.Size(929, 509);
            this.panelReplenishInventory.TabIndex = 2;
            this.panelReplenishInventory.Visible = false;
            // 
            // cmbWarehouse
            // 
            this.cmbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWarehouse.FormattingEnabled = true;
            this.cmbWarehouse.Location = new System.Drawing.Point(602, 145);
            this.cmbWarehouse.Name = "cmbWarehouse";
            this.cmbWarehouse.Size = new System.Drawing.Size(223, 21);
            this.cmbWarehouse.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(526, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Warehouse";
            // 
            // btnDiscard
            // 
            this.btnDiscard.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDiscard.IconColor = System.Drawing.Color.Black;
            this.btnDiscard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDiscard.Location = new System.Drawing.Point(750, 189);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(75, 22);
            this.btnDiscard.TabIndex = 16;
            this.btnDiscard.Text = "[Discard]";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // btnSave
            // 
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSave.IconColor = System.Drawing.Color.Black;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.Location = new System.Drawing.Point(669, 189);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 22);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "[Save]";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(514, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Products:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductID,
            this.colProductName,
            this.colPQuantity});
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView3.Location = new System.Drawing.Point(514, 226);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(415, 283);
            this.dataGridView3.TabIndex = 11;
            // 
            // colProductID
            // 
            this.colProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProductID.HeaderText = "#";
            this.colProductID.MinimumWidth = 6;
            this.colProductID.Name = "colProductID";
            this.colProductID.ReadOnly = true;
            // 
            // colProductName
            // 
            this.colProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colProductName.HeaderText = "ProductName";
            this.colProductName.MinimumWidth = 6;
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            this.colProductName.Width = 97;
            // 
            // colPQuantity
            // 
            this.colPQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colPQuantity.HeaderText = "Quantity";
            this.colPQuantity.MinimumWidth = 6;
            this.colPQuantity.Name = "colPQuantity";
            this.colPQuantity.ReadOnly = true;
            this.colPQuantity.Width = 71;
            // 
            // btnEnterReplenish
            // 
            this.btnEnterReplenish.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEnterReplenish.IconColor = System.Drawing.Color.Black;
            this.btnEnterReplenish.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEnterReplenish.Location = new System.Drawing.Point(832, 62);
            this.btnEnterReplenish.Name = "btnEnterReplenish";
            this.btnEnterReplenish.Size = new System.Drawing.Size(75, 22);
            this.btnEnterReplenish.TabIndex = 10;
            this.btnEnterReplenish.Text = "[Enter]";
            this.btnEnterReplenish.UseVisualStyleBackColor = true;
            this.btnEnterReplenish.Click += new System.EventHandler(this.btnEnterReplenish_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(524, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(602, 119);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(224, 20);
            this.txtQuantity.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(524, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "ProductName";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(602, 64);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(224, 20);
            this.txtProductID.TabIndex = 6;
            this.txtProductID.TextChanged += new System.EventHandler(this.txtProductID_TextChanged);
            this.txtProductID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductID_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(524, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ProductID";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(602, 93);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(224, 20);
            this.txtProductName.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMovementID,
            this.colProductIDH,
            this.colWarehouse,
            this.colMovementType,
            this.colMovementDate,
            this.colQuantityH});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView2.Location = new System.Drawing.Point(0, 45);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(514, 464);
            this.dataGridView2.TabIndex = 2;
            // 
            // colMovementID
            // 
            this.colMovementID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colMovementID.HeaderText = "#";
            this.colMovementID.MinimumWidth = 6;
            this.colMovementID.Name = "colMovementID";
            this.colMovementID.ReadOnly = true;
            this.colMovementID.Width = 39;
            // 
            // colProductIDH
            // 
            this.colProductIDH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProductIDH.HeaderText = "ProductID";
            this.colProductIDH.MinimumWidth = 6;
            this.colProductIDH.Name = "colProductIDH";
            this.colProductIDH.ReadOnly = true;
            // 
            // colWarehouse
            // 
            this.colWarehouse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colWarehouse.HeaderText = "Warehouse";
            this.colWarehouse.MinimumWidth = 6;
            this.colWarehouse.Name = "colWarehouse";
            this.colWarehouse.ReadOnly = true;
            this.colWarehouse.Width = 87;
            // 
            // colMovementType
            // 
            this.colMovementType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colMovementType.HeaderText = "MovementType";
            this.colMovementType.MinimumWidth = 6;
            this.colMovementType.Name = "colMovementType";
            this.colMovementType.ReadOnly = true;
            this.colMovementType.Width = 106;
            // 
            // colMovementDate
            // 
            this.colMovementDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colMovementDate.HeaderText = "Date";
            this.colMovementDate.MinimumWidth = 6;
            this.colMovementDate.Name = "colMovementDate";
            this.colMovementDate.ReadOnly = true;
            this.colMovementDate.Width = 55;
            // 
            // colQuantityH
            // 
            this.colQuantityH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colQuantityH.HeaderText = "Quantity";
            this.colQuantityH.MinimumWidth = 6;
            this.colQuantityH.Name = "colQuantityH";
            this.colQuantityH.ReadOnly = true;
            this.colQuantityH.Width = 71;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label10);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(929, 45);
            this.panel6.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "History:";
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 649);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmOrder";
            this.Text = "btnOrder";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmOrder_KeyPress);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelCash.ResumeLayout(false);
            this.panelCash.PerformLayout();
            this.panelPlaceOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelOrderTop.ResumeLayout(false);
            this.panelOrderTop.PerformLayout();
            this.panelOrderControls.ResumeLayout(false);
            this.panelPlaceOrderSide.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSaleTotalContaine.ResumeLayout(false);
            this.panelSaleTotalContaine.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.panelReplenishInventory.ResumeLayout(false);
            this.panelReplenishInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton btnReturnExchange;
        private FontAwesome.Sharp.IconButton btnReplenishInventory;
        private FontAwesome.Sharp.IconButton btnPlaceOrder;
        private System.Windows.Forms.Panel panelPlaceOrder;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelOrderControls;
        private FontAwesome.Sharp.IconButton btnAddDiscount;
        private FontAwesome.Sharp.IconButton btnSettle;
        private FontAwesome.Sharp.IconButton btnProductInquiry;
        private FontAwesome.Sharp.IconButton btnNewTransaction;
        private System.Windows.Forms.Panel panelPlaceOrderSide;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelSaleTotalContaine;
        private System.Windows.Forms.Label lblSaleTotal;
        private System.Windows.Forms.Panel panelOrderTop;
        private FontAwesome.Sharp.IconButton btnEnter;
        private System.Windows.Forms.TextBox txtQuery;
        private FontAwesome.Sharp.IconButton btnVoidItem;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Panel panelReplenishInventory;
        private FontAwesome.Sharp.IconButton btnDiscard;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPQuantity;
        private FontAwesome.Sharp.IconButton btnEnterReplenish;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMovementID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductIDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMovementType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMovementDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantityH;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalPrice;
        private System.Windows.Forms.ComboBox cmbWarehouse;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCashTendered;
        private System.Windows.Forms.Panel panelCash;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}