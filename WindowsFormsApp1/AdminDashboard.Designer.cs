using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class AdminDashboard : Form
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menu_active = new System.Windows.Forms.Panel();
            this.categorybutton = new System.Windows.Forms.Button();
            this.claimbutton = new System.Windows.Forms.Button();
            this.reportbutton = new System.Windows.Forms.Button();
            this.policybutton = new System.Windows.Forms.Button();
            this.AdminProfile = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.AdminProfile);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1070, 60);
            this.panel4.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.menu_active);
            this.panel1.Controls.Add(this.categorybutton);
            this.panel1.Controls.Add(this.claimbutton);
            this.panel1.Controls.Add(this.reportbutton);
            this.panel1.Controls.Add(this.policybutton);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 60);
            this.panel1.TabIndex = 9;
            // 
            // menu_active
            // 
            this.menu_active.BackColor = System.Drawing.Color.Navy;
            this.menu_active.Location = new System.Drawing.Point(-1, 1);
            this.menu_active.Name = "menu_active";
            this.menu_active.Size = new System.Drawing.Size(210, 8);
            this.menu_active.TabIndex = 1;
            // 
            // categorybutton
            // 
            this.categorybutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.categorybutton.FlatAppearance.BorderSize = 0;
            this.categorybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categorybutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorybutton.ForeColor = System.Drawing.Color.White;
            this.categorybutton.Image = global::WindowsFormsApp1.Properties.Resources.icons8_category_401;
            this.categorybutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categorybutton.Location = new System.Drawing.Point(0, 0);
            this.categorybutton.Margin = new System.Windows.Forms.Padding(0);
            this.categorybutton.Name = "categorybutton";
            this.categorybutton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.categorybutton.Size = new System.Drawing.Size(210, 60);
            this.categorybutton.TabIndex = 7;
            this.categorybutton.Text = "  Category Management";
            this.categorybutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.categorybutton.UseVisualStyleBackColor = false;
            this.categorybutton.Click += new System.EventHandler(this.categorybutton_Click);
            // 
            // claimbutton
            // 
            this.claimbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.claimbutton.FlatAppearance.BorderSize = 0;
            this.claimbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.claimbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claimbutton.ForeColor = System.Drawing.Color.White;
            this.claimbutton.Image = global::WindowsFormsApp1.Properties.Resources.icons8_claim_40__1_;
            this.claimbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.claimbutton.Location = new System.Drawing.Point(420, 0);
            this.claimbutton.Margin = new System.Windows.Forms.Padding(0);
            this.claimbutton.Name = "claimbutton";
            this.claimbutton.Size = new System.Drawing.Size(210, 60);
            this.claimbutton.TabIndex = 3;
            this.claimbutton.Text = "  Claim Processing";
            this.claimbutton.UseVisualStyleBackColor = false;
            this.claimbutton.Click += new System.EventHandler(this.claimbutton_Click);
            // 
            // reportbutton
            // 
            this.reportbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.reportbutton.FlatAppearance.BorderSize = 0;
            this.reportbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportbutton.ForeColor = System.Drawing.Color.White;
            this.reportbutton.Image = global::WindowsFormsApp1.Properties.Resources.icons8_report_40;
            this.reportbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportbutton.Location = new System.Drawing.Point(634, 0);
            this.reportbutton.Margin = new System.Windows.Forms.Padding(0);
            this.reportbutton.Name = "reportbutton";
            this.reportbutton.Size = new System.Drawing.Size(210, 60);
            this.reportbutton.TabIndex = 3;
            this.reportbutton.Text = "  Reporting Tools";
            this.reportbutton.UseVisualStyleBackColor = false;
            this.reportbutton.Click += new System.EventHandler(this.reportbutton_Click);
            // 
            // policybutton
            // 
            this.policybutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.policybutton.FlatAppearance.BorderSize = 0;
            this.policybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.policybutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.policybutton.ForeColor = System.Drawing.Color.White;
            this.policybutton.Image = global::WindowsFormsApp1.Properties.Resources.icons8_medical_insurance_402;
            this.policybutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.policybutton.Location = new System.Drawing.Point(210, 0);
            this.policybutton.Margin = new System.Windows.Forms.Padding(0);
            this.policybutton.Name = "policybutton";
            this.policybutton.Size = new System.Drawing.Size(210, 60);
            this.policybutton.TabIndex = 3;
            this.policybutton.Text = " Policy Management";
            this.policybutton.UseVisualStyleBackColor = false;
            this.policybutton.Click += new System.EventHandler(this.policybutton_Click);
            // 
            // AdminProfile
            // 
            this.AdminProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminProfile.Image = global::WindowsFormsApp1.Properties.Resources.icons8_admin_48;
            this.AdminProfile.Location = new System.Drawing.Point(1020, 3);
            this.AdminProfile.Name = "AdminProfile";
            this.AdminProfile.Size = new System.Drawing.Size(47, 52);
            this.AdminProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AdminProfile.TabIndex = 3;
            this.AdminProfile.TabStop = false;
            this.AdminProfile.Click += new System.EventHandler(this.AdminProfile_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1070, 671);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdminProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel4;
        private PictureBox AdminProfile;
        private Button categorybutton;
        private Panel menu_active;
        private Button reportbutton;
        private Button claimbutton;
        private Button policybutton;
        private Panel panel1;
    }
}