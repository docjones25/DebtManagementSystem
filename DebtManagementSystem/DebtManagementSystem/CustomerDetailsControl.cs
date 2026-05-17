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
    public partial class CustomerDetailsControl : UserControl
    {
        public CustomerDetailsControl()
        {
            InitializeComponent();
        }

        private int customerID;
        public CustomerDetailsControl(int id)
        {
            InitializeComponent();
            customerID = id;
        }

        private void LoadCustomerInfo()
        {
            string connectionString =
                @"Data Source=.\SQLEXPRESS;
                Initial Catalog=DebtManagementSystemDB;
                Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT
                    Customers.FirstName,
                    Customers.LastName,

                    ISNULL(Customers.InitialDebt, 0)
                    +
                    ISNULL(
                    (
                        SELECT SUM(TotalAmount)
                        FROM Transactions
                        WHERE Transactions.CustomerID = Customers.CustomerID
                    ), 0)
                    -
                    ISNULL(
                    (
                        SELECT SUM(Amount)
                        FROM Payments
                        WHERE Payments.CustomerID = Customers.CustomerID
                    ), 0)

                    AS TotalDebt
                FROM Customers
                WHERE Customers.CustomerID = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@id",
                        customerID);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtFirstName.Text = reader["FirstName"].ToString();
                        txtLastName.Text = reader["LastName"].ToString();
                        decimal debt = 0;
                        if (reader["TotalDebt"] != DBNull.Value)
                        {
                            debt = Convert.ToDecimal(reader["TotalDebt"]);
                        }
                        lblDebt.Text = "₱" + debt.ToString("N2");
                        if (debt > 0)
                        {
                            lblDebt.ForeColor =Color.Red;
                        }
                        else
                        {
                            lblDebt.ForeColor =Color.Green;
                        }
                    }
                }
            }
        }

        private void CustomerDetailsControl_Load(object sender, EventArgs e)
        {
            LoadCustomerInfo();
            LoadTransactionHistory();
        }

        private void UpdateCustomer()
        {
            if (txtFirstName.Text.Trim() == "" || txtLastName.Text.Trim() == "")
            {
                MessageBox.Show("Enter customer name.");
                return;
            }
            string connectionString =
                @"Data Source=.\SQLEXPRESS;
                Initial Catalog=DebtManagementSystemDB;
                Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    UPDATE Customers
                    SET
                        FirstName = @first,
                        LastName = @last
                    WHERE CustomerID = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@first", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@last", txtLastName.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Customer Updated!");
        }

        private void RecordPayment()
        {
            if (txtPaymentAmount.Text.Trim() == "")
            {
                MessageBox.Show("Enter payment amount.");
                return;
            }
            decimal payment;
            if (!decimal.TryParse(txtPaymentAmount.Text, out payment))
            {
                MessageBox.Show("Invalid amount.");
                return;
            }
            if (payment <= 0)
            {
                MessageBox.Show(
                    "Invalid payment amount.");

                return;
            }
            string connectionString =
                @"Data Source=.\SQLEXPRESS;
                Initial Catalog=DebtManagementSystemDB;
                Integrated Security=True";
            using (SqlConnection conn =new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    INSERT INTO Payments
                    (
                        CustomerID,
                        Amount
                    )
                    VALUES
                    (
                        @customerID,
                        @amount
                    )";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@customerID", customerID);
                    cmd.Parameters.AddWithValue("@amount", payment);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Payment Recorded!");
            txtPaymentAmount.Clear();
            LoadCustomerInfo();
            LoadTransactionHistory();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateCustomer();
        }

        private void btnRecordPayments_Click(object sender, EventArgs e)
        {
            RecordPayment();
        }

        private void LoadTransactionHistory()
        {
            flowTransactionHistory.Controls.Clear();
            string connectionString =
                @"Data Source=.\SQLEXPRESS;
                Initial Catalog=DebtManagementSystemDB;
                Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT
                        'Purchase' AS Type,
                        TransactionDate AS Date,
                        TotalAmount AS Amount
                    FROM Transactions
                    WHERE CustomerID = @id

                    UNION ALL

                    SELECT
                        'Payment' AS Type,
                        PaymentDate AS Date,
                        Amount
                    FROM Payments
                    WHERE CustomerID = @id
                    ORDER BY Date DESC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", customerID);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        TransactionCard card = new TransactionCard();
                        card.TransactionType = reader["Type"].ToString();
                        DateTime date = Convert.ToDateTime(reader["Date"]);
                        card.TransactionDate = date.ToString("MMM dd, yyyy");
                        decimal amount =Convert.ToDecimal(reader["Amount"]);
                        card.Amount = "₱" + amount.ToString("N2");
                        flowTransactionHistory.Controls.Add(card);
                    }
                }
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Main_Menu main = (Main_Menu)this.FindForm();
            main.LoadControl(new CustomersControl());
        }
        private void DeleteCustomer()
        {
            DialogResult result =
                MessageBox.Show(
                    "Delete this customer?",
                    "Delete Customer",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string connectionString =
                    @"Data Source=.\SQLEXPRESS;
                    Initial Catalog=DebtManagementSystemDB;
                    Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        UPDATE Customers
                        SET IsArchived = 1
                        WHERE CustomerID = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", customerID);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Customer Deleted!");
                Main_Menu main = (Main_Menu)this.FindForm();
                main.LoadControl(new CustomersControl());
            }
        }
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            DeleteCustomer();
        }
    }
}
