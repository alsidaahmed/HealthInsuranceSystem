namespace WindowsFormsApp1
{
    partial class DoctorClaim
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorClaim));
            this.claimdataGridView = new System.Windows.Forms.DataGridView();
            this.ClaimID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PolicyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClaimDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.claimDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.policyComboBox = new MetroFramework.Controls.MetroComboBox();
            this.patientComboBox = new MetroFramework.Controls.MetroComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ClaimIDtb = new MetroFramework.Controls.MetroTextBox();
            this.addclaimbutton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.deleteclaimbutton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.updateclaimbutton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.amounttb = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descriptiontb = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.claimdataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // claimdataGridView
            // 
            this.claimdataGridView.AllowUserToAddRows = false;
            this.claimdataGridView.AllowUserToDeleteRows = false;
            this.claimdataGridView.AllowUserToResizeColumns = false;
            this.claimdataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.claimdataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.claimdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.claimdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.claimdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.claimdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.claimdataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.claimdataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.claimdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.claimdataGridView.ColumnHeadersHeight = 35;
            this.claimdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.claimdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClaimID,
            this.PatientName,
            this.PolicyName,
            this.Description,
            this.Amount,
            this.ClaimDate,
            this.Status});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.claimdataGridView.DefaultCellStyle = dataGridViewCellStyle14;
            this.claimdataGridView.EnableHeadersVisualStyles = false;
            this.claimdataGridView.Location = new System.Drawing.Point(24, 234);
            this.claimdataGridView.Name = "claimdataGridView";
            this.claimdataGridView.ReadOnly = true;
            this.claimdataGridView.RowHeadersVisible = false;
            this.claimdataGridView.RowTemplate.Height = 50;
            this.claimdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.claimdataGridView.Size = new System.Drawing.Size(757, 261);
            this.claimdataGridView.TabIndex = 6;
            // 
            // ClaimID
            // 
            this.ClaimID.HeaderText = "Claim ID";
            this.ClaimID.Name = "ClaimID";
            this.ClaimID.ReadOnly = true;
            // 
            // PatientName
            // 
            this.PatientName.HeaderText = "Patient Name";
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            // 
            // PolicyName
            // 
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Format = "d";
            dataGridViewCellStyle10.NullValue = "m/d/y";
            this.PolicyName.DefaultCellStyle = dataGridViewCellStyle10;
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
            // Amount
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle11.NullValue = null;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle11;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // ClaimDate
            // 
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.SeaGreen;
            this.ClaimDate.DefaultCellStyle = dataGridViewCellStyle12;
            this.ClaimDate.HeaderText = "Claim Date";
            this.ClaimDate.Name = "ClaimDate";
            this.ClaimDate.ReadOnly = true;
            // 
            // Status
            // 
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Yellow;
            this.Status.DefaultCellStyle = dataGridViewCellStyle13;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.claimDatePicker);
            this.panel1.Controls.Add(this.policyComboBox);
            this.panel1.Controls.Add(this.patientComboBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.ClaimIDtb);
            this.panel1.Controls.Add(this.addclaimbutton);
            this.panel1.Controls.Add(this.deleteclaimbutton);
            this.panel1.Controls.Add(this.updateclaimbutton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.amounttb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.descriptiontb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 185);
            this.panel1.TabIndex = 7;
            // 
            // claimDatePicker
            // 
            this.claimDatePicker.CalendarMonthBackground = System.Drawing.Color.Orchid;
            this.claimDatePicker.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.claimDatePicker.CustomFormat = "yyy/MM/dd";
            this.claimDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.claimDatePicker.Location = new System.Drawing.Point(252, 85);
            this.claimDatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.claimDatePicker.Name = "claimDatePicker";
            this.claimDatePicker.Size = new System.Drawing.Size(132, 29);
            this.claimDatePicker.TabIndex = 24;
            this.claimDatePicker.UseCustomBackColor = true;
            this.claimDatePicker.UseCustomForeColor = true;
            // 
            // policyComboBox
            // 
            this.policyComboBox.BackColor = System.Drawing.Color.Orchid;
            this.policyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.policyComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.policyComboBox.FormattingEnabled = true;
            this.policyComboBox.ItemHeight = 23;
            this.policyComboBox.Location = new System.Drawing.Point(12, 82);
            this.policyComboBox.Name = "policyComboBox";
            this.policyComboBox.Size = new System.Drawing.Size(176, 29);
            this.policyComboBox.TabIndex = 22;
            this.policyComboBox.UseCustomBackColor = true;
            this.policyComboBox.UseCustomForeColor = true;
            this.policyComboBox.UseSelectable = true;
            // 
            // patientComboBox
            // 
            this.patientComboBox.BackColor = System.Drawing.Color.Orchid;
            this.patientComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.patientComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.patientComboBox.FormattingEnabled = true;
            this.patientComboBox.ItemHeight = 23;
            this.patientComboBox.Location = new System.Drawing.Point(11, 24);
            this.patientComboBox.Name = "patientComboBox";
            this.patientComboBox.Size = new System.Drawing.Size(176, 29);
            this.patientComboBox.TabIndex = 8;
            this.patientComboBox.UseCustomBackColor = true;
            this.patientComboBox.UseCustomForeColor = true;
            this.patientComboBox.UseSelectable = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label9.Location = new System.Drawing.Point(579, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 30);
            this.label9.TabIndex = 21;
            this.label9.Text = "      Enter ClaimID\r\n To Update Or Delete :";
            // 
            // ClaimIDtb
            // 
            this.ClaimIDtb.BackColor = System.Drawing.Color.Orchid;
            // 
            // 
            // 
            this.ClaimIDtb.CustomButton.Image = null;
            this.ClaimIDtb.CustomButton.Location = new System.Drawing.Point(14, 2);
            this.ClaimIDtb.CustomButton.Name = "";
            this.ClaimIDtb.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.ClaimIDtb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ClaimIDtb.CustomButton.TabIndex = 1;
            this.ClaimIDtb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ClaimIDtb.CustomButton.UseSelectable = true;
            this.ClaimIDtb.CustomButton.Visible = false;
            this.ClaimIDtb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.ClaimIDtb.ForeColor = System.Drawing.Color.White;
            this.ClaimIDtb.Lines = new string[0];
            this.ClaimIDtb.Location = new System.Drawing.Point(711, 80);
            this.ClaimIDtb.MaxLength = 32767;
            this.ClaimIDtb.Name = "ClaimIDtb";
            this.ClaimIDtb.PasswordChar = '\0';
            this.ClaimIDtb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ClaimIDtb.SelectedText = "";
            this.ClaimIDtb.SelectionLength = 0;
            this.ClaimIDtb.SelectionStart = 0;
            this.ClaimIDtb.ShortcutsEnabled = true;
            this.ClaimIDtb.Size = new System.Drawing.Size(42, 30);
            this.ClaimIDtb.TabIndex = 19;
            this.ClaimIDtb.UseCustomBackColor = true;
            this.ClaimIDtb.UseCustomForeColor = true;
            this.ClaimIDtb.UseSelectable = true;
            this.ClaimIDtb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ClaimIDtb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // addclaimbutton
            // 
            this.addclaimbutton.ActiveBorderThickness = 1;
            this.addclaimbutton.ActiveCornerRadius = 20;
            this.addclaimbutton.ActiveFillColor = System.Drawing.Color.Green;
            this.addclaimbutton.ActiveForecolor = System.Drawing.Color.LightYellow;
            this.addclaimbutton.ActiveLineColor = System.Drawing.Color.LightGreen;
            this.addclaimbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.addclaimbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addclaimbutton.BackgroundImage")));
            this.addclaimbutton.ButtonText = "ADD";
            this.addclaimbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addclaimbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addclaimbutton.ForeColor = System.Drawing.Color.SeaGreen;
            this.addclaimbutton.IdleBorderThickness = 1;
            this.addclaimbutton.IdleCornerRadius = 20;
            this.addclaimbutton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.addclaimbutton.IdleForecolor = System.Drawing.Color.Orchid;
            this.addclaimbutton.IdleLineColor = System.Drawing.Color.Orchid;
            this.addclaimbutton.Location = new System.Drawing.Point(394, 131);
            this.addclaimbutton.Margin = new System.Windows.Forms.Padding(0);
            this.addclaimbutton.Name = "addclaimbutton";
            this.addclaimbutton.Size = new System.Drawing.Size(100, 50);
            this.addclaimbutton.TabIndex = 16;
            this.addclaimbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addclaimbutton.Click += new System.EventHandler(this.addclaimbutton_Click);
            // 
            // deleteclaimbutton
            // 
            this.deleteclaimbutton.ActiveBorderThickness = 1;
            this.deleteclaimbutton.ActiveCornerRadius = 20;
            this.deleteclaimbutton.ActiveFillColor = System.Drawing.Color.Red;
            this.deleteclaimbutton.ActiveForecolor = System.Drawing.Color.White;
            this.deleteclaimbutton.ActiveLineColor = System.Drawing.Color.Crimson;
            this.deleteclaimbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.deleteclaimbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteclaimbutton.BackgroundImage")));
            this.deleteclaimbutton.ButtonText = "DELETE";
            this.deleteclaimbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteclaimbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteclaimbutton.ForeColor = System.Drawing.Color.SeaGreen;
            this.deleteclaimbutton.IdleBorderThickness = 1;
            this.deleteclaimbutton.IdleCornerRadius = 20;
            this.deleteclaimbutton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.deleteclaimbutton.IdleForecolor = System.Drawing.Color.Orchid;
            this.deleteclaimbutton.IdleLineColor = System.Drawing.Color.Orchid;
            this.deleteclaimbutton.Location = new System.Drawing.Point(567, 128);
            this.deleteclaimbutton.Margin = new System.Windows.Forms.Padding(0);
            this.deleteclaimbutton.Name = "deleteclaimbutton";
            this.deleteclaimbutton.Size = new System.Drawing.Size(100, 50);
            this.deleteclaimbutton.TabIndex = 15;
            this.deleteclaimbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteclaimbutton.Click += new System.EventHandler(this.deleteclaimbutton_Click);
            // 
            // updateclaimbutton
            // 
            this.updateclaimbutton.ActiveBorderThickness = 1;
            this.updateclaimbutton.ActiveCornerRadius = 20;
            this.updateclaimbutton.ActiveFillColor = System.Drawing.Color.LightSkyBlue;
            this.updateclaimbutton.ActiveForecolor = System.Drawing.Color.White;
            this.updateclaimbutton.ActiveLineColor = System.Drawing.Color.LightSkyBlue;
            this.updateclaimbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.updateclaimbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateclaimbutton.BackgroundImage")));
            this.updateclaimbutton.ButtonText = "UPDATE";
            this.updateclaimbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateclaimbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateclaimbutton.ForeColor = System.Drawing.Color.SeaGreen;
            this.updateclaimbutton.IdleBorderThickness = 1;
            this.updateclaimbutton.IdleCornerRadius = 20;
            this.updateclaimbutton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.updateclaimbutton.IdleForecolor = System.Drawing.Color.Orchid;
            this.updateclaimbutton.IdleLineColor = System.Drawing.Color.Orchid;
            this.updateclaimbutton.Location = new System.Drawing.Point(669, 128);
            this.updateclaimbutton.Margin = new System.Windows.Forms.Padding(0);
            this.updateclaimbutton.Name = "updateclaimbutton";
            this.updateclaimbutton.Size = new System.Drawing.Size(100, 50);
            this.updateclaimbutton.TabIndex = 14;
            this.updateclaimbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updateclaimbutton.Click += new System.EventHandler(this.updateclaimbutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label5.Location = new System.Drawing.Point(250, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Claim Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label4.Location = new System.Drawing.Point(251, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Amount:";
            // 
            // amounttb
            // 
            this.amounttb.BackColor = System.Drawing.Color.Orchid;
            // 
            // 
            // 
            this.amounttb.CustomButton.Image = null;
            this.amounttb.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.amounttb.CustomButton.Name = "";
            this.amounttb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.amounttb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.amounttb.CustomButton.TabIndex = 1;
            this.amounttb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.amounttb.CustomButton.UseSelectable = true;
            this.amounttb.CustomButton.Visible = false;
            this.amounttb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.amounttb.ForeColor = System.Drawing.Color.White;
            this.amounttb.Lines = new string[0];
            this.amounttb.Location = new System.Drawing.Point(253, 30);
            this.amounttb.MaxLength = 32767;
            this.amounttb.Name = "amounttb";
            this.amounttb.PasswordChar = '\0';
            this.amounttb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.amounttb.SelectedText = "";
            this.amounttb.SelectionLength = 0;
            this.amounttb.SelectionStart = 0;
            this.amounttb.ShortcutsEnabled = true;
            this.amounttb.Size = new System.Drawing.Size(131, 23);
            this.amounttb.TabIndex = 6;
            this.amounttb.UseCustomBackColor = true;
            this.amounttb.UseCustomForeColor = true;
            this.amounttb.UseSelectable = true;
            this.amounttb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.amounttb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label3.Location = new System.Drawing.Point(9, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description:";
            // 
            // descriptiontb
            // 
            this.descriptiontb.BackColor = System.Drawing.Color.Orchid;
            // 
            // 
            // 
            this.descriptiontb.CustomButton.Image = null;
            this.descriptiontb.CustomButton.Location = new System.Drawing.Point(332, 2);
            this.descriptiontb.CustomButton.Name = "";
            this.descriptiontb.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.descriptiontb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.descriptiontb.CustomButton.TabIndex = 1;
            this.descriptiontb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descriptiontb.CustomButton.UseSelectable = true;
            this.descriptiontb.CustomButton.Visible = false;
            this.descriptiontb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.descriptiontb.ForeColor = System.Drawing.Color.White;
            this.descriptiontb.Lines = new string[0];
            this.descriptiontb.Location = new System.Drawing.Point(12, 136);
            this.descriptiontb.MaxLength = 32767;
            this.descriptiontb.Multiline = true;
            this.descriptiontb.Name = "descriptiontb";
            this.descriptiontb.PasswordChar = '\0';
            this.descriptiontb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptiontb.SelectedText = "";
            this.descriptiontb.SelectionLength = 0;
            this.descriptiontb.SelectionStart = 0;
            this.descriptiontb.ShortcutsEnabled = true;
            this.descriptiontb.Size = new System.Drawing.Size(372, 42);
            this.descriptiontb.TabIndex = 4;
            this.descriptiontb.UseCustomBackColor = true;
            this.descriptiontb.UseCustomForeColor = true;
            this.descriptiontb.UseSelectable = true;
            this.descriptiontb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.descriptiontb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label2.Location = new System.Drawing.Point(10, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose Policy :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Patient :";
            // 
            // DoctorClaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.claimdataGridView);
            this.Name = "DoctorClaim";
            this.Text = "DoctorClaim";
            ((System.ComponentModel.ISupportInitialize)(this.claimdataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView claimdataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox amounttb;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox descriptiontb;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 addclaimbutton;
        private Bunifu.Framework.UI.BunifuThinButton2 deleteclaimbutton;
        private Bunifu.Framework.UI.BunifuThinButton2 updateclaimbutton;
        private MetroFramework.Controls.MetroTextBox ClaimIDtb;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroComboBox patientComboBox;
        private MetroFramework.Controls.MetroComboBox policyComboBox;
        private MetroFramework.Controls.MetroDateTime claimDatePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaimID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PolicyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaimDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}