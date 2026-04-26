using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebtManagementSystem
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void uploadImgBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string projectPath = Application.StartupPath;
                    string resourcesPath = Path.Combine(projectPath, "Resources");

                    // Ensure Resources folder exists
                    if (!Directory.Exists(resourcesPath))
                    {
                        Directory.CreateDirectory(resourcesPath);
                    }

                    int counter = 1;
                    string extension = Path.GetExtension(ofd.FileName);
                    string baseName = Path.GetFileNameWithoutExtension(ofd.FileName);
                    string destPath;

                    do
                    {
                        string uniqueName = $"{baseName}_{counter:D3}{extension}";
                        destPath = Path.Combine(resourcesPath, uniqueName);
                        counter++;
                    } while (File.Exists(destPath));

                    File.Copy(ofd.FileName, destPath);
                    itemPic.Image = Image.FromFile(destPath);


                }
            }
        }
    }
}
