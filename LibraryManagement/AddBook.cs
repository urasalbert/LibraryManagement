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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void botton_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (bookname_txtbox.Text != "" && bookauthor_txtbox.Text != "" && bookquantity_txtbox.Text != ""
                && bookpublic_txtbox.Text != "" && bookprice_txtbox.Text != "")
            {
                String book_name = bookname_txtbox.Text;
                String book_author_name = bookauthor_txtbox.Text;
                int book_quantity = Convert.ToInt32(bookquantity_txtbox.Text);
                String book_publication = bookpublic_txtbox.Text;
                int price = Convert.ToInt32(bookprice_txtbox.Text);
                String book_date = bookdate_dtp.Value.ToString("yyyy-MM-dd");

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source=DESKTOP-UK8VSNU\\SQLEXPRESS;database=LibraryManagement;integrated security=True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                conn.Open();
                cmd.CommandText = "insert into book_table (book_name,book_author_name,book_quantity,book_publication,book_price,book_purchase_date) " +
                    "values ('" + book_name + "','" + book_author_name + "','" + book_quantity + "','" + book_publication + "', '" + price + "', '" + book_date + "')";

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
            bookname_txtbox.Clear();
            bookauthor_txtbox.Clear();
            bookquantity_txtbox.Clear();
            bookpublic_txtbox.Clear();
            bookprice_txtbox.Clear();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminPageForm frm = new AdminPageForm();
            frm.Show();
            this.Hide();
        }
    }
}
