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
            _entities.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            _entities.Remove(entity);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _entities.ToList();
        }

        public List<T> GetAll(Expression<Func<T,bool>> predicate)
        {
            return _entities.Where(predicate).ToList();
        }

        public T GetById(int id)
        {
            return _entities.FirstOrDefault(x => x.Id == id);
        }

        public void Update(int id, T entity)
        {
            var entityToUpdate = GetById(id);
            _entities.Update(entityToUpdate);
            _context.SaveChanges();
        }
    }
}
