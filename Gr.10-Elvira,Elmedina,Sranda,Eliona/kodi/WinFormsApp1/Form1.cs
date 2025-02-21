using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=DESKTOP-DPS8O57;Database=LibraryManagment;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
            chkShowPassword.CheckedChanged += new EventHandler(chkShowPassword_CheckedChanged);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.PasswordChar = '*';
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Role FROM Users WHERE Username=@username AND Password=@password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();
                object role = cmd.ExecuteScalar();
                conn.Close();

                if (role != null)
                {
                    MessageBox.Show("Login successful! Role: " + role.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OpenDashboard(role.ToString());
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OpenDashboard(string role)
        {
            if (role == "Administrator")
            {
                AdminDashboard adminForm = new AdminDashboard();
                adminForm.Show();
            }
            else if (role == "Librarian")
            {
                LibrarianDashboard librarianForm = new LibrarianDashboard();
                librarianForm.Show();
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
         

    }
}
