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
    public partial class frmCurrency : Form
    {

        int CurrencyID;
        public frmCurrency()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Currency bo = new Currency(0, TextBoxCurrency.Text);
            gridCurrency.DataSource = bo.Add();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            Currency bo = new Currency(CurrencyID, "");
            gridCurrency.DataSource = bo.Delete();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Currency bo = new Currency(CurrencyID, TextBoxCurrency.Text);
            gridCurrency.DataSource = bo.Update();
        }

        

        private void TextBoxCurrency_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridCurrency_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrencyID = (int)gridCurrency.Rows[e.RowIndex].Cells[0].Value;
            TextBoxCurrency.Text = gridCurrency.Rows[e.RowIndex].Cells[1].Value.ToString();

            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }

        private void frmCurrency_Load(object sender, EventArgs e)
        {
            Currency bo = new Currency(0, "");
            gridCurrency.DataSource = bo.Select();

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
    }
}
