using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PolicyForm : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=lenovo;Initial Catalog=ElectronicInsurance;User ID=sa;Password=sidaahmed23;Encrypt=False");
        public PolicyForm()
        {
            InitializeComponent();
            PolicyBindData();
        }

        internal void PolicyBindData()
        {
            string query = @"SELECT * FROM InsurancePolicies";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            policydataGridView.Columns["PolicyID"].DataPropertyName = "PolicyID";
            policydataGridView.Columns["PolicyName"].DataPropertyName = "PolicyName";
            policydataGridView.Columns["Description"].DataPropertyName = "Description";
            policydataGridView.Columns["Duration"].DataPropertyName = "Duration";
            policydataGridView.Columns["Premium"].DataPropertyName = "Premium";
            policydataGridView.Columns["Photo"].DataPropertyName = "Photo";
            policydataGridView.Columns["CategoryId"].DataPropertyName = "CategoryId";

            policydataGridView.DataSource = dataTable;
        }

        private void policydataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                string resourcename = policydataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();

                if (!String.IsNullOrEmpty(resourcename))
                {
                    try
                    {
                        policypictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(resourcename);

                        if (policypictureBox.Image == null)
                        {
                            MessageBox.Show("Image not found in Resources.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Loading Image: " + ex.Message);
                    }
                }
            }
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(policynametb.Text) || String.IsNullOrWhiteSpace(phototb.Text) || String.IsNullOrWhiteSpace(descriptiontb.Text) || String.IsNullOrEmpty(durationtb.Text) || String.IsNullOrEmpty(premiumtb.Text))
            {
                MessageBox.Show("Please Fill All Fields!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    sqlConnection.Open();
                    string query = @"INSERT INTO InsurancePolicies (PolicyName,Description,Duration,Premium,Photo) VALUES(@policyname, @description, @duration, @premium, @photo)";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@policyname", policynametb.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@description", descriptiontb.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@duration", durationtb.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@premium", premiumtb.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@photo", phototb.Text.Trim());
                        int RowsAffected = sqlCommand.ExecuteNonQuery();
                        if (RowsAffected > 0)
                        {
                            MessageBox.Show("Policy Was Added Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            PolicyBindData();
                        }
                    }
                }
                catch (SqlException ex) { MessageBox.Show("Database Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                finally { sqlConnection.Close(); }
            }
        }




        private void updatebutton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(policynametb.Text) || String.IsNullOrWhiteSpace(phototb.Text) || String.IsNullOrWhiteSpace(descriptiontb.Text) || String.IsNullOrEmpty(durationtb.Text) || String.IsNullOrEmpty(premiumtb.Text))
            {
                MessageBox.Show("Please Enter Valid Policy Details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                sqlConnection.Open();
                string query = @"UPDATE InsurancePolicies SET PolicyName = @PolicyName, Description = @PolicyDescription, Duration = @duration, Premium = @premium, Photo = @photo WHERE PolicyID = @PolicyID";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@PolicyName", policynametb.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@PolicyDescription", descriptiontb.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@duration", durationtb.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@premium", premiumtb.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@photo", phototb.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@PolicyID", idtextbox.Text.Trim());
                    int rowsAffected = sqlCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Policy uUpdated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PolicyBindData();
                    }
                    else
                    {
                        MessageBox.Show("No policy found with the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { sqlConnection.Close(); }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(policynametb.Text))
            {
                MessageBox.Show("Please Write Name Of Policy Which You Want To Delete!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Are You Sure To Delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    sqlConnection.Open();
                    string query = @"DELETE FROM InsurancePolicies WHERE PolicyName = (@policyname)";
                    SqlCommand sqlcommand = new SqlCommand(query, sqlConnection);
                    sqlcommand.Parameters.AddWithValue("@policyname", policynametb.Text.Trim());
                    int rowsAffected = sqlcommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Policy Deleted Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PolicyBindData();
                    }
                    else
                    {
                        MessageBox.Show("Policy Not Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex) { MessageBox.Show("Database Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                finally { sqlConnection.Close(); }
            }
        }
    }
}
