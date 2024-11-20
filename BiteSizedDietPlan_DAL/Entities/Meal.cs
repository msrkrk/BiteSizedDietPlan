using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan_DAL.Entities
{
    public class Meal : BaseClass
    {
        public string Name { get; set; }

        public int Calorie { get; set; }

        public int MealCategoryId { get; set; }
        public MealCategory MealCategory { get; set; }

    }
}
