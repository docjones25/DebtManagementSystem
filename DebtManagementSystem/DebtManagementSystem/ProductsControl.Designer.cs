namespace DebtManagementSystem
{
    partial class ProductsControl
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
            this.panelProductHeader = new System.Windows.Forms.Panel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.Products = new System.Windows.Forms.Label();
            this.flowProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.panelProductHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProductHeader
            // 
            this.panelProductHeader.Controls.Add(this.btnAddProduct);
            this.panelProductHeader.Controls.Add(this.txtSearchBar);
            this.panelProductHeader.Controls.Add(this.Products);
            this.panelProductHeader.Location = new System.Drawing.Point(3, 3);
            this.panelProductHeader.Name = "panelProductHeader";
            this.panelProductHeader.Size = new System.Drawing.Size(926, 157);
            this.panelProductHeader.TabIndex = 0;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(718, 12);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(183, 50);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBar.Location = new System.Drawing.Point(19, 78);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(882, 47);
            this.txtSearchBar.TabIndex = 2;
            // 
            // Products
            // 
            this.Products.AutoSize = true;
            this.Products.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Products.Location = new System.Drawing.Point(12, 21);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(135, 41);
            this.Products.TabIndex = 1;
            this.Products.Text = "Products";
            // 
            // flowProducts
            // 
            this.flowProducts.AutoScroll = true;
            this.flowProducts.Location = new System.Drawing.Point(3, 166);
            this.flowProducts.Name = "flowProducts";
            this.flowProducts.Size = new System.Drawing.Size(926, 480);
            this.flowProducts.TabIndex = 1;
            // 
            // ProductsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowProducts);
            this.Controls.Add(this.panelProductHeader);
            this.Name = "ProductsControl";
            this.Size = new System.Drawing.Size(932, 649);
            this.Load += new System.EventHandler(this.ProductsControl_Load);
            this.panelProductHeader.ResumeLayout(false);
            this.panelProductHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProductHeader;
        private System.Windows.Forms.Label Products;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.FlowLayoutPanel flowProducts;
        private System.Windows.Forms.Button btnAddProduct;
    }
}
