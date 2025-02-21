using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Clients : Form
    {
        // Connection string
        private string connectionString = "Server=DESKTOP-DPS8O57;Database=LibraryManagment;Integrated Security=True;";

        public Clients()
        {
            InitializeComponent();
        }

        // The Load event handler to initialize combo box with status options
        private void Clients_Load(object sender, EventArgs e)
        {
            // Populate comboBoxStatus with options like Active, Inactive
            comboBoxStatus.Items.Clear(); // Clear any existing items
            comboBoxStatus.Items.Add("Active");
            comboBoxStatus.Items.Add("Inactive");

            // Optionally set the default value to "Active" if desired
            comboBoxStatus.SelectedIndex = 0; // Default is "Active"
        }


        // Add button functionality (Save client to the database)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate inputs before proceeding
            if (string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                // Create a new client record
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Clients (First_Name, Last_Name, Date_of_Birth, Email, Phone, Address, Membership_Active) " +
                                   "VALUES (@FirstName, @LastName, @DateOfBirth, @Email, @Phone, @Address, @MembershipActive)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Split the Full Name into First and Last Name (assuming full name is in txtFullName)
                        string[] nameParts = txtFullName.Text.Split(' ');
                        string firstName = nameParts[0];
                        string lastName = nameParts.Length > 1 ? nameParts[1] : "";

                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@DateOfBirth", dateTimePickerBirthdate.Value);
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);
                        command.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        command.Parameters.AddWithValue("@Address", txtAddress.Text);
                        command.Parameters.AddWithValue("@MembershipActive", comboBoxStatus.SelectedItem.ToString() == "Active" ? 1 : 0);

                        command.ExecuteNonQuery();  // Execute the query to insert the data
                    }
                }

                MessageBox.Show("Client added successfully.");
                ClearFields(); // Optional: Clear fields after adding client
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        // Save button functionality (Update client in the database)
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validation for inputs
            if (string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                // Update client details in the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Clients SET First_Name = @FirstName, Last_Name = @LastName, Date_of_Birth = @DateOfBirth, " +
                                   "Email = @Email, Phone = @Phone, Address = @Address, Membership_Active = @MembershipActive " +
                                   "WHERE Email = @Email";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        string[] nameParts = txtFullName.Text.Split(' ');
                        string firstName = nameParts[0];
                        string lastName = nameParts.Length > 1 ? nameParts[1] : "";

                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@DateOfBirth", dateTimePickerBirthdate.Value);
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);
                        command.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        command.Parameters.AddWithValue("@Address", txtAddress.Text);
                        command.Parameters.AddWithValue("@MembershipActive", comboBoxStatus.SelectedItem.ToString() == "Active" ? 1 : 0);
                        // Assuming you have the Client_ID to update
                        command.Parameters.AddWithValue("@ClientID", 1); // Replace 1 with actual Client_ID

                        command.ExecuteNonQuery(); // Execute the query to update the data
                    }
                }

                MessageBox.Show("Client updated successfully.");
                ClearFields(); // Optional: Clear fields after saving client
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }




        // Optional: Method to clear input fields after an action
        private void ClearFields()
        {
            txtFullName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            comboBoxStatus.SelectedIndex = -1;
            dateTimePickerBirthdate.Value = DateTime.Now;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
