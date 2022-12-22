using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PharmacyManagementSystem.AdministratorUC
{
    public partial class UC_AddUser : UserControl
    {
        function fn = new function();
        String query;
        //string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=pharmacy";
        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            String role = txtUserRole.Text;
            String name = txtName.Text;
            String dob = txtDob.Text;
            Int64 mobile = Int64.Parse(txtMobileNo.Text);
            // String mobile;
            // mobile = txtMobileNo.ToString();
            String email = txtEmail.Text;
            String username = txtUsername.Text;
            String pass = txtPassword.Text;

             try
             {
                 query = "insert into users(userRole,name,dob,mobile,email,username,pass) values('"+role+"','"+name+"','"+dob+"','"+mobile+"','"+email+"','"+username+"','"+pass+"')";
                  fn.setData(query, "Sign up Successful");
             }
             catch(Exception)
             {
                 MessageBox.Show("Username Already exit","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtName.Clear();
            txtDob.ResetText();
            txtMobileNo.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtUserRole.SelectedIndex = -1;
        }

        private void UC_AddUser_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            query = "select *from users where username='" + txtUsername.Text + "'";
            DataSet ds = fn.getData(query);
            if(ds.Tables[0].Rows.Count==0)
            {
                pictureBox1.ImageLocation = @"F:\All CSE File\3rd year 1st semester\c sharp\Pharmacy Management System in C#\yes.png";
            }
            else
            {
                pictureBox1.ImageLocation = @"F:\All CSE File\3rd year 1st semester\c sharp\Pharmacy Management System in C#\no.png";
            }
        }
    }
}
