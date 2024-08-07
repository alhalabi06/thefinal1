using final1.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace final1
{
    public partial class frmPatient : Form
    {
        public int RelativesID;
        public int PatientID;

        public frmPatient()
        {
            InitializeComponent();
        }

        public void RefreshPatientGrid()
        {
            Patient bo = new Patient(0, "", "", "", new Genders(0, ""), DateTime.Now, new City(0, 0, ""), new EmergencyContact(RelativesID, "", 0, ""), new BloodType(0, ""));
            DataTable patientTable = bo.Select();
            patientTable.Columns.Add("Address", typeof(string), "CityName + ', ' + StateName + ', ' + CountryName");
            dgPatient.DataSource = patientTable;
            HideColumns();
        }

        private void HideColumns()
        {
            if (dgPatient.Columns["PatientID"] != null)
            {
                dgPatient.Columns["PatientID"].Visible = false;
            }
            if (dgPatient.Columns["RelativesID"] != null)
            {
                dgPatient.Columns["RelativesID"].Visible = false;
            }
            if (dgPatient.Columns["RelativesName"] != null)
            {
                dgPatient.Columns["RelativesName"].Visible = false;
            }
            if (dgPatient.Columns["CityName"] != null)
            {
                dgPatient.Columns["CityName"].Visible = false;
            }
            if (dgPatient.Columns["StateName"] != null)
            {
                dgPatient.Columns["StateName"].Visible = false;
            }
            if (dgPatient.Columns["CountryName"] != null)
            {
                dgPatient.Columns["CountryName"].Visible = false;
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

        private bool ValidateInput()
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

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Patient bo = new Patient(0, txtFirstName.Text, txtLastName.Text, txtPhoneNumber.Text,
                                         new Genders(int.Parse(cmbGender.SelectedValue.ToString()), ""),
                                         dtpDOB.Value,
                                         new City(int.Parse(cmbCity.SelectedValue.ToString()), int.Parse(cmbState.SelectedValue.ToString()), ""),
                                         new EmergencyContact(RelativesID, "", 0, ""),
                                         new BloodType(int.Parse(cmbBloodType.SelectedValue.ToString()), ""));
                bo.Add();
                RefreshPatientGrid();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Patient bo = new Patient(PatientID, txtFirstName.Text, txtLastName.Text, txtPhoneNumber.Text,
                                         new Genders(int.Parse(cmbGender.SelectedValue.ToString()), ""),
                                         dtpDOB.Value,
                                         new City(int.Parse(cmbCity.SelectedValue.ToString()), int.Parse(cmbState.SelectedValue.ToString()), ""),
                                         new EmergencyContact(RelativesID, "", 0, ""),
                                         new BloodType(int.Parse(cmbBloodType.SelectedValue.ToString()), ""));
                bo.Update();
                RefreshPatientGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Patient bo = new Patient(PatientID, "", "", "",
                                    new Genders(int.Parse(cmbGender.SelectedValue.ToString()), ""),
                                    DateTime.Now,
                                    new City(0, 0, ""),
                                    new EmergencyContact(RelativesID, "", 0, ""),
                                    new BloodType(int.Parse(cmbBloodType.SelectedValue.ToString()), ""));
            bo.Delete();
            RefreshPatientGrid();
        }

        private void dgPatient_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgPatient.Rows[e.RowIndex];
                PatientID = row.Cells["PatientID"].Value != null ? int.Parse(row.Cells["PatientID"].Value.ToString()) : 0;
                txtFirstName.Text = row.Cells["FirstName"].Value?.ToString() ?? "";
                txtLastName.Text = row.Cells["LastName"].Value?.ToString() ?? "";
                txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value?.ToString() ?? "";
                cmbGender.Text = row.Cells["Gender"].Value?.ToString() ?? "";
                dtpDOB.Value = DateTime.TryParse(row.Cells["DateOfBirth"].Value?.ToString(), out DateTime dob) ? dob : DateTime.Now;
                cmbCountry.Text = row.Cells["CountryName"].Value?.ToString() ?? "";
                cmbState.Text = row.Cells["StateName"].Value?.ToString() ?? "";
                cmbCity.Text = row.Cells["CityName"].Value?.ToString() ?? "";
                cmbBloodType.Text = row.Cells["BloodType"].Value?.ToString() ?? "";

                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;

            }
        }

        private void frmPatient_Load_1(object sender, EventArgs e)
        {
            Patient bo = new Patient(0, "", "", "", new Genders(0, ""), DateTime.Now, new City(0, 0, ""), new EmergencyContact(RelativesID, "", 0, ""), new BloodType(0, ""));
            DataTable patientTable = bo.Select();
            patientTable.Columns.Add("Address", typeof(string), "CityName + ', ' + StateName + ', ' + CountryName");
            dgPatient.DataSource = patientTable;
            HideColumns();
            LoadComboBoxes();
            ResetForm();
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

        private void cmbBloodType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgPatient.Rows[e.RowIndex];
                PatientID = row.Cells["PatientID"].Value != null ? int.Parse(row.Cells["PatientID"].Value.ToString()) : 0;
                txtFirstName.Text = row.Cells["FirstName"].Value?.ToString() ?? "";
                txtLastName.Text = row.Cells["LastName"].Value?.ToString() ?? "";
                txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value?.ToString() ?? "";
                cmbGender.Text = row.Cells["Gender"].Value?.ToString() ?? "";
                dtpDOB.Value = DateTime.TryParse(row.Cells["DateOfBirth"].Value?.ToString(), out DateTime dob) ? dob : DateTime.Now;
                cmbCountry.Text = row.Cells["CountryName"].Value?.ToString() ?? "";
                cmbState.Text = row.Cells["StateName"].Value?.ToString() ?? "";
                cmbCity.Text = row.Cells["CityName"].Value?.ToString() ?? "";
                cmbBloodType.Text = row.Cells["BloodType"].Value?.ToString() ?? "";

                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;

            }
        }
    }
}