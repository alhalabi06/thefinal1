using final1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final1
{
    public partial class frmEmergencyContact : Form
    {

        int EmergencyContactID;
        public frmEmergencyContact()
        {
            InitializeComponent();
        }


        private void TextBoxEmergencyContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridEmergencyContact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmergencyContactID = (int)gridEmergencyContact.Rows[e.RowIndex].Cells[0].Value;
            TextBoxEmergencyContact.Text = gridEmergencyContact.Rows[e.RowIndex].Cells[1].Value.ToString();

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            EmergencyContact bo = new EmergencyContact(0, TextBoxEmergencyContact.Text, 0, "");
            gridEmergencyContact.DataSource = bo.Add();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            EmergencyContact bo = new EmergencyContact(0, TextBoxEmergencyContact.Text, 0, "");
            gridEmergencyContact.DataSource = bo.Update();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            EmergencyContact bo = new EmergencyContact(0, TextBoxEmergencyContact.Text, 0, "");
            gridEmergencyContact.DataSource = bo.Delete();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }

        private void frmEmergencyContact_Load_1(object sender, EventArgs e)
        {
            EmergencyContact bo = new EmergencyContact(0, TextBoxEmergencyContact.Text, 0, "");
            gridEmergencyContact.DataSource = bo.Select();

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
    }
}
