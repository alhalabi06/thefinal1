namespace final1
{
    partial class frmRegister
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
            label1 = new Label();
            lblLogin = new Label();
            txtLogin = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            txtConfirmPass = new TextBox();
            label2 = new Label();
            label3 = new Label();
            bttnClear = new Button();
            lbllLogin = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 10.0173912F);
            label1.Location = new Point(409, 486);
            label1.Name = "label1";
            label1.Size = new Size(91, 22);
            label1.TabIndex = 17;
            label1.Text = "Go Back To ";
            label1.Click += label1_Click;
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.None;
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Sylfaen", 11.8956518F);
            lblLogin.ForeColor = Color.ForestGreen;
            lblLogin.Location = new Point(302, 210);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(58, 25);
            lblLogin.TabIndex = 12;
            lblLogin.Text = "Login";
            // 
            // txtLogin
            // 
            txtLogin.Anchor = AnchorStyles.None;
            txtLogin.Font = new Font("Sylfaen", 11.8956518F);
            txtLogin.Location = new Point(486, 204);
            txtLogin.Margin = new Padding(3, 4, 3, 4);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(194, 33);
            txtLogin.TabIndex = 13;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.None;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Sylfaen", 11.8956518F);
            lblPassword.ForeColor = Color.ForestGreen;
            lblPassword.Location = new Point(302, 259);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 14;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Font = new Font("Sylfaen", 11.8956518F);
            txtPassword.Location = new Point(486, 256);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(194, 33);
            txtPassword.TabIndex = 15;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Sylfaen", 10.0173912F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(551, 343);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(131, 26);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Sylfaen", 11.8956518F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(306, 442);
            button1.Name = "button1";
            button1.Size = new Size(185, 41);
            button1.TabIndex = 19;
            button1.Text = "Submit\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Anchor = AnchorStyles.None;
            txtConfirmPass.Font = new Font("Sylfaen", 11.8956518F);
            txtConfirmPass.Location = new Point(486, 308);
            txtConfirmPass.Margin = new Padding(3, 4, 3, 4);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(194, 33);
            txtConfirmPass.TabIndex = 21;
            txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 11.8956518F);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(302, 311);
            label2.Name = "label2";
            label2.Size = new Size(160, 25);
            label2.TabIndex = 20;
            label2.Text = "Confirm Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 18.1565228F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(409, 115);
            label3.Name = "label3";
            label3.Size = new Size(207, 39);
            label3.TabIndex = 22;
            label3.Text = "Create Account";
            // 
            // bttnClear
            // 
            bttnClear.Font = new Font("Sylfaen", 11.8956518F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttnClear.Location = new Point(497, 442);
            bttnClear.Name = "bttnClear";
            bttnClear.Size = new Size(185, 41);
            bttnClear.TabIndex = 23;
            bttnClear.Text = "Clear";
            bttnClear.UseVisualStyleBackColor = true;
            bttnClear.Click += bttnClear_Click;
            // 
            // lbllLogin
            // 
            lbllLogin.AutoSize = true;
            lbllLogin.Font = new Font("Sylfaen", 10.0173912F);
            lbllLogin.ForeColor = Color.ForestGreen;
            lbllLogin.Location = new Point(497, 486);
            lbllLogin.Name = "lbllLogin";
            lbllLogin.Size = new Size(54, 22);
            lbllLogin.TabIndex = 24;
            lbllLogin.Text = "Login?";
            lbllLogin.Click += label4_Click;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 656);
            Controls.Add(lbllLogin);
            Controls.Add(bttnClear);
            Controls.Add(label3);
            Controls.Add(txtConfirmPass);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtLogin);
            Controls.Add(lblLogin);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRegister";
            Load += frmRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblLogin;
        private TextBox txtLogin;
        private Label lblPassword;
        private TextBox txtPassword;
        private CheckBox checkBox1;
        private Button button1;
        private TextBox txtConfirmPass;
        private Label label2;
        private Label label3;
        private Button bttnClear;
        private Label lbllLogin;
    }
}