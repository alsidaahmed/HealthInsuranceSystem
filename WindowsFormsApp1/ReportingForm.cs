using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ReportingForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=lenovo;Initial Catalog=ElectronicInsurance;User ID=sa;Password=sidaahmed23;Encrypt=False");
        public ReportingForm()
        {
            InitializeComponent();
            this.AdminReport.RefreshReport();

        }

        private DataTable ClaimDetails()
        {
            DataTable dataTable = new DataTable();
            string query = @"SELECT PatientName, PolicyName, ClaimDate, Status, Amount FROM InsuranceClaims";
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            dataTable.Load(reader);
            connection.Close();
            return dataTable;
        }

        private DataTable PolicyInformation()
        {
            DataTable dataTable = new DataTable();
            string query = @"SELECT PolicyName, Duration, Premium FROM InsurancePolicies";
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            dataTable.Load(reader);
            connection.Close();
            return dataTable;
        }

        private DataTable PatientInformation()
        {
            DataTable dataTable = new DataTable();
            string query = @"SELECT PatientID, PatientName FROM Patients";
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            dataTable.Load(reader);
            connection.Close();
            return dataTable;

        }

        private void claimReport_Click(object sender, EventArgs e)
        {
            AdminReport.LocalReport.DataSources.Clear();
            ReportDataSource claimDetails = new ReportDataSource("ClaimReport", ClaimDetails());
            AdminReport.LocalReport.ReportPath = @"C:\Users\Manar\source\repos\HealthInsuranceSystem\WindowsFormsApp1\AdminReport\Report1.rdlc";
            AdminReport.LocalReport.DataSources.Add(claimDetails);
            AdminReport.RefreshReport();
        }

        private void policyReport_Click(object sender, EventArgs e)
        {
            AdminReport.LocalReport.DataSources.Clear();
            ReportDataSource policyInformation = new ReportDataSource("PolicyDataSet", PolicyInformation());
            AdminReport.LocalReport.ReportPath = @"C:\Users\Manar\source\repos\HealthInsuranceSystem\WindowsFormsApp1\AdminReport\Report2.rdlc";
            AdminReport.LocalReport.DataSources.Add(policyInformation);
            AdminReport.RefreshReport();
        }

        private void Patientbutton_Click(object sender, EventArgs e)
        {
            AdminReport.LocalReport.DataSources.Clear();
            ReportDataSource patientInformation = new ReportDataSource("PatientReport", PatientInformation());
            AdminReport.LocalReport.ReportPath = @"C:\Users\Manar\source\repos\HealthInsuranceSystem\WindowsFormsApp1\AdminReport\Report3.rdlc";
            AdminReport.LocalReport.DataSources.Add(patientInformation);
            AdminReport.RefreshReport();
        }
    }
}
