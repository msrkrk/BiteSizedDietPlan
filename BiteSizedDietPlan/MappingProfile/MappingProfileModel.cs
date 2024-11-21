using AutoMapper;
using BiteSizedDietPlan.Models.MealViewModels;
using BiteSizedDietPlan.Models.UserViewModels;
using BiteSizedDietPlan_BLL.Dtos.MealDtos;
using BiteSizedDietPlan_BLL.Dtos.UserDtos;
using BiteSizedDietPlan_DAL.Entities;
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
            CreateMap<RegisterUserViewModel, RegisterUserDto>().ReverseMap();
            CreateMap<FoodEntryViewModel, FoodEntryDto>().ReverseMap();
            CreateMap<FoodEntryMealViewModel, FoodEntryMealDto>().ReverseMap();
            CreateMap<MealCategoryViewModel, MealCategoryDto>().ReverseMap();
            CreateMap<MealViewModel, MealDto>().ReverseMap();
            CreateMap<LoginUserDto, UserViewModel>().ReverseMap();  
        }
    }
}
