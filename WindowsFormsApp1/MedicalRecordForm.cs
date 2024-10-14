using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MedicalRecordForm : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=lenovo;Initial Catalog=ElectronicInsurance;User ID=sa;Password=sidaahmed23;Encrypt=False");
        public MedicalRecordForm()
        {
            InitializeComponent();
            BindRecordData();
            LoadPatientName();
        }

        internal void BindRecordData()
        {
            string query = @"select RecordID, PatientName, Diagnosis, Prescription, DoctorNotes, VisitDate from MedicalRecords";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            medicalrecordDataGrid.Columns["RecordID"].DataPropertyName = "RecordID";
            medicalrecordDataGrid.Columns["PatientName"].DataPropertyName = "PatientName";
            medicalrecordDataGrid.Columns["Diagnosis"].DataPropertyName = "Diagnosis";
            medicalrecordDataGrid.Columns["Prescription"].DataPropertyName = "Prescription";
            medicalrecordDataGrid.Columns["DoctorNotes"].DataPropertyName = "DoctorNotes";
            medicalrecordDataGrid.Columns["VisitDate"].DataPropertyName = "VisitDate";

            medicalrecordDataGrid.DataSource = dataTable;
        }

        internal void LoadPatientName()
        {
            try
            {
                string query = @"SELECT PatientID, PatientName FROM Patients";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable table = new DataTable();
                sqlDataAdapter.Fill(table);

                patientcomboBox.DisplayMember = "PatientName";
                patientcomboBox.ValueMember = "PatientID";
                patientcomboBox.DataSource = table;
            }
            catch (SqlException ex) { MessageBox.Show("DataBase Error " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
;
        }
        private void AddRecordButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Diagnosistb.Text) || String.IsNullOrWhiteSpace(Prescriptiontb.Text) || String.IsNullOrWhiteSpace(Notestb.Text) || String.IsNullOrEmpty(recordDatePicker.Text) || String.IsNullOrEmpty(patientcomboBox.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please Fill All Fields!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    sqlConnection.Open();
                    string query = @"INSERT INTO MedicalRecords (PatientID, PatientName, Diagnosis, Prescription, DoctorNotes, VisitDate) VALUES(@ID, @name, @diagnosis, @prescription, @notes, @date)";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@name", patientcomboBox.Text);
                        sqlCommand.Parameters.AddWithValue("@diagnosis", Diagnosistb.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@prescription", Prescriptiontb.Text);
                        sqlCommand.Parameters.AddWithValue("@notes", Notestb.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@date", recordDatePicker.Text);
                        sqlCommand.Parameters.AddWithValue("@ID", patientcomboBox.SelectedValue);


                        int RowsAffected = sqlCommand.ExecuteNonQuery();
                        if (RowsAffected > 0)
                        {
                            System.Windows.Forms.MessageBox.Show("New Medical Record Was Added Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BindRecordData();
                        }
                    }
                }
                catch (SqlException ex) { System.Windows.Forms.MessageBox.Show("Database Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                finally { sqlConnection.Close(); }
            }
        }

        private void DeleteRecordButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(IDtb.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please Write ID Of Record Which You Want To Delete!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (System.Windows.Forms.MessageBox.Show("Are You Sure To Delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    sqlConnection.Open();
                    string query = @"DELETE FROM MedicalRecords WHERE RecordID = (@ID)";
                    SqlCommand sqlcommand = new SqlCommand(query, sqlConnection);
                    sqlcommand.Parameters.AddWithValue("@ID", IDtb.Text);
                    int rowsAffected = sqlcommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        System.Windows.Forms.MessageBox.Show("Medical Record Deleted Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindRecordData();
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Record Not Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex) { System.Windows.Forms.MessageBox.Show("Database Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                finally { sqlConnection.Close(); }
            }
        }

        private void UpdataRecordButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Diagnosistb.Text) || String.IsNullOrWhiteSpace(Prescriptiontb.Text) || String.IsNullOrWhiteSpace(Notestb.Text) || String.IsNullOrEmpty(recordDatePicker.Text) || String.IsNullOrEmpty(patientcomboBox.Text) || String.IsNullOrEmpty(IDtb.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please Fill All Fields!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    sqlConnection.Open();
                    string query = @"UPDATE MedicalRecords SET PatientID = @patientID,  PatientName = @name, Diagnosis = @diagnosis, Prescription = @prescription, DoctorNotes = @notes, VisitDate = @date WHERE RecordID = @ID";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@name", patientcomboBox.Text);
                        sqlCommand.Parameters.AddWithValue("@diagnosis", Diagnosistb.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@prescription", Prescriptiontb.Text);
                        sqlCommand.Parameters.AddWithValue("@notes", Notestb.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@date", recordDatePicker.Text);
                        sqlCommand.Parameters.AddWithValue("@patientID", patientcomboBox.SelectedValue);
                        sqlCommand.Parameters.AddWithValue("@ID", IDtb.Text);

                        int RowsAffected = sqlCommand.ExecuteNonQuery();
                        if (RowsAffected > 0)
                        {
                            System.Windows.Forms.MessageBox.Show("Medical Record Updated Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BindRecordData();
                        }
                    }
                }
                catch (SqlException ex) { System.Windows.Forms.MessageBox.Show("Database Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                finally { sqlConnection.Close(); }
            }
        }
    }
}
