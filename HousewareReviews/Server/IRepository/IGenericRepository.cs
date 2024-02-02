using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace HousewareReviews.Server.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        // Method signature for retrieving all entities
        Task<IList<T>> GetAll(
            Expression<Func<T, bool>> expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null
         );

        // Method signature for retrieving a single entity
        Task<T> Get(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null);
        // Method signature for inserting a single entity
        Task Insert(T entity);
        // Method signature for inserting a range of entities
        Task InsertRange(IEnumerable<T> entities);
        // Method signature for deleting an entity by its id
        Task Delete(int id);
        // Method signature for deleting a range of entities
        void DeleteRange(IEnumerable<T> entities);
        // Method signature for updating a single entity
        void Update(T entity);
    }
}
