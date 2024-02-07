using HousewareReviews.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HousewareReviews.Server.Configurations.Entities
{
    public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            // Seed the database with initial data for the Staff entity
            builder.HasData(
                new Staff
                {
                    Id = 1,
                    UserId = "3781efa7-66dc-47f0-860f-e506d04102e4",
                    FirstName = "Andrina",
                    LastName = "Morrison",
                    NRIC = "S1234567A",
                    Email = "staff@blazor.com",
                    ContactNumber = "91234567",
                    ProfileImgUri = "/images/users/andrina.jpg",
                    Password = "P@ssword1"
                }
            );
        }
    }
}
