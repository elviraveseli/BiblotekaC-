using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Loans : Form
    {
        private string connectionString = "Server=DESKTOP-DPS8O57;Database=LibraryManagment;Integrated Security=True;";

        public Loans()
        {
            InitializeComponent();
            btnAdd.Click += new EventHandler(btnAdd_Click);
        }

        private void Loans_Load(object sender, EventArgs e)
        {
            LoadClients();
            LoadMaterials();
            LoadLoans();  // Load loans if editing
            LoadPayments(); // Load payments if needed
        }

        // Load clients into comboBoxClient
        private void LoadClients()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Client_ID, First_Name, Last_Name FROM Clients", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Dictionary<int, string> clients = new Dictionary<int, string>();

                    while (reader.Read())
                    {
                        clients.Add(reader.GetInt32(0), reader.GetString(1) + " " + reader.GetString(2)); // Full Name
                    }

                    comboBoxClient.DataSource = new BindingSource(clients, null);
                    comboBoxClient.DisplayMember = "Value";
                    comboBoxClient.ValueMember = "Key";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading clients: " + ex.Message);
                }
            }
        }

        // Load materials into comboBoxMaterial
        private void LoadMaterials()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Material_ID, Title FROM Bibliographic_Materials", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Dictionary<int, string> materials = new Dictionary<int, string>();

                    while (reader.Read())
                    {
                        materials.Add(reader.GetInt32(0), reader.GetString(1));
                    }

                    comboBoxMaterial.DataSource = new BindingSource(materials, null);
                    comboBoxMaterial.DisplayMember = "Value";
                    comboBoxMaterial.ValueMember = "Key";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading materials: " + ex.Message);
                }
            }
        }

        // Load loans for editing, or initialize as new
        private void LoadLoans()
        {
            // This method is used if you're editing an existing loan
            // You can add a ComboBox or DataGridView to select a loan to edit
            // Example: Load loan details based on selected Loan_ID
            // For now, we’ll assume the loanID is set before calling Save
            // If you're editing, set loanID from the selected Loan_ID (this is an example)
            // loanID = selectedLoanID;
        }

        // Load payments (with Client's First and Last Name)
        private void LoadPayments()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            p.Payment_ID, 
                            p.Client_ID, 
                            c.First_Name, 
                            c.Last_Name, 
                            p.Amount, 
                            p.Payment_Date 
                        FROM Payments p
                        JOIN Clients c ON p.Client_ID = c.Client_ID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Example: Display or use the payment data
                    while (reader.Read())
                    {
                        int paymentId = reader.GetInt32(0);
                        int clientId = reader.GetInt32(1);
                        string firstName = reader.GetString(2);
                        string lastName = reader.GetString(3);
                        decimal amount = reader.GetDecimal(4);
                        DateTime paymentDate = reader.GetDateTime(5);

                        // You can display this data in a DataGridView or use it elsewhere
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading payments: " + ex.Message);
                }
            }
        }

        // Add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Loans (Client_ID, Material_ID, Loan_Date, Return_Date, Penalty_Fee) " +
                        "VALUES (@ClientID, @MaterialID, @LoanDate, @ReturnDate, @PenaltyFee)", conn);

                    int clientID = ((KeyValuePair<int, string>)comboBoxClient.SelectedItem).Key;
                    int materialID = ((KeyValuePair<int, string>)comboBoxMaterial.SelectedItem).Key;

                    cmd.Parameters.AddWithValue("@ClientID", clientID);
                    cmd.Parameters.AddWithValue("@MaterialID", materialID);
                    cmd.Parameters.AddWithValue("@LoanDate", dateTimePickerLoan.Value);
                    cmd.Parameters.AddWithValue("@ReturnDate", dateTimePickerReturn.Value);
                    cmd.Parameters.AddWithValue("@PenaltyFee", numericUpDownPenalty.Value);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Loan added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding loan: " + ex.Message);
            }
        }

        
    }
}
