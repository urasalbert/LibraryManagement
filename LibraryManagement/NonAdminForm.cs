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

namespace LibraryManagement
{
    public partial class NonAdminForm : Form
    {
        private string userID;
        public NonAdminForm(string userID)
        {
            InitializeComponent();
            this.userID = userID;// login formdan giriş yapan kişinin userID daha sonra rent için çekildi
        }

        private void NonAdminForm_Load(object sender, EventArgs e)
        {           
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source=DESKTOP-UK8VSNU\\SQLEXPRESS;database=LibraryManagement;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select * from book_table";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);


            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.Columns[6].Visible = false;
        }

        private void txt_searchname_TextChanged(object sender, EventArgs e)
        {

            string searchName = txt_searchname.Text.Trim();


            if (!string.IsNullOrEmpty(searchName))
            {
                string connectionString = "data source=DESKTOP-UK8VSNU\\SQLEXPRESS;database=LibraryManagement;integrated security=True";
                string query = "SELECT * FROM book_table WHERE book_name LIKE @searchName";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@searchName", "%" + searchName + "%");


                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            else
            {
                NonAdminForm_Load(sender, e);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        int book_id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count && e.ColumnIndex < dataGridView1.Columns.Count)
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        if (int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), out int id))
                        {
                            book_id = id;

                            SqlConnection conn = new SqlConnection();
                            conn.ConnectionString = "data source=DESKTOP-UK8VSNU\\SQLEXPRESS;database=LibraryManagement;integrated security=True";
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = conn;

                            cmd.CommandText = "select * from book_table where book_id = @bookId";
                            cmd.Parameters.AddWithValue("@bookId", book_id);

                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataSet ds = new DataSet();
                            da.Fill(ds);

                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                label2.Text = ds.Tables[0].Rows[0][1].ToString();

                            }
                        }
                    }
                }
            }
        }

        private void btn_rent_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime borrowDate = DateTime.Today;
                DateTime returnDate = borrowDate.AddDays(14);

                bool alreadyRented = CheckIfAlreadyRented(userID, book_id);

                if (alreadyRented)
                {
                    MessageBox.Show("You can't rent the same book!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = "data source=DESKTOP-UK8VSNU\\SQLEXPRESS;database=LibraryManagement;integrated security=True";
                string query = "INSERT INTO borrowedbooks (UserID, BookID, BorrowDate, ReturnDate) VALUES (@UserID, @BookID, @BorrowDate, @ReturnDate)";
                string updateQuery = "UPDATE book_table SET book_quantity = book_quantity - 1 WHERE book_id = @BookID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);
                        command.Parameters.AddWithValue("@BookID", book_id);
                        command.Parameters.AddWithValue("@BorrowDate", borrowDate);
                        command.Parameters.AddWithValue("@ReturnDate", returnDate);

                        connection.Open();
                        command.ExecuteNonQuery();

                       
                    }
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", book_id);
                        command.ExecuteNonQuery();
                    }
                   MessageBox.Show("Book successfully rented!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a book!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckIfAlreadyRented(string userID, int bookID)
        {
            string connectionString = "data source=DESKTOP-UK8VSNU\\SQLEXPRESS;database=LibraryManagement;integrated security=True";
            string query = "SELECT COUNT(*) FROM borrowedbooks WHERE UserID = @UserID AND BookID = @BookID AND isReturned = 0"; // isReturned 0 ise alabilecek

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@BookID", bookID);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    return count > 0; // Daha önce kiralanmışsa ve iade edilmemişse true döndür
                }
            }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            ReturnBookNonAdmin returnbookpage = new ReturnBookNonAdmin(userID);
            this.Hide();
            returnbookpage.Show();
        }
    }
}

