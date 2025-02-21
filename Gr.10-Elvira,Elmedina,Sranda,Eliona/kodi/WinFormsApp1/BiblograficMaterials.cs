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
    public partial class BiblograficMaterials : Form
    {
        private string connectionString = "Server=DESKTOP-DPS8O57;Database=LibraryManagment;Integrated Security=True;";

        public BiblograficMaterials()
        {
            InitializeComponent();
        }

        private void BiblograficMaterials_Load(object sender, EventArgs e)
        {
            // Populate the Material Type dropdown
            comboBoxMaterialType.Items.Add("Book");
            comboBoxMaterialType.Items.Add("Ebook");
            comboBoxMaterialType.Items.Add("Audio Book");
            comboBoxMaterialType.Items.Add("Online Course");
        }

        // Save or Update bibliographic material
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Collect data from the form
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            string coAuthor = txtCoAuthors.Text;
            string publisher = txtPublisher.Text;
            DateTime publicationDate = dateTimePickerPublication.Value;
            string isbn = txtISBN.Text;
            string doi = txtDOI.Text;
            string materialType = comboBoxMaterialType.SelectedItem.ToString();
            int availableCopies = (int)numericUpDownAvaliableCopies.Value;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check if a record with the given ISBN already exists
                string checkQuery = "SELECT COUNT(*) FROM Bibliographic_Materials WHERE ISBN = @ISBN";
                SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@ISBN", isbn);
                int recordCount = (int)checkCommand.ExecuteScalar();

                // If the record exists, update it; otherwise, insert it
                if (recordCount > 0)
                {
                    string updateQuery = "UPDATE Bibliographic_Materials SET Title = @Title, Author = @Author, Co_Authors = @CoAuthor, Publisher = @Publisher, " +
                                         "Publication_Date = @PublicationDate, DOI = @DOI, Material_Type = @MaterialType, Available_Copies = @AvailableCopies " +
                                         "WHERE ISBN = @ISBN";

                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@Title", title);
                    updateCommand.Parameters.AddWithValue("@Author", author);
                    updateCommand.Parameters.AddWithValue("@CoAuthor", coAuthor);
                    updateCommand.Parameters.AddWithValue("@Publisher", publisher);
                    updateCommand.Parameters.AddWithValue("@PublicationDate", publicationDate);
                    updateCommand.Parameters.AddWithValue("@DOI", doi);
                    updateCommand.Parameters.AddWithValue("@MaterialType", materialType);
                    updateCommand.Parameters.AddWithValue("@AvailableCopies", availableCopies);
                    updateCommand.Parameters.AddWithValue("@ISBN", isbn);

                    updateCommand.ExecuteNonQuery();
                    MessageBox.Show("Bibliographic material updated successfully!");
                }
                else
                {
                    string insertQuery = "INSERT INTO Bibliographic_Materials (Title, Author, Co_Authors, Publisher, Publication_Date, ISBN, DOI, Material_Type, Available_Copies) " +
                                         "VALUES (@Title, @Author, @CoAuthor, @Publisher, @PublicationDate, @ISBN, @DOI, @MaterialType, @AvailableCopies)";

                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@Title", title);
                    insertCommand.Parameters.AddWithValue("@Author", author);
                    insertCommand.Parameters.AddWithValue("@CoAuthor", coAuthor);
                    insertCommand.Parameters.AddWithValue("@Publisher", publisher);
                    insertCommand.Parameters.AddWithValue("@PublicationDate", publicationDate);
                    insertCommand.Parameters.AddWithValue("@ISBN", isbn);
                    insertCommand.Parameters.AddWithValue("@DOI", doi);
                    insertCommand.Parameters.AddWithValue("@MaterialType", materialType);
                    insertCommand.Parameters.AddWithValue("@AvailableCopies", availableCopies);

                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Bibliographic material added successfully!");
                }

                // Optionally, clear the form after saving
                ClearForm();
            }
        }

        // Function to clear the form fields after saving
        private void ClearForm()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            txtCoAuthors.Clear();
            txtPublisher.Clear();
            txtISBN.Clear();
            txtDOI.Clear();
            numericUpDownAvaliableCopies.Value = 0;
            comboBoxMaterialType.SelectedIndex = -1;
        }

        // Add new bibliographic material
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Collect data from the form
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            string coAuthor = txtCoAuthors.Text;
            string publisher = txtPublisher.Text;
            DateTime publicationDate = dateTimePickerPublication.Value;
            string isbn = txtISBN.Text;
            string doi = txtDOI.Text;
            string materialType = comboBoxMaterialType.SelectedItem.ToString();
            int availableCopies = (int)numericUpDownAvaliableCopies.Value;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO Bibliographic_Materials (Title, Author, Co_Authors, Publisher, Publication_Date, ISBN, DOI, Material_Type, Available_Copies) " +
                                 "VALUES (@Title, @Author, @CoAuthor, @Publisher, @PublicationDate, @ISBN, @DOI, @MaterialType, @AvailableCopies)";

                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@Title", title);
                insertCommand.Parameters.AddWithValue("@Author", author);
                insertCommand.Parameters.AddWithValue("@CoAuthor", coAuthor);
                insertCommand.Parameters.AddWithValue("@Publisher", publisher);
                insertCommand.Parameters.AddWithValue("@PublicationDate", publicationDate);
                insertCommand.Parameters.AddWithValue("@ISBN", isbn);
                insertCommand.Parameters.AddWithValue("@DOI", doi);
                insertCommand.Parameters.AddWithValue("@MaterialType", materialType);
                insertCommand.Parameters.AddWithValue("@AvailableCopies", availableCopies);

                insertCommand.ExecuteNonQuery();
                MessageBox.Show("Bibliographic material added successfully!");

                // Optionally, clear the form after saving
                ClearForm();
            }
        }

        


    }
}
