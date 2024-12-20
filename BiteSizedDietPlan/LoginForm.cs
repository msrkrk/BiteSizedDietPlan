﻿using AutoMapper;
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
        private readonly IMealService _mealService;
        private readonly IFoodEntryService _foodEntryService;

        public LoginForm(IUserService userService, IMapper mapper, IHashService hashService,IMealService mealService,IFoodEntryService foodEntryService)
        {
            InitializeComponent();
            _userService = userService;
            _mapper = mapper;
            _hashService = hashService;
            _mealService = mealService;
            _foodEntryService = foodEntryService;
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

                Form homePage = new HomePageForm(_mapper,_mealService,_mapper.Map<UserViewModel>(user),_foodEntryService);
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
            Form form = new RegisterForm(_userService, _mapper, _hashService, _mealService,_foodEntryService);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}




