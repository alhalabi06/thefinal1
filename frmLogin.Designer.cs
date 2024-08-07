namespace final1
{
    partial class frmLogin
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
            txtPassword = new TextBox();
            txtLogin = new TextBox();
            label1 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            bttnClear = new Button();
            label3 = new Label();
            lblPassword = new Label();
            lblLogin = new Label();
            lblCreateAccount = new Label();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Font = new Font("Sylfaen", 11.8956518F);
            txtPassword.Location = new Point(491, 276);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(198, 33);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtLogin
            // 
            txtLogin.Anchor = AnchorStyles.None;
            txtLogin.Font = new Font("Sylfaen", 11.8956518F);
            txtLogin.Location = new Point(491, 223);
            txtLogin.Margin = new Padding(3, 4, 3, 4);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(198, 33);
            txtLogin.TabIndex = 5;
            txtLogin.TextChanged += txtLogin_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 10.0173912F);
            label1.Location = new Point(352, 443);
            label1.Name = "label1";
            label1.Size = new Size(168, 22);
            label1.TabIndex = 9;
            label1.Text = "Don't Have an Account?";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Sylfaen", 10.0173912F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(545, 321);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(131, 26);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Sylfaen", 11.8956518F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(294, 384);
            button1.Name = "button1";
            button1.Size = new Size(185, 43);
            button1.TabIndex = 11;
            button1.Text = "Submit\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // bttnClear
            // 
            bttnClear.Font = new Font("Sylfaen", 11.8956518F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttnClear.Location = new Point(491, 386);
            bttnClear.Name = "bttnClear";
            bttnClear.Size = new Size(185, 41);
            bttnClear.TabIndex = 24;
            bttnClear.Text = "Clear";
            bttnClear.UseVisualStyleBackColor = true;
            bttnClear.Click += bttnClear_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 18.1565228F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(433, 118);
            label3.Name = "label3";
            label3.Size = new Size(87, 39);
            label3.TabIndex = 28;
            label3.Text = "Login";
            label3.Click += label3_Click;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.None;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Sylfaen", 11.8956518F);
            lblPassword.ForeColor = Color.ForestGreen;
            lblPassword.Location = new Point(294, 284);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 26;
            lblPassword.Text = "Password";
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.None;
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Sylfaen", 11.8956518F);
            lblLogin.ForeColor = Color.ForestGreen;
            lblLogin.Location = new Point(294, 231);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(58, 25);
            lblLogin.TabIndex = 25;
            lblLogin.Text = "Login";
            lblLogin.Click += lblLogin_Click;
            // 
            // lblCreateAccount
            // 
            lblCreateAccount.AutoSize = true;
            lblCreateAccount.Font = new Font("Sylfaen", 10.0173912F);
            lblCreateAccount.ForeColor = Color.ForestGreen;
            lblCreateAccount.Location = new Point(514, 443);
            lblCreateAccount.Name = "lblCreateAccount";
            lblCreateAccount.Size = new Size(110, 22);
            lblCreateAccount.TabIndex = 29;
            lblCreateAccount.Text = "Create Account";
            lblCreateAccount.Click += lbllLogin_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 656);
            Controls.Add(lblCreateAccount);
            Controls.Add(label3);
            Controls.Add(lblPassword);
            Controls.Add(lblLogin);
            Controls.Add(bttnClear);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private Label label1;
        private CheckBox checkBox1;
        private Button button1;
        private Button bttnClear;
        private Label label3;
        private Label lblPassword;
        private Label lblLogin;
        private Label lblCreateAccount;
    }
}