using AutoMapper;
using BiteSizedDietPlan.Models.UserViewModels;
using BiteSizedDietPlan_BLL.Dtos.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan.MappingProfile
{
    public class MappingProfileModel:Profile
    {
        public MappingProfileModel()
        {
            CreateMap<UserViewModel, UserDto>().ReverseMap();
            CreateMap<LoginUserViewModel, LoginUserDto>().ReverseMap();
        }
    }
}
