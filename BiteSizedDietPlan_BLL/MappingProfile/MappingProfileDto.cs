using AutoMapper;
using BiteSizedDietPlan_BLL.Dtos.MealDtos;
using BiteSizedDietPlan_BLL.Dtos.ReportsDto;
using BiteSizedDietPlan_BLL.Dtos.UserDtos;
using BiteSizedDietPlan_DAL.Entities;
using Microsoft.Identity.Client.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiteSizedDietPlan_DAL.Enums;

namespace BiteSizedDietPlan_BLL.MappingProfile
{
    public class MappingProfileDto : Profile
    {
        public MappingProfileDto()
        {
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<LoginUserDto, User>().ReverseMap();
            CreateMap<RegisterUserDto, User>().ReverseMap();
            CreateMap<FoodEntryDto, FoodEntry>().ReverseMap().ForMember(dest => dest.Calorie, src => src.MapFrom(x => x.FoodEntryMeals.Sum(y => y.Meal.Calorie * y.Portion)));
            CreateMap<FoodEntryMealDto, FoodEntryMeal>().ReverseMap()
                .ForMember(dest => dest.Calorie, src => src.MapFrom(x => x.Meal.Calorie * x.Portion));
            CreateMap<User, GeneralCalorieReportDto>()
                .ForMember(dest => dest.User, src => src.MapFrom(x => x.Email))
                .ForMember(dest => dest.DinnerCalorie, src => src.MapFrom(x =>
                    x.FoodEntries
                        .Where(y => y.MealType == MealType.Dinner)
                        .Sum(y => y.FoodEntryMeals.Sum(z => z.Meal.Calorie * z.Portion)
                        )
                    )
                )
                .ForMember(dest => dest.BreakfastCalorie, src => src.MapFrom(x =>
                    x.FoodEntries
                        .Where(y => y.MealType == MealType.Breakfast)
                        .Sum(y => y.FoodEntryMeals.Sum(z => z.Meal.Calorie * z.Portion)
                        )
                    )
                )
                .ForMember(dest => dest.LunchCalorie, src => src.MapFrom(x =>
                    x.FoodEntries
                        .Where(y => y.MealType == MealType.Lunch)
                        .Sum(y => y.FoodEntryMeals.Sum(z => z.Meal.Calorie * z.Portion)
                        )
                    )
                )
                .ForMember(dest => dest.SnacksCalorie, src => src.MapFrom(x =>
                    x.FoodEntries
                        .Where(y => y.MealType == MealType.Snacks)
                        .Sum(y => y.FoodEntryMeals.Sum(z => z.Meal.Calorie * z.Portion)
                        )
                    )
                );


            CreateMap<MealCategoryDto, MealCategory>().ReverseMap();
            CreateMap<MealDto, Meal>().ReverseMap();


        }

    }
}
