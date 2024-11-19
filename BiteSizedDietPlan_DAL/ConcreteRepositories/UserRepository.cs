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
    public class UserRepository<T> : IUserRepository<T> where T : User
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _entities;

        public UserRepository(AppDbContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }

        
        public User GetUserByEmail(string email)
        {
            var users = _entities.ToList();

            var user = users.FirstOrDefault(x => x.Email == email);
            return user;
        }

        
    }
}
