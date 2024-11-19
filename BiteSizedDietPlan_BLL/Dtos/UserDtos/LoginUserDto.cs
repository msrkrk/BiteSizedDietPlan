using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan_BLL.Dtos.UserDtos
{
    public class LoginUserDto:BaseDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
