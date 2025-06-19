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
    public partial class formBook : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;

        public formBook()
        {
            InitializeComponent();
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\DITP2123\\Labtest2\\LABTEST2\\LABTEST2\\AdmiralBookstoreDatabase.mdf;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void bookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.admiralBookstore);

        }

        private void formBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'admiralBookstore.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.admiralBookstore.Book);
            LoadData();

        }

        private void LoadData()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\DITP2123\\Labtest2\\LABTEST2\\LABTEST2\\AdmiralBookstoreDatabase.mdf;Integrated Security=True";
            string query = "SELECT * FROM Book";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Book");

                bookDGV.DataSource = dataSet.Tables["Book"];
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string query = "UPDATE Book SET Title = @Title, Publisher = @Publisher, PublishDate = @PublishDate WHERE [ISBN-13] = @ISBN13";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ISBN13", iSBNtxtbx.Text);
                    command.Parameters.AddWithValue("@Title", titletxtBx.Text);
                    command.Parameters.AddWithValue("@Publisher", publishertxtBx.Text);
                    command.Parameters.AddWithValue("@PublishDate", publishDTP.Value);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadData();
                ClearInputs();
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(iSBNtxtbx.Text) || string.IsNullOrEmpty(titletxtBx.Text) ||
                string.IsNullOrEmpty(publishertxtBx.Text) || publishDTP.Value == DateTimePicker.MinimumDateTime)
            {
                MessageBox.Show("Please fill in all fields.");
                return false;
            }
            return true;
        }

        private void ClearInputs()
        {
            iSBNtxtbx.Clear();
            titletxtBx.Clear();
            publishertxtBx.Clear();
        }

        private void btnAuthorA_Click(object sender, EventArgs e)
        {
            FormAuthor fAuthor = new FormAuthor();
            fAuthor.Show();
            this.Hide();
        }

        private void btnStockB_Click_1(object sender, EventArgs e)
        {
            formStock fStock = new formStock();
            fStock.Show();
            this.Hide();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string query = "INSERT INTO Book ([ISBN-13], Title, Publisher, PublishDate) VALUES (@ISBN13, @Title, @Publisher, @PublishDate)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ISBN13", iSBNtxtbx.Text);
                    command.Parameters.AddWithValue("@Title", titletxtBx.Text);
                    command.Parameters.AddWithValue("@Publisher", publishertxtBx.Text);
                    command.Parameters.AddWithValue("@PublishDate", publishDTP.Value);

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
