namespace WindowsFormsApp1
{
    partial class MedicalRecordForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicalRecordForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.medicalrecordDataGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.patientcomboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.recordDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IDtb = new MetroFramework.Controls.MetroTextBox();
            this.DeleteRecordButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Notestb = new MetroFramework.Controls.MetroTextBox();
            this.Prescriptiontb = new MetroFramework.Controls.MetroTextBox();
            this.AddRecordButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.UpdataRecordButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Diagnosistb = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RecordID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.medicalrecordDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // medicalrecordDataGrid
            // 
            this.medicalrecordDataGrid.AllowUserToAddRows = false;
            this.medicalrecordDataGrid.AllowUserToDeleteRows = false;
            this.medicalrecordDataGrid.AllowUserToResizeColumns = false;
            this.medicalrecordDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.medicalrecordDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.medicalrecordDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.medicalrecordDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.medicalrecordDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.medicalrecordDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.medicalrecordDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.medicalrecordDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.medicalrecordDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.medicalrecordDataGrid.ColumnHeadersHeight = 30;
            this.medicalrecordDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.medicalrecordDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecordID,
            this.PatientName,
            this.Diagnosis,
            this.Prescription,
            this.DoctorNotes,
            this.VisitDate});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.medicalrecordDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.medicalrecordDataGrid.EnableHeadersVisualStyles = false;
            this.medicalrecordDataGrid.Location = new System.Drawing.Point(421, 88);
            this.medicalrecordDataGrid.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.medicalrecordDataGrid.Name = "medicalrecordDataGrid";
            this.medicalrecordDataGrid.ReadOnly = true;
            this.medicalrecordDataGrid.RowHeadersVisible = false;
            this.medicalrecordDataGrid.RowTemplate.Height = 50;
            this.medicalrecordDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.medicalrecordDataGrid.Size = new System.Drawing.Size(742, 383);
            this.medicalrecordDataGrid.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.patientcomboBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.recordDatePicker);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.IDtb);
            this.panel1.Controls.Add(this.DeleteRecordButton);
            this.panel1.Controls.Add(this.Notestb);
            this.panel1.Controls.Add(this.Prescriptiontb);
            this.panel1.Controls.Add(this.AddRecordButton);
            this.panel1.Controls.Add(this.UpdataRecordButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Diagnosistb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 443);
            this.panel1.TabIndex = 3;
            // 
            // patientcomboBox
            // 
            this.patientcomboBox.FormattingEnabled = true;
            this.patientcomboBox.Location = new System.Drawing.Point(12, 25);
            this.patientcomboBox.Name = "patientcomboBox";
            this.patientcomboBox.Size = new System.Drawing.Size(138, 21);
            this.patientcomboBox.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.GreenYellow;
            this.label9.Location = new System.Drawing.Point(11, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Choose Patient :";
            // 
            // recordDatePicker
            // 
            this.recordDatePicker.CustomFormat = "yyy/MM/dd";
            this.recordDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.recordDatePicker.Location = new System.Drawing.Point(12, 254);
            this.recordDatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.recordDatePicker.Name = "recordDatePicker";
            this.recordDatePicker.Size = new System.Drawing.Size(138, 29);
            this.recordDatePicker.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(311, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Delete";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.GreenYellow;
            this.label6.Location = new System.Drawing.Point(106, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.AliceBlue;
            this.label5.Location = new System.Drawing.Point(56, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Enter RecordID Wich You Want To Update Or";
            // 
            // IDtb
            // 
            this.IDtb.BackColor = System.Drawing.Color.Chocolate;
            // 
            // 
            // 
            this.IDtb.CustomButton.Image = null;
            this.IDtb.CustomButton.Location = new System.Drawing.Point(15, 2);
            this.IDtb.CustomButton.Name = "";
            this.IDtb.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.IDtb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.IDtb.CustomButton.TabIndex = 1;
            this.IDtb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.IDtb.CustomButton.UseSelectable = true;
            this.IDtb.CustomButton.Visible = false;
            this.IDtb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.IDtb.ForeColor = System.Drawing.Color.White;
            this.IDtb.Lines = new string[0];
            this.IDtb.Location = new System.Drawing.Point(135, 386);
            this.IDtb.MaxLength = 32767;
            this.IDtb.Name = "IDtb";
            this.IDtb.PasswordChar = '\0';
            this.IDtb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.IDtb.SelectedText = "";
            this.IDtb.SelectionLength = 0;
            this.IDtb.SelectionStart = 0;
            this.IDtb.ShortcutsEnabled = true;
            this.IDtb.Size = new System.Drawing.Size(43, 30);
            this.IDtb.TabIndex = 14;
            this.IDtb.UseCustomBackColor = true;
            this.IDtb.UseCustomForeColor = true;
            this.IDtb.UseSelectable = true;
            this.IDtb.WaterMarkColor = System.Drawing.Color.White;
            this.IDtb.WaterMarkFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.ActiveBorderThickness = 1;
            this.DeleteRecordButton.ActiveCornerRadius = 20;
            this.DeleteRecordButton.ActiveFillColor = System.Drawing.Color.Red;
            this.DeleteRecordButton.ActiveForecolor = System.Drawing.Color.White;
            this.DeleteRecordButton.ActiveLineColor = System.Drawing.Color.Crimson;
            this.DeleteRecordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.DeleteRecordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteRecordButton.BackgroundImage")));
            this.DeleteRecordButton.ButtonText = "Delete";
            this.DeleteRecordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRecordButton.ForeColor = System.Drawing.Color.YellowGreen;
            this.DeleteRecordButton.IdleBorderThickness = 1;
            this.DeleteRecordButton.IdleCornerRadius = 20;
            this.DeleteRecordButton.IdleFillColor = System.Drawing.Color.GreenYellow;
            this.DeleteRecordButton.IdleForecolor = System.Drawing.Color.Brown;
            this.DeleteRecordButton.IdleLineColor = System.Drawing.Color.DarkGreen;
            this.DeleteRecordButton.Location = new System.Drawing.Point(271, 376);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteRecordButton.Name = "DeleteRecordButton";
            this.DeleteRecordButton.Size = new System.Drawing.Size(90, 50);
            this.DeleteRecordButton.TabIndex = 7;
            this.DeleteRecordButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteRecordButton.Click += new System.EventHandler(this.DeleteRecordButton_Click);
            // 
            // Notestb
            // 
            this.Notestb.BackColor = System.Drawing.Color.Chocolate;
            // 
            // 
            // 
            this.Notestb.CustomButton.Image = null;
            this.Notestb.CustomButton.Location = new System.Drawing.Point(305, 1);
            this.Notestb.CustomButton.Name = "";
            this.Notestb.CustomButton.Size = new System.Drawing.Size(43, 43);
            this.Notestb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Notestb.CustomButton.TabIndex = 1;
            this.Notestb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Notestb.CustomButton.UseSelectable = true;
            this.Notestb.CustomButton.Visible = false;
            this.Notestb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Notestb.ForeColor = System.Drawing.Color.White;
            this.Notestb.Lines = new string[0];
            this.Notestb.Location = new System.Drawing.Point(12, 181);
            this.Notestb.MaxLength = 32767;
            this.Notestb.Multiline = true;
            this.Notestb.Name = "Notestb";
            this.Notestb.PasswordChar = '\0';
            this.Notestb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Notestb.SelectedText = "";
            this.Notestb.SelectionLength = 0;
            this.Notestb.SelectionStart = 0;
            this.Notestb.ShortcutsEnabled = true;
            this.Notestb.Size = new System.Drawing.Size(349, 45);
            this.Notestb.TabIndex = 13;
            this.Notestb.UseCustomBackColor = true;
            this.Notestb.UseCustomForeColor = true;
            this.Notestb.UseSelectable = true;
            this.Notestb.WaterMarkColor = System.Drawing.Color.White;
            this.Notestb.WaterMarkFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Prescriptiontb
            // 
            this.Prescriptiontb.BackColor = System.Drawing.Color.Chocolate;
            // 
            // 
            // 
            this.Prescriptiontb.CustomButton.Image = null;
            this.Prescriptiontb.CustomButton.Location = new System.Drawing.Point(327, 1);
            this.Prescriptiontb.CustomButton.Name = "";
            this.Prescriptiontb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Prescriptiontb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Prescriptiontb.CustomButton.TabIndex = 1;
            this.Prescriptiontb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Prescriptiontb.CustomButton.UseSelectable = true;
            this.Prescriptiontb.CustomButton.Visible = false;
            this.Prescriptiontb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Prescriptiontb.ForeColor = System.Drawing.Color.White;
            this.Prescriptiontb.Lines = new string[0];
            this.Prescriptiontb.Location = new System.Drawing.Point(12, 127);
            this.Prescriptiontb.MaxLength = 32767;
            this.Prescriptiontb.Name = "Prescriptiontb";
            this.Prescriptiontb.PasswordChar = '\0';
            this.Prescriptiontb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Prescriptiontb.SelectedText = "";
            this.Prescriptiontb.SelectionLength = 0;
            this.Prescriptiontb.SelectionStart = 0;
            this.Prescriptiontb.ShortcutsEnabled = true;
            this.Prescriptiontb.Size = new System.Drawing.Size(349, 23);
            this.Prescriptiontb.TabIndex = 12;
            this.Prescriptiontb.UseCustomBackColor = true;
            this.Prescriptiontb.UseCustomForeColor = true;
            this.Prescriptiontb.UseSelectable = true;
            this.Prescriptiontb.WaterMarkColor = System.Drawing.Color.White;
            this.Prescriptiontb.WaterMarkFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // AddRecordButton
            // 
            this.AddRecordButton.ActiveBorderThickness = 1;
            this.AddRecordButton.ActiveCornerRadius = 20;
            this.AddRecordButton.ActiveFillColor = System.Drawing.Color.GreenYellow;
            this.AddRecordButton.ActiveForecolor = System.Drawing.Color.Brown;
            this.AddRecordButton.ActiveLineColor = System.Drawing.Color.DarkGreen;
            this.AddRecordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.AddRecordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddRecordButton.BackgroundImage")));
            this.AddRecordButton.ButtonText = "Add";
            this.AddRecordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRecordButton.ForeColor = System.Drawing.Color.YellowGreen;
            this.AddRecordButton.IdleBorderThickness = 1;
            this.AddRecordButton.IdleCornerRadius = 20;
            this.AddRecordButton.IdleFillColor = System.Drawing.Color.GreenYellow;
            this.AddRecordButton.IdleForecolor = System.Drawing.Color.Brown;
            this.AddRecordButton.IdleLineColor = System.Drawing.Color.DarkGreen;
            this.AddRecordButton.Location = new System.Drawing.Point(271, 245);
            this.AddRecordButton.Margin = new System.Windows.Forms.Padding(5);
            this.AddRecordButton.Name = "AddRecordButton";
            this.AddRecordButton.Size = new System.Drawing.Size(90, 50);
            this.AddRecordButton.TabIndex = 5;
            this.AddRecordButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddRecordButton.Click += new System.EventHandler(this.AddRecordButton_Click);
            // 
            // UpdataRecordButton
            // 
            this.UpdataRecordButton.ActiveBorderThickness = 1;
            this.UpdataRecordButton.ActiveCornerRadius = 20;
            this.UpdataRecordButton.ActiveFillColor = System.Drawing.Color.GreenYellow;
            this.UpdataRecordButton.ActiveForecolor = System.Drawing.Color.Brown;
            this.UpdataRecordButton.ActiveLineColor = System.Drawing.Color.DarkGreen;
            this.UpdataRecordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.UpdataRecordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdataRecordButton.BackgroundImage")));
            this.UpdataRecordButton.ButtonText = "Update";
            this.UpdataRecordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdataRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdataRecordButton.ForeColor = System.Drawing.Color.YellowGreen;
            this.UpdataRecordButton.IdleBorderThickness = 1;
            this.UpdataRecordButton.IdleCornerRadius = 20;
            this.UpdataRecordButton.IdleFillColor = System.Drawing.Color.GreenYellow;
            this.UpdataRecordButton.IdleForecolor = System.Drawing.Color.Brown;
            this.UpdataRecordButton.IdleLineColor = System.Drawing.Color.DarkGreen;
            this.UpdataRecordButton.Location = new System.Drawing.Point(179, 376);
            this.UpdataRecordButton.Margin = new System.Windows.Forms.Padding(5);
            this.UpdataRecordButton.Name = "UpdataRecordButton";
            this.UpdataRecordButton.Size = new System.Drawing.Size(90, 50);
            this.UpdataRecordButton.TabIndex = 6;
            this.UpdataRecordButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdataRecordButton.Click += new System.EventHandler(this.UpdataRecordButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.GreenYellow;
            this.label3.Location = new System.Drawing.Point(11, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prescription:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(9, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Visit Data:";
            // 
            // Diagnosistb
            // 
            this.Diagnosistb.BackColor = System.Drawing.Color.Chocolate;
            // 
            // 
            // 
            this.Diagnosistb.CustomButton.Image = null;
            this.Diagnosistb.CustomButton.Location = new System.Drawing.Point(327, 1);
            this.Diagnosistb.CustomButton.Name = "";
            this.Diagnosistb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Diagnosistb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Diagnosistb.CustomButton.TabIndex = 1;
            this.Diagnosistb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Diagnosistb.CustomButton.UseSelectable = true;
            this.Diagnosistb.CustomButton.Visible = false;
            this.Diagnosistb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Diagnosistb.ForeColor = System.Drawing.Color.White;
            this.Diagnosistb.Lines = new string[0];
            this.Diagnosistb.Location = new System.Drawing.Point(12, 72);
            this.Diagnosistb.MaxLength = 32767;
            this.Diagnosistb.Name = "Diagnosistb";
            this.Diagnosistb.PasswordChar = '\0';
            this.Diagnosistb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Diagnosistb.SelectedText = "";
            this.Diagnosistb.SelectionLength = 0;
            this.Diagnosistb.SelectionStart = 0;
            this.Diagnosistb.ShortcutsEnabled = true;
            this.Diagnosistb.Size = new System.Drawing.Size(349, 23);
            this.Diagnosistb.TabIndex = 11;
            this.Diagnosistb.UseCustomBackColor = true;
            this.Diagnosistb.UseCustomForeColor = true;
            this.Diagnosistb.UseSelectable = true;
            this.Diagnosistb.WaterMarkColor = System.Drawing.Color.White;
            this.Diagnosistb.WaterMarkFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.GreenYellow;
            this.label4.Location = new System.Drawing.Point(10, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Doctor Notes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.GreenYellow;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Diagnosis:";
            // 
            // RecordID
            // 
            this.RecordID.HeaderText = "Record ID";
            this.RecordID.Name = "RecordID";
            this.RecordID.ReadOnly = true;
            // 
            // PatientName
            // 
            this.PatientName.HeaderText = "Patient Name";
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            // 
            // Diagnosis
            // 
            this.Diagnosis.HeaderText = "Diagnosis";
            this.Diagnosis.Name = "Diagnosis";
            this.Diagnosis.ReadOnly = true;
            // 
            // Prescription
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.NullValue = null;
            this.Prescription.DefaultCellStyle = dataGridViewCellStyle3;
            this.Prescription.HeaderText = "Prescription";
            this.Prescription.Name = "Prescription";
            this.Prescription.ReadOnly = true;
            // 
            // DoctorNotes
            // 
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.DoctorNotes.DefaultCellStyle = dataGridViewCellStyle4;
            this.DoctorNotes.HeaderText = "Doctor Notes";
            this.DoctorNotes.Name = "DoctorNotes";
            this.DoctorNotes.ReadOnly = true;
            // 
            // VisitDate
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.VisitDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.VisitDate.HeaderText = "Visit Date";
            this.VisitDate.Name = "VisitDate";
            this.VisitDate.ReadOnly = true;
            // 
            // MedicalRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1175, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.medicalrecordDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedicalRecordForm";
            this.Text = "MedicalRecordForm";
            ((System.ComponentModel.ISupportInitialize)(this.medicalrecordDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView medicalrecordDataGrid;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 AddRecordButton;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox Notestb;
        private MetroFramework.Controls.MetroTextBox Prescriptiontb;
        private MetroFramework.Controls.MetroTextBox Diagnosistb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 UpdataRecordButton;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteRecordButton;
        private MetroFramework.Controls.MetroTextBox IDtb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroDateTime recordDatePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox patientcomboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitDate;
    }
}