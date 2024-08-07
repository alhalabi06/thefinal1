using System;
using final1.Classes;
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
    public partial class MDIBlood : Form
    {
        private int childFormNumber = 0;

        public MDIBlood()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }


        private void Users_Click(object sender, EventArgs e)
        {
/*            frmUsers users = new frmUsers();
            users.MdiParent = this;
            users.Show();*/
        }

        private void btnBloodType_Click(object sender, EventArgs e)
        {
            frmBloodType BloodType = new frmBloodType();
            BloodType.MdiParent = this;
            BloodType.Show();
        }

        private void btnCountry_Click(object sender, EventArgs e)
        {
            frmCountry Country = new frmCountry();
            Country.MdiParent = this;
            Country.Show();
        }

        private void btnCurrency_Click(object sender, EventArgs e)
        {
            frmCurrency Currency = new frmCurrency();
            Currency.MdiParent = this;
            Currency.Show();
        }

        private void btnEmergencyContact_Click(object sender, EventArgs e)
        {
            frmEmergencyContact EmergencyContact = new frmEmergencyContact();
            EmergencyContact.MdiParent = this;
            EmergencyContact.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmloyee Employee = new frmEmloyee();
            Employee.MdiParent = this;
            Employee.Show();
        }

        private void isurrenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInsurence Insurence = new frmInsurence();
            Insurence.MdiParent = this;
            Insurence.Show();
        }

        private void invoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
/*            frmInvoices Invoices = new frmInvoices();
            Invoices.MdiParent = this;
            Invoices.Show();*/
        }

        private void ledgersToolStripMenuItem_Click(object sender, EventArgs e)
        {
/*            frmLedgers Ledgers = new frmLedgers();
            Ledgers.MdiParent = this;
            Ledgers.Show();*/
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPatient Patient = new frmPatient();
            Patient.MdiParent = this;
            Patient.Show();
        }   

        private void pricesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmPrice Prices = new frmPrice();
           Prices.MdiParent = this;
           Prices.Show();
        }

        private void receiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Receipt Ledgers = new Receipt();
            Ledgers.MdiParent = this;
            Ledgers.Show();
        }

        private void testGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestGroup TestGroup = new frmTestGroup();
            TestGroup.MdiParent = this;
            TestGroup.Show();
        }

        private void testsToolStripMenuItem_Click(object sender, EventArgs e)
        {
/*           frmTests Tests = new frmTests();
           Tests.MdiParent = this;
           Tests.Show();*/
        }

        private void testTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestType TestType = new frmTestType();
            TestType.MdiParent = this;
            TestType.Show();
        }

        private void unitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnits Units = new frmUnits();
            Units.MdiParent = this;
            Units.Show();
        }

        private void MDIBlood_Load(object sender, EventArgs e)
        {

        }

        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}