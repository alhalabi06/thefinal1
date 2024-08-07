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
    public partial class frmTestGroup : Form
    {
        public int TestID;
        public int GroupID;
        public frmTestGroup()
        {
            InitializeComponent();
        }

        private void dgTestGroup_Load(object sender, EventArgs e)
        {
            TestGroup bo = new TestGroup(0, new Tests(0, "", 0, 0, 0), "");
            dgTestGroups.DataSource = bo.Select();


            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void dgTestGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TestID = (int)dgTestGroups.Rows[e.RowIndex].Cells[0].Value;
            GroupID = (int)dgTestGroups.Rows[e.RowIndex].Cells[1].Value;
            txtGroupName.Text = dgTestGroups.Rows[e.RowIndex].Cells[2].Value.ToString();

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            TestGroup bo = new TestGroup(0, new Tests(0, "", 0, 0, 0), txtGroupName.Text);
            dgTestGroups.DataSource = bo.Add();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            TestGroup bo = new TestGroup(GroupID, new Tests(TestID, "", 0, 0, 0), txtGroupName.Text);
            dgTestGroups.DataSource = bo.Update();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            TestGroup bo = new TestGroup(GroupID, new Tests(TestID, "", 0, 0, 0), "");
            dgTestGroups.DataSource = bo.Delete();
        }

        private void dgTestGroups_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
