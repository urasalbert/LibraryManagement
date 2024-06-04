using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class AdminLoginForm : Form
    {
        private readonly string connectionString = @"Data Source=DESKTOP-UK8VSNU\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True;";

        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = username_txtBox.Text;
            string user_password = password_txtBox.Text;
            string email = txt_email.Text;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM admin_login WHERE username = @username AND password = @password AND email = @email";

                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", user_password);
                    command.Parameters.AddWithValue("@email", email);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        AdminPageForm adminform = new AdminPageForm();
                        adminform.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        password_txtBox.Clear();
                        username_txtBox.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }

        private void x_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void username_txtBox_Click(object sender, EventArgs e)
        {
            if (username_txtBox.Text == "Username")
            {
                username_txtBox.Clear();
            }
        }

        private void txt_email_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == "E-Mail")
            {
                txt_email.Clear();
            }
        }

        private void password_txtBox_Click(object sender, EventArgs e)
        {
            if (password_txtBox.Text == "Password")
            {
                password_txtBox.Clear();
                password_txtBox.PasswordChar = '*';

            }
        }

        private void password_txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (password_txtBox.Text == "Password")
            {
                password_txtBox.Clear();
                password_txtBox.PasswordChar = '*';

            }
        }

        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_email.Text == "E-Mail")
            {
                txt_email.Clear();
            }
        }

        private void username_txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (username_txtBox.Text == "Username")
            {
                username_txtBox.Clear();
            }
        }
    }
}
