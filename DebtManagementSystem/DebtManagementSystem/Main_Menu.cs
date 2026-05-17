using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

            ApplyRoundness(btnDashboard, 25);
            ApplyRoundness(btnCustomers, 25);
            ApplyRoundness(btnProducts, 25);
            ApplyRoundness(btnTransactions, 25);
            ApplyRoundness(btnFlappyJuds, 25);

            Color hoverColor = ColorTranslator.FromHtml("#d8b9ff");
            Color normalColor = Color.Transparent;

            ApplyHoverEffect(btnDashboard, hoverColor, normalColor);
            ApplyHoverEffect(btnCustomers, hoverColor, normalColor);
            ApplyHoverEffect(btnProducts, hoverColor, normalColor);
            ApplyHoverEffect(btnTransactions, hoverColor, normalColor);
            ApplyHoverEffect(btnPaymens, hoverColor, normalColor);
            ApplyHoverEffect(btnFlappyJuds, hoverColor, normalColor);

        }

        public void LoadControl(UserControl control)
        {
            mainPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(control);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadControl(new DashboardControl());
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            LoadControl(new CustomersControl());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            LoadControl(new ProductsControl());
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            LoadControl(new TransactionsControl());
        }

        private void btnPaymens_Click(object sender, EventArgs e)
        {
            LoadControl(new PaymentsControl());
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
            btn.Resize += (s, e) =>
            {
                Rectangle rect = new Rectangle(0, 0, btn.Width, btn.Height);
                GraphicsPath path = ApplyDesign(rect, radius);
                btn.Region = new Region(path); // make button physically rounded
                btn.Invalidate();
            };

            btn.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                Rectangle rect = new Rectangle(1, 1, btn.Width - 3, btn.Height - 3);
                GraphicsPath path = ApplyDesign(rect, radius);

                // Fill the rounded path with BackColor (hover effect matches roundness)
                using (SolidBrush brush = new SolidBrush(btn.BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

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

        private void ApplyHoverEffect(Button btn, Color hoverColor, Color normalColor)
        {
            btn.BackColor = normalColor;

            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = hoverColor;
                btn.Invalidate(); // force redraw with hover color
            };

            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = normalColor;
                btn.Invalidate(); // force redraw with normal color
            };
        }
    }
}

