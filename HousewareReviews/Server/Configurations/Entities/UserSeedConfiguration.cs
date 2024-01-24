using HousewareReviews.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace HousewareReviews.Server.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                    Email = "staff@blazor.com",
                    NormalizedEmail = "STAFF@BLAZOR.COM",
                    UserName = "staff@blazor.com",
                    NormalizedUserName = "STAFF@BLAZOR.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                },
                new ApplicationUser
                {
                    Id = "1ce40de7-b2a7-4cf4-a8f3-c811191a664d",
                    Email = "consumer@blazor.com",
                    NormalizedEmail = "CONSUMER@BLAZOR.COM",
                    UserName = "consumer@blazor.com",
                    NormalizedUserName = "CONSUMER@BLAZOR.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                }
            );
        }
    }
}
