namespace DebtManagementSystem
{
    partial class DashboardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DashboardPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowTopDebtors = new System.Windows.Forms.FlowLayoutPanel();
            this.flowRecentTransactions = new System.Windows.Forms.FlowLayoutPanel();
            this.totalDebt = new System.Windows.Forms.Panel();
            this.lblNumDebt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalProducts = new System.Windows.Forms.Panel();
            this.lblNumProducts = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalCustomer = new System.Windows.Forms.Panel();
            this.lblNumCustomer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DashboardPanel.SuspendLayout();
            this.totalDebt.SuspendLayout();
            this.totalProducts.SuspendLayout();
            this.totalCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.Controls.Add(this.label6);
            this.DashboardPanel.Controls.Add(this.label5);
            this.DashboardPanel.Controls.Add(this.label1);
            this.DashboardPanel.Controls.Add(this.flowTopDebtors);
            this.DashboardPanel.Controls.Add(this.flowRecentTransactions);
            this.DashboardPanel.Controls.Add(this.totalDebt);
            this.DashboardPanel.Controls.Add(this.totalProducts);
            this.DashboardPanel.Controls.Add(this.totalCustomer);
            this.DashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(932, 649);
            this.DashboardPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dashboard";
            // 
            // flowTopDebtors
            // 
            this.flowTopDebtors.AutoScroll = true;
            this.flowTopDebtors.Location = new System.Drawing.Point(630, 317);
            this.flowTopDebtors.Name = "flowTopDebtors";
            this.flowTopDebtors.Size = new System.Drawing.Size(270, 303);
            this.flowTopDebtors.TabIndex = 4;
            // 
            // flowRecentTransactions
            // 
            this.flowRecentTransactions.AutoScroll = true;
            this.flowRecentTransactions.Location = new System.Drawing.Point(27, 317);
            this.flowRecentTransactions.Name = "flowRecentTransactions";
            this.flowRecentTransactions.Size = new System.Drawing.Size(582, 303);
            this.flowRecentTransactions.TabIndex = 3;
            // 
            // totalDebt
            // 
            this.totalDebt.BackColor = System.Drawing.Color.White;
            this.totalDebt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalDebt.Controls.Add(this.lblNumDebt);
            this.totalDebt.Controls.Add(this.label4);
            this.totalDebt.Location = new System.Drawing.Point(630, 86);
            this.totalDebt.Name = "totalDebt";
            this.totalDebt.Size = new System.Drawing.Size(280, 171);
            this.totalDebt.TabIndex = 2;
            // 
            // lblNumDebt
            // 
            this.lblNumDebt.AutoSize = true;
            this.lblNumDebt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDebt.ForeColor = System.Drawing.Color.Red;
            this.lblNumDebt.Location = new System.Drawing.Point(69, 85);
            this.lblNumDebt.Name = "lblNumDebt";
            this.lblNumDebt.Size = new System.Drawing.Size(60, 28);
            this.lblNumDebt.TabIndex = 3;
            this.lblNumDebt.Text = "1000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 38);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total Debt";
            // 
            // totalProducts
            // 
            this.totalProducts.BackColor = System.Drawing.Color.White;
            this.totalProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalProducts.Controls.Add(this.lblNumProducts);
            this.totalProducts.Controls.Add(this.label3);
            this.totalProducts.Location = new System.Drawing.Point(329, 86);
            this.totalProducts.Name = "totalProducts";
            this.totalProducts.Size = new System.Drawing.Size(280, 171);
            this.totalProducts.TabIndex = 1;
            // 
            // lblNumProducts
            // 
            this.lblNumProducts.AutoSize = true;
            this.lblNumProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumProducts.Location = new System.Drawing.Point(103, 85);
            this.lblNumProducts.Name = "lblNumProducts";
            this.lblNumProducts.Size = new System.Drawing.Size(36, 28);
            this.lblNumProducts.TabIndex = 2;
            this.lblNumProducts.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total Products";
            // 
            // totalCustomer
            // 
            this.totalCustomer.BackColor = System.Drawing.Color.White;
            this.totalCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCustomer.Controls.Add(this.lblNumCustomer);
            this.totalCustomer.Controls.Add(this.label2);
            this.totalCustomer.Location = new System.Drawing.Point(27, 86);
            this.totalCustomer.Name = "totalCustomer";
            this.totalCustomer.Size = new System.Drawing.Size(280, 171);
            this.totalCustomer.TabIndex = 0;
            // 
            // lblNumCustomer
            // 
            this.lblNumCustomer.AutoSize = true;
            this.lblNumCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCustomer.Location = new System.Drawing.Point(102, 85);
            this.lblNumCustomer.Name = "lblNumCustomer";
            this.lblNumCustomer.Size = new System.Drawing.Size(36, 28);
            this.lblNumCustomer.TabIndex = 1;
            this.lblNumCustomer.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Customers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 38);
            this.label5.TabIndex = 2;
            this.label5.Text = "Recent Transaction";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(634, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 38);
            this.label6.TabIndex = 6;
            this.label6.Text = "Top Debtors";
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DashboardPanel);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(932, 649);
            this.Load += new System.EventHandler(this.DashboardControl_Load);
            this.DashboardPanel.ResumeLayout(false);
            this.DashboardPanel.PerformLayout();
            this.totalDebt.ResumeLayout(false);
            this.totalDebt.PerformLayout();
            this.totalProducts.ResumeLayout(false);
            this.totalProducts.PerformLayout();
            this.totalCustomer.ResumeLayout(false);
            this.totalCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DashboardPanel;
        private System.Windows.Forms.Panel totalDebt;
        private System.Windows.Forms.Panel totalProducts;
        private System.Windows.Forms.Panel totalCustomer;
        private System.Windows.Forms.FlowLayoutPanel flowTopDebtors;
        private System.Windows.Forms.FlowLayoutPanel flowRecentTransactions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumDebt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumProducts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}
