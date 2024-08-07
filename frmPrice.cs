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
    public partial class frmPrice : Form
    {

        int PriceID;
        int CurrencyID;
        int InsurenceID;
        int TestID;
        public frmPrice()
        {
            InitializeComponent();
        }

        private void TextBoxPrices_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }

        private void frmPrice_Load(object sender, EventArgs e)
        {
            clsPrice bo = new clsPrice(0,0,0,0,0);
            gridPrice.DataSource = bo.Select();

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void gridPrices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PriceID = (int)gridPrice.Rows[e.RowIndex].Cells[0].Value;
            TextBoxPrice.Text = gridPrice.Rows[e.RowIndex].Cells[1].Value.ToString();
            CurrencyID = (int)gridPrice.Rows[e.RowIndex].Cells[2].Value;
            InsurenceID = (int)gridPrice.Rows[e.RowIndex].Cells[3].Value;
            TestID = (int)gridPrice.Rows[e.RowIndex].Cells[4].Value;

            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            
            clsPrice bo = new clsPrice(0,int.Parse(TextBoxPrice.Text),0,0,0);
            gridPrice.DataSource = bo.Add();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        { 
            clsPrice bo = new clsPrice(PriceID, int.Parse(TextBoxPrice.Text),0,0,0);
            gridPrice.DataSource = bo.Update();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            clsPrice bo = new clsPrice(PriceID,0,0,0,0);
            gridPrice.DataSource = bo.Delete();
        }

        private void btnSelect_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxCurrency_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
