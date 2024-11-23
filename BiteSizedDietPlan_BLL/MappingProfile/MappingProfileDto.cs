﻿using AutoMapper;
using BiteSizedDietPlan_BLL.Dtos.MealDtos;
using BiteSizedDietPlan_BLL.Dtos.UserDtos;
using BiteSizedDietPlan_DAL.Entities;
using Microsoft.Identity.Client.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan_BLL.MappingProfile
{
    public class MappingProfileDto:Profile
    {
        public MappingProfileDto()
        {
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<LoginUserDto, User>().ReverseMap();
            CreateMap<RegisterUserDto, User>().ReverseMap();
            CreateMap<FoodEntryDto, FoodEntry>().ReverseMap().ForMember(dest => dest.Calorie,src => src.MapFrom(x=>x.FoodEntryMeals.Sum(y=>y.Meal.Calorie*y.Portion)));
            CreateMap<FoodEntryMealDto, FoodEntryMeal>().ReverseMap()
                .ForMember(dest => dest.Calorie,src => src.MapFrom(x=>x.Meal.Calorie*x.Portion));
            CreateMap<MealCategoryDto, MealCategory>().ReverseMap();
            CreateMap<MealDto, Meal>().ReverseMap();
           
           
        }

    }
}
