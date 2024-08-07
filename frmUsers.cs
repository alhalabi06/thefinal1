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
    public partial class frmUsers : Form
    {

        int UsersID;
        public frmUsers()
        {
            InitializeComponent();
        }
        private void gridUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UsersID = (int)gridUser.Rows[e.RowIndex].Cells[0].Value;
            TextBoxUserName.Text = gridUser.Rows[e.RowIndex].Cells[1].Value.ToString();

            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            clsUsers bo = new clsUsers(0, TextBoxUserName.Text, 0, 0, 0);
            gridUser.DataSource = bo.Add();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            clsUsers bo = new clsUsers(0, TextBoxUserName.Text, 0, 0, 0);
            gridUser.DataSource = bo.Update();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            clsUsers bo = new clsUsers(0, TextBoxUserName.Text, 0, 0, 0);
            gridUser.DataSource = bo.Delete();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void frmUsers_Load_1(object sender, EventArgs e)
        {
            clsUsers bo = new clsUsers(0, "", 0, 0, 0);
            gridUser.DataSource = bo.Select();

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxUserName_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
