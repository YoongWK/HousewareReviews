using HousewareReviews.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HousewareComments.Server.Configurations.Entities
{
    public class CommentreportSeedConfiguration : IEntityTypeConfiguration<Commentreport>
    {
        public void Configure(EntityTypeBuilder<Commentreport> builder)
        {
            // Seed the database with initial data for the Commentreport entity
            builder.HasData(
                new Commentreport
                {
                    Id = 1,
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
