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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.sideBarPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFlappyJuds = new System.Windows.Forms.Button();
            this.btnPaymens = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.sideBarPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.BackColor = System.Drawing.Color.Transparent;
            this.sideBarPanel.Controls.Add(this.panel1);
            this.sideBarPanel.Controls.Add(this.headerPanel);
            this.sideBarPanel.Location = new System.Drawing.Point(12, 12);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(300, 649);
            this.sideBarPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnFlappyJuds);
            this.panel1.Controls.Add(this.btnPaymens);
            this.panel1.Controls.Add(this.btnTransactions);
            this.panel1.Controls.Add(this.btnProducts);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Location = new System.Drawing.Point(3, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 354);
            this.panel1.TabIndex = 7;
            // 
            // btnFlappyJuds
            // 
            this.btnFlappyJuds.Location = new System.Drawing.Point(3, 293);
            this.btnFlappyJuds.Name = "btnFlappyJuds";
            this.btnFlappyJuds.Size = new System.Drawing.Size(288, 50);
            this.btnFlappyJuds.TabIndex = 11;
            this.btnFlappyJuds.Text = "Flappy Juds";
            this.btnFlappyJuds.UseVisualStyleBackColor = true;
            // 
            // btnPaymens
            // 
            this.btnPaymens.Location = new System.Drawing.Point(3, 237);
            this.btnPaymens.Name = "btnPaymens";
            this.btnPaymens.Size = new System.Drawing.Size(288, 50);
            this.btnPaymens.TabIndex = 10;
            this.btnPaymens.Text = "Payments";
            this.btnPaymens.UseVisualStyleBackColor = true;
            this.btnPaymens.Click += new System.EventHandler(this.btnPaymens_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.Location = new System.Drawing.Point(3, 181);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(288, 50);
            this.btnTransactions.TabIndex = 9;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(3, 125);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(288, 50);
            this.btnProducts.TabIndex = 8;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(3, 69);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(288, 50);
            this.btnCustomers.TabIndex = 7;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(3, 13);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(288, 50);
            this.btnDashboard.TabIndex = 6;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Location = new System.Drawing.Point(3, 3);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(294, 200);
            this.headerPanel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 157);
            this.label1.TabIndex = 0;
            this.label1.Text = "Debt Management System";
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Location = new System.Drawing.Point(318, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(932, 649);
            this.mainPanel.TabIndex = 1;
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sideBarPanel);
            this.Name = "Main_Menu";
            this.sideBarPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBarPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button currentButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFlappyJuds;
        private System.Windows.Forms.Button btnPaymens;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnCustomers;
        private Button btnDashboard;
    }
}

