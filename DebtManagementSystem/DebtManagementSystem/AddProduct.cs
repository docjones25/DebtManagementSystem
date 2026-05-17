using DebtManagementSystem.DebtDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DebtManagementSystem
{
    public partial class AddProduct : Form
    {
        private ProductsControl productsControl;
        public AddProduct(ProductsControl control)
        {
            InitializeComponent();
            productsControl = control;

            ApplyRoundness(clearBtn, 25);
            ApplyRoundness(addBtn, 25);
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
        private GraphicsPath ApplyDesign(RectangleF rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }
        private void ApplyRoundness(Button btn, int radius)
        {
            btn.Resize += (s, e) => btn.Invalidate(); // force redraw on resize

            btn.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.Clear(btn.Parent.BackColor); // clears background properly

                Rectangle rect = new Rectangle(1, 1, btn.Width - 3, btn.Height - 3);
                GraphicsPath path = ApplyDesign(rect, radius);

                using (Pen borderPen = new Pen(ColorTranslator.FromHtml("#8878c3"), 2))
                {
                    e.Graphics.DrawPath(borderPen, path);
                }

                TextRenderer.DrawText(
                    e.Graphics,
                    btn.Text,
                    btn.Font,
                    btn.ClientRectangle,
                    btn.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            };

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.Transparent;
        }


    }
}
