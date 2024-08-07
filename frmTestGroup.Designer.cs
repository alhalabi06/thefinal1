namespace final1
{
    partial class frmTestGroup
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
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblGroupName = new Label();
            txtGroupName = new TextBox();
            dgTestGroups = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgTestGroups).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.BackColor = Color.FromArgb(0, 192, 0);
            btnAdd.Font = new Font("Microsoft Sans Serif", 11.89565F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(74, 408);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 56);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.BackColor = Color.Blue;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 11.89565F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(334, 408);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(149, 56);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Microsoft Sans Serif", 11.89565F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(611, 408);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(139, 56);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // lblGroupName
            // 
            lblGroupName.Anchor = AnchorStyles.None;
            lblGroupName.AutoSize = true;
            lblGroupName.Font = new Font("Microsoft Sans Serif", 11.89565F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGroupName.Location = new Point(75, 194);
            lblGroupName.Name = "lblGroupName";
            lblGroupName.Size = new Size(119, 24);
            lblGroupName.TabIndex = 24;
            lblGroupName.Text = "Group Name";
            // 
            // txtGroupName
            // 
            txtGroupName.Anchor = AnchorStyles.None;
            txtGroupName.Font = new Font("Microsoft Sans Serif", 11.89565F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGroupName.Location = new Point(226, 194);
            txtGroupName.Margin = new Padding(3, 4, 3, 4);
            txtGroupName.Name = "txtGroupName";
            txtGroupName.Size = new Size(148, 29);
            txtGroupName.TabIndex = 25;
            // 
            // dgTestGroups
            // 
            dgTestGroups.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dgTestGroups.BackgroundColor = SystemColors.Control;
            dgTestGroups.BorderStyle = BorderStyle.None;
            dgTestGroups.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.765218F);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgTestGroups.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgTestGroups.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.765218F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgTestGroups.DefaultCellStyle = dataGridViewCellStyle2;
            dgTestGroups.EnableHeadersVisualStyles = false;
            dgTestGroups.GridColor = SystemColors.Menu;
            dgTestGroups.Location = new Point(436, 108);
            dgTestGroups.Margin = new Padding(3, 4, 3, 4);
            dgTestGroups.Name = "dgTestGroups";
            dgTestGroups.RowHeadersVisible = false;
            dgTestGroups.RowHeadersWidth = 49;
            dgTestGroups.Size = new Size(314, 205);
            dgTestGroups.TabIndex = 50;
            dgTestGroups.CellContentClick += dgTestGroups_CellContentClick_2;
            // 
            // frmTestGroup
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 534);
            Controls.Add(dgTestGroups);
            Controls.Add(txtGroupName);
            Controls.Add(lblGroupName);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmTestGroup";
            Text = "Test Group ";
            Load += dgTestGroup_Load;
            ((System.ComponentModel.ISupportInitialize)dgTestGroups).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.TextBox txtGroupName;
        private DataGridView dgTestGroups;
    }
}