using final1.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace final1
{
    public partial class frmEmloyee : Form
    {
        public int RelativesID;
        public int BloodID;
        public int EmployeeID;

        public frmEmloyee()
        {
            InitializeComponent();
        }

        private void frmEmloyee_Load(object sender, EventArgs e)
        {
            Employee bo = new Employee(0, "", "", "", new Genders(0, ""), DateTime.Now, new City(0, 0, ""), new EmergencyContact(RelativesID, "", 0, ""), new BloodType(0, ""));
            DataTable employeeTable = bo.Select();
            employeeTable.Columns.Add("Address", typeof(string), "CityName + ', ' + StateName + ', ' + CountryName");
            dgEmplyee.DataSource = employeeTable;
            HideColumns();
            LoadComboBoxes();
            ResetForm();
        }

        private void HideColumns()
        {
            if (dgEmplyee.Columns["EmployeeID"] != null)
            {
                dgEmplyee.Columns["EmployeeID"].Visible = false;
            }
            if (dgEmplyee.Columns["RelativesID"] != null)
            {
                dgEmplyee.Columns["RelativesID"].Visible = false;
            }
            if (dgEmplyee.Columns["RelativesName"] != null)
            {
                dgEmplyee.Columns["RelativesName"].Visible = false;
            }
            if (dgEmplyee.Columns["CityName"] != null)
            {
                dgEmplyee.Columns["CityName"].Visible = false;
            }
            if (dgEmplyee.Columns["StateName"] != null)
            {
                dgEmplyee.Columns["StateName"].Visible = false;
            }
            if (dgEmplyee.Columns["CountryName"] != null)
            {
                dgEmplyee.Columns["CountryName"].Visible = false;
            }

        }

        private void LoadComboBoxes()
        {
            cmbCountry.DisplayMember = "CountryName";
            cmbCountry.ValueMember = "CountryID";
            cmbCountry.DataSource = new clsCountry(0, "").Select();

            cmbBloodType.DisplayMember = "BloodType";
            cmbBloodType.ValueMember = "BloodID";
            cmbBloodType.DataSource = new BloodType(0, "").Select();

            cmbGender.DisplayMember = "Gender";
            cmbGender.ValueMember = "GenderID";
            cmbGender.DataSource = new Genders(0, "").Select();
        }

        public bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
                cmbGender.SelectedIndex == -1 ||
                cmbCity.SelectedIndex == -1 ||
                cmbState.SelectedIndex == -1 ||
                cmbCountry.SelectedIndex == -1 ||
                cmbBloodType.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all required fields.");
                return false;
            }
            return true;
        }

        private void RefreshEmployeeGrid()
        {
            Employee bo = new Employee(0, "", "", "", new Genders(0, ""), DateTime.Now, new City(0, 0, ""), new EmergencyContact(RelativesID, "", 0, ""), new BloodType(0, ""));
            DataTable employeeTable = bo.Select();
            employeeTable.Columns.Add("Address", typeof(string), "CityName + ', ' + StateName + ', ' + CountryName");
            dgEmplyee.DataSource = employeeTable;
            HideColumns();
            ResetForm();
        }

        private void ResetForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhoneNumber.Clear();
            cmbGender.SelectedIndex = -1;
            cmbCity.SelectedIndex = -1;
            cmbState.SelectedIndex = -1;
            cmbCountry.SelectedIndex = -1;
            cmbBloodType.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Now;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void dgEmplyee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgEmplyee.Rows[e.RowIndex];
                EmployeeID = int.Parse(row.Cells["EmployeeID"].Value.ToString());
                txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                txtLastName.Text = row.Cells["LastName"].Value.ToString();
                txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value.ToString();
                cmbGender.Text = row.Cells["Gender"].Value.ToString();
                dtpDOB.Value = DateTime.TryParse(row.Cells["DateOfBirth"].Value.ToString(), out DateTime dob) ? dob : DateTime.Now;
                cmbCountry.Text = row.Cells["CountryName"].Value.ToString();
                cmbState.Text = row.Cells["StateName"].Value.ToString();
                cmbCity.Text = row.Cells["CityName"].Value.ToString();
                cmbBloodType.Text = row.Cells["BloodType"].Value.ToString();
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            Employee bo = new Employee(EmployeeID, "", "", "", new Genders(0, ""), DateTime.Now, new City(0, 0, ""), new EmergencyContact(RelativesID, "", 0, ""), new BloodType(0, ""));
            bo.Delete();
            RefreshEmployeeGrid();
        }


        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Employee bo = new Employee(0, txtFirstName.Text, txtLastName.Text, txtPhoneNumber.Text, new Genders(int.Parse(cmbGender.SelectedValue.ToString()), ""), dtpDOB.Value, new City(int.Parse(cmbCity.SelectedValue.ToString()), int.Parse(cmbState.SelectedValue.ToString()), ""), new EmergencyContact(RelativesID, "", 0, ""), new BloodType(int.Parse(cmbBloodType.SelectedValue.ToString()), ""));
                bo.Add();
                RefreshEmployeeGrid();
            }
        }

        private void cmbCountry_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbCountry.SelectedIndex > -1)
            {
                cmbState.DisplayMember = "StateName";
                cmbState.ValueMember = "StateID";
                cmbState.DataSource = new clsState(0, int.Parse(cmbCountry.SelectedValue.ToString()), "").SelectID();
                cmbState.SelectedIndex = -1;
            }
        }

        private void cmbState_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbState.SelectedIndex > -1)
            {
                cmbCity.DisplayMember = "CityName";
                cmbCity.ValueMember = "CityID";
                cmbCity.DataSource = new City(0, int.Parse(cmbState.SelectedValue.ToString()), "").SelectID();
                cmbCity.SelectedIndex = -1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Employee bo = new Employee(EmployeeID, txtFirstName.Text, txtLastName.Text, txtPhoneNumber.Text,
                                           new Genders(int.Parse(s: cmbGender.SelectedValue.ToString()), ""),
                                           dtpDOB.Value,
                                           new City(int.Parse(cmbCity.SelectedValue.ToString()),
                                                    int.Parse(cmbState.SelectedValue.ToString()), ""),
                                           new EmergencyContact(RelativesID, "", 0, ""),
                                           new BloodType(int.Parse(cmbBloodType.SelectedValue.ToString()), ""));
                bo.Update();
                RefreshEmployeeGrid();
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}