namespace final1
{
    partial class Receipt
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label1 = new Label();
            txtReceipt = new TextBox();
            txtAmount = new TextBox();
            lblAmount = new Label();
            dgReceipt = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgReceipt).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.BackColor = Color.FromArgb(0, 192, 0);
            btnAdd.Font = new Font("Microsoft Sans Serif", 11.89565F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(234, 544);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 56);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "add";
            btnAdd.UseVisualStyleBackColor = false;
//            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.BackColor = Color.Blue;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 11.89565F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(460, 544);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(149, 56);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
 //           btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Microsoft Sans Serif", 11.89565F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(700, 544);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(139, 56);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
 //           btnDelete.Click += btnDelete_Click_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.89565F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(241, 235);
            label1.Name = "label1";
            label1.Size = new Size(79, 24);
            label1.TabIndex = 19;
            label1.Text = "Receipt ";
            // 
            // txtReceipt
            // 
            txtReceipt.Anchor = AnchorStyles.None;
            txtReceipt.Font = new Font("Microsoft Sans Serif", 11.89565F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReceipt.Location = new Point(336, 229);
            txtReceipt.Margin = new Padding(3, 4, 3, 4);
            txtReceipt.Name = "txtReceipt";
            txtReceipt.Size = new Size(194, 29);
            txtReceipt.TabIndex = 20;
            // 
            // txtAmount
            // 
            txtAmount.Anchor = AnchorStyles.None;
            txtAmount.Font = new Font("Microsoft Sans Serif", 11.89565F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(336, 317);
            txtAmount.Margin = new Padding(3, 4, 3, 4);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(194, 29);
            txtAmount.TabIndex = 22;
            // 
            // lblAmount
            // 
            lblAmount.Anchor = AnchorStyles.None;
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Microsoft Sans Serif", 11.89565F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAmount.Location = new Point(241, 324);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(76, 24);
            lblAmount.TabIndex = 21;
            lblAmount.Text = "Amount";
            // 
            // dgReceipt
            // 
            dgReceipt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dgReceipt.BackgroundColor = SystemColors.Control;
            dgReceipt.BorderStyle = BorderStyle.None;
            dgReceipt.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 8.765218F);
            dataGridViewCellStyle5.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgReceipt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgReceipt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 8.765218F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgReceipt.DefaultCellStyle = dataGridViewCellStyle6;
            dgReceipt.EnableHeadersVisualStyles = false;
            dgReceipt.GridColor = SystemColors.Menu;
            dgReceipt.Location = new Point(589, 151);
            dgReceipt.Margin = new Padding(3, 4, 3, 4);
            dgReceipt.Name = "dgReceipt";
            dgReceipt.RowHeadersVisible = false;
            dgReceipt.RowHeadersWidth = 49;
            dgReceipt.Size = new Size(437, 302);
            dgReceipt.TabIndex = 49;
 //           dgReceipt.CellContentClick += dgReceipt_CellContentClick_1;
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 674);
            Controls.Add(dgReceipt);
            Controls.Add(txtAmount);
            Controls.Add(lblAmount);
            Controls.Add(txtReceipt);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Receipt";
            Text = "Receipt";
            Load += Receipt_Load;
            ((System.ComponentModel.ISupportInitialize)dgReceipt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReceipt;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private DataGridView dgReceipt;
    }
}