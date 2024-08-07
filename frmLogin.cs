using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using final1.Classes;

namespace final1
{
    public partial class frmLogin : Form
    {
        public string UserName;
        public int UserID;

        private readonly string connectionString = "Server=localhost;Database=final;Trusted_Connection=True;";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (ValidateCredentials(username, password))
            {

                this.Hide();
                using (var mainForm = new MDIBlood())
                {
                    mainForm.ShowDialog();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username password.");
            }
        }

        private bool ValidateCredentials(string username, string password)
        {
            bool isValid = false;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();


                    string query = "SELECT UserID, UserName FROM tblUsers WHERE UserName = @UserName AND Password = @password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                UserID = reader.GetInt32(0);
                                UserName = reader.GetString(1);
                                isValid = true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return isValid;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private void bttnClear_Click(object sender, EventArgs e)
        {
            txtLogin.Clear();
            txtPassword.Clear();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbllLogin_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }
    }
}