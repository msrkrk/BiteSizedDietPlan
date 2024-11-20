using AutoMapper;
using BiteSizedDietPlan;
using BiteSizedDietPlan.Models.UserViewModels;
using BiteSizedDietPlan_BLL.AbstractServices;
using BiteSizedDietPlan_BLL.ConcreteServices;

namespace BiteSizedDietPlan
{
    public partial class LoginForm : Form
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly IHashService _hashService;

        public LoginForm(IUserService userService, IMapper mapper, IHashService hashService)
        {
            InitializeComponent();
            _userService = userService;
            _mapper = mapper;
            _hashService = hashService;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text.Trim();


                if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Email ve parola alanları boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string hashedPassword = _hashService.GetHashCode(password);
                var user = _userService.Login(email, hashedPassword);
                if (user == null)
                {
                    MessageBox.Show("Giriş yaptığınız email veya parolaya ait kullanıcı bulunmuyor, lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Hoşgeldiniz.");
                Form homePage = new HomePageForm();
                this.Hide();
                homePage.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu! " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new RegisterForm(_userService, _mapper, _hashService);
            this.Hide();
            form.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}




