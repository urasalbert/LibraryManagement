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
    public partial class ReturnBookNonAdmin : Form
    {

        string userID;
        string borrowID;
        public ReturnBookNonAdmin(string userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void ReturnBookNonAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("data source=DESKTOP-UK8VSNU\\SQLEXPRESS;database=LibraryManagement;integrated security=True"))
                {
                    conn.Open();
                    string query = "SELECT * FROM borrowedbooks WHERE UserID = @UserID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", userID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Columns.Contains("BorrowID"))
                    {
                        borrowID = ds.Tables[0].Rows[0]["BorrowID"].ToString();
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("No books found to return.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        NonAdminForm nonadmin = new NonAdminForm(userID);
                        this.Close();
                        nonadmin.Show();
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
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[0].Visible = false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            NonAdminForm nonadmin = new NonAdminForm(userID);
            this.Hide();
            nonadmin.Show();
        }
    }
}
