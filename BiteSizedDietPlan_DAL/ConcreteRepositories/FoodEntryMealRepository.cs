using BiteSizedDietPlan_DAL.AbstractRepositories;
using BiteSizedDietPlan_DAL.Context;
using BiteSizedDietPlan_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan_DAL.ConcreteRepositories
{
    public class FoodEntryMealRepository : GenericRepository<FoodEntryMeal>, IFoodEntryMealRepository
    {
        public FoodEntryMealRepository(AppDbContext context) : base(context)
        {

        }

        public override List<FoodEntryMeal> GetAll(Expression<Func<FoodEntryMeal, bool>> predicate)
        {
            return _entities.AsNoTracking().Where(predicate)
                .Include(x => x.FoodEntry)
                .ThenInclude(y => y.User)
                .Include(x => x.Meal)
                .ToList();
        }
    }




}
