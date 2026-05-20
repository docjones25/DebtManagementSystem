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
    public partial class CartItemCard : UserControl
    {
        public CartItemCard()
        {
            InitializeComponent();
        }

        public string ProductName
        {
            get { return lblProductName.Text; }
            set { lblProductName.Text = value; }
        }
        public string Price
        {
            get { return lblSubtotal.Text; }
            set { lblSubtotal.Text = value; }
        }
        
        public Image ProductImage
        {
            get { return imgProduct.Image; }
            set { imgProduct.Image = value; }
        }
        public int ProductID { get; set; }
        public decimal PriceValue { get; set; }
        private int quantity = 1;
        public int Quantity
        {
            get { return quantity; }
            set
            {
                quantity = value;
                lblQuantity.Text = quantity.ToString();
                decimal subtotal = PriceValue * quantity;
                lblSubtotal.Text = "₱" + subtotal.ToString("N2");
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Quantity++;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (Quantity > 1)
            {
                Quantity--;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
