namespace Inventory_Management_System.Dashboard.frmPanelContainers
{
    partial class frmSalesReport
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toDate_StockMovement = new System.Windows.Forms.DateTimePicker();
            this.fromDate_StockMovement = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboStockMovement_Movement = new System.Windows.Forms.ComboBox();
            this.cboStockMovement_Warehouse = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStockMovement_ProductID = new System.Windows.Forms.TextBox();
            this.dataGridStockMovement = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMovementType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMovementDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMovementQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStockMovement_Search = new FontAwesome.Sharp.IconButton();
            this.btnStockMovement_ClearFilters = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStockMovement)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 50);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(10, 0);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1095, 599);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.dataGridStockMovement);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(952, 702);
            this.panel3.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.AutoScroll = true;
            this.panel7.Controls.Add(this.btnStockMovement_Search);
            this.panel7.Controls.Add(this.groupBox1);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.txtStockMovement_ProductID);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 599);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(952, 103);
            this.panel7.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStockMovement_ClearFilters);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.toDate_StockMovement);
            this.groupBox1.Controls.Add(this.fromDate_StockMovement);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboStockMovement_Movement);
            this.groupBox1.Controls.Add(this.cboStockMovement_Warehouse);
            this.groupBox1.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 97);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(583, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "To";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(433, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Date";
            // 
            // toDate_StockMovement
            // 
            this.toDate_StockMovement.CustomFormat = "MM/dd/yyyy";
            this.toDate_StockMovement.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDate_StockMovement.Location = new System.Drawing.Point(611, 23);
            this.toDate_StockMovement.Name = "toDate_StockMovement";
            this.toDate_StockMovement.Size = new System.Drawing.Size(97, 23);
            this.toDate_StockMovement.TabIndex = 2;
            // 
            // fromDate_StockMovement
            // 
            this.fromDate_StockMovement.CustomFormat = "MM/dd/yyyy";
            this.fromDate_StockMovement.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDate_StockMovement.Location = new System.Drawing.Point(474, 24);
            this.fromDate_StockMovement.Name = "fromDate_StockMovement";
            this.fromDate_StockMovement.Size = new System.Drawing.Size(97, 23);
            this.fromDate_StockMovement.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Movement";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Warehouse";
            // 
            // cboStockMovement_Movement
            // 
            this.cboStockMovement_Movement.FormattingEnabled = true;
            this.cboStockMovement_Movement.Items.AddRange(new object[] {
            "Inbound",
            "Outbound",
            "Both"});
            this.cboStockMovement_Movement.Location = new System.Drawing.Point(307, 22);
            this.cboStockMovement_Movement.Name = "cboStockMovement_Movement";
            this.cboStockMovement_Movement.Size = new System.Drawing.Size(121, 23);
            this.cboStockMovement_Movement.TabIndex = 0;
            // 
            // cboStockMovement_Warehouse
            // 
            this.cboStockMovement_Warehouse.FormattingEnabled = true;
            this.cboStockMovement_Warehouse.Location = new System.Drawing.Point(90, 23);
            this.cboStockMovement_Warehouse.Name = "cboStockMovement_Warehouse";
            this.cboStockMovement_Warehouse.Size = new System.Drawing.Size(121, 23);
            this.cboStockMovement_Warehouse.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(740, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "ProductID:";
            // 
            // txtStockMovement_ProductID
            // 
            this.txtStockMovement_ProductID.Location = new System.Drawing.Point(740, 28);
            this.txtStockMovement_ProductID.Name = "txtStockMovement_ProductID";
            this.txtStockMovement_ProductID.Size = new System.Drawing.Size(209, 20);
            this.txtStockMovement_ProductID.TabIndex = 0;
            // 
            // dataGridStockMovement
            // 
            this.dataGridStockMovement.AllowUserToAddRows = false;
            this.dataGridStockMovement.AllowUserToDeleteRows = false;
            this.dataGridStockMovement.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridStockMovement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridStockMovement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStockMovement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colProductName,
            this.colWarehouse,
            this.colMovementType,
            this.colMovementDate,
            this.colMovementQuantity});
            this.dataGridStockMovement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridStockMovement.Location = new System.Drawing.Point(0, 40);
            this.dataGridStockMovement.Name = "dataGridStockMovement";
            this.dataGridStockMovement.ReadOnly = true;
            this.dataGridStockMovement.RowHeadersVisible = false;
            this.dataGridStockMovement.Size = new System.Drawing.Size(952, 662);
            this.dataGridStockMovement.TabIndex = 1;
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colID.HeaderText = "#";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 39;
            // 
            // colProductName
            // 
            this.colProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProductName.HeaderText = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            // 
            // colWarehouse
            // 
            this.colWarehouse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colWarehouse.HeaderText = "Warehouse";
            this.colWarehouse.Name = "colWarehouse";
            this.colWarehouse.ReadOnly = true;
            // 
            // colMovementType
            // 
            this.colMovementType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colMovementType.HeaderText = "Movement";
            this.colMovementType.Name = "colMovementType";
            this.colMovementType.ReadOnly = true;
            this.colMovementType.Width = 82;
            // 
            // colMovementDate
            // 
            this.colMovementDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colMovementDate.HeaderText = "Date";
            this.colMovementDate.Name = "colMovementDate";
            this.colMovementDate.ReadOnly = true;
            this.colMovementDate.Width = 55;
            // 
            // colMovementQuantity
            // 
            this.colMovementQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colMovementQuantity.HeaderText = "Quantity";
            this.colMovementQuantity.Name = "colMovementQuantity";
            this.colMovementQuantity.ReadOnly = true;
            this.colMovementQuantity.Width = 71;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(952, 40);
            this.panel6.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label1.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Movements";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 711);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panel2.Size = new System.Drawing.Size(952, 500);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(3, 1217);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panel4.Size = new System.Drawing.Size(952, 500);
            this.panel4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "label1";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(3, 1723);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panel5.Size = new System.Drawing.Size(952, 500);
            this.panel5.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "label1";
            // 
            // btnStockMovement_Search
            // 
            this.btnStockMovement_Search.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnStockMovement_Search.IconColor = System.Drawing.Color.Black;
            this.btnStockMovement_Search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStockMovement_Search.Location = new System.Drawing.Point(740, 54);
            this.btnStockMovement_Search.Name = "btnStockMovement_Search";
            this.btnStockMovement_Search.Size = new System.Drawing.Size(90, 29);
            this.btnStockMovement_Search.TabIndex = 3;
            this.btnStockMovement_Search.Text = "[Search]";
            this.btnStockMovement_Search.UseVisualStyleBackColor = true;
            this.btnStockMovement_Search.Click += new System.EventHandler(this.btnStockMovement_Search_Click);
            // 
            // btnStockMovement_ClearFilters
            // 
            this.btnStockMovement_ClearFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnStockMovement_ClearFilters.ForeColor = System.Drawing.Color.Black;
            this.btnStockMovement_ClearFilters.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnStockMovement_ClearFilters.IconColor = System.Drawing.Color.Black;
            this.btnStockMovement_ClearFilters.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStockMovement_ClearFilters.Location = new System.Drawing.Point(6, 60);
            this.btnStockMovement_ClearFilters.Name = "btnStockMovement_ClearFilters";
            this.btnStockMovement_ClearFilters.Size = new System.Drawing.Size(90, 31);
            this.btnStockMovement_ClearFilters.TabIndex = 3;
            this.btnStockMovement_ClearFilters.Text = "[Clear Filters]";
            this.btnStockMovement_ClearFilters.UseVisualStyleBackColor = true;
            this.btnStockMovement_ClearFilters.Click += new System.EventHandler(this.btnStockMovement_ClearFilters_Click);
            // 
            // frmSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 649);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSalesReport";
            this.Text = "frmSalesReport";
            this.Load += new System.EventHandler(this.frmSalesReport_Load);
            this.Resize += new System.EventHandler(this.frmSalesReport_Resize);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStockMovement)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridStockMovement;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMovementType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMovementDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMovementQuantity;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStockMovement_ProductID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboStockMovement_Movement;
        private System.Windows.Forms.ComboBox cboStockMovement_Warehouse;
        private System.Windows.Forms.DateTimePicker toDate_StockMovement;
        private System.Windows.Forms.DateTimePicker fromDate_StockMovement;
        private FontAwesome.Sharp.IconButton btnFilter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnStockMovement_Search;
        private FontAwesome.Sharp.IconButton btnStockMovement_ClearFilters;
    }
}