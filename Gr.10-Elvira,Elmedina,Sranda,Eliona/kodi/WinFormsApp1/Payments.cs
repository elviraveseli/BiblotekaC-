using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Payments : Form
    {
        private string connectionString = "Server=DESKTOP-DPS8O57;Database=LibraryManagment;Integrated Security=True;";


        public Payments()
        {
            InitializeComponent();

        }

        private void Payments_Load(object sender, EventArgs e)
        {
            // Populate comboBoxClient with client data from database (joining Payments and Clients)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT c.Client_ID, c.First_Name + ' ' + c.Last_Name AS Client_Name " +
                               "FROM Clients c";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable clientTable = new DataTable();
                adapter.Fill(clientTable);

                comboBoxClient.DataSource = clientTable;
                comboBoxClient.ValueMember = "Client_ID";   // Use Client_ID as the value
                comboBoxClient.DisplayMember = "Client_Name"; // Display the full name
            }

            // Populate comboBoxType with predefined payment types
            comboBoxType.Items.Add("Monthly Subscription");
            comboBoxType.Items.Add("Late Fee");
            comboBoxType.Items.Add("Annual Subscription");
            // Add more payment types as needed
        }

        

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Ensure that all required fields are filled
            if (comboBoxClient.SelectedIndex == -1 || comboBoxType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a client and payment type.");
                return;
            }

            // Get the values from the controls
            int clientId = (int)comboBoxClient.SelectedValue; // Get Client_ID from ComboBox
            decimal amount = numericUpDownPayments.Value;
            DateTime paymentDate = dateTimePickerPayment.Value;
            string paymentType = comboBoxType.SelectedItem.ToString();

            // Insert data into the database
            string query = "INSERT INTO Payments (Client_ID, Amount, Payment_Date, Payment_Type) VALUES (@ClientID, @Amount, @PaymentDate, @PaymentType)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClientID", clientId);
                command.Parameters.AddWithValue("@Amount", amount);
                command.Parameters.AddWithValue("@PaymentDate", paymentDate);
                command.Parameters.AddWithValue("@PaymentType", paymentType);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Payment successfully added.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
