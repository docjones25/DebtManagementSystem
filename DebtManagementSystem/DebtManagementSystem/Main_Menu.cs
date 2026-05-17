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
