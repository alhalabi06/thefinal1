namespace final1
{
    partial class frmBloodType
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
            this.TextBoxBloodType = new System.Windows.Forms.TextBox();
            this.txtBloodType = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gridBloodType = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridBloodType)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxBloodType
            // 
            this.TextBoxBloodType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxBloodType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxBloodType.Location = new System.Drawing.Point(144, 96);
            this.TextBoxBloodType.Name = "TextBoxBloodType";
            this.TextBoxBloodType.Size = new System.Drawing.Size(195, 26);
            this.TextBoxBloodType.TabIndex = 1;
            this.TextBoxBloodType.TextChanged += new System.EventHandler(this.TextBoxBloodType_TextChanged);
            // 
            // txtBloodType
            // 
            this.txtBloodType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBloodType.AutoSize = true;
            this.txtBloodType.BackColor = System.Drawing.Color.Transparent;
            this.txtBloodType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBloodType.Location = new System.Drawing.Point(24, 94);
            this.txtBloodType.Name = "txtBloodType";
            this.txtBloodType.Size = new System.Drawing.Size(103, 20);
            this.txtBloodType.TabIndex = 50;
            this.txtBloodType.Text = "Blood Type";
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelect.BackColor = System.Drawing.Color.Chocolate;
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelect.Location = new System.Drawing.Point(620, 321);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(159, 43);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.Brown;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(424, 321);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(159, 43);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.CadetBlue;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(219, 321);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(159, 43);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(19, 321);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 43);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gridBloodType
            // 
            this.gridBloodType.AllowUserToAddRows = false;
            this.gridBloodType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridBloodType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBloodType.Location = new System.Drawing.Point(418, 31);
            this.gridBloodType.Name = "gridBloodType";
            this.gridBloodType.RowHeadersVisible = false;
            this.gridBloodType.RowHeadersWidth = 51;
            this.gridBloodType.RowTemplate.Height = 24;
            this.gridBloodType.Size = new System.Drawing.Size(370, 256);
            this.gridBloodType.TabIndex = 8;
            this.gridBloodType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBloodType_CellContentClick);
            // 
            // frmBloodType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridBloodType);
            this.Controls.Add(this.TextBoxBloodType);
            this.Controls.Add(this.txtBloodType);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmBloodType";
            this.Text = "Blood Type";
            this.Load += new System.EventHandler(this.frmBloodType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBloodType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxBloodType;
        private System.Windows.Forms.Label txtBloodType;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView gridBloodType;
    }
}