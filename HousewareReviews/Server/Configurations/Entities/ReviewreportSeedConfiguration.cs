using HousewareReviews.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HousewareReviews.Server.Configurations.Entities
{
    public class ReviewreportSeedConfiguration : IEntityTypeConfiguration<Reviewreport>
    {
        public void Configure(EntityTypeBuilder<Reviewreport> builder)
        {
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
