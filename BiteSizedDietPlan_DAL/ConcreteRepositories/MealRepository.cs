using BiteSizedDietPlan_DAL.AbstractRepositories;
using BiteSizedDietPlan_DAL.ConcreteRepositories;
using BiteSizedDietPlan_DAL.Context;
using BiteSizedDietPlan_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan_DAL.ConcreteRepositories
{
    public class MealRepository : GenericRepository<Meal> , IMealRepository
    {
        public MealRepository(AppDbContext context) : base(context)
        {
                
        }

        public List<Meal> GetMealsWithFoodEntries(DateTime start, DateTime end)
        {
            return _entities.AsNoTracking()
                  .Include(x => x.FoodEntryMeals.Where(y => start.Date <= y.FoodEntry.Date.Date && end.Date >= y.FoodEntry.Date.Date))
                  .ThenInclude(y => y.FoodEntry)
                  .ToList();
        }

       

    }
}

