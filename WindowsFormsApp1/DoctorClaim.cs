using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DoctorClaim : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=lenovo;Initial Catalog=ElectronicInsurance;User ID=sa;Password=sidaahmed23;Encrypt=False");
        public DoctorClaim()
        {
            InitializeComponent();
            BindClaimDataGridView();
            LoadPatientData();
            LoadPolicyData();
        }

        internal void LoadPatientData()
        {
            try
            {
                string query = @"SELECT PatientID, PatientName FROM Patients";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                patientComboBox.DisplayMember = "PatientName";
                patientComboBox.ValueMember = "PatientID";
                patientComboBox.DataSource = dataTable;
            }
            catch (SqlException ex) { MessageBox.Show("DataBase Error " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        internal void LoadPolicyData()
        {
            try
            {
                string query = @"SELECT PolicyID, PolicyName FROM InsurancePolicies";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                policyComboBox.DisplayMember = "PolicyName";
                policyComboBox.ValueMember = "PolicyID";
                policyComboBox.DataSource = dataTable;
            }
            catch (SqlException ex) { MessageBox.Show("DataBase Error " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        internal void BindClaimDataGridView()
        {
            string query = @"SELECT ClaimID, PatientName, PolicyName, Description, Amount, ClaimDate, Status FROM InsuranceClaims";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            claimdataGridView.Columns["ClaimID"].DataPropertyName = "ClaimID";
            claimdataGridView.Columns["PatientName"].DataPropertyName = "PatientName";
            claimdataGridView.Columns["PolicyName"].DataPropertyName = "PolicyName";
            claimdataGridView.Columns["Description"].DataPropertyName = "Description";
            claimdataGridView.Columns["Amount"].DataPropertyName = "Amount";
            claimdataGridView.Columns["ClaimDate"].DataPropertyName = "ClaimDate";
            claimdataGridView.Columns["Status"].DataPropertyName = "Status";

            claimdataGridView.DataSource = dataTable;

        }

        private void addclaimbutton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(patientComboBox.Text) || String.IsNullOrWhiteSpace(policyComboBox.Text) || String.IsNullOrWhiteSpace(descriptiontb.Text) || String.IsNullOrEmpty(amounttb.Text) || String.IsNullOrEmpty(claimDatePicker.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please Fill All Fields!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    sqlConnection.Open();
                    string query = @"INSERT INTO InsuranceClaims (PatientName,PolicyName,Description,Amount,ClaimDate) VALUES(@patient, @policy, @description, @amount, @date)";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@patient", patientComboBox.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@policy", policyComboBox.Text);
                        sqlCommand.Parameters.AddWithValue("@description", descriptiontb.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@amount", amounttb.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@date", claimDatePicker.Text);

                        int RowsAffected = sqlCommand.ExecuteNonQuery();
                        if (RowsAffected > 0)
                        {
                            System.Windows.Forms.MessageBox.Show("New Claim Was Added Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BindClaimDataGridView();
                        }
                    }
                }
                catch (SqlException ex) { System.Windows.Forms.MessageBox.Show("Database Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                finally { sqlConnection.Close(); }
            }

        }

        private void updateclaimbutton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(patientComboBox.Text) || String.IsNullOrWhiteSpace(policyComboBox.Text) || String.IsNullOrWhiteSpace(descriptiontb.Text) || String.IsNullOrEmpty(amounttb.Text) || String.IsNullOrEmpty(claimDatePicker.Text) || String.IsNullOrEmpty(ClaimIDtb.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please Enter Valid Details!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    sqlConnection.Open();
                    string query = @"UPDATE InsuranceClaims SET PatientName = @patient, PolicyName = @policy, Description = @description, Amount = @amount WHERE ClaimID = @ID)";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@patient", patientComboBox.Text);
                        sqlCommand.Parameters.AddWithValue("@policy", policyComboBox.Text);
                        sqlCommand.Parameters.AddWithValue("@description", descriptiontb.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@amount", amounttb.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@date", claimDatePicker.Text);
                        sqlCommand.Parameters.AddWithValue("@ID", ClaimIDtb.Text);

                        int RowsAffected = sqlCommand.ExecuteNonQuery();
                        if (RowsAffected > 0)
                        {
                            System.Windows.Forms.MessageBox.Show("Claim Was Updated Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BindClaimDataGridView();
                        }
                    }
                }
                catch (SqlException ex) { System.Windows.Forms.MessageBox.Show("Database Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                finally { sqlConnection.Close(); }
            }

        }

        private void deleteclaimbutton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ClaimIDtb.Text))
            {
                MessageBox.Show("Please Enter ClaimID Which You Want To Delete!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Are You Sure To Delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    sqlConnection.Open();
                    string query = @"DELETE FROM InsuranceClaims WHERE ClaimID = (@ID)";
                    SqlCommand sqlcommand = new SqlCommand(query, sqlConnection);
                    sqlcommand.Parameters.AddWithValue("@ID", ClaimIDtb.Text);
                    int rowsAffected = sqlcommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Claim Deleted Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindClaimDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Claim Not Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex) { MessageBox.Show("Database Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                finally { sqlConnection.Close(); }

            }

        }
    }
}