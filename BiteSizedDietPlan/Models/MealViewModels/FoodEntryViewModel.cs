using BiteSizedDietPlan.Models.UserViewModels;
using BiteSizedDietPlan_DAL.Entities;
using BiteSizedDietPlan_DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan.Models.MealViewModels
{
    public class FoodEntryViewModel: BaseViewModel
    {
        public DateTime Date { get; set; }
        public MealType MealType { get; set; }

        public int UserId { get; set; }

        public UserViewModel User { get; set; }

        public List<FoodEntryMealViewModel> FoodEntryMeals { get; set; }
    }
}
