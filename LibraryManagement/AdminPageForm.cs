using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class AdminPageForm : Form
    {
        public AdminPageForm()
        {
            InitializeComponent();
        }

        private void UserPageForm_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook addbook = new AddBook();
            addbook.Show();

        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBook viewbook = new ViewBook();
            this.Hide();
            viewbook.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addstudent = new AddStudentForm();
            addstudent.Show();
            this.Hide();
        }

        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudent viewstudent = new ViewStudent();
            viewstudent.Show();
            this.Hide();
        }
        private void viewStudentRentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook returnbook = new ReturnBook();
            returnbook.Show();
            this.Hide();
        }
    }
}
