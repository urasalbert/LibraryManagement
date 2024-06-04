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
    public partial class ReturnBook : Form
    {

        string userID;
        string borrowID;
        
        public ReturnBook()
        {
            InitializeComponent();
            txt_studenID.Text = userID;

        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source=DESKTOP-UK8VSNU\\SQLEXPRESS;database=LibraryManagement;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                // Sadece isReturned değeri false olan kitapları seç
                cmd.CommandText = "SELECT * FROM borrowedbooks WHERE isReturned = 0";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

                if (dataGridView1.Rows.Count > 0 && dataGridView1.Columns.Contains("BorrowID"))
                {
                    DataGridViewCell borrowIDCell = dataGridView1.Rows[0].Cells["BorrowID"];

                    if (borrowIDCell.Value != null)
                    {
                        borrowID = borrowIDCell.Value.ToString();
                    }
                    else
                    {
                        MessageBox.Show("There are no books found to return.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AdminPageForm adminpage = new AdminPageForm();
                        this.Close();
                        adminpage.Show();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.Columns[5].Visible = false;//isReturned bilgisi öğrencilere gözükmemeli
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Geçerli bir satır seçildiyse devam et
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                borrowID = row.Cells["BorrowID"].Value.ToString(); // Seçilen satırın BorrowID değerini al
            }
        }

        DateTime returnDate = DateTime.Now;
        private void btn_return_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "data source=DESKTOP-UK8VSNU\\SQLEXPRESS;database=LibraryManagement;integrated security=True";
                string returnQuery = "INSERT INTO returnedbooks (BorrowID, ReturnDate) VALUES (@BorrowID, @ReturnDate)";
                string updateQuery = "UPDATE borrowedbooks SET isReturned = 1 WHERE BorrowID = @BorrowID"; // İade edilen kitabın isReturned değerini 1 yap

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(returnQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ReturnDate", returnDate);
                        command.Parameters.AddWithValue("@BorrowID", borrowID);
                        command.ExecuteNonQuery();
                    }
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))//borrowid değerini kullanarak kitabın teslim edildiğini belirle
                    {
                        updateCommand.Parameters.AddWithValue("@BorrowID", borrowID);
                        updateCommand.ExecuteNonQuery();
                    }


                    string selectQuery = "SELECT * FROM borrowedbooks WHERE isReturned = 0";

                    SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    MessageBox.Show("Book successfully returned!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error returning the book:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_studenID_TextChanged(object sender, EventArgs e)//userID bağımlı search bar
        {
            {
                try
                {
                    int userID;
                    if (int.TryParse(txt_studenID.Text.Trim(), out userID))
                    {
                        string filterExpression = string.Format("UserID = {0}", userID);
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = filterExpression;
                    }
                    else
                    {
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while searching: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_viewstudent_Click(object sender, EventArgs e)
        {
            ViewStudent viewStudent = new ViewStudent();
            this.Hide();
            viewStudent.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPageForm adminpage = new AdminPageForm();
            this.Hide();
            adminpage.Show();
        }
    }
}

