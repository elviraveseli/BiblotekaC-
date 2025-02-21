using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class OverdueLoans : Form
    {
        private string connectionString = "Server=DESKTOP-DPS8O57;Database=LibraryManagment;Integrated Security=True;";


        public OverdueLoans()
        {
            InitializeComponent();
        }

        private void OverdueLoans_Load(object sender, EventArgs e)
        {
            // Optionally, load data on form load if you want to display all overdue loans initially
            LoadOverdueLoans(DateTime.Now);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // Get the selected date from the DateTimePicker
            DateTime selectedDate = dateTimePickerOverdueLoans.Value;

            // Load overdue loans based on the selected date
            LoadOverdueLoans(selectedDate);
        }

        private void LoadOverdueLoans(DateTime selectedDate)
        {
            string query = "SELECT Loan_ID, First_Name,Last_Name, Title, Loan_Date, Return_Date, Actual_Return_Date, Days_Overdue, Penalty_Fee " +
                           "FROM Overdue_Loans " +
                           "WHERE Return_Date <= @selectedDate AND Actual_Return_Date > Return_Date"; // Assuming you're looking for overdue loans that haven't been returned

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@selectedDate", selectedDate);

                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                // Bind the DataGridView to the DataTable
                dataGridViewOverdueLoans.DataSource = dt;
            }
        }
    }
}
