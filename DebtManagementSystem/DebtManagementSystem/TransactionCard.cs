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
    public partial class TransactionCard : UserControl
    {
        public TransactionCard()
        {
            InitializeComponent();
        }
        public string TransactionType
        {
            get { return lblType.Text; }
            set { lblType.Text = value; }
        }

        public string TransactionDate
        {
            get { return lblDate.Text; }
            set { lblDate.Text = value; }
        }

        public string Amount
        {
            get { return lblAmount.Text; }
            set
            {
                lblAmount.Text = value;
                decimal amount = decimal.Parse(value.Replace("₱", ""));
                if (TransactionType == "Payment")
                {
                    lblAmount.ForeColor =
                        Color.Green;
                }
                else
                {
                    lblAmount.ForeColor =
                        Color.Red;
                }
            }
        }
    }
}
