using AutoMapper;
using BiteSizedDietPlan.Models.UserViewModels;
using BiteSizedDietPlan_BLL.AbstractServices;

namespace BiteSizedDietPlan
{
    public partial class LoginForm : Form
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly IHashService _hashService;

        public LoginForm(IUserService userService, IMapper mapper,IHashService hashService)
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
                var loggedInUser = new LoginUserViewModel()
                {
                    Email = txtEmail.Text,
                    Password = _hashService.GetHashCode(txtPassword.Text),
                };

                var user = _userService.Login(loggedInUser.Email, loggedInUser.Password);
                MessageBox.Show("Hoşgeldiniz.");

                Form homePage = new HomePageForm();
                this.Hide();
                homePage.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu! " + ex.Message);
            }


        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new RegisterForm(_userService, _mapper, _hashService);
            this.Hide();
            form.ShowDialog();
        }
    }
}
