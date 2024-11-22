using BiteSizedDietPlan_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan_BLL.Dtos.MealDtos
{
    public class FoodEntryMealDto:BaseDto
    {
        public int Portion { get; set; }
        public int FoodEntryId { get; set; }
        public FoodEntryDto FoodEntry { get; set; }

        public int MealId { get; set; }
        public MealDto Meal { get; set; }
    }
}
