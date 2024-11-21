using BiteSizedDietPlan_DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan_DAL.Entities
{
    public class FoodEntry:BaseClass
    {
        public MealType MealType { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public List<FoodEntryMeal> FoodEntryMeals { get; set; }
    }
}
