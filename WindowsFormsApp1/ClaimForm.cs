using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ClaimForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=lenovo;Initial Catalog=ElectronicInsurance;User ID=sa;Password=sidaahmed23;Encrypt=False");

        public ClaimForm()
        {
            InitializeComponent();
            LoadClaimData();
            ComboBoxStatusBinding();

        }

        internal void ComboBoxStatusBinding()
        {
            try
            {
                string query = @"SELECT StatusID, StatusName FROM Status";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                statusComboBox.DisplayMember = "StatusName";
                statusComboBox.ValueMember = "StatusID";
                statusComboBox.DataSource = dataTable;
            }
            catch (SqlException ex) { MessageBox.Show("DataBase Error " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        internal void LoadClaimData()
        {
            string query = @"SELECT ic.[ClaimID], ic.[PatientName], ic.[PolicyName],ic.[Description],ic.[Amount], ic.[ClaimDate], ic.[Status] FROM InsuranceClaims ic";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
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

        private void ClaimForm_Load(object sender, System.EventArgs e)
        {
            LoadClaimData();
            ComboBoxStatusBinding();
        }

        private void updatebutton_Click(object sender, System.EventArgs e)
        {
            if ((string.IsNullOrEmpty(claimIDTextBox.Text)) || (string.IsNullOrEmpty((String)statusComboBox.SelectedItem))) { MessageBox.Show("Please Enter ClaimID And Select Status", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                string query = @"UPDATE InsuranceClaims SET Status = @Status WHERE ClaimID = @ClaimID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Status", statusComboBox.Text);
                    command.Parameters.AddWithValue("@ClaimID", claimIDTextBox.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                MessageBox.Show("Claim Status Updated Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadClaimData();
            }
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            string claimID = searchtextbox.Text.Trim();
            if (!string.IsNullOrEmpty(claimID))
            {
                foreach (DataGridViewRow row in claimdataGridView.Rows)
                {
                    if (row.Cells["ClaimID"].Value.ToString().Equals(claimID))
                    {
                        row.Selected = true;
                        claimdataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                        return;
                    }
                }
                MessageBox.Show("Claim Not Found", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please Enter A Valid ClaimID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void penddingbutton_Click(object sender, EventArgs e)
        {
            FilterClaimsByStatus("Pending");
        }

        private void approvedbutton_Click(object sender, EventArgs e)
        {
            FilterClaimsByStatus("Approved");
        }

        private void rejectedbutton_Click(object sender, EventArgs e)
        {
            FilterClaimsByStatus("Rejected");
        }

        private void FilterClaimsByStatus(string status)
        {
            if (claimdataGridView.DataSource != null)
            {
                DataTable dataTable = (DataTable)claimdataGridView.DataSource;

                dataTable.DefaultView.RowFilter = $"Status = '{status}'";
            }
        }
    }
}
