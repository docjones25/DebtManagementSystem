using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebtManagementSystem
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();

        }

        private void dashboardBtn_Click_1(object sender, EventArgs e)
        {

        }
        private void LoadControl(UserControl control)
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

    }
}
