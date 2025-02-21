using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class LibrarianDashboard : Form
    {
        // Database connection string
        private string connectionString = "Server=DESKTOP-DPS8O57;Database=LibraryManagment;Integrated Security=True;";

        public LibrarianDashboard()
        {
            InitializeComponent();
        }

        private void LibrarianDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnMaterials_Click(object sender, EventArgs e)
        {
            // Open the Bibliographic Materials form
            BiblograficMaterials materialsForm = new BiblograficMaterials();
            materialsForm.Show();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            // Open the Clients form
            Clients clientsForm = new Clients();
            clientsForm.Show();
        }

        private void btnLoans_Click(object sender, EventArgs e)
        {
            // Open the Loans form
            Loans loansForm = new Loans();
            loansForm.Show();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            // Open the Payments form
            Payments paymentsForm = new Payments();
            paymentsForm.Show();
        }

        // New event handler for TotalPayments button
        private void btnTotalPayments_Click(object sender, EventArgs e)
        {
            Total_Payments total_PaymentsForm = new Total_Payments();
            total_PaymentsForm.Show();
        }

        private void btnOverdueLoans_Click(object sender, EventArgs e)
        {
            OverdueLoans overdueLoansForm = new OverdueLoans();
            overdueLoansForm.Show();
        }
        private void btnActiveClients_Click(object sender, EventArgs e)
        {
            ActiveClients activeClientsForm = new ActiveClients();
            activeClientsForm.Show();
        }
    }
}
