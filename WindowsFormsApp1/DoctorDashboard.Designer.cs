
namespace WindowsFormsApp1
{
    partial class DoctorDashboard
    {
      // <summary>
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.formactive = new System.Windows.Forms.Panel();
            this.DoctorProfile = new System.Windows.Forms.PictureBox();
            this.patientbutton = new System.Windows.Forms.Button();
            this.makeclaimbutton = new System.Windows.Forms.Button();
            this.recordbutton = new System.Windows.Forms.Button();
            this.viewcategorybutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.formactive);
            this.panel1.Controls.Add(this.DoctorProfile);
            this.panel1.Controls.Add(this.patientbutton);
            this.panel1.Controls.Add(this.makeclaimbutton);
            this.panel1.Controls.Add(this.recordbutton);
            this.panel1.Controls.Add(this.viewcategorybutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 60);
            this.panel1.TabIndex = 0;
            // 
            // formactive
            // 
            this.formactive.BackColor = System.Drawing.Color.Navy;
            this.formactive.Location = new System.Drawing.Point(0, 1);
            this.formactive.Name = "formactive";
            this.formactive.Size = new System.Drawing.Size(210, 8);
            this.formactive.TabIndex = 1;
            // 
            // DoctorProfile
            // 
            this.DoctorProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DoctorProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.DoctorProfile.Image = global::WindowsFormsApp1.Properties.Resources.nurse_male_40;
            this.DoctorProfile.Location = new System.Drawing.Point(942, 0);
            this.DoctorProfile.Name = "DoctorProfile";
            this.DoctorProfile.Size = new System.Drawing.Size(49, 60);
            this.DoctorProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.DoctorProfile.TabIndex = 1;
            this.DoctorProfile.TabStop = false;
            this.DoctorProfile.Click += new System.EventHandler(this.DoctorProfile_Click);
            // 
            // patientbutton
            // 
            this.patientbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.patientbutton.FlatAppearance.BorderSize = 0;
            this.patientbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientbutton.ForeColor = System.Drawing.Color.White;
            this.patientbutton.Image = global::WindowsFormsApp1.Properties.Resources.clinic_30;
            this.patientbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientbutton.Location = new System.Drawing.Point(0, -1);
            this.patientbutton.Name = "patientbutton";
            this.patientbutton.Size = new System.Drawing.Size(210, 60);
            this.patientbutton.TabIndex = 1;
            this.patientbutton.Text = "Patient Managment";
            this.patientbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.patientbutton.UseVisualStyleBackColor = false;
            this.patientbutton.Click += new System.EventHandler(this.patientbutton_Click);
            // 
            // makeclaimbutton
            // 
            this.makeclaimbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.makeclaimbutton.FlatAppearance.BorderSize = 0;
            this.makeclaimbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeclaimbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeclaimbutton.ForeColor = System.Drawing.Color.White;
            this.makeclaimbutton.Image = global::WindowsFormsApp1.Properties.Resources.property_301;
            this.makeclaimbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.makeclaimbutton.Location = new System.Drawing.Point(630, -1);
            this.makeclaimbutton.Name = "makeclaimbutton";
            this.makeclaimbutton.Size = new System.Drawing.Size(210, 60);
            this.makeclaimbutton.TabIndex = 3;
            this.makeclaimbutton.Text = "Claims Managment";
            this.makeclaimbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.makeclaimbutton.UseVisualStyleBackColor = false;
            this.makeclaimbutton.Click += new System.EventHandler(this.makeclaimbutton_Click);
            // 
            // recordbutton
            // 
            this.recordbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.recordbutton.FlatAppearance.BorderSize = 0;
            this.recordbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordbutton.ForeColor = System.Drawing.Color.White;
            this.recordbutton.Image = global::WindowsFormsApp1.Properties.Resources.treatment_30;
            this.recordbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recordbutton.Location = new System.Drawing.Point(210, -1);
            this.recordbutton.Name = "recordbutton";
            this.recordbutton.Size = new System.Drawing.Size(210, 60);
            this.recordbutton.TabIndex = 2;
            this.recordbutton.Text = "Medical Records";
            this.recordbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.recordbutton.UseVisualStyleBackColor = false;
            this.recordbutton.Click += new System.EventHandler(this.recordbutton_Click);
            // 
            // viewcategorybutton
            // 
            this.viewcategorybutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.viewcategorybutton.FlatAppearance.BorderSize = 0;
            this.viewcategorybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewcategorybutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewcategorybutton.ForeColor = System.Drawing.Color.White;
            this.viewcategorybutton.Image = global::WindowsFormsApp1.Properties.Resources.category_30;
            this.viewcategorybutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewcategorybutton.Location = new System.Drawing.Point(420, -1);
            this.viewcategorybutton.Name = "viewcategorybutton";
            this.viewcategorybutton.Size = new System.Drawing.Size(210, 60);
            this.viewcategorybutton.TabIndex = 4;
            this.viewcategorybutton.Text = "View Category";
            this.viewcategorybutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.viewcategorybutton.UseVisualStyleBackColor = false;
            this.viewcategorybutton.Click += new System.EventHandler(this.viewcategorybutton_Click);
            // 
            // DoctorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 491);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "DoctorDashboard";
            this.Text = "Doctor Dashboard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DoctorProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button patientbutton;
        private System.Windows.Forms.Button recordbutton;
        private System.Windows.Forms.Panel formactive;
        private System.Windows.Forms.PictureBox DoctorProfile;
        private System.Windows.Forms.Button makeclaimbutton;
        private System.Windows.Forms.Button viewcategorybutton;
    }
}