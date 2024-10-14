using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DoctorDashboard : Form
    {
        public DoctorDashboard()
        {
            InitializeComponent();
        }

        private void patientbutton_Click(object sender, EventArgs e)
        {
            this.formactive.Location = new Point(patientbutton.Location.X, patientbutton.Location.Y);
            PatientForm patientForm = new PatientForm();
            patientForm.MdiParent = this;
            patientForm.FormBorderStyle = FormBorderStyle.None;
            patientForm.Dock = DockStyle.Fill;
            patientForm.Show();

        }

        private void recordbutton_Click(object sender, EventArgs e)
        {
            this.formactive.Location = new Point(recordbutton.Location.X, recordbutton.Location.Y);
            MedicalRecordForm medicalRecordForm = new MedicalRecordForm();
            medicalRecordForm.MdiParent = this;
            medicalRecordForm.FormBorderStyle= FormBorderStyle.None;
            medicalRecordForm.Dock = DockStyle.Fill;
            medicalRecordForm.Show();
        }

        private void viewcategorybutton_Click(object sender, EventArgs e)
        {
            this.formactive.Location = new Point(viewcategorybutton.Location.X, recordbutton.Location.Y);
            ViewCategory viewCategory = new ViewCategory();
            viewCategory.MdiParent = this;
            viewCategory.FormBorderStyle = FormBorderStyle.None;
            viewCategory.Dock = DockStyle.Fill;
            viewCategory.Show();
        }

        private void makeclaimbutton_Click(object sender, EventArgs e)
        {
            this.formactive.Location = new Point(makeclaimbutton.Location.X, recordbutton.Location.Y);
            DoctorClaim doctorClaim = new DoctorClaim();
            doctorClaim.MdiParent = this;
            doctorClaim.FormBorderStyle = FormBorderStyle.None;
            doctorClaim.Dock = DockStyle.Fill;
            doctorClaim.Show();

        }

        private void DoctorProfile_Click(object sender, EventArgs e)
        {
            DoctorProfile doctorProfile = new DoctorProfile();
            doctorProfile.MdiParent = this;
            doctorProfile.FormBorderStyle = FormBorderStyle.None;
            doctorProfile.Dock = DockStyle.Fill;
            doctorProfile.Show();
        }
    }
}
