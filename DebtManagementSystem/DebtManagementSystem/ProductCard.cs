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
        public ProductCard()
        {
            InitializeComponent();
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

    }
}
