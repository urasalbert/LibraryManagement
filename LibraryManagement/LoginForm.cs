using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UK8VSNU\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True;");

        private void x_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void username_txtBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (username_txtBox.Text == "E-Mail")
            {
                username_txtBox.Clear();
            }
        }

        private void password_txtBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (password_txtBox.Text == "Password")
            {
                password_txtBox.Clear();
                password_txtBox.PasswordChar = '*';

            }
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string studentEmail = username_txtBox.Text;
            string studentPassword = password_txtBox.Text;

            try
            {

                string query = "SELECT * FROM student_table WHERE email = @studentEmail AND password = @studentPassword";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.SelectCommand.Parameters.AddWithValue("@studentEmail", studentEmail);
                sda.SelectCommand.Parameters.AddWithValue("@studentPassword", studentPassword);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                   
                    string userID = dt.Rows[0]["id"].ToString();//userid sonrasi için kaydedildi
                    NonAdminForm userform = new NonAdminForm(userID);
                    ReturnBook returnbookform = new ReturnBook();
                    userform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    password_txtBox.Clear();
                    username_txtBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadScreen_form_Load(object sender, EventArgs e)
        {

        }    

        private void password_txtBox_KeyPress(object sender, KeyPressEventArgs e)
            //tab ile geçiş sırasında password görünümü bozulmasın
        {
            if (password_txtBox.Text == "Password")
            {
                password_txtBox.Clear();
                password_txtBox.PasswordChar = '*';

            }
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            AdminLoginForm loginForm = new AdminLoginForm();
            loginForm.Show();
            this.Hide();
        }

    }
}
