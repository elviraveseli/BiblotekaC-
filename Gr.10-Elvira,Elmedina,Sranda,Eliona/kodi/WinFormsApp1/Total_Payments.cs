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

namespace WinFormsApp1
{
    public partial class Total_Payments : Form
    {
        private string connectionString = "Server=DESKTOP-DPS8O57;Database=LibraryManagment;Integrated Security=True;";

        public Total_Payments()
        {
            InitializeComponent();
        }

        private void Total_Payments_Load(object sender, EventArgs e)
        {
            // Populate ComboBox with months
            comboBoxMonth.Items.AddRange(new string[] {
                "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"
            });

            // Populate ComboBox with years (adjust as needed)
            for (int i = 2020; i <= DateTime.Now.Year; i++)
            {
                comboBoxYear.Items.Add(i.ToString());
            }

            // Select the current month and year by default
            comboBoxMonth.SelectedIndex = DateTime.Now.Month - 1;
            comboBoxYear.SelectedIndex = comboBoxYear.Items.IndexOf(DateTime.Now.Year.ToString());

            // Load data into DataGridView
            LoadData();
        }

        private void LoadData(int? month = null, int? year = null)
        {
            string query = "SELECT * FROM Total_Payments_Details";

            // Apply filter based on selected month and year
            if (month.HasValue && year.HasValue)
            {
                query += " WHERE MONTH(Payment_Date) = @Month AND YEAR(Payment_Date) = @Year";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                // Add parameters if month and year are selected
                if (month.HasValue && year.HasValue)
                {
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@Month", month);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@Year", year);
                }

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Bind data to DataGridView
                dataGridViewPayments.DataSource = dataTable;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // Get the selected month and year
            int selectedMonth = comboBoxMonth.SelectedIndex + 1; // Months start from 1
            int selectedYear = Convert.ToInt32(comboBoxYear.SelectedItem);

            // Reload data with the selected month and year
            LoadData(selectedMonth, selectedYear);
        }
    }
}
