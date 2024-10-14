using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows;

namespace WindowsFormsApp1
{
    public partial class PatientForm : Form
    {
        SqlConnection SqlConnection = new SqlConnection(@"Data Source=lenovo;Initial Catalog=ElectronicInsurance;User ID=sa;Password=sidaahmed23;Encrypt=False");
        public PatientForm()
        {
            InitializeComponent();
            LoadPatientData();
        }

        internal void LoadPatientData()
        {
            string query = @"select * from Patients";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, SqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            patientdataGridView.Columns["PatientID"].DataPropertyName = "PatientID";
            patientdataGridView.Columns["PatientName"].DataPropertyName = "PatientName";
            patientdataGridView.Columns["DOB"].DataPropertyName = "DOB";
            patientdataGridView.Columns["Address"].DataPropertyName = "Address";
            patientdataGridView.Columns["Phone"].DataPropertyName = "Phone";
            patientdataGridView.Columns["Email"].DataPropertyName = "Email";

            patientdataGridView.DataSource = dataTable;
        }

        private void addpatientbutton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nametb.Text) || String.IsNullOrWhiteSpace(phonetb.Text) || String.IsNullOrWhiteSpace(DOBpicker.Text) || String.IsNullOrEmpty(emailtb.Text) || String.IsNullOrEmpty(addresstb.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please Fill All Fields!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection.Open();
                    string query = @"INSERT INTO Patients (PatientName,DOB,Address,Phone,Email) VALUES(@name, @dob, @address, @phone, @email)";
                    using (SqlCommand sqlCommand = new SqlCommand(query, SqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@name", nametb.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@dob", DOBpicker.Text);
                        sqlCommand.Parameters.AddWithValue("@address", addresstb.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@phone", phonetb.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@email", emailtb.Text.Trim());

                        int RowsAffected = sqlCommand.ExecuteNonQuery();
                        if (RowsAffected > 0)
                        {
                            System.Windows.Forms.MessageBox.Show("New Patient Was Added Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadPatientData();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    System.Windows.Forms.MessageBox.Show("Database Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { SqlConnection.Close(); }
            }
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nametb.Text) || String.IsNullOrWhiteSpace(phonetb.Text) || String.IsNullOrWhiteSpace(DOBpicker.Text) || String.IsNullOrEmpty(emailtb.Text) || String.IsNullOrEmpty(addresstb.Text) || String.IsNullOrEmpty(IDtb.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please Enter Valid Patient Details!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                SqlConnection.Open();
                string query = @"UPDATE Patients SET PatientName = @name, DOB = @dob, Address = @address, Phone = @phone, Email = @email WHERE PatientID = @patientID";
                using (SqlCommand sqlCommand = new SqlCommand(query, SqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@name", nametb.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@dob", DOBpicker.Text);
                    sqlCommand.Parameters.AddWithValue("@address", addresstb.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@phone", phonetb.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@email", emailtb.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@patientID", IDtb.Text.Trim());

                    int RowsAffected = sqlCommand.ExecuteNonQuery();
                    if (RowsAffected > 0)
                    {
                        System.Windows.Forms.MessageBox.Show("Patient Data Updated Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPatientData();
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("No Patient Found With The Given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Database Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { SqlConnection.Close(); }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nametb.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please Write Name Of Patient Which You Want To Delete!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (System.Windows.Forms.MessageBox.Show("Are You Sure To Delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    SqlConnection.Open();
                    string query = "DELETE FROM Patients WHERE PatientName = (@name)";
                    SqlCommand sqlcommand = new SqlCommand(query, SqlConnection);
                    sqlcommand.Parameters.AddWithValue("@name", nametb.Text.Trim());
                    int rowsAffected = sqlcommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        System.Windows.Forms.MessageBox.Show("Patient Deleted Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPatientData();
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Patient Not Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    System.Windows.Forms.MessageBox.Show("Database Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    SqlConnection.Close();
                }
            }
        }
    }
}
