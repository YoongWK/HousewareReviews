using HousewareReviews.Shared.Domain;

namespace HousewareReviews.Server.IRepository
{
    // Define the IUnitOfWork interface inheriting from IDisposable
    public interface IUnitOfWork : IDisposable
    {
        // Method signature for saving changes to the database
        Task Save(HttpContext httpContext);

        // Properties for accessing different repositories related to specific entities
        IGenericRepository<Category> Categories { get; }
        IGenericRepository<Comment> Comments { get; }
        IGenericRepository<Company> Companies { get; }
        IGenericRepository<Consumer> Consumers { get; }
        IGenericRepository<Product> Products { get; }
        IGenericRepository<Reviewreport> Reviewreports { get; }
		IGenericRepository<Commentreport> Commentreports { get; }
		IGenericRepository<Review> Reviews { get; }
        IGenericRepository<Staff> Staffs { get; }
    }
}
