namespace final1
{
    partial class frmInsurence
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
            this.gridInsurences = new System.Windows.Forms.DataGridView();
            this.TextBoxInsurences = new System.Windows.Forms.TextBox();
            this.txtInsurences = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridInsurences)).BeginInit();
            this.SuspendLayout();
            // 
            // gridInsurences
            // 
            this.gridInsurences.AllowUserToAddRows = false;
            this.gridInsurences.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridInsurences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInsurences.Location = new System.Drawing.Point(411, 60);
            this.gridInsurences.Name = "gridInsurences";
            this.gridInsurences.RowHeadersVisible = false;
            this.gridInsurences.RowHeadersWidth = 51;
            this.gridInsurences.RowTemplate.Height = 24;
            this.gridInsurences.Size = new System.Drawing.Size(370, 256);
            this.gridInsurences.TabIndex = 56;
            this.gridInsurences.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridInsurences_CellContentClick);
            // 
            // TextBoxInsurences
            // 
            this.TextBoxInsurences.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxInsurences.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInsurences.Location = new System.Drawing.Point(146, 123);
            this.TextBoxInsurences.Name = "TextBoxInsurences";
            this.TextBoxInsurences.Size = new System.Drawing.Size(195, 26);
            this.TextBoxInsurences.TabIndex = 51;
            this.TextBoxInsurences.TextChanged += new System.EventHandler(this.TextBoxInsurences_TextChanged);
            // 
            // txtInsurences
            // 
            this.txtInsurences.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInsurences.AutoSize = true;
            this.txtInsurences.BackColor = System.Drawing.Color.Transparent;
            this.txtInsurences.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsurences.Location = new System.Drawing.Point(26, 121);
            this.txtInsurences.Name = "txtInsurences";
            this.txtInsurences.Size = new System.Drawing.Size(101, 20);
            this.txtInsurences.TabIndex = 57;
            this.txtInsurences.Text = "Insurences";
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelect.BackColor = System.Drawing.Color.Chocolate;
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelect.Location = new System.Drawing.Point(622, 348);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(159, 43);
            this.btnSelect.TabIndex = 55;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.Brown;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(426, 348);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(159, 43);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.CadetBlue;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(221, 348);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(159, 43);
            this.btnUpdate.TabIndex = 53;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(21, 348);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 43);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmInsurences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridInsurences);
            this.Controls.Add(this.TextBoxInsurences);
            this.Controls.Add(this.txtInsurences);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmInsurences";
            this.Text = "Insurences";
            this.Load += new System.EventHandler(this.frmInsurences_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridInsurences)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridInsurences;
        private System.Windows.Forms.TextBox TextBoxInsurences;
        private System.Windows.Forms.Label txtInsurences;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
    }
}