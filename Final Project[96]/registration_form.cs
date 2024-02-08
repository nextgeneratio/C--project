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
using System.Diagnostics.Eventing.Reader;

namespace Employee_Management_System
{
    public partial class registration_form : Form
    {
        public registration_form()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=AMJAD;Initial Catalog=ems;Integrated Security=True");
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void exit_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to exit....?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            first_name.Text = "";
            last_name.Text = "";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            DateTime thisDay = DateTime.Today; 
            dateTimePicker1.Text = thisDay.ToString();
            male.Checked = false;
            female.Checked = false;
            address.Text = "";
            email.Text = "";
            mobile_no.Text = "";
            home_no.Text = "";
            deparment_name.Text = "";
            designation.Text = "";
            employee_type.Text = "";
        }

        private void registration_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = first_name.Text;
                string lastName = last_name.Text;
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy/MM/dd";
                string gender;
                if (male.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                string address1 = address.Text;
                string email1 = email.Text;
                int mobilephone = int.Parse(mobile_no.Text);
                int homePhone = int.Parse(home_no.Text);
                string departmentName = deparment_name.Text;
                string designation1 = designation.Text;
                string employeeType = employee_type.Text;
                string query_insert = "INSER INTO employee VALUES('" + firstName + "," + lastName + "," + dateTimePicker1.Text + "," + gender + "," + address1 +","+ email1 +","+ mobilephone + "," + homePhone + "," + departmentName + "," + designation + "," + employeeType + ")";
                conn.Open();
                SqlCommand cmnd = new SqlCommand(query_insert, conn);
                cmnd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Added Successfully!", "Registered Employee!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                string msg = "Insert Error: ";
                msg += ex.Message;
            }
        }

        private void first_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void mobile_no_TextChanged(object sender, EventArgs e)
        {

        }

        private void deparment_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void designation_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string no = comboBox1.Text;
            if (no != "New Register")
            {
                conn.Open();
                string query_select = "SELECT  *  FROM Registration2 WHERE regNo =" + no;
                SqlCommand cmd = new SqlCommand(query_select, conn);
                SqlDataReader row = cmd.ExecuteReader();
                while (row.Read())
                {
                    first_name.Text = row[1].ToString();
                    last_name.Text = row[2].ToString();
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.CustomFormat = "yyyy/MM/dd";
                    dateTimePicker1.Text = row[3].ToString();
                    if (row[4].ToString() == "Male")
                    {
                        male.Checked = true;
                        female.Checked = false;
                    }
                    else
                    {
                        male.Checked = false;
                        female.Checked = true;
                    }
                    address.Text = row[5].ToString();
                    email.Text = row[6].ToString();
                    mobile_no.Text = row[7].ToString();
                    home_no.Text = row[8].ToString();
                    deparment_name.Text = row[9].ToString();
                    designation.Text = row[10].ToString();
                    employee_type.Text = row[11].ToString();
                }
                conn.Close();
                registration.Enabled = false;
                update.Enabled = true;
                delete.Enabled = true;
            }
            else
            {
                first_name.Text = " ";
                last_name.Text = " ";
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy/MM/dd";
                DateTime thisday = DateTime.Today;
                dateTimePicker1.Text = thisday.ToString();
                male.Checked = true;
                female.Checked = false;
                address.Text = " ";
                email.Text = " ";
                mobile_no.Text = " ";
                home_no.Text = " ";
                deparment_name.Text= " ";
                designation.Text = " ";
                employee_type.Text = " ";
                registration.Enabled = true;
                update.Enabled= false; 
                delete.Enabled = false;
            }
        }
     

        private void update_Click(object sender, EventArgs e)
        {
            string no = comboBox1.Text;
            if (no != "New Register")
            {
                string firstName = first_name.Text;
                string lastName = last_name.Text;
                dateTimePicker1.Format = DateTimePickerFormat.Custom; 
                dateTimePicker1.CustomFormat = "yyyy/MM/dd";
                string gender;
                if (male.Checked)
                {
                    gender = "Male";
                }
                else if (female.Checked)
                {
                    gender = "Female";
                }
                else
                {
                    gender = "None";
                }
            
                string address1 = address.Text;
                string email1 = email.Text;
                int mobilephone = int.Parse(mobile_no.Text);
                int homePhone = int.Parse(home_no.Text);
                string departmentName = deparment_name.Text; 
                string designation = deparment_name.Text;
                string employeeType = employee_type.Text;
                string query_insert =  "UPDATE employee SET firstName = '"+ firstName + "', lastName ='" + lastName + "',dateOfBirth = '" + dateTimePicker1.Text + "',gender = '" + gender + "', address = '" + address1 + "', email = '" + email1 +  "',mobilePhone = '" + mobilephone + "', homePhone = '"+ homePhone + "', departmentName = '" + departmentName + "',designation = '" + designation + "', employeeType = '" + employeeType + "',WHERE empNo = '"+ no;
                conn.Open();
                SqlCommand cmnd = new SqlCommand(query_insert, conn);
                cmnd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Updated Successfully!", "Updated Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void employee_type_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            {
                var result = MessageBox.Show("Are you sure, Do you really want to Delete this Record....?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string no = comboBox1.Text;
                    string query_insert = "DELETE FROM employee WHERE empNo = " + no + "";
                    conn.Open();
                    SqlCommand cmnd = new SqlCommand(query_insert, conn);
                    cmnd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record Deleted Successfully!", "Deleted Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void logout_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_form obj = new Login_form();
            obj.Show();
            this.Close();
        }

        private void registration_form_Load(object sender, EventArgs e)
        {
            conn.Open();
            string query_select = "SELECT * FROM employee";
            SqlCommand cmnd = new SqlCommand(query_select, conn);
            SqlDataReader row = cmnd.ExecuteReader();
            comboBox1.Items.Add("New Register");
            while(row.Read())
            {
                comboBox1.Items.Add(row[0].ToString());
            }
            conn.Close();
        }
    }   
}
