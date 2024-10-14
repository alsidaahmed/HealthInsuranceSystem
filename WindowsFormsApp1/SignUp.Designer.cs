namespace WindowsFormsApp1
{
    partial class SignUp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.signup_phone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.signup_password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.signup_fullname = new System.Windows.Forms.TextBox();
            this.signup_selectrole = new System.Windows.Forms.ComboBox();
            this.userRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.electronicInsuranceDataSet = new WindowsFormsApp1.ElectronicInsuranceDataSet();
            this.label9 = new System.Windows.Forms.Label();
            this.signup_close = new System.Windows.Forms.Label();
            this.signup_loginhere = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.signup_showpassword = new System.Windows.Forms.CheckBox();
            this.signup_btn = new System.Windows.Forms.Button();
            this.signup_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.signup_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.userRolesTableAdapter = new WindowsFormsApp1.ElectronicInsuranceDataSetTableAdapters.UserRolesTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userRolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronicInsuranceDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.signup_phone);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.signup_password);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.signup_fullname);
            this.panel1.Controls.Add(this.signup_selectrole);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.signup_close);
            this.panel1.Controls.Add(this.signup_loginhere);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.signup_showpassword);
            this.panel1.Controls.Add(this.signup_btn);
            this.panel1.Controls.Add(this.signup_email);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.signup_username);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 414);
            this.panel1.TabIndex = 1;
            // 
            // signup_phone
            // 
            this.signup_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_phone.Location = new System.Drawing.Point(301, 204);
            this.signup_phone.Multiline = true;
            this.signup_phone.Name = "signup_phone";
            this.signup_phone.Size = new System.Drawing.Size(305, 30);
            this.signup_phone.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(298, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Fullname";
            // 
            // signup_password
            // 
            this.signup_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_password.Location = new System.Drawing.Point(301, 261);
            this.signup_password.Multiline = true;
            this.signup_password.Name = "signup_password";
            this.signup_password.PasswordChar = '*';
            this.signup_password.Size = new System.Drawing.Size(305, 30);
            this.signup_password.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(298, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(298, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Phone";
            // 
            // signup_fullname
            // 
            this.signup_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_fullname.Location = new System.Drawing.Point(301, 30);
            this.signup_fullname.Multiline = true;
            this.signup_fullname.Name = "signup_fullname";
            this.signup_fullname.Size = new System.Drawing.Size(305, 30);
            this.signup_fullname.TabIndex = 16;
            // 
            // signup_selectrole
            // 
            this.signup_selectrole.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.userRolesBindingSource, "RoleId", true));
            this.signup_selectrole.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.userRolesBindingSource, "RoleName", true));
            this.signup_selectrole.DataSource = this.userRolesBindingSource;
            this.signup_selectrole.DisplayMember = "RoleName";
            this.signup_selectrole.FormattingEnabled = true;
            this.signup_selectrole.Location = new System.Drawing.Point(513, 298);
            this.signup_selectrole.Name = "signup_selectrole";
            this.signup_selectrole.Size = new System.Drawing.Size(93, 21);
            this.signup_selectrole.TabIndex = 14;
            this.signup_selectrole.ValueMember = "RoleId";
            // 
            // userRolesBindingSource
            // 
            this.userRolesBindingSource.DataMember = "UserRoles";
            this.userRolesBindingSource.DataSource = this.electronicInsuranceDataSet;
            // 
            // electronicInsuranceDataSet
            // 
            this.electronicInsuranceDataSet.DataSetName = "ElectronicInsuranceDataSet";
            this.electronicInsuranceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(434, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Select Role:";
            // 
            // signup_close
            // 
            this.signup_close.AutoSize = true;
            this.signup_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_close.Location = new System.Drawing.Point(616, 0);
            this.signup_close.Name = "signup_close";
            this.signup_close.Size = new System.Drawing.Size(15, 16);
            this.signup_close.TabIndex = 10;
            this.signup_close.Text = "X";
            this.signup_close.Click += new System.EventHandler(this.signup_close_Click);
            // 
            // signup_loginhere
            // 
            this.signup_loginhere.AutoSize = true;
            this.signup_loginhere.BackColor = System.Drawing.Color.White;
            this.signup_loginhere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_loginhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_loginhere.ForeColor = System.Drawing.Color.MidnightBlue;
            this.signup_loginhere.Location = new System.Drawing.Point(485, 391);
            this.signup_loginhere.Name = "signup_loginhere";
            this.signup_loginhere.Size = new System.Drawing.Size(68, 13);
            this.signup_loginhere.TabIndex = 9;
            this.signup_loginhere.Text = "LogIn here";
            this.signup_loginhere.Click += new System.EventHandler(this.signup_loginhere_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(314, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Already have an account ?";
            // 
            // signup_showpassword
            // 
            this.signup_showpassword.AutoSize = true;
            this.signup_showpassword.BackColor = System.Drawing.Color.Transparent;
            this.signup_showpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_showpassword.ForeColor = System.Drawing.Color.Gray;
            this.signup_showpassword.Location = new System.Drawing.Point(301, 299);
            this.signup_showpassword.Name = "signup_showpassword";
            this.signup_showpassword.Size = new System.Drawing.Size(119, 20);
            this.signup_showpassword.TabIndex = 7;
            this.signup_showpassword.Text = "show password";
            this.signup_showpassword.UseVisualStyleBackColor = false;
            this.signup_showpassword.CheckedChanged += new System.EventHandler(this.signup_showpassword_CheckedChanged);
            // 
            // signup_btn
            // 
            this.signup_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.signup_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_btn.FlatAppearance.BorderSize = 0;
            this.signup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_btn.ForeColor = System.Drawing.Color.White;
            this.signup_btn.Location = new System.Drawing.Point(404, 343);
            this.signup_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(75, 23);
            this.signup_btn.TabIndex = 6;
            this.signup_btn.Text = "SignUp";
            this.signup_btn.UseVisualStyleBackColor = false;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // signup_email
            // 
            this.signup_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_email.Location = new System.Drawing.Point(301, 146);
            this.signup_email.Multiline = true;
            this.signup_email.Name = "signup_email";
            this.signup_email.Size = new System.Drawing.Size(305, 30);
            this.signup_email.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // signup_username
            // 
            this.signup_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_username.Location = new System.Drawing.Point(301, 88);
            this.signup_username.Multiline = true;
            this.signup_username.Name = "signup_username";
            this.signup_username.Size = new System.Drawing.Size(305, 30);
            this.signup_username.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 413);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.icons8_sign_up_100;
            this.pictureBox1.Location = new System.Drawing.Point(80, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Health Insurance System ";
            // 
            // userRolesTableAdapter
            // 
            this.userRolesTableAdapter.ClearBeforeFill = true;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userRolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronicInsuranceDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label signup_close;
        private System.Windows.Forms.Label signup_loginhere;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox signup_showpassword;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.TextBox signup_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox signup_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox signup_password;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox signup_selectrole;
        private System.Windows.Forms.TextBox signup_phone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox signup_fullname;
        private System.Windows.Forms.Label label10;
        private ElectronicInsuranceDataSet electronicInsuranceDataSet;
        private System.Windows.Forms.BindingSource userRolesBindingSource;
        private ElectronicInsuranceDataSetTableAdapters.UserRolesTableAdapter userRolesTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}