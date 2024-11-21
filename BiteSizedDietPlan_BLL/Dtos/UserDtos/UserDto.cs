using BiteSizedDietPlan_BLL.Dtos.MealDtos;
using BiteSizedDietPlan_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan_BLL.Dtos.UserDtos
{
    public class UserDto:BaseDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public List<FoodEntryDto> FoodEntries { get; set; }
    }
}
