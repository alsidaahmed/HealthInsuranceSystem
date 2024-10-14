namespace WindowsFormsApp1
{
    partial class PatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.IDtb = new MetroFramework.Controls.MetroTextBox();
            this.deletebutton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.addpatientbutton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.updatebutton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.emailtb = new System.Windows.Forms.TextBox();
            this.phonetb = new System.Windows.Forms.TextBox();
            this.addresstb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nametb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.patientdataGridView = new System.Windows.Forms.DataGridView();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOBpicker = new MetroFramework.Controls.MetroDateTime();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.DOBpicker);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.IDtb);
            this.panel1.Controls.Add(this.deletebutton);
            this.panel1.Controls.Add(this.addpatientbutton);
            this.panel1.Controls.Add(this.updatebutton);
            this.panel1.Controls.Add(this.emailtb);
            this.panel1.Controls.Add(this.phonetb);
            this.panel1.Controls.Add(this.addresstb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nametb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(70, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 168);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.LightGreen;
            this.label7.Location = new System.Drawing.Point(364, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(283, 14);
            this.label7.TabIndex = 17;
            this.label7.Text = "Enter Patient ID Which You Want To Update:";
            // 
            // IDtb
            // 
            // 
            // 
            // 
            this.IDtb.CustomButton.Image = null;
            this.IDtb.CustomButton.Location = new System.Drawing.Point(9, 2);
            this.IDtb.CustomButton.Name = "";
            this.IDtb.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.IDtb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.IDtb.CustomButton.TabIndex = 1;
            this.IDtb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.IDtb.CustomButton.UseSelectable = true;
            this.IDtb.CustomButton.Visible = false;
            this.IDtb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.IDtb.Lines = new string[0];
            this.IDtb.Location = new System.Drawing.Point(648, 100);
            this.IDtb.MaxLength = 32767;
            this.IDtb.Name = "IDtb";
            this.IDtb.PasswordChar = '\0';
            this.IDtb.PromptText = "1";
            this.IDtb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.IDtb.SelectedText = "";
            this.IDtb.SelectionLength = 0;
            this.IDtb.SelectionStart = 0;
            this.IDtb.ShortcutsEnabled = true;
            this.IDtb.Size = new System.Drawing.Size(37, 30);
            this.IDtb.TabIndex = 12;
            this.IDtb.UseSelectable = true;
            this.IDtb.WaterMark = "1";
            this.IDtb.WaterMarkColor = System.Drawing.Color.DarkGreen;
            this.IDtb.WaterMarkFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // deletebutton
            // 
            this.deletebutton.ActiveBorderThickness = 1;
            this.deletebutton.ActiveCornerRadius = 20;
            this.deletebutton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.deletebutton.ActiveForecolor = System.Drawing.Color.Red;
            this.deletebutton.ActiveLineColor = System.Drawing.Color.Red;
            this.deletebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.deletebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deletebutton.BackgroundImage")));
            this.deletebutton.ButtonText = "DELETE";
            this.deletebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deletebutton.IdleBorderThickness = 1;
            this.deletebutton.IdleCornerRadius = 20;
            this.deletebutton.IdleFillColor = System.Drawing.Color.Red;
            this.deletebutton.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.deletebutton.IdleLineColor = System.Drawing.Color.Crimson;
            this.deletebutton.Location = new System.Drawing.Point(912, 89);
            this.deletebutton.Margin = new System.Windows.Forms.Padding(0);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(100, 50);
            this.deletebutton.TabIndex = 10;
            this.deletebutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // addpatientbutton
            // 
            this.addpatientbutton.ActiveBorderThickness = 1;
            this.addpatientbutton.ActiveCornerRadius = 20;
            this.addpatientbutton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.addpatientbutton.ActiveForecolor = System.Drawing.Color.DeepPink;
            this.addpatientbutton.ActiveLineColor = System.Drawing.Color.DeepPink;
            this.addpatientbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.addpatientbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addpatientbutton.BackgroundImage")));
            this.addpatientbutton.ButtonText = "Add Patient";
            this.addpatientbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addpatientbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addpatientbutton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addpatientbutton.IdleBorderThickness = 1;
            this.addpatientbutton.IdleCornerRadius = 20;
            this.addpatientbutton.IdleFillColor = System.Drawing.Color.DeepPink;
            this.addpatientbutton.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.addpatientbutton.IdleLineColor = System.Drawing.Color.MediumVioletRed;
            this.addpatientbutton.Location = new System.Drawing.Point(801, 89);
            this.addpatientbutton.Margin = new System.Windows.Forms.Padding(0);
            this.addpatientbutton.Name = "addpatientbutton";
            this.addpatientbutton.Size = new System.Drawing.Size(100, 50);
            this.addpatientbutton.TabIndex = 9;
            this.addpatientbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addpatientbutton.Click += new System.EventHandler(this.addpatientbutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.ActiveBorderThickness = 1;
            this.updatebutton.ActiveCornerRadius = 20;
            this.updatebutton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.updatebutton.ActiveForecolor = System.Drawing.Color.LightGreen;
            this.updatebutton.ActiveLineColor = System.Drawing.Color.LightGreen;
            this.updatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.updatebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updatebutton.BackgroundImage")));
            this.updatebutton.ButtonText = "UPDATE";
            this.updatebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.ForeColor = System.Drawing.Color.SeaGreen;
            this.updatebutton.IdleBorderThickness = 1;
            this.updatebutton.IdleCornerRadius = 20;
            this.updatebutton.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.updatebutton.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.updatebutton.IdleLineColor = System.Drawing.Color.DarkGreen;
            this.updatebutton.Location = new System.Drawing.Point(690, 89);
            this.updatebutton.Margin = new System.Windows.Forms.Padding(0);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(100, 50);
            this.updatebutton.TabIndex = 10;
            this.updatebutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // emailtb
            // 
            this.emailtb.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtb.Location = new System.Drawing.Point(822, 24);
            this.emailtb.Name = "emailtb";
            this.emailtb.Size = new System.Drawing.Size(190, 26);
            this.emailtb.TabIndex = 11;
            // 
            // phonetb
            // 
            this.phonetb.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonetb.Location = new System.Drawing.Point(600, 24);
            this.phonetb.Name = "phonetb";
            this.phonetb.Size = new System.Drawing.Size(190, 26);
            this.phonetb.TabIndex = 10;
            // 
            // addresstb
            // 
            this.addresstb.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresstb.Location = new System.Drawing.Point(231, 24);
            this.addresstb.Name = "addresstb";
            this.addresstb.Size = new System.Drawing.Size(190, 26);
            this.addresstb.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DeepPink;
            this.label5.Location = new System.Drawing.Point(823, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 14);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DeepPink;
            this.label4.Location = new System.Drawing.Point(597, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(228, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(455, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "DOB:";
            // 
            // nametb
            // 
            this.nametb.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametb.Location = new System.Drawing.Point(3, 24);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(190, 26);
            this.nametb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(0, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // patientdataGridView
            // 
            this.patientdataGridView.AllowUserToAddRows = false;
            this.patientdataGridView.AllowUserToDeleteRows = false;
            this.patientdataGridView.AllowUserToResizeColumns = false;
            this.patientdataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.patientdataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.patientdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patientdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.patientdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.patientdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patientdataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.patientdataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.patientdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.patientdataGridView.ColumnHeadersHeight = 30;
            this.patientdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.patientdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientID,
            this.PatientName,
            this.DOB,
            this.Address,
            this.Phone,
            this.Email});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.patientdataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.patientdataGridView.EnableHeadersVisualStyles = false;
            this.patientdataGridView.Location = new System.Drawing.Point(70, 47);
            this.patientdataGridView.Name = "patientdataGridView";
            this.patientdataGridView.ReadOnly = true;
            this.patientdataGridView.RowHeadersVisible = false;
            this.patientdataGridView.RowTemplate.Height = 50;
            this.patientdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientdataGridView.Size = new System.Drawing.Size(1015, 235);
            this.patientdataGridView.TabIndex = 5;
            // 
            // PatientID
            // 
            this.PatientID.HeaderText = "Patient ID";
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            // 
            // PatientName
            // 
            this.PatientName.HeaderText = "Patient Name";
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            // 
            // DOB
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = "m/d/y";
            this.DOB.DefaultCellStyle = dataGridViewCellStyle3;
            this.DOB.HeaderText = "DOB";
            this.DOB.Name = "DOB";
            this.DOB.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Phone
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle4.NullValue = null;
            this.Phone.DefaultCellStyle = dataGridViewCellStyle4;
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Email
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.Email.DefaultCellStyle = dataGridViewCellStyle5;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // DOBpicker
            // 
            this.DOBpicker.CustomFormat = "yyy/MM/dd";
            this.DOBpicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DOBpicker.Location = new System.Drawing.Point(458, 24);
            this.DOBpicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.DOBpicker.Name = "DOBpicker";
            this.DOBpicker.Size = new System.Drawing.Size(118, 29);
            this.DOBpicker.TabIndex = 18;
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1192, 515);
            this.Controls.Add(this.patientdataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientForm";
            this.Text = "PatientForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox addresstb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailtb;
        private System.Windows.Forms.TextBox phonetb;
        private Bunifu.Framework.UI.BunifuThinButton2 addpatientbutton;
        private Bunifu.Framework.UI.BunifuThinButton2 deletebutton;
        private Bunifu.Framework.UI.BunifuThinButton2 updatebutton;
        private System.Windows.Forms.DataGridView patientdataGridView;
        private MetroFramework.Controls.MetroTextBox IDtb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private MetroFramework.Controls.MetroDateTime DOBpicker;
    }
}