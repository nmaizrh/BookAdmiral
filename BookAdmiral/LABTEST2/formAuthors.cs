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
    public partial class FormAuthor : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;

        public FormAuthor()
        {
            InitializeComponent();
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\DITP2123\\Labtest2\\LABTEST2\\LABTEST2\\AdmiralBookstoreDatabase.mdf;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void authorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.authorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.admiralBookstore);

        }

        private void FormAuthor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'admiralBookstore.Author' table. You can move, or remove it, as needed.
            this.authorTableAdapter.Fill(this.admiralBookstore.Author);
            LoadData();

        }

        private void LoadData()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\DITP2123\\Labtest2\\LABTEST2\\LABTEST2\\AdmiralBookstoreDatabase.mdf;Integrated Security=True";
            string query = "SELECT * FROM Author";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Author");

                authorDGV.DataSource = dataSet.Tables["Author"];
            }
        }

        private void authorIDtextbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void nametxtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void birthYeartxtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string query = "INSERT INTO Author (AuthorID, Name, BirthYear) VALUES (@AuthorID, @Name, @BirthYear)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AuthorID", authorIDtextbx.Text);
                    command.Parameters.AddWithValue("@Name", nametxtbx.Text);
                    command.Parameters.AddWithValue("@BirthYear", birthYeartxtbx.Text);

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
            if (string.IsNullOrEmpty(authorIDtextbx.Text) || string.IsNullOrEmpty(nametxtbx.Text) ||
                string.IsNullOrEmpty(birthYeartxtbx.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return false;
            }
            return true;
        }

        private void ClearInputs()
        {
            authorIDtextbx.Clear();
            nametxtbx.Clear();
            birthYeartxtbx.Clear();
        }

        private void btnStockA_Click(object sender, EventArgs e)
        {
            formStock fStock = new formStock();
            fStock.Show();
            this.Hide();

        }

        private void btnBookA_Click(object sender, EventArgs e)
        {
            formBook fBook = new formBook();
            fBook.Show();
            this.Hide();

        }
    }
}
