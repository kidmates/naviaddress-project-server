using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NaviaddressProjectServer.DataAccess.Contract;

namespace NaviaddressProjectServer.DataAccess.EFCore
{
    public class GenericRepository<C, T> :
        IGenericRepository<T> where T : class where C : DbContext, new()
    {
        private C Context { get; set; } = new C();

        public IQueryable<T> GetAll()
        {
            return Context.Set<T>();
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().Where(predicate);
        }

        public async Task<T> GetById(Guid id)
        {
            return await Context.Set<T>().FindAsync(id);
        }

        public void Add(T entity)
        {
            Context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
        }

        public void Edit(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }

        public async Task Save()
        {
            await Context.SaveChangesAsync();
        }
    }
}