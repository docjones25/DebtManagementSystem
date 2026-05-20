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
                    Products.ProductID,
                        Products.ProductName,
                        Products.Price,
                        Products.ImagePath,
                        Categories.CategoryName
                    FROM Products
                    INNER JOIN Categories
                    ON Products.CategoryID = Categories.CategoryID
                    WHERE Products.IsArchived = 0";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ProductCard card = new ProductCard(this);
                        card.ProductName = reader["ProductName"].ToString();
                        card.ProductPrice = "₱" + reader["Price"].ToString();
                        card.ProductCategory = reader["CategoryName"].ToString();
                        string imagePath = reader["ImagePath"].ToString();
                        if (File.Exists(imagePath))
                        {
                            if (File.Exists(imagePath))
                            {
                                byte[] bytes = File.ReadAllBytes(imagePath);

                                using (MemoryStream ms = new MemoryStream(bytes))
                                {
                                    Image temp = Image.FromStream(ms);

                                    card.ProductImage = new Bitmap(temp);
                                }
                            }
                        }
                        card.ProductID = Convert.ToInt32(reader["ProductID"]);
                        flowProducts.Controls.Add(card); 
                    }
                }
            }
        }

        private void ProductsControl_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            SearchProducts();
        }

        private void SearchProducts()
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
                    SELECT *
                    FROM Products
                    WHERE IsArchived = 0
                    AND ProductName LIKE @search";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@search",
                        "%" + txtSearch.Text.Trim() + "%");
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ProductCard card = new ProductCard(this);
                        card.ProductID = Convert.ToInt32(reader["ProductID"]);
                        card.ProductName = reader["ProductName"].ToString();
                        decimal price = Convert.ToDecimal(reader["Price"]);
                        card.ProductPrice = "₱" + price.ToString("N2");
                        string imagePath = reader["ImagePath"].ToString();
                        if (File.Exists(imagePath))
                        {
                            byte[] bytes = File.ReadAllBytes(imagePath);
                            using (MemoryStream ms = new MemoryStream(bytes))
                            {
                                Image temp = Image.FromStream(ms);
                                card.ProductImage = new Bitmap(temp);
                            }
                        }
                        flowProducts.Controls.Add(card);
                    }
                }
            }
        }
    }
}
