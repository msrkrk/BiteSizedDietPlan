using BiteSizedDietPlan_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan_DAL.AbstractRepositories
{
    public interface IMealRepository :IGenericRepository<Meal>
    {

        List<Meal> GetMealsWithFoodEntries(DateTime start, DateTime end);
    }
}
