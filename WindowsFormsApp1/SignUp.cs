using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class SignUp : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=lenovo;Initial Catalog=ElectronicInsurance;User ID=sa;Password=sidaahmed23;Encrypt=False");
        public SignUp()
        {
            InitializeComponent();
            LoadUserRoles();
        }

        private void signup_loginhere_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        private void signup_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'electronicInsuranceDataSet.UserRoles' table. You can move, or remove it, as needed.
            this.userRolesTableAdapter.Fill(this.electronicInsuranceDataSet.UserRoles);
        }

        private void LoadUserRoles()
        {
            try
            {
                string query = "select RoleId, RoleName from UserRoles";
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection))
                {
                    DataTable dt = new DataTable();
                    sqlDataAdapter.Fill(dt);

                    signup_selectrole.DisplayMember = "RoleName";
                    signup_selectrole.ValueMember = "RoleId";
                    signup_selectrole.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading User Roles: " + ex.Message);
            }
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(signup_fullname.Text) || string.IsNullOrWhiteSpace(signup_username.Text) || string.IsNullOrWhiteSpace(signup_email.Text) || string.IsNullOrWhiteSpace(signup_phone.Text) || string.IsNullOrWhiteSpace(signup_password.Text))
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(signup_email.Text))
            {
                MessageBox.Show("Please enter a valid email address", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidPhoneNumber(signup_phone.Text))
            {
                MessageBox.Show("Please enter a valid phone number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (signup_password.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (signup_selectrole.SelectedValue == null)
            {
                MessageBox.Show("Please select a role", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                sqlConnection.Open();

                string checkUsername = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                using (SqlCommand checkUserCommand = new SqlCommand(checkUsername, sqlConnection))
                {
                    checkUserCommand.Parameters.AddWithValue("@Username", signup_username.Text.Trim());
                    int userCount = (int)checkUserCommand.ExecuteScalar();

                    if (userCount > 0)
                    {
                        MessageBox.Show($"{signup_username.Text} already exists!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string insertQuery = @"INSERT INTO Users (FullName, Username, Email, Phone, Password, RoleId, Rolename) VALUES (@FullName, @Username, @Email, @Phone, @Password, @RoleId, @Rolename)";

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection))
                {
                    insertCommand.Parameters.AddWithValue("@FullName", signup_fullname.Text.Trim());
                    insertCommand.Parameters.AddWithValue("@Username", signup_username.Text.Trim());
                    insertCommand.Parameters.AddWithValue("@Email", signup_email.Text.Trim());
                    insertCommand.Parameters.AddWithValue("@Phone", signup_phone.Text.Trim());
                    insertCommand.Parameters.AddWithValue("@Password", HashPassword(signup_password.Text.Trim()));
                    insertCommand.Parameters.AddWithValue("@RoleId", Convert.ToInt32(signup_selectrole.SelectedValue));
                    insertCommand.Parameters.AddWithValue("@Rolename", signup_selectrole.Text);

                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registered Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private bool IsValidPhoneNumber(string phone)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\+?[\d-]{10,15}$");
        }
        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, BCrypt.Net.BCrypt.GenerateSalt());
        }

        private void signup_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (signup_showpassword.Checked)
            {
                signup_password.PasswordChar = '\0';
            }
            else
            {
                signup_password.PasswordChar = '*';
            }
        }
    }
}
