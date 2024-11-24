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
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context):base(context) 
        {
        }

        
        public User GetUserByEmail(string email)
        {
            var users = _entities.ToList();

            var user = users.FirstOrDefault(x => x.Email == email);
            return user;
        }

        public override List<User> GetAll()
        {
            return _entities.AsNoTracking()
                .Include(x => x.FoodEntries)
                .ThenInclude(y => y.FoodEntryMeals)
                .ThenInclude(x => x.Meal)
                .ToList();
        }

        public override List<User> GetAll(Expression<Func<User, bool>> predicate)
        {
            return _entities.AsNoTracking().Where(predicate)
                .Include(x => x.FoodEntries)
                .ThenInclude(y => y.FoodEntryMeals)
                .ThenInclude(x => x.Meal)
                .ToList();
        }

    }
}
