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
    public partial class frmUnits : Form
    {

        int UnitID;
        public frmUnits()
        {
            InitializeComponent();
        }

        private void TextBoxUnits_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            clsUnits bo = new clsUnits(0, TextBoxUnits.Text);
            gridUnits.DataSource = bo.Add();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            clsUnits bo = new clsUnits(UnitID, TextBoxUnits.Text);
            gridUnits.DataSource = bo.Update();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            clsUnits bo = new clsUnits(UnitID, "");
            gridUnits.DataSource = bo.Delete();
        }

        private void gridUnits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UnitID = (int)gridUnits.Rows[e.RowIndex].Cells[0].Value;
            TextBoxUnits.Text = gridUnits.Rows[e.RowIndex].Cells[1].Value.ToString();

            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void frmUnits_Load(object sender, EventArgs e)
        {
            clsUnits bo = new clsUnits(0, "");
            gridUnits.DataSource = bo.Select();

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }
    }
}
