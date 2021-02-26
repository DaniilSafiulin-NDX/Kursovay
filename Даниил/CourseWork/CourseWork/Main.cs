using CourseWork.Запросы;
using System;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Main : Form
    {
        private Queries db = new Queries();
        public Main()
        {
            InitializeComponent();
            DataGrid.Visible = false;
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGrid.Visible = true;
            DataGrid.DataSource = db.GetUsersTable();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGrid.Visible = true;
            DataGrid.DataSource = db.GetBooksTable();
        }

        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGrid.Visible = true;
            DataGrid.DataSource = db.GetNotesTable();
        }

        private void usersToolStripMenuItem1_Click(object sender, EventArgs e)
        {


        }
    }
}
