namespace WindowsFormsApp1
{
    partial class LogIn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.login_close = new System.Windows.Forms.Label();
            this.login_register = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.login_showpassword = new System.Windows.Forms.CheckBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.login_passwordtb = new System.Windows.Forms.TextBox();
            this.login_password = new System.Windows.Forms.Label();
            this.login_usernametb = new System.Windows.Forms.TextBox();
            this.login_username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.login_close);
            this.panel1.Controls.Add(this.login_register);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.login_showpassword);
            this.panel1.Controls.Add(this.login_btn);
            this.panel1.Controls.Add(this.login_passwordtb);
            this.panel1.Controls.Add(this.login_password);
            this.panel1.Controls.Add(this.login_usernametb);
            this.panel1.Controls.Add(this.login_username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 413);
            this.panel1.TabIndex = 0;
            // 
            // login_close
            // 
            this.login_close.AutoSize = true;
            this.login_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_close.Location = new System.Drawing.Point(609, 10);
            this.login_close.Name = "login_close";
            this.login_close.Size = new System.Drawing.Size(15, 16);
            this.login_close.TabIndex = 10;
            this.login_close.Text = "X";
            this.login_close.Click += new System.EventHandler(this.login_close_Click);
            // 
            // login_register
            // 
            this.login_register.AutoSize = true;
            this.login_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_register.ForeColor = System.Drawing.Color.Navy;
            this.login_register.Location = new System.Drawing.Point(488, 337);
            this.login_register.Name = "login_register";
            this.login_register.Size = new System.Drawing.Size(70, 13);
            this.login_register.TabIndex = 9;
            this.login_register.Text = "Register here";
            this.login_register.Click += new System.EventHandler(this.login_register_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(333, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Don\'t have an account ?";
            // 
            // login_showpassword
            // 
            this.login_showpassword.AutoSize = true;
            this.login_showpassword.BackColor = System.Drawing.Color.Transparent;
            this.login_showpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_showpassword.ForeColor = System.Drawing.Color.Gray;
            this.login_showpassword.Location = new System.Drawing.Point(301, 227);
            this.login_showpassword.Name = "login_showpassword";
            this.login_showpassword.Size = new System.Drawing.Size(119, 20);
            this.login_showpassword.TabIndex = 7;
            this.login_showpassword.Text = "show password";
            this.login_showpassword.UseVisualStyleBackColor = false;
            this.login_showpassword.CheckedChanged += new System.EventHandler(this.login_showpassword_CheckedChanged);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(407, 279);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 6;
            this.login_btn.Text = "LOGIN";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // login_passwordtb
            // 
            this.login_passwordtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_passwordtb.Location = new System.Drawing.Point(301, 187);
            this.login_passwordtb.Multiline = true;
            this.login_passwordtb.Name = "login_passwordtb";
            this.login_passwordtb.PasswordChar = '*';
            this.login_passwordtb.Size = new System.Drawing.Size(305, 34);
            this.login_passwordtb.TabIndex = 5;
            // 
            // login_password
            // 
            this.login_password.AutoSize = true;
            this.login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password.ForeColor = System.Drawing.Color.Navy;
            this.login_password.Location = new System.Drawing.Point(298, 171);
            this.login_password.Name = "login_password";
            this.login_password.Size = new System.Drawing.Size(61, 15);
            this.login_password.TabIndex = 4;
            this.login_password.Text = "Password";
            // 
            // login_usernametb
            // 
            this.login_usernametb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_usernametb.Location = new System.Drawing.Point(301, 113);
            this.login_usernametb.Multiline = true;
            this.login_usernametb.Name = "login_usernametb";
            this.login_usernametb.Size = new System.Drawing.Size(305, 34);
            this.login_usernametb.TabIndex = 3;
            // 
            // login_username
            // 
            this.login_username.AutoSize = true;
            this.login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_username.ForeColor = System.Drawing.Color.Navy;
            this.login_username.Location = new System.Drawing.Point(298, 95);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(65, 15);
            this.login_username.TabIndex = 2;
            this.login_username.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(297, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome Back!";
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
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.icons8_login_100;
            this.pictureBox1.Location = new System.Drawing.Point(86, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(28, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Health Insurance System ";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label login_username;
        private System.Windows.Forms.TextBox login_passwordtb;
        private System.Windows.Forms.Label login_password;
        private System.Windows.Forms.TextBox login_usernametb;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.CheckBox login_showpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label login_register;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label login_close;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

