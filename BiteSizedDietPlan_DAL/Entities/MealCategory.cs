using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan_DAL.Entities
{
    public class MealCategory : BaseClass
    {
        public string Name { get; set; }

        public List<Meal> Meals { get; set; }
    }
}
