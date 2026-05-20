using System.Drawing;
using System.Windows.Forms;

namespace DebtManagementSystem
{
    partial class Main_Menu
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.sideBarPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFlappyJuds = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.sideBarPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mainPanel);
            this.panel2.Controls.Add(this.sideBarPanel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1902, 1033);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(816, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 0);
            this.label2.TabIndex = 0;
            this.label2.Text = "Debt Management System";
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Location = new System.Drawing.Point(482, 3);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1417, 1027);
            this.mainPanel.TabIndex = 3;
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.Controls.Add(this.panel1);
            this.sideBarPanel.Controls.Add(this.headerPanel);
            this.sideBarPanel.Location = new System.Drawing.Point(3, 3);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(473, 1027);
            this.sideBarPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.btnFlappyJuds);
            this.panel1.Controls.Add(this.btnTransactions);
            this.panel1.Controls.Add(this.btnProducts);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Location = new System.Drawing.Point(3, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 437);
            this.panel1.TabIndex = 7;
            // 
            // btnFlappyJuds
            // 
            this.btnFlappyJuds.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFlappyJuds.Location = new System.Drawing.Point(3, 227);
            this.btnFlappyJuds.Name = "btnFlappyJuds";
            this.btnFlappyJuds.Size = new System.Drawing.Size(288, 50);
            this.btnFlappyJuds.TabIndex = 11;
            this.btnFlappyJuds.Text = "Flappy Juds";
            this.btnFlappyJuds.UseVisualStyleBackColor = true;
            // 
            // btnTransactions
            // 
            this.btnTransactions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTransactions.Location = new System.Drawing.Point(3, 171);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(288, 50);
            this.btnTransactions.TabIndex = 9;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnProducts.Location = new System.Drawing.Point(3, 115);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(288, 50);
            this.btnProducts.TabIndex = 8;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCustomers.Location = new System.Drawing.Point(3, 59);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(288, 50);
            this.btnCustomers.TabIndex = 7;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDashboard.Location = new System.Drawing.Point(3, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(288, 50);
            this.btnDashboard.TabIndex = 6;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Location = new System.Drawing.Point(89, 3);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(294, 200);
            this.headerPanel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 138);
            this.label1.TabIndex = 0;
            this.label1.Text = "Debt Management System";
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel2);
            this.Name = "Main_Menu";
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            this.panel2.ResumeLayout(false);
            this.sideBarPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button currentButton;
        private Panel panel2;
        private Label label2;
        private Panel mainPanel;
        private Panel sideBarPanel;
        private Panel panel1;
        private Button btnFlappyJuds;
        private Button btnTransactions;
        private Button btnProducts;
        private Button btnCustomers;
        private Button btnDashboard;
        private Panel headerPanel;
        private Label label1;
    }
}

