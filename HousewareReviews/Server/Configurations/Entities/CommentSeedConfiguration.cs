using HousewareReviews.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HousewareReviews.Server.Configurations.Entities
{
    public class CommentSeedConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            // Seed the database with initial data for the Comment entity
            builder.HasData(
                new Comment
                {
                    Id = 1,
                    Description = "Agreed! The Aerogaz 16” wall fan is way too noisy. Regretted buying it. Found a quieter one for better sleep.",
                    DateCreated = new DateTime(2024, 1, 6, 15, 32, 40),
                    DateUpdated = new DateTime(2024, 1, 6, 15, 32, 40),
                    ReviewId = 4,
                    ConsumerId = 4
                },
                new Comment
                {
                    Id = 2,
                    Description = "Absolutely agree! It's a game-changer!",
                    DateCreated = new DateTime(2024, 1, 6, 15, 32, 40),
                    DateUpdated = new DateTime(2024, 1, 6, 15, 32, 40),
                    ReviewId = 5,
                    ConsumerId = 2
                },
                new Comment
                {
                    Id = 3,
                    Description = ":#%#&%”?*%”#%6",
                    DateCreated = new DateTime(2024, 1, 17, 15, 10, 40),
                    DateUpdated = new DateTime(2024, 1, 17, 15, 10, 40),
                    ReviewId = 1,
                    ConsumerId = 3
                }
            );
        }
    }
}
