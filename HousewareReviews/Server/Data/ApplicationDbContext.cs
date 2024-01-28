using Duende.IdentityServer.EntityFramework.Options;
using HousewareComments.Server.Configurations.Entities;
using HousewareReviews.Server.Configurations.Entities;
using HousewareReviews.Server.Models;
using HousewareReviews.Shared.Domain;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

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
			.HasOne(e => e.Consumer)
			.WithMany()
			.HasForeignKey(e => e.ConsumerId)
			.OnDelete(DeleteBehavior.SetNull);

			builder.Entity<Comment>()
			.HasOne(e => e.Consumer)
			.WithMany()
			.HasForeignKey(e => e.ConsumerId)
			.OnDelete(DeleteBehavior.SetNull);

			builder.Entity<Reviewreport>()
			.HasOne(e => e.Consumer)
			.WithMany()
			.HasForeignKey(e => e.ConsumerId)
			.OnDelete(DeleteBehavior.SetNull);

			builder.Entity<Reviewreport>()
		    .HasOne(e => e.Staff)
		    .WithMany()
		    .HasForeignKey(e => e.StaffId)
		    .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Reviewreport>()
            .HasOne(e => e.Review)
            .WithMany()
            .HasForeignKey(e => e.ReviewId)
            .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Commentreport>()
			.HasOne(e => e.Consumer)
			.WithMany()
			.HasForeignKey(e => e.ConsumerId)
			.OnDelete(DeleteBehavior.SetNull);

			builder.Entity<Commentreport>()
			.HasOne(e => e.Staff)
			.WithMany()
			.HasForeignKey(e => e.StaffId)
			.OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Commentreport>()
            .HasOne(e => e.Comment)
            .WithMany()
            .HasForeignKey(e => e.CommentId)
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