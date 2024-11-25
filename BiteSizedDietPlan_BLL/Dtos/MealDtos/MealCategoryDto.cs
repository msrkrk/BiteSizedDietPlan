using BiteSizedDietPlan_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan_BLL.Dtos.MealDtos
{
    public class MealCategoryDto:BaseDto
    {
        public string Name { get; set; }

        public List<MealDto> Meals { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
