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
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseClass
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _entities;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }

        public void Add(T entity)
        {
            var entry = _entities.Add(entity);
            _context.SaveChanges();
            entry.State = EntityState.Detached;
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            var entry = _entities.Remove(entity);
            _context.SaveChanges();

            entry.State = EntityState.Detached;
        }

        public List<T> GetAll()
        {
            return _entities.AsNoTracking().ToList();
        }

        public List<T> GetAll(Expression<Func<T,bool>> predicate)
        {
            return _entities.AsNoTracking().Where(predicate).ToList();
        }

        public T GetById(int id)
        {
            return _entities.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public void Update(T entity)
        {
            var entry = _entities.Update(entity);
            _context.SaveChanges();
            entry.State = EntityState.Detached;
        }
    }
}
