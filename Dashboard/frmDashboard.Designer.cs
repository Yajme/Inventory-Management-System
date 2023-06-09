﻿namespace Inventory_Management_System.Dashboard
{
    partial class frmDashboard
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
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnSalesReport = new FontAwesome.Sharp.IconButton();
            this.btnInventory = new FontAwesome.Sharp.IconButton();
            this.btnOrder = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelSideTop = new System.Windows.Forms.Panel();
            this.btnShowHidePanel = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sidePanel.SuspendLayout();
            this.panelSideTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.AutoScroll = true;
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.sidePanel.Controls.Add(this.btnSettings);
            this.sidePanel.Controls.Add(this.btnLogout);
            this.sidePanel.Controls.Add(this.btnExit);
            this.sidePanel.Controls.Add(this.btnSalesReport);
            this.sidePanel.Controls.Add(this.btnInventory);
            this.sidePanel.Controls.Add(this.btnOrder);
            this.sidePanel.Controls.Add(this.btnHome);
            this.sidePanel.Controls.Add(this.panelSideTop);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(2);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(169, 681);
            this.sidePanel.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.btnSettings.IconColor = System.Drawing.Color.White;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.IconSize = 35;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 555);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(169, 42);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnLogout.IconColor = System.Drawing.Color.White;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 35;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 597);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(169, 42);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 35;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 639);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(169, 42);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalesReport.FlatAppearance.BorderSize = 0;
            this.btnSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesReport.ForeColor = System.Drawing.Color.White;
            this.btnSalesReport.IconChar = FontAwesome.Sharp.IconChar.LineChart;
            this.btnSalesReport.IconColor = System.Drawing.Color.White;
            this.btnSalesReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalesReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesReport.Location = new System.Drawing.Point(0, 332);
            this.btnSalesReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(169, 48);
            this.btnSalesReport.TabIndex = 4;
            this.btnSalesReport.Tag = "btnSalesReport";
            this.btnSalesReport.Text = "Sales Report";
            this.btnSalesReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalesReport.UseVisualStyleBackColor = true;
            this.btnSalesReport.Click += new System.EventHandler(this.btnPanel);
            // 
            // btnInventory
            // 
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnInventory.IconColor = System.Drawing.Color.White;
            this.btnInventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(0, 284);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(2);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(169, 48);
            this.btnInventory.TabIndex = 3;
            this.btnInventory.Tag = "btnInventory";
            this.btnInventory.Text = "Inventory";
            this.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnPanel);
            // 
            // btnOrder
            // 
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnOrder.IconColor = System.Drawing.Color.White;
            this.btnOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(0, 236);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(169, 48);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Tag = "btnOrder";
            this.btnOrder.Text = "Order";
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnPanel);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 188);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(169, 48);
            this.btnHome.TabIndex = 1;
            this.btnHome.Tag = "btnHome";
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnPanel);
            // 
            // panelSideTop
            // 
            this.panelSideTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panelSideTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelSideTop.Controls.Add(this.pictureBox1);
            this.panelSideTop.Controls.Add(this.btnShowHidePanel);
            this.panelSideTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSideTop.Location = new System.Drawing.Point(0, 0);
            this.panelSideTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelSideTop.Name = "panelSideTop";
            this.panelSideTop.Size = new System.Drawing.Size(169, 188);
            this.panelSideTop.TabIndex = 0;
            // 
            // btnShowHidePanel
            // 
            this.btnShowHidePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowHidePanel.FlatAppearance.BorderSize = 0;
            this.btnShowHidePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowHidePanel.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            this.btnShowHidePanel.IconColor = System.Drawing.Color.White;
            this.btnShowHidePanel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowHidePanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowHidePanel.Location = new System.Drawing.Point(0, 0);
            this.btnShowHidePanel.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowHidePanel.Name = "btnShowHidePanel";
            this.btnShowHidePanel.Size = new System.Drawing.Size(169, 39);
            this.btnShowHidePanel.TabIndex = 1;
            this.btnShowHidePanel.UseVisualStyleBackColor = true;
            this.btnShowHidePanel.Click += new System.EventHandler(this.btnShowHidePanel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(169, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1095, 32);
            this.panel2.TabIndex = 1;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(169, 32);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1095, 649);
            this.panelContainer.TabIndex = 2;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Inventory_Management_System.Properties.Resources.inventory_management;
            this.pictureBox1.Location = new System.Drawing.Point(0, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sidePanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDashboard_FormClosing);
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.sidePanel.ResumeLayout(false);
            this.panelSideTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnSalesReport;
        private FontAwesome.Sharp.IconButton btnInventory;
        private FontAwesome.Sharp.IconButton btnOrder;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel panelSideTop;
        private System.Windows.Forms.Panel panelContainer;
        private FontAwesome.Sharp.IconButton btnShowHidePanel;
        private FontAwesome.Sharp.IconButton btnSettings;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}