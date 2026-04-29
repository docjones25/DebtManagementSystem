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

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
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
    }
}
