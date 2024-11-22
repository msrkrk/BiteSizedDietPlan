using BiteSizedDietPlan_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan_BLL.Dtos.MealDtos
{
    public class MealDto:BaseDto
    {
            public string Name { get; set; }

            public int Calorie { get; set; }

            public int MealCategoryId { get; set; }
            public MealCategoryDto MealCategory { get; set; }

            public List<FoodEntryMealDto> FoodEntryMeals { get; set; }
            public string ImagePath { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
