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
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (txt_studentname.Text != "" && txt_studentname.Text != "" && txt_department.Text != "" && txt_studentID.Text != ""
                && txt_studentpw.Text != "" && txt_studentmail.Text != "")
            {
                String studentname = txt_studentname.Text;
                String studentsurname = txt_studentsurname.Text;
                String department = txt_department.Text;
                int id = Convert.ToInt32(txt_studentID.Text);
                String password = txt_studentpw.Text;
                String mail = txt_studentmail.Text;

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source=DESKTOP-UK8VSNU\\SQLEXPRESS;database=LibraryManagement;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                conn.Open();
                cmd.CommandText = "insert into student_table (name,surname,department,studentID,password,email)" +
                    "values('" + studentname + "', '" + studentsurname + "', '" + department + "', '" + id + "','" + password + "','" + mail + "')";
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data Saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Book information cannot be left blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            txt_studentname.Clear();
            txt_studentsurname.Clear();
            txt_department.Clear();
            txt_studentID.Clear();
            txt_studentpw.Clear();
            txt_studentmail.Clear();
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminPageForm urs = new AdminPageForm();
            this.Hide();
            urs.Show();
        }
    }
}
