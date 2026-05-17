using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebtManagementSystem
{
    public partial class ProductCard : UserControl
    {
        private ProductsControl productsControl;
        private bool isOpening = false;
        public ProductCard(ProductsControl control)
        {
            InitializeComponent();
            productsControl = control;  
            this.Click += ProductCard_Click;
            lblName.Click += ProductCard_Click;
            lblPrice.Click += ProductCard_Click;
            lblCategory.Click += ProductCard_Click;
            picProduct.Click += ProductCard_Click;
        }

        
        public string ProductName
        {
            get => lblName.Text;
            set => lblName.Text = value;
        }

        public string ProductCategory
        {
            get => lblCategory.Text;
            set => lblCategory.Text = value;
        }

        public string ProductPrice
        {
            get => lblPrice.Text;
            set => lblPrice.Text = value;
        }

        public Image ProductImage
        {
            get => picProduct.Image;
            set => picProduct.Image = value;
        }

        public int ProductID { get; set; }

        private void ProductCard_Click(object sender, EventArgs e)
        {

            if (isOpening) return;
            isOpening = true;
            AddProduct editForm = new AddProduct(productsControl, ProductID);
            editForm.ShowDialog();
            isOpening = false;
        }
    }
}
