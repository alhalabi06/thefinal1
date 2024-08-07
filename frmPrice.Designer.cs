namespace final1
{
    partial class frmPrice
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
            this.gridPrice = new System.Windows.Forms.DataGridView();
            this.TextBoxPrice = new System.Windows.Forms.TextBox();
            this.txtPrices = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBoxCurrency = new System.Windows.Forms.TextBox();
            this.txtCurrency = new System.Windows.Forms.Label();
            this.textBoxTestName = new System.Windows.Forms.TextBox();
            this.txtTestName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxInssurenceName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPrice
            // 
            this.gridPrice.AllowUserToAddRows = false;
            this.gridPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPrice.Location = new System.Drawing.Point(410, 48);
            this.gridPrice.Name = "gridPrice";
            this.gridPrice.RowHeadersVisible = false;
            this.gridPrice.RowHeadersWidth = 51;
            this.gridPrice.RowTemplate.Height = 24;
            this.gridPrice.Size = new System.Drawing.Size(370, 256);
            this.gridPrice.TabIndex = 56;
            this.gridPrice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPrices_CellContentClick);
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPrice.Location = new System.Drawing.Point(193, 134);
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.Size = new System.Drawing.Size(195, 26);
            this.TextBoxPrice.TabIndex = 51;
            this.TextBoxPrice.TextChanged += new System.EventHandler(this.TextBoxPrices_TextChanged);
            // 
            // txtPrices
            // 
            this.txtPrices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrices.AutoSize = true;
            this.txtPrices.BackColor = System.Drawing.Color.Transparent;
            this.txtPrices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrices.Location = new System.Drawing.Point(15, 137);
            this.txtPrices.Name = "txtPrices";
            this.txtPrices.Size = new System.Drawing.Size(63, 20);
            this.txtPrices.TabIndex = 57;
            this.txtPrices.Text = "Prices";
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.BackColor = System.Drawing.Color.Chocolate;
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelect.Location = new System.Drawing.Point(621, 348);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(159, 43);
            this.btnSelect.TabIndex = 55;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Brown;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(425, 348);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(159, 43);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.CadetBlue;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(220, 348);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(159, 43);
            this.btnUpdate.TabIndex = 53;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(20, 348);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 43);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // textBoxCurrency
            // 
            this.textBoxCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCurrency.Location = new System.Drawing.Point(193, 173);
            this.textBoxCurrency.Name = "textBoxCurrency";
            this.textBoxCurrency.Size = new System.Drawing.Size(195, 26);
            this.textBoxCurrency.TabIndex = 58;
            this.textBoxCurrency.TextChanged += new System.EventHandler(this.textBoxCurrency_TextChanged);
            // 
            // txtCurrency
            // 
            this.txtCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrency.AutoSize = true;
            this.txtCurrency.BackColor = System.Drawing.Color.Transparent;
            this.txtCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrency.Location = new System.Drawing.Point(15, 176);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(85, 20);
            this.txtCurrency.TabIndex = 59;
            this.txtCurrency.Text = "Currency";
            // 
            // textBoxTestName
            // 
            this.textBoxTestName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTestName.Location = new System.Drawing.Point(193, 247);
            this.textBoxTestName.Name = "textBoxTestName";
            this.textBoxTestName.Size = new System.Drawing.Size(195, 26);
            this.textBoxTestName.TabIndex = 60;
            this.textBoxTestName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTestName
            // 
            this.txtTestName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTestName.AutoSize = true;
            this.txtTestName.BackColor = System.Drawing.Color.Transparent;
            this.txtTestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTestName.Location = new System.Drawing.Point(15, 250);
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Size = new System.Drawing.Size(100, 20);
            this.txtTestName.TabIndex = 61;
            this.txtTestName.Text = "Test Name";
            this.txtTestName.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(193, 212);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 26);
            this.textBox2.TabIndex = 62;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxInssurenceName
            // 
            this.textBoxInssurenceName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInssurenceName.AutoSize = true;
            this.textBoxInssurenceName.BackColor = System.Drawing.Color.Transparent;
            this.textBoxInssurenceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInssurenceName.Location = new System.Drawing.Point(15, 213);
            this.textBoxInssurenceName.Name = "textBoxInssurenceName";
            this.textBoxInssurenceName.Size = new System.Drawing.Size(155, 20);
            this.textBoxInssurenceName.TabIndex = 63;
            this.textBoxInssurenceName.Text = "Inssurence Name";
            // 
            // frmPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxInssurenceName);
            this.Controls.Add(this.textBoxTestName);
            this.Controls.Add(this.txtTestName);
            this.Controls.Add(this.textBoxCurrency);
            this.Controls.Add(this.txtCurrency);
            this.Controls.Add(this.gridPrice);
            this.Controls.Add(this.TextBoxPrice);
            this.Controls.Add(this.txtPrices);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmPrice";
            this.Text = "Price";
            this.Load += new System.EventHandler(this.frmPrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPrice;
        private System.Windows.Forms.TextBox TextBoxPrice;
        private System.Windows.Forms.Label txtPrices;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBoxCurrency;
        private System.Windows.Forms.Label txtCurrency;
        private System.Windows.Forms.TextBox textBoxTestName;
        private System.Windows.Forms.Label txtTestName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label textBoxInssurenceName;
    }
}