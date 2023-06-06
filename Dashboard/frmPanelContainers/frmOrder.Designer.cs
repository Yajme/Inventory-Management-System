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
            this.btnReturnExchange = new FontAwesome.Sharp.IconButton();
            this.btnPlaceOrder = new FontAwesome.Sharp.IconButton();
            this.btnReplenishInventory = new FontAwesome.Sharp.IconButton();
            this.panelPlaceOrder = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelOrderTop = new System.Windows.Forms.Panel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.panelOrderControls = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.btnProductInquiry = new FontAwesome.Sharp.IconButton();
            this.btnNewTransaction = new FontAwesome.Sharp.IconButton();
            this.panelPlaceOrderSide = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSaleTotalContaine = new System.Windows.Forms.Panel();
            this.lblSaleTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.panelReplenishInventory = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
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
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panelTop.Controls.Add(this.btnReturnExchange);
            this.panelTop.Controls.Add(this.btnPlaceOrder);
            this.panelTop.Controls.Add(this.btnReplenishInventory);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1095, 73);
            this.panelTop.TabIndex = 0;
            // 
            // btnReturnExchange
            // 
            this.btnReturnExchange.AutoSize = true;
            this.btnReturnExchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnExchange.ForeColor = System.Drawing.Color.White;
            this.btnReturnExchange.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnReturnExchange.IconColor = System.Drawing.Color.Black;
            this.btnReturnExchange.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturnExchange.Location = new System.Drawing.Point(246, 9);
            this.btnReturnExchange.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturnExchange.Name = "btnReturnExchange";
            this.btnReturnExchange.Size = new System.Drawing.Size(134, 56);
            this.btnReturnExchange.TabIndex = 2;
            this.btnReturnExchange.Text = "[Return and Exchanges]";
            this.btnReturnExchange.UseVisualStyleBackColor = true;
            this.btnReturnExchange.Click += new System.EventHandler(this.btnReturnExchange_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.AutoSize = true;
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPlaceOrder.IconColor = System.Drawing.Color.Black;
            this.btnPlaceOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlaceOrder.Location = new System.Drawing.Point(9, 9);
            this.btnPlaceOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(81, 56);
            this.btnPlaceOrder.TabIndex = 0;
            this.btnPlaceOrder.Text = "[Place Order]";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnReplenishInventory
            // 
            this.btnReplenishInventory.AutoSize = true;
            this.btnReplenishInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplenishInventory.ForeColor = System.Drawing.Color.White;
            this.btnReplenishInventory.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnReplenishInventory.IconColor = System.Drawing.Color.Black;
            this.btnReplenishInventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReplenishInventory.Location = new System.Drawing.Point(103, 9);
            this.btnReplenishInventory.Margin = new System.Windows.Forms.Padding(2);
            this.btnReplenishInventory.Name = "btnReplenishInventory";
            this.btnReplenishInventory.Size = new System.Drawing.Size(129, 56);
            this.btnReplenishInventory.TabIndex = 1;
            this.btnReplenishInventory.Text = "[Replenish Inventory]";
            this.btnReplenishInventory.UseVisualStyleBackColor = true;
            this.btnReplenishInventory.Click += new System.EventHandler(this.btnReplenishInventory_Click);
            // 
            // panelPlaceOrder
            // 
            this.panelPlaceOrder.Controls.Add(this.dataGridView1);
            this.panelPlaceOrder.Controls.Add(this.panelOrderTop);
            this.panelPlaceOrder.Controls.Add(this.panelOrderControls);
            this.panelPlaceOrder.Controls.Add(this.panelPlaceOrderSide);
            this.panelPlaceOrder.Location = new System.Drawing.Point(1075, 549);
            this.panelPlaceOrder.Name = "panelPlaceOrder";
            this.panelPlaceOrder.Size = new System.Drawing.Size(809, 579);
            this.panelPlaceOrder.TabIndex = 1;
            this.panelPlaceOrder.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRow,
            this.colDesc,
            this.colUnitPrice,
            this.colQuantity,
            this.colTotalPrice});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(572, 515);
            this.dataGridView1.TabIndex = 5;
            // 
            // colRow
            // 
            this.colRow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colRow.HeaderText = "#";
            this.colRow.Name = "colRow";
            this.colRow.ReadOnly = true;
            this.colRow.Width = 39;
            // 
            // colDesc
            // 
            this.colDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDesc.HeaderText = "Description";
            this.colDesc.Name = "colDesc";
            this.colDesc.ReadOnly = true;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colUnitPrice.HeaderText = "Price";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.ReadOnly = true;
            this.colUnitPrice.Width = 56;
            // 
            // colQuantity
            // 
            this.colQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.Width = 71;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colTotalPrice.HeaderText = "Total";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.ReadOnly = true;
            this.colTotalPrice.Width = 56;
            // 
            // panelOrderTop
            // 
            this.panelOrderTop.Controls.Add(this.iconButton4);
            this.panelOrderTop.Controls.Add(this.txtQuery);
            this.panelOrderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOrderTop.Location = new System.Drawing.Point(0, 0);
            this.panelOrderTop.Name = "panelOrderTop";
            this.panelOrderTop.Size = new System.Drawing.Size(572, 27);
            this.panelOrderTop.TabIndex = 6;
            // 
            // iconButton4
            // 
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.Location = new System.Drawing.Point(368, 0);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(65, 27);
            this.iconButton4.TabIndex = 5;
            this.iconButton4.Text = "Enter";
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // txtQuery
            // 
            this.txtQuery.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuery.Location = new System.Drawing.Point(0, 0);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(368, 26);
            this.txtQuery.TabIndex = 4;
            // 
            // panelOrderControls
            // 
            this.panelOrderControls.Controls.Add(this.iconButton1);
            this.panelOrderControls.Controls.Add(this.iconButton8);
            this.panelOrderControls.Controls.Add(this.iconButton7);
            this.panelOrderControls.Controls.Add(this.btnProductInquiry);
            this.panelOrderControls.Controls.Add(this.btnNewTransaction);
            this.panelOrderControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOrderControls.Location = new System.Drawing.Point(0, 542);
            this.panelOrderControls.Name = "panelOrderControls";
            this.panelOrderControls.Size = new System.Drawing.Size(572, 37);
            this.panelOrderControls.TabIndex = 4;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(463, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(110, 37);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "[F5] - Void Item";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton8
            // 
            this.iconButton8.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton8.IconColor = System.Drawing.Color.Black;
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.Location = new System.Drawing.Point(353, 0);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Size = new System.Drawing.Size(110, 37);
            this.iconButton8.TabIndex = 3;
            this.iconButton8.Text = "[F4] - Add Discount";
            this.iconButton8.UseVisualStyleBackColor = true;
            // 
            // iconButton7
            // 
            this.iconButton7.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton7.IconColor = System.Drawing.Color.Black;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.Location = new System.Drawing.Point(263, 0);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(90, 37);
            this.iconButton7.TabIndex = 2;
            this.iconButton7.Text = "[F3] - Settle";
            this.iconButton7.UseVisualStyleBackColor = true;
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
            this.btnProductInquiry.Text = "[F2] - Product Inquiry";
            this.btnProductInquiry.UseVisualStyleBackColor = true;
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
            this.btnNewTransaction.Text = "[F1] - New Transaction";
            this.btnNewTransaction.UseVisualStyleBackColor = true;
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
            this.panelPlaceOrderSide.Location = new System.Drawing.Point(572, 0);
            this.panelPlaceOrderSide.Name = "panelPlaceOrderSide";
            this.panelPlaceOrderSide.Size = new System.Drawing.Size(237, 579);
            this.panelPlaceOrderSide.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSubTotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 40);
            this.panel1.TabIndex = 6;
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
            this.lblSaleTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleTotal.ForeColor = System.Drawing.Color.White;
            this.lblSaleTotal.Location = new System.Drawing.Point(3, 8);
            this.lblSaleTotal.Name = "lblSaleTotal";
            this.lblSaleTotal.Size = new System.Drawing.Size(44, 20);
            this.lblSaleTotal.TabIndex = 0;
            this.lblSaleTotal.Text = "0.00";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblVAT);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 419);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 40);
            this.panel2.TabIndex = 7;
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
            this.panel3.Location = new System.Drawing.Point(0, 459);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 40);
            this.panel3.TabIndex = 7;
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
            this.panel4.Location = new System.Drawing.Point(0, 499);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(237, 40);
            this.panel4.TabIndex = 7;
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
            this.panel5.Location = new System.Drawing.Point(0, 539);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(237, 40);
            this.panel5.TabIndex = 8;
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
            this.panelContainer.Controls.Add(this.panelPlaceOrder);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 73);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1095, 576);
            this.panelContainer.TabIndex = 2;
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
            // panelReplenishInventory
            // 
            this.panelReplenishInventory.Location = new System.Drawing.Point(0, 32);
            this.panelReplenishInventory.Name = "panelReplenishInventory";
            this.panelReplenishInventory.Size = new System.Drawing.Size(1095, 511);
            this.panelReplenishInventory.TabIndex = 2;
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
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalPrice;
        private System.Windows.Forms.Panel panelOrderControls;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton btnProductInquiry;
        private FontAwesome.Sharp.IconButton btnNewTransaction;
        private System.Windows.Forms.Panel panelPlaceOrderSide;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelSaleTotalContaine;
        private System.Windows.Forms.Label lblSaleTotal;
        private System.Windows.Forms.Panel panelOrderTop;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.TextBox txtQuery;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Panel panelReplenishInventory;
    }
}