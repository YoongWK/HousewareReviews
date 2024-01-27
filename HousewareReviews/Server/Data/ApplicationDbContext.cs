using Duende.IdentityServer.EntityFramework.Options;
using HousewareComments.Server.Configurations.Entities;
using HousewareReviews.Server.Configurations.Entities;
using HousewareReviews.Server.Models;
using HousewareReviews.Shared.Domain;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Reflection.Emit;

namespace HousewareReviews.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Consumer> Consumers { get; set; }
        public DbSet<Staff> Staffs { get; set;}
        public DbSet<Company> Companies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product>  Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Reviewreport> Reviewreports { get; set; }
		public DbSet<Commentreport> Commentreports { get; set; }
		protected override void OnModelCreating(ModelBuilder builder)
        {
			builder.Entity<Review>()
			.HasOne(s => s.Consumer)
			.WithMany()
			.HasForeignKey(s => s.ConsumerId)
			.OnDelete(DeleteBehavior.SetNull);

			builder.Entity<Comment>()
			.HasOne(s => s.Consumer)
			.WithMany()
			.HasForeignKey(s => s.ConsumerId)
			.OnDelete(DeleteBehavior.SetNull);

			builder.Entity<Reviewreport>()
			.HasOne(s => s.Consumer)
			.WithMany()
			.HasForeignKey(s => s.ConsumerId)
			.OnDelete(DeleteBehavior.SetNull);

			builder.Entity<Reviewreport>()
		    .HasOne(s => s.Staff)
		    .WithMany()
		    .HasForeignKey(s => s.StaffId)
		    .OnDelete(DeleteBehavior.SetNull);

			builder.Entity<Commentreport>()
			.HasOne(s => s.Consumer)
			.WithMany()
			.HasForeignKey(s => s.ConsumerId)
			.OnDelete(DeleteBehavior.SetNull);

			builder.Entity<Commentreport>()
			.HasOne(s => s.Staff)
			.WithMany()
			.HasForeignKey(s => s.StaffId)
			.OnDelete(DeleteBehavior.SetNull);

			base.OnModelCreating(builder);
            builder.ApplyConfiguration(new CategorySeedConfiguration());
            builder.ApplyConfiguration(new CompanySeedConfiguration());
            builder.ApplyConfiguration(new ProductSeedConfiguration());
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new ConsumerSeedConfiguration());
            builder.ApplyConfiguration(new StaffSeedConfiguration());
            builder.ApplyConfiguration(new ReviewSeedConfiguration());
            builder.ApplyConfiguration(new CommentSeedConfiguration());
            builder.ApplyConfiguration(new ReviewreportSeedConfiguration());
			builder.ApplyConfiguration(new CommentreportSeedConfiguration());
		}
    }
}