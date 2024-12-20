﻿namespace BiteSizedDietPlan
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            btnLogin = new Button();
            label1 = new Label();
            lblRegister = new LinkLabel();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            chkShowPassword = new CheckBox();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BackgroundImage = Properties.Resources.VTg_sWn3oukIbHhnZvi6NTsZU3D76DnPjyNJSnhAVGI__1_;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(374, 480);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(101, 28);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "GİRİŞ YAP";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(329, 339);
            label1.Name = "label1";
            label1.Size = new Size(46, 18);
            label1.TabIndex = 1;
            label1.Text = "Email:";
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.BackColor = Color.Transparent;
            lblRegister.Font = new Font("Calibri", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRegister.Location = new Point(367, 519);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(116, 18);
            lblRegister.TabIndex = 5;
            lblRegister.TabStop = true;
            lblRegister.Text = "Şimdi Kayıt Olun!";
            lblRegister.LinkClicked += lblRegister_LinkClicked;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Window;
            txtEmail.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(329, 367);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(197, 26);
            txtEmail.TabIndex = 1;
            txtEmail.Text = "misra@bitesized.com";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(329, 438);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(197, 26);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "Misra123.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(329, 408);
            label2.Name = "label2";
            label2.Size = new Size(51, 18);
            label2.TabIndex = 4;
            label2.Text = "Parola:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(253, 16);
            label3.Name = "label3";
            label3.Size = new Size(375, 58);
            label3.TabIndex = 6;
            label3.Text = "BiteSized: Her lokmanın değerini bil.\r\n\r\n";
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Calibri", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(253, 56);
            label4.Name = "label4";
            label4.Size = new Size(376, 145);
            label4.TabIndex = 7;
            label4.Text = resources.GetString("label4.Text");
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.BackColor = Color.Transparent;
            chkShowPassword.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowPassword.Location = new Point(532, 445);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(58, 17);
            chkShowPassword.TabIndex = 3;
            chkShowPassword.Text = "Göster";
            chkShowPassword.UseVisualStyleBackColor = false;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnExit
            // 
            btnExit.BackgroundImage = Properties.Resources.kırmızı;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(584, 589);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(38, 23);
            btnExit.TabIndex = 6;
            btnExit.Text = "Çıkış";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.adef1;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(632, 620);
            Controls.Add(btnExit);
            Controls.Add(chkShowPassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(lblRegister);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(632, 620);
            MinimumSize = new Size(632, 620);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label label1;
        private LinkLabel lblRegister;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox chkShowPassword;
        private Button btnExit;
    }
}
