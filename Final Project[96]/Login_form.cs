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

namespace Employee_Management_System
{
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=AMJAD;Initial Catalog=ems;Integrated Security=True");

        private void clear_Click(object sender, EventArgs e)
        {
            user_name.Clear();
            password.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Click(object sender, EventArgs e)
        {
            conn.Open();
            string Username = user_name.Text;
            string Password = password.Text;

            string query_select = "SELECT * FROM Login WHERE username ='" + Username +"'AND password = '" + Password + "'";
            SqlCommand cmnd = new SqlCommand(query_select, conn);
            SqlDataReader row = cmnd.ExecuteReader();
            if (row.HasRows )
            {
                this.Hide();
                registration_form obj = new registration_form();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login Credantials, Please check Username & Password and try again ! ", "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
