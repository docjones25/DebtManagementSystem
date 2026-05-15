using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DebtManagementSystem
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();

            ApplyRoundness(dashboardBtn, 25);
            ApplyRoundness(customerBtn, 25);
            ApplyRoundness(productsBtn, 25);
            ApplyRoundness(transactionBtn, 25);
            ApplyRoundness(flappyJudsBtn, 25);
            ApplyRoundness(exitBtn, 25);
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            this.Hide();
            customer.Show();
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            this.Hide();
            product.Show();
        }

        private void transactionBtn_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
            this.Hide();
            transaction.Show();
        }

        private void flappyJudsBtn_Click(object sender, EventArgs e)
        {
        }

        private void ApplyRoundness(Button btn, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            btn.Region = new Region(path);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.Transparent;
            btn.ForeColor = Color.Black;

            btn.Resize += (s, e) =>
            {
                GraphicsPath resizePath = new GraphicsPath();
                resizePath.StartFigure();
                resizePath.AddArc(0, 0, radius, radius, 180, 90);
                resizePath.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
                resizePath.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
                resizePath.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
                resizePath.CloseFigure();

                btn.Region = new Region(resizePath);
            };

            btn.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
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
        }
    }
}
