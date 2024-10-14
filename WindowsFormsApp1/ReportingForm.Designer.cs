namespace WindowsFormsApp1
{
    partial class ReportingForm
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
            this.AdminReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.claimReport = new System.Windows.Forms.Button();
            this.policyReport = new System.Windows.Forms.Button();
            this.Patientbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminReport
            // 
            this.AdminReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.AdminReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AdminReport.Location = new System.Drawing.Point(139, 89);
            this.AdminReport.Name = "ReportViewer";
            this.AdminReport.ServerReport.BearerToken = null;
            this.AdminReport.Size = new System.Drawing.Size(800, 500);
            this.AdminReport.TabIndex = 0;
            // 
            // claimReport
            // 
            this.claimReport.BackColor = System.Drawing.Color.Orchid;
            this.claimReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.claimReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claimReport.ForeColor = System.Drawing.SystemColors.Control;
            this.claimReport.Location = new System.Drawing.Point(5, 0);
            this.claimReport.Name = "claimReport";
            this.claimReport.Size = new System.Drawing.Size(143, 33);
            this.claimReport.TabIndex = 0;
            this.claimReport.Text = "Claim Details";
            this.claimReport.UseVisualStyleBackColor = true;
            this.claimReport.Click += new System.EventHandler(this.claimReport_Click);
            // 
            // policyReport
            // 
            this.policyReport.BackColor = System.Drawing.Color.Orchid;
            this.policyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.policyReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.policyReport.ForeColor = System.Drawing.SystemColors.Control;
            this.policyReport.Location = new System.Drawing.Point(151, 0);
            this.policyReport.Name = "policyReport";
            this.policyReport.Size = new System.Drawing.Size(143, 33);
            this.policyReport.TabIndex = 1;
            this.policyReport.Text = "Policy Information";
            this.policyReport.UseVisualStyleBackColor = true;
            this.policyReport.Click += new System.EventHandler(this.policyReport_Click);
            // 
            // Patientbutton
            // 
            this.Patientbutton.BackColor = System.Drawing.Color.Orchid;
            this.Patientbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Patientbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patientbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.Patientbutton.Location = new System.Drawing.Point(297, 0);
            this.Patientbutton.Name = "Patientbutton";
            this.Patientbutton.Size = new System.Drawing.Size(143, 33);
            this.Patientbutton.TabIndex = 2;
            this.Patientbutton.Text = "Patient Information";
            this.Patientbutton.UseVisualStyleBackColor = true;
            this.Patientbutton.Click += new System.EventHandler(this.Patientbutton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Patientbutton);
            this.panel1.Controls.Add(this.claimReport);
            this.panel1.Controls.Add(this.policyReport);
            this.panel1.Location = new System.Drawing.Point(288, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 36);
            this.panel1.TabIndex = 3;
            // 
            // ReportingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1097, 608);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AdminReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportingForm";
            this.Text = "ReportingForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer AdminReport;
        public System.Windows.Forms.Button claimReport;
        public System.Windows.Forms.Button policyReport;
        public System.Windows.Forms.Button Patientbutton;
        private System.Windows.Forms.Panel panel1;
    }
}