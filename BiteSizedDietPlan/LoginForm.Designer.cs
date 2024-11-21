namespace BiteSizedDietPlan
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
            btnLogin.Location = new Point(695, 1024);
            btnLogin.Margin = new Padding(6, 6, 6, 6);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(188, 60);
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
            label1.Location = new Point(611, 723);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 37);
            label1.TabIndex = 1;
            label1.Text = "Email:";
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.BackColor = Color.Transparent;
            lblRegister.Font = new Font("Calibri", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRegister.Location = new Point(682, 1107);
            lblRegister.Margin = new Padding(6, 0, 6, 0);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(230, 37);
            lblRegister.TabIndex = 5;
            lblRegister.TabStop = true;
            lblRegister.Text = "Şimdi Kayıt Olun!";
            lblRegister.LinkClicked += lblRegister_LinkClicked;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Window;
            txtEmail.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(611, 783);
            txtEmail.Margin = new Padding(6, 6, 6, 6);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(362, 44);
            txtEmail.TabIndex = 1;
            txtEmail.Text = "misra@bitesized.com";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(611, 934);
            txtPassword.Margin = new Padding(6, 6, 6, 6);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(362, 44);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "Misra123.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(611, 870);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 37);
            label2.TabIndex = 4;
            label2.Text = "Parola:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(470, 34);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(746, 118);
            label3.TabIndex = 6;
            label3.Text = "BiteSized: Her lokmanın değerini bil.\r\n\r\n";
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Calibri", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(470, 119);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(698, 309);
            label4.TabIndex = 7;
            label4.Text = resources.GetString("label4.Text");
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.BackColor = Color.Transparent;
            chkShowPassword.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowPassword.Location = new Point(988, 949);
            chkShowPassword.Margin = new Padding(6, 6, 6, 6);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(105, 31);
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
            btnExit.Location = new Point(1085, 1257);
            btnExit.Margin = new Padding(6, 6, 6, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(71, 49);
            btnExit.TabIndex = 6;
            btnExit.Text = "Çıkış";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.adef1;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1174, 1325);
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
            Margin = new Padding(6, 6, 6, 6);
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
