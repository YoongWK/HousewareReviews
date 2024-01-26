using HousewareReviews.Shared.Domain;
using Microsoft.EntityFrameworkCore;

namespace HousewareReviews.Server.Configurations.Entities
{
    public class ReportSeedConfiguration : IEntityTypeConfiguration<Report>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Report> builder)
        {
            builder.HasData(
                new Report
                {
                    Id = 1,
                    Category = "Spam",
                    Description = "Irrelevant gibberish review",
                    Outcome = "Pending",
                    ReviewId = 6,
                    ConsumerId = 1,
                },
                new Report
                {
                    Id = 2,
                    Category = "Spam",
                    Description = "Unhelpful comment that serves no purpose",
                    Outcome = "Pending",
                    CommentId = 3,
                    ConsumerId = 1,
                }
            );
        }
    }
}
