namespace WindowsFormsApp1
{
    partial class ClaimForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClaimForm));
            this.claimdataGridView = new System.Windows.Forms.DataGridView();
            this.ClaimID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PolicyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClaimDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.searchtextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.claimIDTextBox = new System.Windows.Forms.TextBox();
            this.statusComboBox = new MetroFramework.Controls.MetroComboBox();
            this.updatebutton = new System.Windows.Forms.Button();
            this.rejectedbutton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.approvedbutton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.penddingbutton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.searchbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.claimdataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.claimdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.claimdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.claimdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.claimdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.claimdataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.claimdataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.claimdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.claimdataGridView.ColumnHeadersHeight = 30;
            this.claimdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.claimdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClaimID,
            this.PatientName,
            this.PolicyName,
            this.Description,
            this.Amount,
            this.ClaimDate,
            this.Status});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.claimdataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.claimdataGridView.EnableHeadersVisualStyles = false;
            this.claimdataGridView.Location = new System.Drawing.Point(69, 140);
            this.claimdataGridView.Name = "claimdataGridView";
            this.claimdataGridView.ReadOnly = true;
            this.claimdataGridView.RowHeadersVisible = false;
            this.claimdataGridView.RowTemplate.Height = 50;
            this.claimdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.claimdataGridView.Size = new System.Drawing.Size(807, 331);
            this.claimdataGridView.TabIndex = 0;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.Format = "C5";
            dataGridViewCellStyle3.NullValue = "0";
            this.Amount.DefaultCellStyle = dataGridViewCellStyle3;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // ClaimDate
            // 
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.ClaimDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.ClaimDate.HeaderText = "Claim Date";
            this.ClaimDate.Name = "ClaimDate";
            this.ClaimDate.ReadOnly = true;
            // 
            // Status
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Yellow;
            this.Status.DefaultCellStyle = dataGridViewCellStyle5;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // searchtextbox
            // 
            this.searchtextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.searchtextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchtextbox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.searchtextbox.ForeColor = System.Drawing.Color.White;
            this.searchtextbox.Location = new System.Drawing.Point(71, 74);
            this.searchtextbox.Multiline = true;
            this.searchtextbox.Name = "searchtextbox";
            this.searchtextbox.Size = new System.Drawing.Size(242, 28);
            this.searchtextbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(68, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search By ID:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(592, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status Filters:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepPink;
            this.label4.Location = new System.Drawing.Point(306, 530);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Insert ClaimID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepPink;
            this.label5.Location = new System.Drawing.Point(306, 576);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Insert Status:";
            // 
            // claimIDTextBox
            // 
            this.claimIDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.claimIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.claimIDTextBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.claimIDTextBox.ForeColor = System.Drawing.Color.White;
            this.claimIDTextBox.Location = new System.Drawing.Point(420, 524);
            this.claimIDTextBox.Multiline = true;
            this.claimIDTextBox.Name = "claimIDTextBox";
            this.claimIDTextBox.Size = new System.Drawing.Size(36, 29);
            this.claimIDTextBox.TabIndex = 12;
            // 
            // statusComboBox
            // 
            this.statusComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.statusComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusComboBox.ForeColor = System.Drawing.Color.White;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.ItemHeight = 23;
            this.statusComboBox.Location = new System.Drawing.Point(420, 572);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 29);
            this.statusComboBox.TabIndex = 13;
            this.statusComboBox.UseCustomBackColor = true;
            this.statusComboBox.UseCustomForeColor = true;
            this.statusComboBox.UseSelectable = true;
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.updatebutton.FlatAppearance.BorderSize = 0;
            this.updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebutton.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.updatebutton.ForeColor = System.Drawing.Color.White;
            this.updatebutton.Location = new System.Drawing.Point(553, 572);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 29);
            this.updatebutton.TabIndex = 14;
            this.updatebutton.Text = "UPDATE";
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // rejectedbutton
            // 
            this.rejectedbutton.ActiveBorderThickness = 1;
            this.rejectedbutton.ActiveCornerRadius = 20;
            this.rejectedbutton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.rejectedbutton.ActiveForecolor = System.Drawing.Color.White;
            this.rejectedbutton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.rejectedbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.rejectedbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rejectedbutton.BackgroundImage")));
            this.rejectedbutton.ButtonText = "rejected";
            this.rejectedbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rejectedbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rejectedbutton.ForeColor = System.Drawing.Color.White;
            this.rejectedbutton.IdleBorderThickness = 1;
            this.rejectedbutton.IdleCornerRadius = 20;
            this.rejectedbutton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.rejectedbutton.IdleForecolor = System.Drawing.Color.White;
            this.rejectedbutton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.rejectedbutton.Location = new System.Drawing.Point(188, 0);
            this.rejectedbutton.Margin = new System.Windows.Forms.Padding(5);
            this.rejectedbutton.Name = "rejectedbutton";
            this.rejectedbutton.Size = new System.Drawing.Size(93, 42);
            this.rejectedbutton.TabIndex = 9;
            this.rejectedbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rejectedbutton.Click += new System.EventHandler(this.rejectedbutton_Click);
            // 
            // approvedbutton
            // 
            this.approvedbutton.ActiveBorderThickness = 1;
            this.approvedbutton.ActiveCornerRadius = 20;
            this.approvedbutton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.approvedbutton.ActiveForecolor = System.Drawing.Color.White;
            this.approvedbutton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.approvedbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.approvedbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("approvedbutton.BackgroundImage")));
            this.approvedbutton.ButtonText = "approved";
            this.approvedbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.approvedbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvedbutton.ForeColor = System.Drawing.Color.White;
            this.approvedbutton.IdleBorderThickness = 1;
            this.approvedbutton.IdleCornerRadius = 20;
            this.approvedbutton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.approvedbutton.IdleForecolor = System.Drawing.Color.White;
            this.approvedbutton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.approvedbutton.Location = new System.Drawing.Point(94, 0);
            this.approvedbutton.Margin = new System.Windows.Forms.Padding(5);
            this.approvedbutton.Name = "approvedbutton";
            this.approvedbutton.Size = new System.Drawing.Size(93, 42);
            this.approvedbutton.TabIndex = 8;
            this.approvedbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.approvedbutton.Click += new System.EventHandler(this.approvedbutton_Click);
            // 
            // penddingbutton
            // 
            this.penddingbutton.AccessibleName = "";
            this.penddingbutton.ActiveBorderThickness = 1;
            this.penddingbutton.ActiveCornerRadius = 20;
            this.penddingbutton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.penddingbutton.ActiveForecolor = System.Drawing.Color.White;
            this.penddingbutton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.penddingbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.penddingbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("penddingbutton.BackgroundImage")));
            this.penddingbutton.ButtonText = "pendding";
            this.penddingbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.penddingbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penddingbutton.ForeColor = System.Drawing.Color.White;
            this.penddingbutton.IdleBorderThickness = 1;
            this.penddingbutton.IdleCornerRadius = 20;
            this.penddingbutton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.penddingbutton.IdleForecolor = System.Drawing.Color.White;
            this.penddingbutton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.penddingbutton.Location = new System.Drawing.Point(0, 0);
            this.penddingbutton.Margin = new System.Windows.Forms.Padding(5);
            this.penddingbutton.Name = "penddingbutton";
            this.penddingbutton.Size = new System.Drawing.Size(93, 42);
            this.penddingbutton.TabIndex = 7;
            this.penddingbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.penddingbutton.Click += new System.EventHandler(this.penddingbutton_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            this.searchbutton.FlatAppearance.BorderSize = 2;
            this.searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbutton.Image = global::WindowsFormsApp1.Properties.Resources.icons8_search_301;
            this.searchbutton.Location = new System.Drawing.Point(319, 74);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(26, 28);
            this.searchbutton.TabIndex = 3;
            this.searchbutton.UseVisualStyleBackColor = false;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.approvedbutton);
            this.panel1.Controls.Add(this.penddingbutton);
            this.panel1.Controls.Add(this.rejectedbutton);
            this.panel1.Location = new System.Drawing.Point(595, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 42);
            this.panel1.TabIndex = 15;
            // 
            // ClaimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1008, 666);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.claimIDTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchtextbox);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.claimdataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClaimForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClaimForm";
            this.Load += new System.EventHandler(this.ClaimForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.claimdataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView claimdataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.TextBox searchtextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 penddingbutton;
        private Bunifu.Framework.UI.BunifuThinButton2 approvedbutton;
        private Bunifu.Framework.UI.BunifuThinButton2 rejectedbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaimID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PolicyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaimDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox claimIDTextBox;
        private MetroFramework.Controls.MetroComboBox statusComboBox;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Panel panel1;
    }
}