namespace DebtManagementSystem
{
    partial class TransactionsControl
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
            this.main_Panel = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnAddToDebt = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowCart = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.flowProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.flowCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.transactionHeaderPanel = new System.Windows.Forms.Panel();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.main_Panel.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.transactionHeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_Panel
            // 
            this.main_Panel.Controls.Add(this.panelRight);
            this.main_Panel.Controls.Add(this.flowProducts);
            this.main_Panel.Controls.Add(this.flowCategory);
            this.main_Panel.Controls.Add(this.transactionHeaderPanel);
            this.main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_Panel.Location = new System.Drawing.Point(0, 0);
            this.main_Panel.Name = "main_Panel";
            this.main_Panel.Size = new System.Drawing.Size(932, 649);
            this.main_Panel.TabIndex = 0;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.btnAddToDebt);
            this.panelRight.Controls.Add(this.lblTotal);
            this.panelRight.Controls.Add(this.label4);
            this.panelRight.Controls.Add(this.flowCart);
            this.panelRight.Controls.Add(this.label3);
            this.panelRight.Location = new System.Drawing.Point(628, 3);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(301, 643);
            this.panelRight.TabIndex = 3;
            // 
            // btnAddToDebt
            // 
            this.btnAddToDebt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToDebt.Location = new System.Drawing.Point(21, 580);
            this.btnAddToDebt.Name = "btnAddToDebt";
            this.btnAddToDebt.Size = new System.Drawing.Size(262, 45);
            this.btnAddToDebt.TabIndex = 6;
            this.btnAddToDebt.Text = "Add To Debt";
            this.btnAddToDebt.UseVisualStyleBackColor = true;
            this.btnAddToDebt.Click += new System.EventHandler(this.btnAddToDebt_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(195, 537);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(68, 28);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "₱ 0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 537);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Amount:";
            // 
            // flowCart
            // 
            this.flowCart.AutoScroll = true;
            this.flowCart.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowCart.Location = new System.Drawing.Point(3, 47);
            this.flowCart.Name = "flowCart";
            this.flowCart.Size = new System.Drawing.Size(295, 466);
            this.flowCart.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Shopping Cart";
            // 
            // flowProducts
            // 
            this.flowProducts.AutoScroll = true;
            this.flowProducts.Location = new System.Drawing.Point(3, 241);
            this.flowProducts.Name = "flowProducts";
            this.flowProducts.Size = new System.Drawing.Size(619, 405);
            this.flowProducts.TabIndex = 2;
            // 
            // flowCategory
            // 
            this.flowCategory.AutoScroll = true;
            this.flowCategory.Location = new System.Drawing.Point(3, 193);
            this.flowCategory.Name = "flowCategory";
            this.flowCategory.Size = new System.Drawing.Size(619, 42);
            this.flowCategory.TabIndex = 1;
            // 
            // transactionHeaderPanel
            // 
            this.transactionHeaderPanel.Controls.Add(this.btnAddCustomer);
            this.transactionHeaderPanel.Controls.Add(this.txtSearch);
            this.transactionHeaderPanel.Controls.Add(this.label2);
            this.transactionHeaderPanel.Controls.Add(this.cmbCustomers);
            this.transactionHeaderPanel.Controls.Add(this.label1);
            this.transactionHeaderPanel.Location = new System.Drawing.Point(3, 3);
            this.transactionHeaderPanel.Name = "transactionHeaderPanel";
            this.transactionHeaderPanel.Size = new System.Drawing.Size(619, 184);
            this.transactionHeaderPanel.TabIndex = 0;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(553, 84);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(49, 36);
            this.btnAddCustomer.TabIndex = 5;
            this.btnAddCustomer.Text = "+";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(19, 135);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(583, 34);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer";
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(19, 84);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(517, 36);
            this.cmbCustomers.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transactions";
            // 
            // TransactionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.main_Panel);
            this.Name = "TransactionsControl";
            this.Size = new System.Drawing.Size(932, 649);
            this.Load += new System.EventHandler(this.TransactionsControl_Load);
            this.main_Panel.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.transactionHeaderPanel.ResumeLayout(false);
            this.transactionHeaderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_Panel;
        private System.Windows.Forms.Panel transactionHeaderPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.FlowLayoutPanel flowCategory;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.FlowLayoutPanel flowProducts;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowCart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddToDebt;
    }
}
