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

        private string imagePath = "";
        private void uploadImgBtn_Click(object sender, EventArgs e)
        {
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

                    productImg.Image = Image.FromFile(destPath);
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (categoryList.SelectedValue == null)
            {
                MessageBox.Show("Please select a category.");
                return;
            }
            int categoryID = (int)categoryList.SelectedValue;

            DebtDataSetTableAdapters.ProductsTableAdapter productsAdapter = new DebtDataSetTableAdapters.ProductsTableAdapter();
            productsAdapter.Insert(txtProductName.Text, categoryID, txtPrice.Value, imagePath);
            productsControl.LoadProducts();
            MessageBox.Show("Product added successfully!");
            this.Close();
        }


        private void categoryList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            CategoriesTableAdapter categoriesAdapter = new CategoriesTableAdapter();
            DebtDataSet.CategoriesDataTable dt = new DebtDataSet.CategoriesDataTable();

            categoriesAdapter.Fill(dt);
            categoryList.DataSource = dt;
            categoryList.DisplayMember = "CategoryName";
            categoryList.ValueMember = "CategoryID";
        }
    }
}
