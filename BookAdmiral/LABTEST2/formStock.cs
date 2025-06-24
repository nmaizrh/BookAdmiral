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

namespace LABTEST2
{
    public partial class formStock : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;

        public formStock()
        {
            InitializeComponent();
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\DITP2123\\Labtest2\\LABTEST2\\LABTEST2\\AdmiralBookstoreDatabase.mdf;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void stockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.admiralBookstore);

        }

        private void formStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'admiralBookstore.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.admiralBookstore.Stock);
            LoadData();

        }

        private void LoadData()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\DITP2123\\Labtest2\\LABTEST2\\LABTEST2\\AdmiralBookstoreDatabase.mdf;Integrated Security=True";
            string query = "SELECT * FROM Stock";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Stock");
                stockDGV.DataSource = dataSet.Tables["Stock"];
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(stockIDtxtbx.Text) || string.IsNullOrEmpty(authorIDtxtbx.Text) ||
                string.IsNullOrEmpty(iSBN13txtbx.Text) || string.IsNullOrEmpty(quantityInStockTextBox.Text) ||
                dateRecordtxtBx.Value == DateTimePicker.MinimumDateTime)
            {
                MessageBox.Show("Please fill in all fields.");
                return false;
            }
            return true;
        }

        private void ClearInputs()
        {
            stockIDtxtbx.Clear();
            authorIDtxtbx.Clear();
            iSBN13txtbx.Clear();
            quantityInStockTextBox.Clear();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string query = "INSERT INTO Stock (StockID, AuthorID, [ISBN-13], QuantityInStock, DateRecorded) VALUES (@StockID, @AuthorID, @ISBN13, @QuantityInStock, @DateRecorded)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StockID", stockIDtxtbx.Text);
                    command.Parameters.AddWithValue("@AuthorID", authorIDtxtbx.Text);
                    command.Parameters.AddWithValue("@ISBN13", iSBN13txtbx.Text);
                    command.Parameters.AddWithValue("@QuantityInStock", quantityInStockTextBox.Text);
                    command.Parameters.AddWithValue("@DateRecorded", dateRecordtxtBx.Value);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadData();
                ClearInputs();
            }

        }

        private void btnAuthorS_Click_1(object sender, EventArgs e)
        {
            FormAuthor fAuthor = new FormAuthor();
            fAuthor.Show();
            this.Hide();
        }

        private void btnBookS_Click_1(object sender, EventArgs e)
        {
            formBook fBook = new formBook();
            fBook.Show();
            this.Hide();
        }

        private void btnDeleteStock_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(stockIDtxtbx.Text))
            {
                string query = "DELETE FROM Stock WHERE StockID = @StockID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StockID", stockIDtxtbx.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadData();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Please enter a StockID to delete.");
            }
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string query = "UPDATE Stock SET AuthorID = @AuthorID, [ISBN-13] = @ISBN13, QuantityInStock = @QuantityInStock, DateRecorded = @DateRecorded WHERE StockID = @StockID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StockID", stockIDtxtbx.Text);
                    command.Parameters.AddWithValue("@AuthorID", authorIDtxtbx.Text);
                    command.Parameters.AddWithValue("@ISBN13", iSBN13txtbx.Text);
                    command.Parameters.AddWithValue("@QuantityInStock", quantityInStockTextBox.Text);
                    command.Parameters.AddWithValue("@DateRecorded", dateRecordtxtBx.Value);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadData();
                ClearInputs();
            }
        }
    }
}
