using DebtManagementSystem.DebtDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DebtManagementSystem
{
    public partial class ProductsControl : UserControl
    {
        public ProductsControl()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProductForm = new AddProduct(this);
            addProductForm.ShowDialog();
        }

        public void LoadProducts()
        {
            flowProducts.Controls.Clear();

            ProductsTableAdapter adapter =
                new ProductsTableAdapter();

            DebtDataSet.ProductsDataTable dt =
                new DebtDataSet.ProductsDataTable();

            adapter.Fill(dt);

            foreach (DebtDataSet.ProductsRow row in dt.Rows)
            {
                ProductCard card = new ProductCard();

                card.ProductName = row.ProductName;

                card.ProductPrice =
                    "₱" + row.Price.ToString();

                if (!row.IsImagePathNull())
                {
                    if (File.Exists(row.ImagePath))
                    {
                        card.ProductImage =
                            Image.FromFile(row.ImagePath);
                    }
                }

                flowProducts.Controls.Add(card);
            }
        }

        private void ProductsControl_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
