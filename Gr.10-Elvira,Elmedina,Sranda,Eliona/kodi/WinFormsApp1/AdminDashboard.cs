using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        // Event handlers for button clicks
        // Event Handlers for Button Clicks (ensure they are only defined once)
        private void btnBiblograficMaterials_Click(object sender, EventArgs e)
        {
            BiblograficMaterials biblograficMaterialsForm = new BiblograficMaterials();
            biblograficMaterialsForm.Show();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            Clients clientsForm = new Clients();
            clientsForm.Show();
        }

        private void btnLoans_Click(object sender, EventArgs e)
        {
            Loans loansForm = new Loans();
            loansForm.Show();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            Payments paymentsForm = new Payments();
            paymentsForm.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Users usersForm = new Users();
            usersForm.Show();
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

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
