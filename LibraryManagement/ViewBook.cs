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
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }

        private void ViewBook_Load(object sender, EventArgs e)//datagrid yüklenmesini databaseden veri çekmesini sağlar
        {
            panel2.Visible = false;
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

        int book_id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count && e.ColumnIndex < dataGridView1.Columns.Count)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    if (int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), out int id))
                    {
                        book_id = id;
                        panel2.Visible = true;

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
                            txt_bookname.Text = ds.Tables[0].Rows[0][1].ToString();
                            txt_authorname.Text = ds.Tables[0].Rows[0][2].ToString();
                            txt_quantity.Text = ds.Tables[0].Rows[0][3].ToString();
                            txt_publication.Text = ds.Tables[0].Rows[0][4].ToString();
                            txt_price.Text = ds.Tables[0].Rows[0][5].ToString();
                            dtp_purchase.Value = Convert.ToDateTime(ds.Tables[0].Rows[0][6]);
                        }
                    }
                }
            }
        }


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
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
                ViewBook_Load(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_searchname.Clear();
            panel2.Visible = false;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (book_id > 0)
            {
                string bookName = txt_bookname.Text;
                string authorName = txt_authorname.Text;
                int quantity = Convert.ToInt32(txt_quantity.Text);
                string publication = txt_publication.Text;
                decimal price = Convert.ToDecimal(txt_price.Text);
                DateTime purchaseDate = dtp_purchase.Value;

                string connectionString = "data source=DESKTOP-UK8VSNU\\SQLEXPRESS;database=LibraryManagement;integrated security=True";
                string query = "UPDATE book_table SET book_name = @bookName, book_author_name = @authorName, " +
                               "book_quantity = @quantity, book_publication = @publication, " +
                               "book_price = @price, book_purchase_date = @purchaseDate " +
                               "WHERE book_id = @book_id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@bookName", bookName);
                        command.Parameters.AddWithValue("@authorName", authorName);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.Parameters.AddWithValue("@publication", publication);
                        command.Parameters.AddWithValue("@price", price);
                        command.Parameters.AddWithValue("@purchaseDate", purchaseDate);
                        command.Parameters.AddWithValue("@book_id", book_id);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("The book has been successfully updated.");
                            ViewBook_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Update operation failed.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a book to update.");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (book_id > 0)
            {
                string connectionString = "data source=DESKTOP-UK8VSNU\\SQLEXPRESS;database=LibraryManagement;integrated security=True";
                string query = "DELETE FROM book_table WHERE book_id = @book_id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@book_id", book_id);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("The book has been successfully deleted.");
                            ViewBook_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Delete operation failed.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a book to delete.");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AdminPageForm userpage = new AdminPageForm();
            this.Close();
            userpage.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
