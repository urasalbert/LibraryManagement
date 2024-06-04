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
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source=DESKTOP-UK8VSNU\\SQLEXPRESS;database=LibraryManagement;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select * from student_table";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
        int student_id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count && e.ColumnIndex < dataGridView1.Columns.Count)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    if (int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), out int id))
                    {
                        student_id = id;
                        panel2.Visible = true;

                        SqlConnection conn = new SqlConnection();
                        conn.ConnectionString = "data source=DESKTOP-UK8VSNU\\SQLEXPRESS;database=LibraryManagement;integrated security=True";
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;

                        cmd.CommandText = "select * from student_table where id = @student_id";
                        cmd.Parameters.AddWithValue("@student_id", student_id);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            txt_studentname.Text = ds.Tables[0].Rows[0][1].ToString();
                            txt_studentsurname.Text = ds.Tables[0].Rows[0][2].ToString();
                            txt_department.Text = ds.Tables[0].Rows[0][3].ToString();
                            txt_studentID.Text = ds.Tables[0].Rows[0][4].ToString();
                            txt_studentpw.Text = ds.Tables[0].Rows[0][5].ToString();
                            txt_studentmail.Text = ds.Tables[0].Rows[0][6].ToString();
                        }
                    }
                }
            }
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchID = txt_search.Text.Trim();

            if (!string.IsNullOrEmpty(searchID))
            {
                string connectionString = "data source=DESKTOP-UK8VSNU\\SQLEXPRESS;database=LibraryManagement;integrated security=True";
                string query = "SELECT * FROM student_table WHERE studentID LIKE @searchID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@searchID", "%" + searchID + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            else
            {
                ViewStudent_Load(sender, e);//arama kutusu boşsa her şeyi yükler
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (student_id > 0)
            {
                string name = txt_studentname.Text;
                string surname = txt_studentsurname.Text;
                string department = txt_department.Text;
                int studentID = Convert.ToInt32(txt_studentID.Text);
                string password = txt_studentpw.Text;
                string mail = txt_studentmail.Text;

                string connectionString = "data source=DESKTOP-UK8VSNU\\SQLEXPRESS;database=LibraryManagement;integrated security=True";
                string query = "UPDATE student_table SET name = @name, surname = @surname, " +
                "studentID = @studentID, password = @password, " +
                "email = @email " +
                "WHERE id = @student_id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@surname", surname);
                        command.Parameters.AddWithValue("@department", department);
                        command.Parameters.AddWithValue("@studentID", studentID);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@email", mail);
                        command.Parameters.AddWithValue("@student_id", student_id);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("The student information has been successfully updated.");
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
                MessageBox.Show("Please select a student to update.");
            }
        }

        private void btn_gotoreturn_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook = new ReturnBook();
            this.Hide();
            returnBook.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPageForm adminPageForm = new AdminPageForm();          
            this.Hide();
            adminPageForm.Show();
        }
    }
}

