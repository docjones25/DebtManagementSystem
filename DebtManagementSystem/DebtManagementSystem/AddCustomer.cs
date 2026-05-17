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
    public partial class AddCustomer : Form
    {
        private CustomersControl customersControl;
        public AddCustomer(CustomersControl control)
        {
            InitializeComponent();
            customersControl = control;
        }
        private void SaveCustomer()
        {
            string connectionString =
                @"Data Source=.\SQLEXPRESS;
                Initial Catalog=DebtManagementSystemDB;
                Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    INSERT INTO Customers
                    (
                        FirstName,
                        LastName,
                        Contact,
                        InitialDebt
                    )
                    VALUES
                    (
                        @first,
                        @last,
                        @contact,
                        @debt
                    )";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@first", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@last", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@contact",txtContact.Text);
                    cmd.Parameters.AddWithValue("@debt", Convert.ToDecimal(txtInitialDebt.Text));
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Customer Added!");
            customersControl.LoadCustomers();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Trim() == "")
            {
                MessageBox.Show("Enter first name.");
                return;
            }

            if (txtLastName.Text.Trim() == "")
            {
                MessageBox.Show("Enter last name.");
                return;
            }
            SaveCustomer();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
