using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class LogIn : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=lenovo;Initial Catalog=ElectronicInsurance;User ID=sa;Password=sidaahmed23;Encrypt=False");
        public LogIn()
        {
            InitializeComponent();
        }

        private void login_register_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void login_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (login_showpassword.Checked)
            {
                login_passwordtb.PasswordChar = '\0';
            }
            else
            {
                login_passwordtb.PasswordChar = '*';
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(login_usernametb.Text) || string.IsNullOrWhiteSpace(login_passwordtb.Text))
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (sqlConnection.State != ConnectionState.Open)
                {
                    try
                    {
                        sqlConnection.Open();

                        string query = "SELECT Password, Rolename FROM Users WHERE Username = @username";
                        using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                        {
                            sqlCommand.Parameters.AddWithValue("@username", login_usernametb.Text.Trim());

                            using (SqlDataReader reader = sqlCommand.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string storedHash = reader["Password"].ToString();
                                    string rolename = reader["Rolename"].ToString();

                                    if (VerifyPassword(login_passwordtb.Text, storedHash))
                                    {
                                        MessageBox.Show("Login Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        switch (rolename.ToLower())
                                        {
                                            case "admin":
                                                AdminDashboard admin = new AdminDashboard();
                                                admin.Show();
                                                this.Hide();
                                                break;
                                            case "doctor":
                                                DoctorDashboard doctor = new DoctorDashboard();
                                                doctor.Show();
                                                this.Hide();
                                                break;
                                            default:
                                                MessageBox.Show("Unknown role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Incorrect Username or Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect Username or Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
            }
        }
        private bool VerifyPassword(string enteredPassword, string storedHash)
        {
            return BCrypt.Net.BCrypt.Verify(enteredPassword, storedHash);
        }
    }
}
