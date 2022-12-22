using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem.PharmacistUC
{
    public partial class UC_P_MedicineValidityCheck : UserControl
    {

        function fn = new function();
        String query;
        public UC_P_MedicineValidityCheck()
        {
            InitializeComponent();
        }

        private void txtCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtCheck.SelectedIndex ==0)
            {
               /* query = "select * from medic where eDate >= getdate()";
                DataSet ds =fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                setLabel.Text = "Valid Medicines. ";
                setLabel.ForeColor = Color.Black;
               */


                // step 2 follow korle
                 query = "select * from medic where eDate >= getdate()";
                setDataGridView(query,"Valid Medicines",Color.Black);
                 
                 
                 


            }
            else if(txtCheck.SelectedIndex ==1)
            {
               /* query = "select * from medic where eDate <=getdate()";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                setLabel.Text = "Expired Medicines";
                setLabel.ForeColor = Color.Red;*/

                //Step 2 Follow korle
                  query = "select * from medic where eDate <=getdate()";
                setDataGridView(query,"Expired Medicines",Color.Red);


                 
                 
                 

            }
            else if(txtCheck.SelectedIndex == 2)
            {
               // query = "select * from medic";
              //  DataSet ds = fn.getData(query);                   //Eigulo na likte chile step 2 follow kora jete pare
              //  guna2DataGridView1.DataSource = ds.Tables[0];     // step 2 er jonno aro ekta method creat kora lagbe
              //  setLabel.Text = "";                               
               // setLabel.ForeColor = Color.Black;


                //step 2 follow korle
                  query = "select * from medic";

                 setDataGridView(query,"",Color.Black);
                 
                 
                 
            }
        }

        //step2 start
        
         private void setDataGridView(String query, String labelName, Color col)
        {
            DataSet ds=fn.getData(query);
            guna2DataGridView1.DataSource =ds.Tables[0];
            setLabel.Text=labelName;
            setLabel.ForeColor =col;
        }
         
         

        private void UC_P_MedicineValidityCheck_Load(object sender, EventArgs e)
        {
            setLabel.Text = "";
        }
    }
}
