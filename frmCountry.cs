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
    public partial class frmCountry : Form
    {

        int CountryID;
        public frmCountry()
        {
            InitializeComponent();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            clsCountry bo = new clsCountry(0, TextBoxCountry.Text);
            gridCountry.DataSource = bo.Add();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            clsCountry bo = new clsCountry(CountryID, TextBoxCountry.Text);
            gridCountry.DataSource = bo.Update();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            clsCountry bo = new clsCountry(CountryID, "");
            gridCountry.DataSource = bo.Delete();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }

        private void frmCountry_Load_1(object sender, EventArgs e)
        {
            clsCountry bo = new clsCountry(0, "");
            gridCountry.DataSource = bo.Select();

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void TextBoxCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridCountry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CountryID = (int)gridCountry.Rows[e.RowIndex].Cells[0].Value;
            TextBoxCountry.Text = gridCountry.Rows[e.RowIndex].Cells[1].Value.ToString();

            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }
    }
}
