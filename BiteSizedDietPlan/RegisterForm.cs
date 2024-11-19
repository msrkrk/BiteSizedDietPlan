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
        public RegisterForm(IUserService userService, IMapper mapper)
        {
            InitializeComponent();
            _userService = userService;
            _mapper = mapper;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            var user = new RegisterUserViewModel();

            if (_userService.GetUserByEmail(txtEmail.Text) == null)
            {
                user.Email = txtEmail.Text;
                user.Password = txtPassword.Text;


                _userService.Register(_mapper.Map<RegisterUserDto>(user));
                MessageBox.Show("Kayıt işlemi başarı ile gerçekleştirilmiştir, aramıza Hoşgeldiniz.");

                Form loginForm = new LoginForm(_userService, _mapper);
                this.Hide();
                loginForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Girilen email adersi başka bir kullanıcı tarafından kullanılmaktadır. Lütfen farklı bir email adresi ile tekrar deneyiniz.");
            }


        }

   
    }
}
