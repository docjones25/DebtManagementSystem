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
    public partial class CustomerCard : UserControl
    {
        private CustomersControl customersControl;
        public int CustomerID
        {
            get
            {
                return int.Parse(lblID.Text);
            }

            set
            {
                lblID.Text = value.ToString();
            }
        }
        public string CustomerName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public string TotalDebt
        {
            get { return lblDebt.Text; }
            set
            {
                lblDebt.Text = value;
                decimal debt = decimal.Parse(value.Replace("₱", ""));
                if (debt > 0)
                {
                    lblDebt.ForeColor = Color.Red;
                }
                else
                {
                    lblDebt.ForeColor = Color.Green;
                }
            }
        }

        public string Contact
        {
            get { return lblContact.Text; }
            set { lblContact.Text = value; }
        }

        public CustomerCard(CustomersControl control)
        {
            InitializeComponent();

            customersControl = control;
            this.Click += CustomerCard_Click;
            lblName.Click += CustomerCard_Click;
            lblDebt.Click += CustomerCard_Click;
            lblID.Click += CustomerCard_Click;
        }

        private void CustomerCard_Click(object sender,EventArgs e)
        {
            CustomerDetailsControl details = new CustomerDetailsControl(CustomerID);
            Main_Menu main = (Main_Menu)this.FindForm();
            main.LoadControl(details);
        }

        private void CustomerCard_Load(object sender, EventArgs e)
        {
            
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblDebt_Click(object sender, EventArgs e)
        {

        }
    }
}
