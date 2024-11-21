using BiteSizedDietPlan_BLL.Dtos.UserDtos;
using BiteSizedDietPlan_DAL.Entities;
using BiteSizedDietPlan_DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan_BLL.Dtos.MealDtos
{
    public class FoodEntryDto:BaseDto
    {
        public MealType MealType { get; set; }

        public int UserId { get; set; }

        public UserDto User { get; set; }

        public List<FoodEntryMealDto> FoodEntryMeals { get; set; }
    }
}
