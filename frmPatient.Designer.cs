namespace final1
{
    partial class frmPatient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            cmbState = new ComboBox();
            lblState = new Label();
            cmbCountry = new ComboBox();
            lblCountry = new Label();
            cmbBloodType = new ComboBox();
            lblBloodType = new Label();
            cmbCity = new ComboBox();
            lblCity = new Label();
            dtpDOB = new DateTimePicker();
            cmbGender = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            txtPhoneNumber = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgPatient = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgPatient).BeginInit();
            SuspendLayout();
            // 
            // cmbState
            // 
            cmbState.Anchor = AnchorStyles.Left;
            cmbState.Font = new Font("Microsoft Sans Serif", 11.89565F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbState.FormattingEnabled = true;
            cmbState.Location = new Point(342, 358);
            cmbState.Margin = new Padding(3, 4, 3, 4);
            cmbState.Name = "cmbState";
            cmbState.Size = new Size(292, 32);
            cmbState.TabIndex = 69;
            cmbState.SelectedIndexChanged += cmbState_SelectedIndexChanged_1;
            // 
            // lblState
            // 
            lblState.AccessibleName = "lblState";
            lblState.Anchor = AnchorStyles.Left;
            lblState.AutoSize = true;
            lblState.Font = new Font("Microsoft Sans Serif", 11.89565F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblState.Location = new Point(182, 361);
            lblState.Name = "lblState";
            lblState.Size = new Size(51, 24);
            lblState.TabIndex = 68;
            lblState.Text = "State";
            // 
            // cmbCountry
            // 
            cmbCountry.Anchor = AnchorStyles.Left;
            cmbCountry.Font = new Font("Microsoft Sans Serif", 11.89565F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(342, 318);
            cmbCountry.Margin = new Padding(3, 4, 3, 4);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(292, 32);
            cmbCountry.TabIndex = 67;
            cmbCountry.SelectedIndexChanged += cmbCountry_SelectedIndexChanged_1;
            // 
            // lblCountry
            // 
            lblCountry.AccessibleName = "lblCountry";
            lblCountry.Anchor = AnchorStyles.Left;
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Microsoft Sans Serif", 11.89565F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCountry.Location = new Point(182, 318);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(75, 24);
            lblCountry.TabIndex = 66;
            lblCountry.Text = "Country";
            // 
            // cmbBloodType
            // 
            cmbBloodType.Anchor = AnchorStyles.Left;
            cmbBloodType.Font = new Font("Microsoft Sans Serif", 11.89565F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBloodType.FormattingEnabled = true;
            cmbBloodType.Location = new Point(342, 439);
            cmbBloodType.Margin = new Padding(3, 4, 3, 4);
            cmbBloodType.Name = "cmbBloodType";
            cmbBloodType.Size = new Size(292, 32);
            cmbBloodType.TabIndex = 65;
            cmbBloodType.SelectedIndexChanged += cmbBloodType_SelectedIndexChanged;
            // 
            // lblBloodType
            // 
            lblBloodType.AccessibleName = "lblBloodType";
            lblBloodType.Anchor = AnchorStyles.Left;
            lblBloodType.AutoSize = true;
            lblBloodType.Font = new Font("Microsoft Sans Serif", 11.89565F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBloodType.Location = new Point(187, 447);
            lblBloodType.Name = "lblBloodType";
            lblBloodType.Size = new Size(107, 24);
            lblBloodType.TabIndex = 64;
            lblBloodType.Text = "Blood Type";
            // 
            // cmbCity
            // 
            cmbCity.Anchor = AnchorStyles.Left;
            cmbCity.Font = new Font("Microsoft Sans Serif", 11.89565F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCity.FormattingEnabled = true;
            cmbCity.Items.AddRange(new object[] { "Los Angeles", "San Francisco", "Houston", "Dallas", "Toronto", "Montreal", "London", "Edinburgh" });
            cmbCity.Location = new Point(342, 399);
            cmbCity.Margin = new Padding(3, 4, 3, 4);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(292, 32);
            cmbCity.TabIndex = 63;
            // 
            // lblCity
            // 
            lblCity.AccessibleName = "lblCity";
            lblCity.Anchor = AnchorStyles.Left;
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Microsoft Sans Serif", 11.89565F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCity.Location = new Point(185, 402);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(40, 24);
            lblCity.TabIndex = 62;
            lblCity.Text = "City";
            // 
            // dtpDOB
            // 
            dtpDOB.Anchor = AnchorStyles.Left;
            dtpDOB.Font = new Font("Segoe UI", 11.8956518F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDOB.Location = new Point(342, 277);
            dtpDOB.Margin = new Padding(3, 4, 3, 4);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(292, 33);
            dtpDOB.TabIndex = 61;
            // 
            // cmbGender
            // 
            cmbGender.Anchor = AnchorStyles.Left;
            cmbGender.Font = new Font("Microsoft Sans Serif", 11.89565F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(342, 237);
            cmbGender.Margin = new Padding(3, 4, 3, 4);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(292, 32);
            cmbGender.TabIndex = 60;
            // 
            // label5
            // 
            label5.AccessibleName = "lblDateOfBirth";
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.89565F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(185, 277);
            label5.Name = "label5";
            label5.Size = new Size(109, 24);
            label5.TabIndex = 59;
            label5.Text = "Date of birth";
            // 
            // label4
            // 
            label4.AccessibleName = "lblGender";
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.89565F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(183, 240);
            label4.Name = "label4";
            label4.Size = new Size(74, 24);
            label4.TabIndex = 58;
            label4.Text = "Gender";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.AccessibleName = "txtPhoneNum";
            txtPhoneNumber.Anchor = AnchorStyles.Left;
            txtPhoneNumber.Font = new Font("Microsoft Sans Serif", 11.89565F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(342, 200);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(292, 29);
            txtPhoneNumber.TabIndex = 57;
            // 
            // label3
            // 
            label3.AccessibleName = "lblPhoneNum";
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.89565F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(183, 205);
            label3.Name = "label3";
            label3.Size = new Size(137, 24);
            label3.TabIndex = 56;
            label3.Text = "Phone number";
            // 
            // txtLastName
            // 
            txtLastName.AccessibleName = "txtLastName";
            txtLastName.Anchor = AnchorStyles.Left;
            txtLastName.Font = new Font("Microsoft Sans Serif", 11.89565F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(342, 163);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(292, 29);
            txtLastName.TabIndex = 55;
            // 
            // txtFirstName
            // 
            txtFirstName.AccessibleName = "txtFirstName";
            txtFirstName.Anchor = AnchorStyles.Left;
            txtFirstName.Font = new Font("Microsoft Sans Serif", 11.89565F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(342, 126);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(292, 29);
            txtFirstName.TabIndex = 54;
            // 
            // label2
            // 
            label2.AccessibleName = "lblLastName";
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.89565F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(183, 168);
            label2.Name = "label2";
            label2.Size = new Size(96, 24);
            label2.TabIndex = 53;
            label2.Text = "Last name";
            // 
            // label1
            // 
            label1.AccessibleName = "lblFirstName";
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.89565F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(183, 131);
            label1.Name = "label1";
            label1.Size = new Size(98, 24);
            label1.TabIndex = 52;
            label1.Text = "First name";
            // 
            // dgPatient
            // 
            dgPatient.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dgPatient.BackgroundColor = SystemColors.Control;
            dgPatient.BorderStyle = BorderStyle.None;
            dgPatient.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.765218F);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgPatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.765218F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgPatient.DefaultCellStyle = dataGridViewCellStyle2;
            dgPatient.EnableHeadersVisualStyles = false;
            dgPatient.GridColor = SystemColors.Menu;
            dgPatient.Location = new Point(688, 131);
            dgPatient.Margin = new Padding(3, 4, 3, 4);
            dgPatient.Name = "dgPatient";
            dgPatient.RowHeadersVisible = false;
            dgPatient.RowHeadersWidth = 49;
            dgPatient.Size = new Size(498, 345);
            dgPatient.TabIndex = 48;
            dgPatient.CellContentClick += dgPatient_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom;
            btnAdd.BackColor = Color.FromArgb(0, 192, 0);
            btnAdd.Font = new Font("Microsoft Sans Serif", 11.89565F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(317, 626);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 56);
            btnAdd.TabIndex = 51;
            btnAdd.Text = "add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom;
            btnUpdate.BackColor = Color.Blue;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 11.89565F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(577, 626);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(149, 56);
            btnUpdate.TabIndex = 50;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom;
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Microsoft Sans Serif", 11.89565F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(846, 626);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(139, 56);
            btnDelete.TabIndex = 49;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 815);
            Controls.Add(cmbState);
            Controls.Add(lblState);
            Controls.Add(cmbCountry);
            Controls.Add(lblCountry);
            Controls.Add(cmbBloodType);
            Controls.Add(lblBloodType);
            Controls.Add(cmbCity);
            Controls.Add(lblCity);
            Controls.Add(dtpDOB);
            Controls.Add(cmbGender);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgPatient);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPatient";
            Text = "Patient";
            Load += frmPatient_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgPatient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbState;
        private Label lblState;
        private ComboBox cmbCountry;
        private Label lblCountry;
        private ComboBox cmbBloodType;
        private Label lblBloodType;
        private ComboBox cmbCity;
        private Label lblCity;
        private DateTimePicker dtpDOB;
        private ComboBox cmbGender;
        private Label label5;
        private Label label4;
        private TextBox txtPhoneNumber;
        private Label label3;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label2;
        private Label label1;
        private DataGridView dgPatient;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
    }
}