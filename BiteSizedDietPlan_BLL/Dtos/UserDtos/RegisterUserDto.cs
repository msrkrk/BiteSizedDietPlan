using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan_BLL.Dtos.UserDtos
{
    public class RegisterUserDto:BaseDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
