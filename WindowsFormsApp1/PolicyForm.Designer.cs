namespace WindowsFormsApp1
{
    partial class PolicyForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.policydataGridView = new System.Windows.Forms.DataGridView();
            this.PolicyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PolicyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Premium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Photo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationtb = new System.Windows.Forms.TextBox();
            this.premiumtb = new System.Windows.Forms.TextBox();
            this.policynametb = new System.Windows.Forms.TextBox();
            this.descriptiontb = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.phototb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.idtextbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.policypictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.policydataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.policypictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Policy Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(3, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(4, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duration:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DeepPink;
            this.label4.Location = new System.Drawing.Point(129, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Premium:";
            // 
            // policydataGridView
            // 
            this.policydataGridView.AllowUserToAddRows = false;
            this.policydataGridView.AllowUserToDeleteRows = false;
            this.policydataGridView.AllowUserToResizeColumns = false;
            this.policydataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.policydataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.policydataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.policydataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.policydataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.policydataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.policydataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.policydataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.policydataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.policydataGridView.ColumnHeadersHeight = 30;
            this.policydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.policydataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PolicyID,
            this.PolicyName,
            this.Description,
            this.Duration,
            this.Premium,
            this.Photo,
            this.CategoryId});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.policydataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.policydataGridView.EnableHeadersVisualStyles = false;
            this.policydataGridView.Location = new System.Drawing.Point(126, 25);
            this.policydataGridView.Name = "policydataGridView";
            this.policydataGridView.ReadOnly = true;
            this.policydataGridView.RowHeadersVisible = false;
            this.policydataGridView.RowTemplate.Height = 50;
            this.policydataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.policydataGridView.Size = new System.Drawing.Size(857, 235);
            this.policydataGridView.TabIndex = 4;
            this.policydataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.policydataGridView_CellClick);
            // 
            // PolicyID
            // 
            this.PolicyID.HeaderText = "Policy ID";
            this.PolicyID.Name = "PolicyID";
            this.PolicyID.ReadOnly = true;
            // 
            // PolicyName
            // 
            this.PolicyName.HeaderText = "Policy Name";
            this.PolicyName.Name = "PolicyName";
            this.PolicyName.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // Premium
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = "0";
            this.Premium.DefaultCellStyle = dataGridViewCellStyle7;
            this.Premium.HeaderText = "Premium";
            this.Premium.Name = "Premium";
            this.Premium.ReadOnly = true;
            // 
            // Photo
            // 
            this.Photo.HeaderText = "Policy Photo";
            this.Photo.Name = "Photo";
            this.Photo.ReadOnly = true;
            // 
            // CategoryId
            // 
            this.CategoryId.HeaderText = "Category ID";
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.ReadOnly = true;
            // 
            // durationtb
            // 
            this.durationtb.Font = new System.Drawing.Font("Tahoma", 10F);
            this.durationtb.Location = new System.Drawing.Point(5, 83);
            this.durationtb.Name = "durationtb";
            this.durationtb.Size = new System.Drawing.Size(115, 24);
            this.durationtb.TabIndex = 5;
            // 
            // premiumtb
            // 
            this.premiumtb.Font = new System.Drawing.Font("Tahoma", 10F);
            this.premiumtb.ForeColor = System.Drawing.Color.SeaGreen;
            this.premiumtb.Location = new System.Drawing.Point(132, 83);
            this.premiumtb.Name = "premiumtb";
            this.premiumtb.Size = new System.Drawing.Size(115, 24);
            this.premiumtb.TabIndex = 6;
            // 
            // policynametb
            // 
            this.policynametb.Font = new System.Drawing.Font("Tahoma", 10F);
            this.policynametb.Location = new System.Drawing.Point(6, 24);
            this.policynametb.Name = "policynametb";
            this.policynametb.Size = new System.Drawing.Size(242, 24);
            this.policynametb.TabIndex = 7;
            // 
            // descriptiontb
            // 
            this.descriptiontb.Font = new System.Drawing.Font("Tahoma", 10F);
            this.descriptiontb.Location = new System.Drawing.Point(6, 195);
            this.descriptiontb.Multiline = true;
            this.descriptiontb.Name = "descriptiontb";
            this.descriptiontb.Size = new System.Drawing.Size(309, 57);
            this.descriptiontb.TabIndex = 8;
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.addbutton.FlatAppearance.BorderSize = 0;
            this.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbutton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.ForeColor = System.Drawing.Color.White;
            this.addbutton.Location = new System.Drawing.Point(662, 170);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(119, 30);
            this.addbutton.TabIndex = 10;
            this.addbutton.Text = "ADD POLICY";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.Red;
            this.deletebutton.FlatAppearance.BorderSize = 0;
            this.deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebutton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.ForeColor = System.Drawing.Color.White;
            this.deletebutton.Location = new System.Drawing.Point(662, 206);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(119, 30);
            this.deletebutton.TabIndex = 11;
            this.deletebutton.Text = "DELETE POLICY";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.updatebutton.FlatAppearance.BorderSize = 0;
            this.updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebutton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.ForeColor = System.Drawing.Color.White;
            this.updatebutton.Location = new System.Drawing.Point(662, 263);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(119, 30);
            this.updatebutton.TabIndex = 12;
            this.updatebutton.Text = "UPDATE POLICY";
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DeepPink;
            this.label5.Location = new System.Drawing.Point(199, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DeepPink;
            this.label6.Location = new System.Drawing.Point(3, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 14);
            this.label6.TabIndex = 14;
            this.label6.Text = "Policy Photo URL:";
            // 
            // phototb
            // 
            this.phototb.Font = new System.Drawing.Font("Tahoma", 10F);
            this.phototb.ForeColor = System.Drawing.SystemColors.Highlight;
            this.phototb.Location = new System.Drawing.Point(5, 143);
            this.phototb.Name = "phototb";
            this.phototb.Size = new System.Drawing.Size(242, 24);
            this.phototb.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.AliceBlue;
            this.label7.Location = new System.Drawing.Point(8, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 14);
            this.label7.TabIndex = 16;
            this.label7.Text = "Enter PolicyID Which You Want To Update:";
            // 
            // idtextbox
            // 
            this.idtextbox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.idtextbox.Location = new System.Drawing.Point(280, 267);
            this.idtextbox.Multiline = true;
            this.idtextbox.Name = "idtextbox";
            this.idtextbox.Size = new System.Drawing.Size(35, 30);
            this.idtextbox.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.policynametb);
            this.panel1.Controls.Add(this.idtextbox);
            this.panel1.Controls.Add(this.policypictureBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.updatebutton);
            this.panel1.Controls.Add(this.descriptiontb);
            this.panel1.Controls.Add(this.phototb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.deletebutton);
            this.panel1.Controls.Add(this.addbutton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.durationtb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.premiumtb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(123, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 335);
            this.panel1.TabIndex = 18;
            // 
            // policypictureBox
            // 
            this.policypictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.policypictureBox.Image = global::WindowsFormsApp1.Properties.Resources.groubinsurance_jpg;
            this.policypictureBox.Location = new System.Drawing.Point(642, 7);
            this.policypictureBox.Name = "policypictureBox";
            this.policypictureBox.Size = new System.Drawing.Size(150, 150);
            this.policypictureBox.TabIndex = 9;
            this.policypictureBox.TabStop = false;
            // 
            // PolicyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1084, 718);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.policydataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PolicyForm";
            this.Text = "PolicyForm";
            ((System.ComponentModel.ISupportInitialize)(this.policydataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.policypictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView policydataGridView;
        private System.Windows.Forms.TextBox durationtb;
        private System.Windows.Forms.TextBox premiumtb;
        private System.Windows.Forms.TextBox policynametb;
        private System.Windows.Forms.TextBox descriptiontb;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phototb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox idtextbox;
        private System.Windows.Forms.PictureBox policypictureBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn PolicyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PolicyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Premium;
        private System.Windows.Forms.DataGridViewTextBoxColumn Photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryId;
        private System.Windows.Forms.Panel panel1;
    }
}