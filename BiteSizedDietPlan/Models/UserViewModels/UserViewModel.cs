using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan.Models.UserViewModels
{
    public class UserViewModel : BaseViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
