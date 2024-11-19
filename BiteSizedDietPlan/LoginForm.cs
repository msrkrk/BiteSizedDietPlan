using AutoMapper;
using BiteSizedDietPlan.Models.UserViewModels;
using BiteSizedDietPlan_BLL.AbstractServices;

namespace BiteSizedDietPlan
{
    public partial class LoginForm : Form
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public LoginForm(IUserService userService, IMapper mapper)
        {
            InitializeComponent();
            _userService = userService;
            _mapper = mapper;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var loggedInUser = new LoginUserViewModel()
                {
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
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
    }
}
