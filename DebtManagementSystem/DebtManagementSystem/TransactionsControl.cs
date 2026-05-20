using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebtManagementSystem
{
    public partial class TransactionsControl : UserControl
    {
        private string selectedCategory = "All";
        public TransactionsControl()
        {
            InitializeComponent();
        }
        private void LoadProducts()
        {
            flowProducts.Controls.Clear();

            string connectionString =
                @"Data Source=.\SQLEXPRESS;
                Initial Catalog=DebtManagementSystemDB;
                Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT
                    Products.ProductID,
                        Products.ProductName,
                        Products.Price,
                        Products.ImagePath,
                        Categories.CategoryName
                    FROM Products
                    INNER JOIN Categories
                    ON Products.CategoryID = Categories.CategoryID
                    WHERE Products.IsArchived = 0";

                using (SqlCommand cmd = new SqlCommand(query, conn))

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TransactionProductCard card = new TransactionProductCard();
                        card.ProductClicked += ProductCard_Clicked;
                        card.ProductID = Convert.ToInt32(reader["ProductID"]);
                        card.ProductName = reader["ProductName"].ToString();
                        card.Category = reader["CategoryName"].ToString();
                        decimal price = Convert.ToDecimal(reader["Price"]);
                        card.Price = "₱" + price.ToString("N2");

                        string imagePath = reader["ImagePath"].ToString();
                        if (File.Exists(imagePath))
                        {
                            if (File.Exists(imagePath))
                            {
                                byte[] bytes = File.ReadAllBytes(imagePath);

                                using (MemoryStream ms = new MemoryStream(bytes))
                                {
                                    Image temp = Image.FromStream(ms);
                                    card.ProductImage = new Bitmap(temp);
                                }
                            }
                        }

                        flowProducts.Controls.Add(card);
                    }
                }
            }
        }

        private void ProductCard_Clicked(object sender, EventArgs e)
        {
            TransactionProductCard productCard = (TransactionProductCard)sender;
            foreach (Control control
                in flowCart.Controls)
            {
                CartItemCard existingCard = control as CartItemCard;
                if (existingCard != null)
                {
                    if (existingCard.ProductID == productCard.ProductID)
                    {
                        existingCard.Quantity++;
                        UpdateTotal();
                        return;
                    }
                }
            }

            CartItemCard cartCard = new CartItemCard();
            cartCard.ProductID = productCard.ProductID;
            cartCard.ProductName = productCard.ProductName;
            cartCard.Price = productCard.Price;
            decimal price =
                decimal.Parse(
                    productCard.Price
                    .Replace("₱", "")
                    .Replace(",", ""));
            cartCard.PriceValue = price;
            cartCard.Quantity = 1;
            cartCard.ProductImage = productCard.ProductImage;
            flowCart.Controls.Add(cartCard);
            UpdateTotal();
        }
        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (Control control in flowCart.Controls)
            {
                CartItemCard card = control as CartItemCard;
                if (card != null)
                {
                    total += card.PriceValue * card.Quantity;
                }
            }
            lblTotal.Text = "₱" + total.ToString("N2");
        }
        private void TransactionsControl_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCustomers();
            LoadCategories();
        }
        private void LoadCustomers()
        {
            cmbCustomers.Items.Clear();

            string connectionString =
                @"Data Source=.\SQLEXPRESS;
                Initial Catalog=DebtManagementSystemDB;
                Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT
                        CustomerID,
                        FirstName,
                        LastName
                    FROM Customers
                    WHERE IsArchived = 0";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbCustomers.Items.Add(
                            new ComboBoxItem(
                                reader["FirstName"].ToString()
                                + " "
                                + reader["LastName"].ToString(),

                                reader["CustomerID"].ToString()
                            ));
                    }
                }
            }
        }
        private void Checkout()
        {
            if (cmbCustomers.SelectedItem == null)
            {
                MessageBox.Show("Select customer.");
                return;
            }

            if (flowCart.Controls.Count == 0)
            {
                MessageBox.Show("Cart is empty.");
                return;
            }

            ComboBoxItem customer = (ComboBoxItem)cmbCustomers.SelectedItem;
            int customerID = Convert.ToInt32(customer.Value);
            decimal total = 0;
            foreach (Control control in flowCart.Controls)
            {
                CartItemCard card = control as CartItemCard;
                if (card != null)
                {
                    total += card.PriceValue * card.Quantity;
                }
            }
            string connectionString =
                @"Data Source=.\SQLEXPRESS;
                Initial Catalog=DebtManagementSystemDB;
                Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    INSERT INTO Transactions
                    (
                        CustomerID,
                        TotalAmount,
                        TransactionType
                    )
                    OUTPUT INSERTED.TransactionID
                    VALUES
                    (
                        @customerID,
                        @total,
                        @type
                    )";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@customerID", customerID);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@type", "Debt");
                    int transactionID;
                    transactionID = Convert.ToInt32(cmd.ExecuteScalar());
                    foreach (Control control in flowCart.Controls)
                    {
                        CartItemCard card = control as CartItemCard;
                        if (card != null)
                        {
                            decimal subtotal = card.PriceValue * card.Quantity;
                            string itemQuery = @"
                                INSERT INTO Transaction_Items
                                (
                                    TransactionID,
                                    ProductID,
                                    Quantity,
                                    Price,
                                    Subtotal
                                )
                                VALUES
                                (
                                    @transactionID,
                                    @productID,
                                    @quantity,
                                    @price,
                                    @subtotal
                                )";
                            using (SqlCommand itemCmd = new SqlCommand(itemQuery, conn))
                            {
                                itemCmd.Parameters.AddWithValue("@transactionID", transactionID);
                                itemCmd.Parameters.AddWithValue("@productID", card.ProductID);
                                itemCmd.Parameters.AddWithValue("@quantity", card.Quantity);
                                itemCmd.Parameters.AddWithValue("@price", card.PriceValue);
                                itemCmd.Parameters.AddWithValue("@subtotal", subtotal);

                                itemCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            MessageBox.Show("Transaction Complete!");
            flowCart.Controls.Clear();
            lblTotal.Text = "₱0.00";
        }
        private void btnAddToDebt_Click(object sender, EventArgs e)
        {
            Checkout();
        }

        private void SearchProducts()
        {
            flowProducts.Controls.Clear();

            string search = txtSearch.Text.Trim();
            string categoryFilter = selectedCategory;
            if (categoryFilter == "All")
            {
                categoryFilter = "";
            }

            string connectionString =
                @"Data Source=.\SQLEXPRESS;
                Initial Catalog=DebtManagementSystemDB;
                Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT
                        Products.ProductID,
                        Products.ProductName,
                        Products.Price,
                        Products.ImagePath,
                        Categories.CategoryName
                    FROM Products
                    INNER JOIN Categories
                    ON Products.CategoryID = Categories.CategoryID

                    WHERE Products.IsArchived = 0
                    AND Products.ProductName LIKE @search
                    AND Categories.CategoryName LIKE @category";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text.Trim() + "%");
                    cmd.Parameters.AddWithValue("@category", "%" + categoryFilter + "%");
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        TransactionProductCard card = new TransactionProductCard();
                        card.ProductClicked += ProductCard_Clicked;
                        card.ProductID = Convert.ToInt32(reader["ProductID"]);
                        card.ProductName = reader["ProductName"].ToString();
                        card.Category = reader["CategoryName"].ToString();
                        decimal price = Convert.ToDecimal(reader["Price"]);
                        card.Price = "₱" + price.ToString("N2");
                        string imagePath = reader["ImagePath"].ToString();
                        if (File.Exists(imagePath))
                        {
                            byte[] bytes = File.ReadAllBytes(imagePath);
                            using (MemoryStream ms = new MemoryStream(bytes))
                            {
                                Image temp = Image.FromStream(ms);
                                card.ProductImage = new Bitmap(temp);
                            }
                        }   
                        flowProducts.Controls.Add(card);
                    }
                }
            }
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer form = new AddCustomer();
            form.ShowDialog();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts();
        }

        private void LoadCategories()
        {
            flowCategory.Controls.Clear();

            Button allButton = new Button();
            allButton.Text = "All";
            allButton.Width = 100;
            allButton.Height = 40;

            allButton.Click += CategoryButton_Click;

            flowCategory.Controls.Add(allButton);
            string connectionString =
                @"Data Source=.\SQLEXPRESS;
                Initial Catalog=DebtManagementSystemDB;
                Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query =
                    "SELECT CategoryName FROM Categories";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader =
                        cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Button btn = new Button();
                        btn.Text = reader["CategoryName"].ToString();
                        btn.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                        btn.Width = 100;
                        btn.Height = 40;
                        btn.Click += CategoryButton_Click;
                        flowCategory.Controls.Add(btn);
                    }
                }
            }
        }
        private void CategoryButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            selectedCategory = btn.Text;
            SearchProducts();
        }
    }
}
