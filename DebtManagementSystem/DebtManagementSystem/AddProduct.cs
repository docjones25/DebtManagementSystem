using DebtManagementSystem.DebtDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebtManagementSystem
{
    public partial class AddProduct : Form
    {
        private ProductsControl productsControl;
        public AddProduct(ProductsControl control)
        {
            InitializeComponent();
            productsControl = control;
        }
        public AddProduct(ProductsControl control, int id)
        {
            InitializeComponent();
            productsControl = control;
            productID = id;
            isEdit = true;
        }

        // variables for edit mode
        private bool isEdit = false;
        private int productID = 0;

        // variable to store the image path
        private string imagePath = "";

        private void uploadImgBtn_Click(object sender, EventArgs e)
        {
            // Open file dialog to select an image
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string projectPath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\"));
                    string resourcesPath = Path.Combine(projectPath, "Resources");

                    if (!Directory.Exists(resourcesPath))
                        Directory.CreateDirectory(resourcesPath);

                    string fileName = Path.GetFileName(ofd.FileName);
                    string destPath = Path.Combine(resourcesPath, fileName);
                    File.Copy(ofd.FileName, destPath, true);

                    using (FileStream fs = new FileStream(
                        destPath,
                        FileMode.Open,
                        FileAccess.Read))
                    {
                        Image temp = Image.FromStream(fs);
                        productImg.Image = new Bitmap(temp);
                    }
                    imagePath = destPath;
                    productImg.SizeMode = PictureBoxSizeMode.Zoom;

                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtProductName.Clear();
            txtPrice.Value = 0;
            categoryList.SelectedIndex = -1;
            productImg.Image = null;
        }
        private void AddNewProduct()
        {
            int categoryID = (int)categoryList.SelectedValue;
            DebtDataSetTableAdapters.ProductsTableAdapter productsAdapter = new DebtDataSetTableAdapters.ProductsTableAdapter();
            productsAdapter.Insert(txtProductName.Text, categoryID, txtPrice.Value, imagePath);
            productsControl.LoadProducts();
            MessageBox.Show("Product added successfully!");
            this.Close();
        }

        private void UpdateProduct()
        {
            string connectionString =
                @"Data Source=.\SQLEXPRESS;
                Initial Catalog=DebtManagementSystemDB;
                Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                UPDATE Products
                SET
                ProductName = @name,
                CategoryID = @category,
                Price = @price,
                ImagePath = @image
                WHERE ProductID = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", txtProductName.Text);
                    cmd.Parameters.AddWithValue("@category", categoryList.SelectedValue);
                    cmd.Parameters.AddWithValue("@price", txtPrice.Value);
                    cmd.Parameters.AddWithValue("@image", imagePath);
                    cmd.Parameters.AddWithValue("@id", productID);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Product Updated!");
            productsControl.LoadProducts();
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                UpdateProduct();
            }
            else
            {
                if (txtProductName.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter a product name.");
                    return;
                } else if (categoryList.SelectedValue == null)
                {
                    MessageBox.Show("Please select a category.");
                    return;
                }
                AddNewProduct();
            }
            
        }

        private Image LoadImageSafe(string path)
        {
            byte[] bytes = File.ReadAllBytes(path);
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                Image temp = Image.FromStream(ms);
                return new Bitmap(temp);
            }
        }

        private void LoadProductData()
        {
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
                    WHERE ProductID = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", productID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtProductName.Text = reader["ProductName"].ToString();
                        txtPrice.Value = Convert.ToDecimal(reader["Price"]);
                        categoryList.SelectedValue = reader["CategoryID"];
                        imagePath = reader["ImagePath"].ToString();
                        if (File.Exists(imagePath))
                        {
                            using (FileStream fs = new FileStream(
                                imagePath,
                                FileMode.Open,
                                FileAccess.Read))
                            {
                                Image temp = Image.FromStream(fs);
                                productImg.Image = new Bitmap(temp);
                            }
                        }
                    }
                }
            }
            addBtn.Text = "Update";
            btnCancel.Text = "Delete";
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            CategoriesTableAdapter categoriesAdapter = new CategoriesTableAdapter();
            DebtDataSet.CategoriesDataTable dt = new DebtDataSet.CategoriesDataTable();
            categoriesAdapter.Fill(dt);
            categoryList.DataSource = dt;
            categoryList.DisplayMember = "CategoryName";
            categoryList.ValueMember = "CategoryID";
            if (isEdit)
            {
                LoadProductData();
            }
        }

        private void DeleteProduct()
        {
            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to delete this product?",
                    "Delete Product",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string connectionString =
                    @"Data Source=.\SQLEXPRESS;
                    Initial Catalog=DebtManagementSystemDB;
                    Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string imagePath = "";
                    // GET IMAGE PATH
                    string getImageQuery = @"
                    SELECT ImagePath
                    FROM Products
                    WHERE ProductID = @id";

                    using (SqlCommand getCmd = new SqlCommand(getImageQuery, conn))
                    {
                        getCmd.Parameters.AddWithValue(
                            "@id",
                            productID);
                        object imageResult = getCmd.ExecuteScalar();

                        if (imageResult != null)
                        {
                            imagePath = imageResult.ToString();
                        }
                    }
                    // DELETE IMAGE FILE
                    if (File.Exists(imagePath))
                    {
                        if (productImg.Image != null)
                        {
                            productImg.Image.Dispose();
                            productImg.Image = null;
                        }
                        File.Delete(imagePath);
                    }
                    // ARCHIVE PRODUCT
                    string query = @"
                    UPDATE Products
                    SET IsArchived = 1
                    WHERE ProductID = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@id",
                            productID);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Product Deleted!");
                productsControl.LoadProducts();
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                DeleteProduct();
            }
            else
            {
                this.Close();
            }
        }
    }
}
