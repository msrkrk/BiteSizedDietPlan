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
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(242, 117);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(170, 26);
            txtEmail.TabIndex = 0;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(242, 92);
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
            btnRegister.Location = new Point(242, 234);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(170, 27);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "ŞİMDİ KAYIT OL!";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(242, 163);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(51, 18);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Parola:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(242, 188);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(170, 26);
            txtPassword.TabIndex = 3;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ccc;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(458, 406);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnRegister);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Label lblEmail;
        private Button btnRegister;
        private Label lblPassword;
        private TextBox txtPassword;
    }
}