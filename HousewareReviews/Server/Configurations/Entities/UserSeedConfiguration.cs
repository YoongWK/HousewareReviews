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
            // Seed the database with initial data for the ApplicationUser
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                    Email = "staff@blazor.com",
                    NormalizedEmail = "STAFF@BLAZOR.COM",
                    UserName = "S1234567A",
                    NormalizedUserName = "S1234567A",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    PhoneNumber = "91234567"
                },
                new ApplicationUser
                {
                    Id = "1ce40de7-b2a7-4cf4-a8f3-c811191a664d",
                    Email = "consumer@blazor.com",
                    NormalizedEmail = "CONSUMER@BLAZOR.COM",
                    UserName = "T1234567A",
                    NormalizedUserName = "T1234567A",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    PhoneNumber = "98765432"
                },
                new ApplicationUser
                {
                    Id = "9du2ii40-h7d9-8sj2-j98s-is0dh83jk48s",
                    Email = "maymorrison@gmail.com",
                    NormalizedEmail = "MAYMORRISON@GMAIL.COM",
                    UserName = "S6523489J",
                    NormalizedUserName = "S6523489J",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    PhoneNumber = "92438900"
                },
                new ApplicationUser
                {
                    Id = "2oh7diw9-0or5-3jf9-8ss6-ks8ya5h297bd",
                    Email = "joshuatan@outlook.com",
                    NormalizedEmail = "JOSHUATAN@OUTLOOK.COM",
                    UserName = "T9366538J",
                    NormalizedUserName = "T9366538J",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    PhoneNumber = "83072245"
                },
                new ApplicationUser
                {
                    Id = "5di8sy83-2i9r-f56h-s8d9-s09njsh7dd53",
                    Email = "ethanlim@hotmail.com",
                    NormalizedEmail = "ETHANLIM@HOTMAIL.COM",
                    UserName = "S9812704F",
                    NormalizedUserName = "S9812704F",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    PhoneNumber = "87229044"
                }
            );
        }
    }
}
