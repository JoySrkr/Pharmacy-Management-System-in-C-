
namespace PharmacyManagementSystem
{
    partial class Pharmacist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacist));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnSellMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnMedValidityCheck = new Guna.UI2.WinForms.Guna2Button();
            this.btnModifyMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashbord = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_P_MedicineValidityCheck1 = new PharmacyManagementSystem.PharmacistUC.UC_P_MedicineValidityCheck();
            this.uC_P_UpdateMedicine1 = new PharmacyManagementSystem.PharmacistUC.UC_P_UpdateMedicine();
            this.uC_P_ViewMedicines1 = new PharmacyManagementSystem.PharmacistUC.UC_P_ViewMedicines();
            this.uC_P_AddMedicine1 = new PharmacyManagementSystem.PharmacistUC.UC_P_AddMedicine();
            this.uC_P_Dashbord1 = new PharmacyManagementSystem.PharmacistUC.UC_P_Dashbord();
            this.uC_P_SellMedicine1 = new PharmacyManagementSystem.PharmacistUC.UC_P_SellMedicine();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnSellMedicine);
            this.panel1.Controls.Add(this.btnMedValidityCheck);
            this.panel1.Controls.Add(this.btnModifyMedicine);
            this.panel1.Controls.Add(this.btnViewMedicine);
            this.panel1.Controls.Add(this.btnAddMedicine);
            this.panel1.Controls.Add(this.btnDashbord);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 609);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLogOut
            // 
            this.btnLogOut.CheckedState.Parent = this.btnLogOut;
            this.btnLogOut.CustomImages.Parent = this.btnLogOut;
            this.btnLogOut.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.HoverState.Parent = this.btnLogOut;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(30, 507);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.ShadowDecoration.Parent = this.btnLogOut;
            this.btnLogOut.Size = new System.Drawing.Size(179, 45);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // btnSellMedicine
            // 
            this.btnSellMedicine.CheckedState.Parent = this.btnSellMedicine;
            this.btnSellMedicine.CustomImages.Parent = this.btnSellMedicine;
            this.btnSellMedicine.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSellMedicine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellMedicine.ForeColor = System.Drawing.Color.White;
            this.btnSellMedicine.HoverState.Parent = this.btnSellMedicine;
            this.btnSellMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnSellMedicine.Image")));
            this.btnSellMedicine.Location = new System.Drawing.Point(30, 456);
            this.btnSellMedicine.Name = "btnSellMedicine";
            this.btnSellMedicine.ShadowDecoration.Parent = this.btnSellMedicine;
            this.btnSellMedicine.Size = new System.Drawing.Size(179, 45);
            this.btnSellMedicine.TabIndex = 7;
            this.btnSellMedicine.Text = "Sell Medicine";
            this.btnSellMedicine.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // btnMedValidityCheck
            // 
            this.btnMedValidityCheck.CheckedState.Parent = this.btnMedValidityCheck;
            this.btnMedValidityCheck.CustomImages.Parent = this.btnMedValidityCheck;
            this.btnMedValidityCheck.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnMedValidityCheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedValidityCheck.ForeColor = System.Drawing.Color.White;
            this.btnMedValidityCheck.HoverState.Parent = this.btnMedValidityCheck;
            this.btnMedValidityCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnMedValidityCheck.Image")));
            this.btnMedValidityCheck.Location = new System.Drawing.Point(12, 392);
            this.btnMedValidityCheck.Name = "btnMedValidityCheck";
            this.btnMedValidityCheck.ShadowDecoration.Parent = this.btnMedValidityCheck;
            this.btnMedValidityCheck.Size = new System.Drawing.Size(218, 58);
            this.btnMedValidityCheck.TabIndex = 6;
            this.btnMedValidityCheck.Text = "Medicine Validity Check";
            this.btnMedValidityCheck.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // btnModifyMedicine
            // 
            this.btnModifyMedicine.CheckedState.Parent = this.btnModifyMedicine;
            this.btnModifyMedicine.CustomImages.Parent = this.btnModifyMedicine;
            this.btnModifyMedicine.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnModifyMedicine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyMedicine.ForeColor = System.Drawing.Color.White;
            this.btnModifyMedicine.HoverState.Parent = this.btnModifyMedicine;
            this.btnModifyMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyMedicine.Image")));
            this.btnModifyMedicine.Location = new System.Drawing.Point(30, 332);
            this.btnModifyMedicine.Name = "btnModifyMedicine";
            this.btnModifyMedicine.ShadowDecoration.Parent = this.btnModifyMedicine;
            this.btnModifyMedicine.Size = new System.Drawing.Size(179, 45);
            this.btnModifyMedicine.TabIndex = 5;
            this.btnModifyMedicine.Text = "Modify Medicine";
            this.btnModifyMedicine.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // btnViewMedicine
            // 
            this.btnViewMedicine.CheckedState.Parent = this.btnViewMedicine;
            this.btnViewMedicine.CustomImages.Parent = this.btnViewMedicine;
            this.btnViewMedicine.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnViewMedicine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMedicine.ForeColor = System.Drawing.Color.White;
            this.btnViewMedicine.HoverState.Parent = this.btnViewMedicine;
            this.btnViewMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnViewMedicine.Image")));
            this.btnViewMedicine.Location = new System.Drawing.Point(30, 281);
            this.btnViewMedicine.Name = "btnViewMedicine";
            this.btnViewMedicine.ShadowDecoration.Parent = this.btnViewMedicine;
            this.btnViewMedicine.Size = new System.Drawing.Size(179, 45);
            this.btnViewMedicine.TabIndex = 4;
            this.btnViewMedicine.Text = "View Medicine";
            this.btnViewMedicine.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.CheckedState.Parent = this.btnAddMedicine;
            this.btnAddMedicine.CustomImages.Parent = this.btnAddMedicine;
            this.btnAddMedicine.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddMedicine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedicine.ForeColor = System.Drawing.Color.White;
            this.btnAddMedicine.HoverState.Parent = this.btnAddMedicine;
            this.btnAddMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMedicine.Image")));
            this.btnAddMedicine.Location = new System.Drawing.Point(30, 230);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.ShadowDecoration.Parent = this.btnAddMedicine;
            this.btnAddMedicine.Size = new System.Drawing.Size(179, 45);
            this.btnAddMedicine.TabIndex = 3;
            this.btnAddMedicine.Text = "Add Medicine";
            this.btnAddMedicine.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnDashbord
            // 
            this.btnDashbord.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashbord.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDashbord.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDashbord.CheckedState.Parent = this.btnDashbord;
            this.btnDashbord.CustomImages.Parent = this.btnDashbord;
            this.btnDashbord.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDashbord.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashbord.ForeColor = System.Drawing.Color.White;
            this.btnDashbord.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDashbord.HoverState.ForeColor = System.Drawing.Color.Sienna;
            this.btnDashbord.HoverState.Parent = this.btnDashbord;
            this.btnDashbord.Image = ((System.Drawing.Image)(resources.GetObject("btnDashbord.Image")));
            this.btnDashbord.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDashbord.Location = new System.Drawing.Point(30, 179);
            this.btnDashbord.Name = "btnDashbord";
            this.btnDashbord.ShadowDecoration.Parent = this.btnDashbord;
            this.btnDashbord.Size = new System.Drawing.Size(179, 45);
            this.btnDashbord.TabIndex = 2;
            this.btnDashbord.Text = "Dashbord";
            this.btnDashbord.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(33, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pharmacist";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_P_SellMedicine1);
            this.panel2.Controls.Add(this.uC_P_MedicineValidityCheck1);
            this.panel2.Controls.Add(this.uC_P_UpdateMedicine1);
            this.panel2.Controls.Add(this.uC_P_ViewMedicines1);
            this.panel2.Controls.Add(this.uC_P_AddMedicine1);
            this.panel2.Controls.Add(this.uC_P_Dashbord1);
            this.panel2.Location = new System.Drawing.Point(236, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(746, 608);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.TargetControl = this.panel2;
            // 
            // uC_P_MedicineValidityCheck1
            // 
            this.uC_P_MedicineValidityCheck1.BackColor = System.Drawing.Color.White;
            this.uC_P_MedicineValidityCheck1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_MedicineValidityCheck1.Name = "uC_P_MedicineValidityCheck1";
            this.uC_P_MedicineValidityCheck1.Size = new System.Drawing.Size(742, 611);
            this.uC_P_MedicineValidityCheck1.TabIndex = 4;
            // 
            // uC_P_UpdateMedicine1
            // 
            this.uC_P_UpdateMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_P_UpdateMedicine1.Location = new System.Drawing.Point(-2, -3);
            this.uC_P_UpdateMedicine1.Name = "uC_P_UpdateMedicine1";
            this.uC_P_UpdateMedicine1.Size = new System.Drawing.Size(742, 611);
            this.uC_P_UpdateMedicine1.TabIndex = 3;
            // 
            // uC_P_ViewMedicines1
            // 
            this.uC_P_ViewMedicines1.BackColor = System.Drawing.Color.White;
            this.uC_P_ViewMedicines1.Location = new System.Drawing.Point(19, 36);
            this.uC_P_ViewMedicines1.Name = "uC_P_ViewMedicines1";
            this.uC_P_ViewMedicines1.Size = new System.Drawing.Size(786, 611);
            this.uC_P_ViewMedicines1.TabIndex = 2;
            // 
            // uC_P_AddMedicine1
            // 
            this.uC_P_AddMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_P_AddMedicine1.Location = new System.Drawing.Point(4, 36);
            this.uC_P_AddMedicine1.Name = "uC_P_AddMedicine1";
            this.uC_P_AddMedicine1.Size = new System.Drawing.Size(783, 611);
            this.uC_P_AddMedicine1.TabIndex = 1;
            // 
            // uC_P_Dashbord1
            // 
            this.uC_P_Dashbord1.BackColor = System.Drawing.Color.White;
            this.uC_P_Dashbord1.Location = new System.Drawing.Point(0, -1);
            this.uC_P_Dashbord1.Name = "uC_P_Dashbord1";
            this.uC_P_Dashbord1.Size = new System.Drawing.Size(740, 611);
            this.uC_P_Dashbord1.TabIndex = 0;
            // 
            // uC_P_SellMedicine1
            // 
            this.uC_P_SellMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_P_SellMedicine1.Location = new System.Drawing.Point(-2, -2);
            this.uC_P_SellMedicine1.Name = "uC_P_SellMedicine1";
            this.uC_P_SellMedicine1.Size = new System.Drawing.Size(742, 611);
            this.uC_P_SellMedicine1.TabIndex = 5;
            // 
            // Pharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pharmacist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pharmacist";
            this.Load += new System.EventHandler(this.Pharmacist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnModifyMedicine;
        private Guna.UI2.WinForms.Guna2Button btnViewMedicine;
        private Guna.UI2.WinForms.Guna2Button btnAddMedicine;
        private Guna.UI2.WinForms.Guna2Button btnDashbord;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button btnSellMedicine;
        private Guna.UI2.WinForms.Guna2Button btnMedValidityCheck;
        private PharmacistUC.UC_P_Dashbord uC_P_Dashbord1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private PharmacistUC.UC_P_AddMedicine uC_P_AddMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private PharmacistUC.UC_P_ViewMedicines uC_P_ViewMedicines1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private PharmacistUC.UC_P_UpdateMedicine uC_P_UpdateMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private PharmacistUC.UC_P_MedicineValidityCheck uC_P_MedicineValidityCheck1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private PharmacistUC.UC_P_SellMedicine uC_P_SellMedicine1;
    }
}