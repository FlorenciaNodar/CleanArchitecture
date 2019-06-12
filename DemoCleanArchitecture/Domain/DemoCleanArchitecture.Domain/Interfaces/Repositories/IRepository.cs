using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DemoCleanArchitecture.Domain.Interfaces.Repositories
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);        
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
        void Save();
        Task<int> SaveAsync();
        void Detach(T entity);
        void AddRange(IEnumerable<T> entity);
        void DeleteRange(IEnumerable<T> entity);        

    }

}
