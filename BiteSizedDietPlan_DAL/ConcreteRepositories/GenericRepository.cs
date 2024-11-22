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
        protected readonly AppDbContext _context;
        protected readonly DbSet<T> _entities;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }

        public virtual int Add(T entity)
        {
            _entities.Add(entity);
            _context.SaveChanges();

            return entity.Id;
        }

        public virtual void Delete(int id)
        {
            var entity = GetById(id);
            _entities.Remove(entity);
            _context.SaveChanges();
        }

        public virtual List<T> GetAll()
        {
            return _entities.AsNoTracking().ToList();
        }

        public virtual List<T> GetAll(Expression<Func<T,bool>> predicate)
        {
            return _entities.AsNoTracking().Where(predicate).ToList();
        }

        public virtual T GetById(int id)
        {
            return _entities.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public virtual void Update(T entity)
        {
            _entities.Update(entity);
            _context.SaveChanges();
        }
    }
}
