using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Login : Form
    {
        private SqlConnection conn = new SqlConnection("server = DESKTOP-4P6JOQT\\SQLEXPRESS; database = LibraryManagement1; integrated security = true");

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string query = "select * from Accounts where username = @username and user_password = @password";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", SqlDbType.NVarChar).Value = username;
            cmd.Parameters.AddWithValue("@password", SqlDbType.NVarChar).Value = password;

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string role = reader["user_role"].ToString();
                if (role.Equals("admin"))
                {
                    MessageBox.Show(this, "Login success", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    AdminDashboard admin = new AdminDashboard(username);
                    admin.ShowDialog();
                    this.Dispose();
                }
                else if (role.Equals("borrower"))
                {
                    MessageBox.Show(this, "Login success", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    BorrowerDashboard borrower = new BorrowerDashboard();
                    borrower.ShowDialog();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                }
            }
            conn.Close();
        }
    }
}
