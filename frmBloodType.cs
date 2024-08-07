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
    public partial class frmBloodType : Form
    {

        int BloodTypeID;
        public frmBloodType()
        {
            InitializeComponent();
        }

    


        private void btnDelete_Click(object sender, EventArgs e)
        {
            BloodType bo = new BloodType(BloodTypeID,"");
            gridBloodType.DataSource = bo.Delete();
        }

        private void frmBloodType_Load(object sender, EventArgs e)
        {
            BloodType bo = new BloodType(0, "");
            gridBloodType.DataSource = bo.Select();

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BloodType bo = new BloodType(BloodTypeID, TextBoxBloodType.Text);
            gridBloodType.DataSource = bo.Update();
        }

        private void gridBloodType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BloodTypeID = (int) gridBloodType.Rows[e.RowIndex].Cells[0].Value;
            TextBoxBloodType.Text = gridBloodType.Rows[e.RowIndex].Cells[1].Value.ToString();

            btnAdd.Enabled = true;
            btnUpdate.Enabled = true; 
            btnDelete.Enabled = true;
        }

        private void TextBoxBloodType_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BloodType bo = new BloodType(0, TextBoxBloodType.Text);
            gridBloodType.DataSource = bo.Add();
        }
    }
}
