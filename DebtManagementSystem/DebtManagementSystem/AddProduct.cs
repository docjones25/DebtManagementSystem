using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public AddProduct()
        {
            InitializeComponent();
        }

        private void categoryList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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
            DebtManagementSystemAdapter adapter = new DebtManagementSystemAdapter();
        }
    }
}
