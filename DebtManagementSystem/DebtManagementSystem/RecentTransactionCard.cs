using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebtManagementSystem
{
    public partial class RecentTransactionCard : UserControl
    {
        public RecentTransactionCard()
        {
            InitializeComponent();
        }

        public string CustomerName
        {
            get { return lblCustomerName.Text; }
            set { lblCustomerName.Text = value; }
        }
        public string TransactionType
        {
            get { return lblTransactionType.Text; }
            set { lblTransactionType.Text = value; }
        }
        public string Amount
        {
            get { return lblAmount.Text; }
            set { lblAmount.Text = value; }

        }
        public string TransactionDate
        {
            get { return lblDateTime.Text; }
            set { lblDateTime.Text = value; }
        }
    }
}
