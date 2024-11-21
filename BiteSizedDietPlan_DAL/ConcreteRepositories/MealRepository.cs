using BiteSizedDietPlan_DAL.AbstractRepositories;
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
    public class MealRepository<T> : IMealRepository<T> where T : Meal
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _entities;
        public MealRepository(AppDbContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }
       
    }
}
