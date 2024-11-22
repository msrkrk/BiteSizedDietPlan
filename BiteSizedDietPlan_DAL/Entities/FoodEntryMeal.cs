using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan_DAL.Entities
{
    public class FoodEntryMeal : BaseClass
    {
        public int Portion { get; set; }
        public int FoodEntryId { get; set; }
        public FoodEntry FoodEntry { get; set; }

        public int MealId { get; set; }
        public Meal Meal { get; set; }

    }
}
