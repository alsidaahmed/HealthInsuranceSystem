using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CategoryForm : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=lenovo;Initial Catalog=ElectronicInsurance;User ID=sa;Password=sidaahmed23;Encrypt=False");
        public CategoryForm()
        {
            InitializeComponent();
            CategoryBindData();
        }

        void CategoryBindData()
        {
            string query = @"SELECT * FROM Category";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            categorydataGridView.Columns["CategoryId"].DataPropertyName = "CategoryId";
            categorydataGridView.Columns["CategoryName"].DataPropertyName = "CategoryName";
            categorydataGridView.Columns["Photo"].DataPropertyName = "Photo";
            categorydataGridView.Columns["Description"].DataPropertyName = "Description";

            categorydataGridView.DataSource = table;
        }
        private void savebutton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(categorynametb.Text) || String.IsNullOrWhiteSpace(phototb.Text) || String.IsNullOrWhiteSpace(descriptiontb.Text))
            {
                MessageBox.Show("Please Fill All Fields!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    sqlConnection.Open();
                    string query = @"INSERT INTO Category (CategoryName,Photo,Description) VALUES(@categoryname, @photo, @description)";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@categoryname", categorynametb.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@photo", phototb.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@description", descriptiontb.Text.Trim());

                        int RowsAffected = sqlCommand.ExecuteNonQuery();
                        if (RowsAffected > 0)
                        {
                            MessageBox.Show("Category Was Added Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CategoryBindData();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { sqlConnection.Close(); }
            }
        }
        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(categorynametb.Text))
            {
                MessageBox.Show("Please Write Name Of Category Which You Want To Delete!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Are You Sure To Delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    sqlConnection.Open();
                    string query = @"DELETE FROM Category WHERE CategoryName = (@categoryname)";
                    SqlCommand sqlcommand = new SqlCommand(query, sqlConnection);
                    sqlcommand.Parameters.AddWithValue("@categoryname", categorynametb.Text.Trim());

                    int rowsAffected = sqlcommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Category deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CategoryBindData();
                    }
                    else
                    {
                        MessageBox.Show("Category not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlConnection.Close();

                }
            }
        }

        private void categorydataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                string resourcename = categorydataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (!String.IsNullOrEmpty(resourcename))
                {
                    try
                    {
                        pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(resourcename);

                        if (pictureBox1.Image == null)
                        {
                            MessageBox.Show("Image Not Found In Resources.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Loading Image: " + ex.Message);
                    }
                }
            }

        }
    }
}