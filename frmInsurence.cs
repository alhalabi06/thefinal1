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
    public partial class frmInsurence : Form
    {
        int InsurenceID;
        public frmInsurence()
        {
            InitializeComponent();
        }

        private void TextBoxInsurences_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsInsurences bo = new clsInsurences(0, TextBoxInsurences.Text);
            gridInsurences.DataSource = bo.Add();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            clsInsurences bo = new clsInsurences(InsurenceID, TextBoxInsurences.Text);
            gridInsurences.DataSource = bo.Update();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clsInsurences bo = new clsInsurences(InsurenceID, "");
            gridInsurences.DataSource = bo.Delete();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }

        private void gridInsurences_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            InsurenceID = (int)gridInsurences.Rows[e.RowIndex].Cells[0].Value;
            TextBoxInsurences.Text = gridInsurences.Rows[e.RowIndex].Cells[1].Value.ToString();

            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void frmInsurences_Load(object sender, EventArgs e)
        {
            clsInsurences bo = new clsInsurences(0, "");
            gridInsurences.DataSource = bo.Select();

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
    }
}
