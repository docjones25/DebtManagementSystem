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
    public partial class TopDebtorCard : UserControl
    {
        public TopDebtorCard()
        {
            InitializeComponent();
        }

        public string CustomerName
        {
            get { return lblCustomerName.Text; }
            set { lblCustomerName.Text = value; }
        }

        public string TotalDebt
        {
            get { return lblDebt.Text; }
            set { lblDebt.Text = value; }
        }

        public string Contact
        {
            get { return lblContact.Text; }
            set { lblContact.Text = value; }
        }
    }
}
