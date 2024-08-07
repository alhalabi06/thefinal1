using System;
using final1.Classes;
using System.Windows.Forms;
using System.Data;
using System.Linq;

namespace final1
{
    public partial class Receipt : Form
    {
        public int RelativesID;
        public int ReceiptID;

        public Receipt()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                clsReceipt bo = new clsReceipt(0, new Patient(0, "", "", "", new Genders(0, ""), DateTime.Now, new City(0, 0, ""), new EmergencyContact(RelativesID, "", 0, ""), new BloodType(0, "")), txtReceipt.Text, new Currency(0, ""), DateTime.Now, int.Parse(txtAmount.Text), new DataTable(), 0);
                bo.Add();
                RefreshReceiptGrid();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                clsReceipt bo = new clsReceipt(ReceiptID, new Patient(0, "", "", "", new Genders(0, ""), DateTime.Now, new City(0, 0, ""), new EmergencyContact(RelativesID, "", 0, ""), new BloodType(0, "")), txtReceipt.Text, new Currency(0, ""), DateTime.Now, int.Parse(txtAmount.Text), new DataTable(), 0);
                bo.Update();
                RefreshReceiptGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clsReceipt bo = new clsReceipt(ReceiptID, new Patient(0, "", "", "", new Genders(0, ""), DateTime.Now, new City(0, 0, ""), new EmergencyContact(RelativesID, "", 0, ""), new BloodType(0, "")), "", new Currency(0, ""), DateTime.Now, 0, new DataTable(), 0);
            bo.Delete();
            RefreshReceiptGrid();
        }

        private void dgReceipt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgReceipt.Rows[e.RowIndex];
                ReceiptID = row.Cells["ReceiptID"].Value != null ? int.Parse(row.Cells["ReceiptID"].Value.ToString()) : 0;
                txtReceipt.Text = row.Cells["Receipt"].Value?.ToString() ?? "";
                txtAmount.Text = row.Cells["Amount"].Value?.ToString() ?? "";

                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            RefreshReceiptGrid();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtReceipt.Text) || string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return false;
            }

            if (!int.TryParse(txtAmount.Text, out _))
            {
                MessageBox.Show("Amount must be a valid number.");
                return false;
            }

            return true;
        }
        public void RefreshReceiptGrid()
        {
            clsReceipt bo = new clsReceipt(0, new Patient(0, "", "", "", new Genders(0, ""), DateTime.Now, new City(0, 0, ""), new EmergencyContact(RelativesID, "", 0, ""), new BloodType(0, "")), "", new Currency(0, ""), DateTime.Now, 0, new DataTable(), 0);
            DataTable ReceiptTable = bo.Select();
            dgReceipt.DataSource = ReceiptTable;
            HideColumns();
        }

        private void HideColumns()
        {
            if (dgReceipt.Columns["ReceiptID"] != null)
            {
                dgReceipt.Columns["ReceiptID"].Visible = false;
            }
        }
    }
}
