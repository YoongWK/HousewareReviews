using HousewareReviews.Server.Data;
using HousewareReviews.Server.IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
namespace HousewareReviews.Server.Repository
{
    // Define the GenericRepository class implementing the IGenericRepository interface
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        // Define the ApplicationDbContext & DBset instances
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _db;

        // Constructor that takes the ApplicationDbContext & DBset instances
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _db = _context.Set<T>();
        }

        // Implement the Delete method to delete an entity by its id
        public async Task Delete(int id)
        {
            var record = await _db.FindAsync(id);
            _db.Remove(record);
        }

        // Implement the DeleteRange method to delete a range of entities
        public void DeleteRange(IEnumerable<T> entities)
        {
            _db.RemoveRange(entities);
        }

        // Implement the Get method to retrieve a single entity
        public async Task<T> Get(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null)
        {
            IQueryable<T> query = _db;

            if (includes != null)
            {
                query = includes(query);
            }

            return await query.AsNoTracking().FirstOrDefaultAsync(expression);
        }

        // Implement the GetAll method to retrieve all entities
        public async Task<IList<T>> GetAll(Expression<Func<T, bool>> expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null)
        {
            IQueryable<T> query = _db;

            if (expression != null)
            {
                query = query.Where(expression);
            }

            if (includes != null)
            {
                query = includes(query);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            return await query.AsNoTracking().ToListAsync();
        }

        // Implement the Insert method to insert a single entity
        public async Task Insert(T entity)
        {
            await _db.AddAsync(entity);
        }

        // Implement the InsertRange method to insert a range of entities
        public async Task InsertRange(IEnumerable<T> entities)
        {
            await _db.AddRangeAsync(entities);
        }

        // Implement the Update method to update a single entity
        public void Update(T entity)
        {
            _db.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
