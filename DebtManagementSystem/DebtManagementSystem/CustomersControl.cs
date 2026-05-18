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
    public partial class CustomersControl : UserControl
    {
        public CustomersControl()
        {
            InitializeComponent();
        }

        private void CustomersControl_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        public void LoadCustomers()
        {
            flowCustomers.Controls.Clear();

            string connectionString =
                @"Data Source=.\SQLEXPRESS;
                Initial Catalog=DebtManagementSystemDB;
                Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT
                        Customers.CustomerID,
                        Customers.FirstName,
                        Customers.LastName,
                        Customers.Contact,
                        ISNULL(Customers.InitialDebt, 0)
                        +
                        ISNULL(
                            SUM(Transactions.TotalAmount),
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

                        AS TotalDebt
                    FROM Customers
                    LEFT JOIN Transactions
                    ON Customers.CustomerID =
                        Transactions.CustomerID

                    WHERE Customers.IsArchived = 0

                    GROUP BY
                        Customers.CustomerID,
                        Customers.FirstName,
                        Customers.LastName,
                        Customers.Contact,
                        Customers.InitialDebt";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CustomerCard card = new CustomerCard(this);
                        card.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                        card.CustomerName =
                            reader["FirstName"].ToString()
                            + " "
                            + reader["LastName"].ToString();
                        decimal debt = Convert.ToDecimal(reader["TotalDebt"]);
                        card.Contact = reader["Contact"].ToString();
                        card.TotalDebt = "₱" + debt.ToString("N2");
                        flowCustomers.Controls.Add(card);
                    }
                }
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer form = new AddCustomer(this);
            form.ShowDialog();
        }
    }
}
