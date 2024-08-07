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
    public partial class frmTestType : Form
    {

        int TestTypeID;
        public frmTestType()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsTestType bo = new clsTestType(0, TextBoxTestType.Text);
            gridTestType.DataSource = bo.Add();
        }
        private void TextBoxTestType_TextChanged(object sender, EventArgs e)
        {

        }


        private void gridTestType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TestTypeID = (int)gridTestType.Rows[e.RowIndex].Cells[0].Value;
            TextBoxTestType.Text = gridTestType.Rows[e.RowIndex].Cells[1].Value.ToString();

            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void frmTestType_Load_1(object sender, EventArgs e)
        {
            clsTestType bo = new clsTestType(0, "");
            gridTestType.DataSource = bo.Select();

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            clsTestType bo = new clsTestType(TestTypeID, TextBoxTestType.Text);
            gridTestType.DataSource = bo.Update();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            clsTestType bo = new clsTestType(TestTypeID, "");
            gridTestType.DataSource = bo.Delete();
        }

        private void btnSelect_Click_1(object sender, EventArgs e)
        {

        }
    }
}
