using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NaviaddressProjectServer.DataAccess.Contract
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        Task<T> GetById(Guid id);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
        Task Save();
    }  
}