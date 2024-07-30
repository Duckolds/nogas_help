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
    public partial class AdminDashboard : Form
    {
        private SqlConnection conn = new SqlConnection("server = DESKTOP-4P6JOQT\\SQLEXPRESS; database = LibraryManagement1; integrated security = true");

        public AdminDashboard()
        {
            InitializeComponent();
            conn.Open();
        }

        public AdminDashboard(string username)
        {
            InitializeComponent();
            conn.Open();

            MessageBox.Show("Welcome, " + username);
        }

        public void GetAuthors()
        {
            string query = "select author_id, author_name from Authors";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(table);
            cbAuthor.DataSource = table;
            cbAuthor.DisplayMember = "author_name";
            cbAuthor.ValueMember = "author_id";
        }

        public void GetCategories()
        {
            string query = "select category_id, category_name from Categories";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(table);
            cbCategory.DataSource = table;
            cbCategory.DisplayMember = "category_name";
            cbCategory.ValueMember = "category_id";
        }

        public void GetPublishers()
        {
            string query = "select publisher_id, publisher_name from Publishers";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(table);
            cbPublisher.DataSource = table;
            cbPublisher.DisplayMember = "publisher_name";
            cbPublisher.ValueMember = "publisher_id";
        }
    }
}
