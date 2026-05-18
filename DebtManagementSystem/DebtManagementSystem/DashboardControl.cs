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
    public partial class DashboardControl : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();
        }

        private void LoadDashboardStats()
        {
            string connectionString =
                @"Data Source=.\SQLEXPRESS;
                Initial Catalog=DebtManagementSystemDB;
                Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // TOTAL CUSTOMERS
                string customerQuery = @"
                    SELECT COUNT(*)
                    FROM Customers
                    WHERE IsArchived = 0";
                using (SqlCommand cmd = new SqlCommand(customerQuery, conn))
                {
                    lblNumCustomer.Text = cmd.ExecuteScalar().ToString();
                }
                // TOTAL PRODUCTS
                string productQuery = @"
                    SELECT COUNT(*)
                    FROM Products
                    WHERE IsArchived = 0";
                using (SqlCommand cmd = new SqlCommand(productQuery, conn))
                {
                    lblNumProducts.Text = cmd.ExecuteScalar().ToString();
                }
                // TOTAL DEBT
                string debtQuery = @"
                    SELECT
                        ISNULL(SUM(InitialDebt), 0)
                        +
                        ISNULL(
                            (
                                SELECT SUM(TotalAmount)
                                FROM Transactions
                            ), 0)
                        -
                        ISNULL(
                            (
                                SELECT SUM(Amount)
                                FROM Payments
                            ), 0)
                    FROM Customers
                    WHERE IsArchived = 0";
                using (SqlCommand cmd = new SqlCommand(debtQuery, conn))
                {
                    decimal debt = Convert.ToDecimal(cmd.ExecuteScalar());
                    lblNumDebt.Text = "₱" + debt.ToString("N2");
                }
            }
        }

        private void LoadRecentTransactions()
        {
            flowRecentTransactions.Controls.Clear();

            string connectionString =
                @"Data Source=.\SQLEXPRESS;
                Initial Catalog=DebtManagementSystemDB;
                Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT TOP 20 *
                    FROM
                    (
                        SELECT
                            Customers.FirstName + ' ' + Customers.LastName AS CustomerName,
                            'Purchase' AS Type,
                            Transactions.TotalAmount AS Amount,
                            Transactions.TransactionDate AS Date
                        FROM Transactions
                        INNER JOIN Customers
                        ON Transactions.CustomerID = Customers.CustomerID

                        UNION ALL

                        SELECT
                            Customers.FirstName + ' ' + Customers.LastName AS CustomerName,
                            'Payment' AS Type,
                            Payments.Amount AS Amount,
                            Payments.PaymentDate AS Date
                        FROM Payments
                        INNER JOIN Customers
                        ON Payments.CustomerID = Customers.CustomerID
                    )
                    AS CombinedTransactions

                    ORDER BY Date DESC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        RecentTransactionCard card = new RecentTransactionCard();
                        card.CustomerName = reader["CustomerName"].ToString();
                        card.TransactionType = reader["Type"].ToString();
                        decimal amount = Convert.ToDecimal(reader["Amount"]);
                        card.Amount = "₱" + amount.ToString("N2");
                        DateTime date = Convert.ToDateTime(reader["Date"]);
                        card.TransactionDate = date.ToString("MMM dd, yyyy");
                        flowRecentTransactions.Controls.Add(card);
                    }
                }
            }
        }

        private void LoadTopDebtors()
        {
            flowTopDebtors.Controls.Clear();

            string connectionString =
                @"Data Source=.\SQLEXPRESS;
        Initial Catalog=DebtManagementSystemDB;
        Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT TOP 5
                        Customers.CustomerID,
                        Customers.FirstName,
                        Customers.LastName,
                        Customers.Contact,
                        (
                            ISNULL(Customers.InitialDebt, 0)
                            +
                            ISNULL(
                                (
                                    SELECT SUM(TotalAmount)
                                    FROM Transactions
                                    WHERE Transactions.CustomerID = Customers.CustomerID
                                ),
                                0
                            )
                            -
                            ISNULL(
                                (
                                    SELECT SUM(Amount)
                                    FROM Payments
                                    WHERE Payments.CustomerID = Customers.CustomerID
                                ),
                                0
                            )
                        ) AS TotalDebt
                    FROM Customers
                    WHERE IsArchived = 0
                    ORDER BY TotalDebt DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TopDebtorCard card = new TopDebtorCard();
                        card.CustomerName = reader["LastName"].ToString();
                        card.Contact = reader["Contact"].ToString();
                        decimal debt = Convert.ToDecimal(reader["TotalDebt"]);
                        card.TotalDebt =  "₱" + debt.ToString("N2");
                        flowTopDebtors.Controls.Add(card);
                    }
                }
            }
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            LoadDashboardStats();
            LoadRecentTransactions();
            LoadTopDebtors();
        }
    }
}
