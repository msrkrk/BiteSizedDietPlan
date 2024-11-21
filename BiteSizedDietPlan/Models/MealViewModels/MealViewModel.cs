using BiteSizedDietPlan_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan.Models.MealViewModels
{
    public class MealViewModel:BaseViewModel
    {
        public string Name { get; set; }

        public int Calorie { get; set; }

        public int MealCategoryId { get; set; }
        public MealCategoryViewModel MealCategory { get; set; }

        public List<FoodEntryMealViewModel> FoodEntryMeals { get; set; }
        public string ImagePath { get; set; }

    }
}
