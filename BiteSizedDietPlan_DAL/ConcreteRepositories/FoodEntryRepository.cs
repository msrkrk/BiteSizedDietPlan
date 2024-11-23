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
    public class FoodEntryRepository : GenericRepository<FoodEntry>, IFoodEntryRepository
    {
        public FoodEntryRepository(AppDbContext context) : base(context)
        {

        }

        public override List<FoodEntry> GetAll(Expression<Func<FoodEntry, bool>> predicate)
        {
            return _entities.AsNoTracking().Where(predicate)
                .Include(x => x.FoodEntryMeals)
                .ThenInclude(x=> x.Meal)
                .Include(y => y.User)
                .ToList();
        }
    }




}
