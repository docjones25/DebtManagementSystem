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
            DebtDataSetTableAdapters.ProductsTableAdapter productsAdapter = new DebtDataSetTableAdapters.ProductsTableAdapter();
            productsAdapter.Insert(txtProductName.Text, txtPrice.Value, (int)categoryList.SelectedValue, imagePath);
            productsControl.LoadProducts();
            MessageBox.Show("Product added successfully!");
            this.Close();
        }

        private void productImg_Click(object sender, EventArgs e)
        {

        }
    }
}
