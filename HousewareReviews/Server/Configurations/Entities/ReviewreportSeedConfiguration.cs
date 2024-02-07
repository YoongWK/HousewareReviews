using HousewareReviews.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HousewareReviews.Server.Configurations.Entities
{
    public class ReviewreportSeedConfiguration : IEntityTypeConfiguration<Reviewreport>
    {
        public void Configure(EntityTypeBuilder<Reviewreport> builder)
        {
            // Seed the database with initial data for the Reviewreport entity
            builder.HasData(
                new Reviewreport
				{
                    Id = 1,
                    Category = "Spam",
                    Description = "Irrelevant gibberish review",
                    Outcome = "Pending",
                    ReviewId = 6,
                    ConsumerId = 1,
                }
            );
        }
    }
}
