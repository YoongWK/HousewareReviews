using HousewareReviews.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousewareReviews.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Category> Categories { get; }
        IGenericRepository<Comment> Comments { get; }
        IGenericRepository<Company> Companies { get; }
        IGenericRepository<Consumer> Consumers { get; }
        IGenericRepository<Product> Products { get; }
        IGenericRepository<Report> Reports { get; }
        IGenericRepository<Review> Reviews { get; }
        IGenericRepository<Staff> Staffs { get; }
    }
}