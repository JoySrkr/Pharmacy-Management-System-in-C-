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
    public partial class Pharmacist : Form
    {
        public Pharmacist()
        {
            InitializeComponent();
        }

        private void Pharmacist_Load(object sender, EventArgs e)
        {
            uC_P_Dashbord1.Visible = false;
            uC_P_AddMedicine1.Visible = false;
            uC_P_ViewMedicines1.Visible = false;
            uC_P_UpdateMedicine1.Visible = false;
            uC_P_MedicineValidityCheck1.Visible = false;
            uC_P_SellMedicine1.Visible = false;
            btnDashbord.PerformClick();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)  // Modify Button
        {
            uC_P_UpdateMedicine1.Visible = true;
            uC_P_UpdateMedicine1.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)  //Dashboard Button
        {
            uC_P_Dashbord1.Visible = true;
            uC_P_Dashbord1.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)  //Add Medicine Button
        {
            uC_P_AddMedicine1.Visible = true;
            uC_P_AddMedicine1.BringToFront();

        }

        private void guna2Button3_Click(object sender, EventArgs e)  //View Medicine Button
        {
            uC_P_ViewMedicines1.Visible = true;
            uC_P_ViewMedicines1.BringToFront();
        }

        private void guna2Button5_Click(object sender, EventArgs e)  //Medicine Validity Check
        {
            uC_P_MedicineValidityCheck1.Visible = true;
            uC_P_MedicineValidityCheck1.BringToFront();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            uC_P_SellMedicine1.Visible = true;
            uC_P_SellMedicine1.BringToFront();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
