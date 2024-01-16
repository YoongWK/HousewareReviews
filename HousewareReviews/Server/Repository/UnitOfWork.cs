using HousewareReviews.Server.Data;
using HousewareReviews.Server.IRepository;
using HousewareReviews.Server.Models;
using HousewareReviews.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HousewareReviews.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Category> _categories;
        private IGenericRepository<Comment> _comments;
        private IGenericRepository<Company> _companies;
        private IGenericRepository<Consumer> _consumers;
        private IGenericRepository<Product> _products;
        private IGenericRepository<Report> _reports;
        private IGenericRepository<Review> _reviews;
        private IGenericRepository<Staff> _staffs;

        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<Category> Categories
            => _categories ??= new GenericRepository<Category>(_context);
        public IGenericRepository<Comment> Comments
            => _comments ??= new GenericRepository<Comment>(_context);
        public IGenericRepository<Company> Companies
            => _companies ??= new GenericRepository<Company>(_context);
        public IGenericRepository<Consumer> Consumers
            => _consumers ??= new GenericRepository<Consumer>(_context);
        public IGenericRepository<Product> Products
            => _products ??= new GenericRepository<Product>(_context);
        public IGenericRepository<Report> Reports
            => _reports ??= new GenericRepository<Report>(_context);
        public IGenericRepository<Review> Reviews
            => _reviews ??= new GenericRepository<Review>(_context);
        public IGenericRepository<Staff> Staffs
            => _staffs ??= new GenericRepository<Staff>(_context);


        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            /*//To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }
            }*/

            await _context.SaveChangesAsync();
        }
    }
}