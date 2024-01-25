using HousewareReviews.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HousewareReviews.Server.Configurations.Entities
{
    public class ConsumerSeedConfiguration : IEntityTypeConfiguration<Consumer>
    {
        public void Configure(EntityTypeBuilder<Consumer> builder)
        {
            builder.HasData(
                new Consumer
                {
                    Id = 1,
                    UserId = "1ce40de7-b2a7-4cf4-a8f3-c811191a664d",
                    FirstName = "Yoong",
                    LastName = "Wai Kit",
                    NRIC = "S9067028Z",
                    Email = "consumer@blazor.com",
                    ContactNumber = "98765432",
                    Password = "P@ssword1"
                }
            );
        }
    }
}
