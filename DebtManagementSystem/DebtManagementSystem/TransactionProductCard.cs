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
    public partial class TransactionProductCard : UserControl
    {
        public event EventHandler ProductClicked;
        public TransactionProductCard()
        {
            InitializeComponent();

            this.Click += TransactionProductCard_Click;
            imgProduct.Click += TransactionProductCard_Click;
            lblProductName.Click += TransactionProductCard_Click;
            lblPrice.Click += TransactionProductCard_Click;
        }

        public int ProductID { get; set; }
        public string ProductName
        {
            get { return lblProductName.Text; }
            set { lblProductName.Text = value; }
        }
        public string Category
        {
            get { return lblCategory.Text; }
            set { lblCategory.Text = value; }
        }
        public string Price
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }
        public Image ProductImage
        {
            get { return imgProduct.Image; }
            set { imgProduct.Image = value; }
        }
        private void TransactionProductCard_Click(object sender, EventArgs e)
        {
            ProductClicked?.Invoke(this, EventArgs.Empty);
        }

       
    }
}
