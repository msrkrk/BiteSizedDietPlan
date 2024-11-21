using BiteSizedDietPlan_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan.Models.MealViewModels
{
    public class MealCategoryViewModel:BaseViewModel
    {
        public string Name { get; set; }

        public List<MealViewModel> Meals { get; set; }
    }
}
