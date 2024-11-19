using BiteSizedDietPlan_BLL.Dtos.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan_BLL.AbstractServices
{
    public interface IUserService
    {
        UserDto Login(string email, string password);

    }
}
