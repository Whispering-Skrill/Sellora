using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Sellora.Server.IRepository
{
    // Generic repository interface with CRUD operations
    public interface IGenericRepository<T> where T : class
    {
        // Retrieves a list of entities
        Task<IList<T>> GetAll(
            Expression<Func<T, bool>> expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null
        );

        // Retrieves a single entity based on specified conditions and includes
        Task<T> Get(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null);
        
        // Inserts a single entity into the repository
        Task Insert(T entity);

        // Inserts a range of entities into the repository
        Task InsertRange(IEnumerable<T> entities);

        // Deletes a single entity from the repository based on its ID
        Task Delete(int id);

        // Deletes a range of entities from the repository
        void DeleteRange(IEnumerable<T> entities);

        // Updates a single entity in the repository
        void Update(T entity);
    }
}