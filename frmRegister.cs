using System;
using System.Windows.Forms;
using final1.Classes;

namespace final1
{
    public partial class frmRegister : Form
    {
        public int UserID;

        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            
        }

        public bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPass.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return false;
            }

            if (txtPassword.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            string username = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();


            clsUsers user = new clsUsers(UserID, username, password,
                                        new Patient(0, "", "", "", new Genders(0, ""), DateTime.Now, new City(0, 0, ""), new EmergencyContact(0, "", 0, ""), new BloodType(0, "")),
                                        new Group(0, ""),
                                        new Employee(0, "", "", "", new Genders(0, ""), DateTime.Now, new City(0, 0, ""), new EmergencyContact(0, "", 0, ""), new BloodType(0, "")));
            if (!user.Ad())
            {
                MessageBox.Show("Failed to register user. Please try again.");
            }
            else
            {
                this.Hide();
                using (var mainForm = new MDIBlood())
                {
                    mainForm.ShowDialog();
                }
                this.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = checkBox1.Checked;
            txtPassword.UseSystemPasswordChar = !isChecked;
            txtConfirmPass.UseSystemPasswordChar = !isChecked;
        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void bttnClear_Click(object sender, EventArgs e)
        {
            txtLogin.Clear();
            txtPassword.Clear();
            txtConfirmPass.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
    }
}