namespace BiteSizedDietPlan
{
    partial class RegisterForm
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
            txtEmail = new TextBox();
            lblEmail = new Label();
            btnRegister = new Button();
            lblPassword = new Label();
            txtPassword = new TextBox();
            chkShowPassword = new CheckBox();
            btnExit = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(212, 111);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(170, 26);
            txtEmail.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(212, 86);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 18);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email:";
            // 
            // btnRegister
            // 
            btnRegister.BackgroundImage = Properties.Resources.ee;
            btnRegister.FlatStyle = FlatStyle.Popup;
            btnRegister.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(212, 226);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(170, 27);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "ŞİMDİ KAYIT OL!";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(212, 155);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(51, 18);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Parola:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(212, 180);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(170, 26);
            txtPassword.TabIndex = 2;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.BackColor = Color.Transparent;
            chkShowPassword.Location = new Point(388, 186);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(60, 19);
            chkShowPassword.TabIndex = 3;
            chkShowPassword.Text = "Göster";
            chkShowPassword.UseVisualStyleBackColor = false;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.BackgroundImage = Properties.Resources.kırmızı;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(406, 371);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(40, 23);
            btnExit.TabIndex = 6;
            btnExit.Text = "Çıkış";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackgroundImage = Properties.Resources.ee;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(255, 271);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 27);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "İPTAL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ccc;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(458, 406);
            Controls.Add(btnCancel);
            Controls.Add(btnExit);
            Controls.Add(chkShowPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnRegister);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Label lblEmail;
        private Button btnRegister;
        private Label lblPassword;
        private TextBox txtPassword;
        private CheckBox chkShowPassword;
        private Button btnExit;
        private Button btnCancel;
    }
}