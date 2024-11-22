using BiteSizedDietPlan_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BiteSizedDietPlan_DAL.AbstractRepositories
{
    public interface IGenericRepository<T> where T : BaseClass
    {
        int Add(T entity); 

        void Delete(int id);
        T GetById(int id);
        List<T> GetAll();
        void Update(T entity);
        List<T> GetAll(Expression<Func<T,bool>>predicate);


    }
}
