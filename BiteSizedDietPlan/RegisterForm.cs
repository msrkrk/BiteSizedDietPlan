using AutoMapper;
using BiteSizedDietPlan.Models.UserViewModels;
using BiteSizedDietPlan_BLL.AbstractServices;
using BiteSizedDietPlan_BLL.Dtos.UserDtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BiteSizedDietPlan
{
    public partial class RegisterForm : Form
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly IHashService _hashService;
        private readonly IMealService _mealService;

        public RegisterForm(IUserService userService, IMapper mapper, IHashService hashService, IMealService mealService)
        {
            InitializeComponent();
            _userService = userService;
            _mapper = mapper;
            _hashService = hashService;
            _mealService = mealService;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new RegisterUserViewModel();

                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text.Trim();

                if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Email ve şifre alanları boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!IsValidPassword(password))
                {
                    MessageBox.Show("Şifreniz en az 6 haneli olmalı, bir büyük harf ve bir özel karakter içermelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (_userService.GetUserByEmail(email) == null)
                {
                    user.Email = email;
                    user.Password = _hashService.GetHashCode(password);

                    _userService.Register(_mapper.Map<RegisterUserDto>(user));
                    MessageBox.Show("Kayıt işlemi başarı ile gerçekleştirilmiştir, aramıza Hoşgeldiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form loginForm = new LoginForm(_userService, _mapper, _hashService,_mealService);
                    this.Hide();
                    loginForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Girilen email adresi başka bir kullanıcı tarafından kullanılmaktadır. Lütfen farklı bir email adresi ile tekrar deneyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu! " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
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

        private bool IsValidPassword(string password)
        {
            bool containUpperCase = password.Any(char.IsUpper);

            bool containSpecialCharacter = password.Any(x => !char.IsLetterOrDigit(x));

            bool isLengthValid = password.Length >= 6;

            return containUpperCase && containSpecialCharacter && isLengthValid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form loginForm = new LoginForm(_userService, _mapper, _hashService,_mealService);
            this.Hide();
            loginForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
