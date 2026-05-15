using DebtManagementSystem.DebtDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            string connectionString =
                @"Data Source=.\SQLEXPRESS;
                Initial Catalog=DebtManagementSystemDB;
                Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                SELECT
                    Products.ProductName,
                    Products.Price,
                    Products.ImagePath,
                    Categories.CategoryName
                FROM Products
                INNER JOIN Categories
                ON Products.CategoryID = Categories.CategoryID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ProductCard card = new ProductCard();
                        card.ProductName = reader["ProductName"].ToString();
                        card.ProductPrice = "₱" + reader["Price"].ToString();
                        card.ProductCategory = reader["CategoryName"].ToString();
                        string imagePath = reader["ImagePath"].ToString();
                        if (File.Exists(imagePath))
                        {
                            card.ProductImage =
                                Image.FromFile(imagePath);
                        }

                        flowProducts.Controls.Add(card);
                    }
                }
            }
        }

        private void ProductsControl_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
