using BiteSizedDietPlan_DAL.Entities;
using BiteSizedDietPlan_DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan.Models.MealViewModels
{
    public class FoodEntryMealViewModel:BaseViewModel
    {
        public int Portion { get; set; }
        public int FoodEntryId { get; set; }
        public FoodEntryViewModel FoodEntry { get; set; }

        public int MealId { get; set; }
        public MealViewModel Meal { get; set; }
    }
}
