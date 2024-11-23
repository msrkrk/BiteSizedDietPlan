using BiteSizedDietPlan_BLL.Dtos.UserDtos;
using BiteSizedDietPlan_DAL.Entities;
using BiteSizedDietPlan_DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan_BLL.Dtos.MealDtos
{
    public class FoodEntryDto:BaseDto
    {
        public DateTime Date { get; set; }
        
        public MealType MealType { get; set; }

        public int UserId { get; set; }

        public UserDto User { get; set; }

        public List<FoodEntryMealDto> FoodEntryMeals { get; set; }

        public int Calorie { get; set; }

        public override string ToString()
        {
            return Helpers.GetEnumDescription(MealType);
        }
    }
}
