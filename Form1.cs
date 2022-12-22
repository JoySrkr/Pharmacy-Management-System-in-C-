using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        /*
         * using MySql.Data.MySqlClient;
         * 
         * 
         * string connectionString ="datasource=127.0.0.1;
        port=3306;username=root;password=;database=pharmacy";

        public void login()
        {
        String query ="select *from login where email= '"+txtUsername.Text+"' and password='"+txtPassword.Text+"' ";

         MySqlConnection databseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

         try
            {
                databseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MessageBox.Show("Login to Adminstrator");
                        Adminstrator frm2 = new Adminstrator();
                        frm2.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid");
                }
                databseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
         
         */

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            
        }

        private void btnSign_Click(object sender, EventArgs e)
        {

            query = "select *from users";
            ds = fn.getData(query);
            if(ds.Tables[0].Rows.Count==0)
            {
                if(txtUsername.Text=="root" && txtPassword.Text=="root")
                {

                     Adminstrator admin = new Adminstrator();
                    admin.Show();
                    this.Hide();
                }
            }
            else
            {
                query = "select *from users where username ='" + txtUsername.Text + "' and pass='" + txtPassword.Text + "'";
                ds = fn.getData(query);
                    if(ds.Tables[0].Rows.Count!=0)
                {
                    String role = ds.Tables[0].Rows[0][1].ToString();
                    if(role=="Administrator")
                    {
                        Adminstrator admin = new Adminstrator(txtUsername.Text);
                        admin.Show();
                        this.Hide();

                    }
                    else if(role=="Pharmacist")
                    {
                        Pharmacist pharm = new Pharmacist();
                        pharm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Username Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            /* if(txtUsername.Text=="login" && txtPassword.Text=="pass")
            {
                Adminstrator am = new Adminstrator();
                am.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }*/

            //            login();
        }
    }
}
