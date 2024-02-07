using HousewareReviews.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HousewareReviews.Server.Configurations.Entities
{
    public class ReviewSeedConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            // Seed the database with initial data for the Review entity
            builder.HasData(
                new Review
                {
                    Id = 1,
                    Rating = 5,
                    Description = "This Aerogaz wall fan, power sia! Confirm plus chop the motor very solid. Really shiok for beating the heat. No kidding.",
                    Reply = "Hey Ethan, awesome to hear you’re loving our wall fan. Stay cool and thanks for choosing Aerogaz!",
                    DateCreated = new DateTime(2023, 12, 25, 10, 30, 45),
                    DateReplied = new DateTime(2023, 12, 28, 11, 20, 10),
                    DateUpdated = new DateTime(2023, 12, 25, 10, 30, 45),
                    ProductId = 1,
                    ConsumerId = 4
                },
                new Review
                {
                    Id = 2,
                    Rating = 3,
                    Description = "The fan does its job in cooling the place down. But always got a hum sound, need to tahan the extra background melody.",
                    Reply = "Hello May, appreciate your honest review! We’re sorry to hear about the hum and we’ll look into improving this issue. If you have more details to share, hit us up. Thanks!",
                    DateCreated = new DateTime(2024, 1, 2, 10, 30, 45),
                    DateReplied = new DateTime(2024, 1, 2, 11, 20, 10),
                    DateUpdated = new DateTime(2024, 1, 2, 10, 30, 45),
                    ProductId = 1,
                    ConsumerId = 2

                },
                new Review
                {
                    Id = 3,
                    Rating = 4,
                    Description = "Reliable fan. Good choice for staying cool.",
                    DateCreated = new DateTime(2024, 1, 2, 14, 30, 45),
                    DateUpdated = new DateTime(2024, 1, 2, 14, 30, 45),
                    ProductId = 1,
                    ConsumerId = 1
                },
                new Review
                {
                    Id = 4,
                    Rating = 1,
                    Description = "Alamak, this Aerogaz 16\" wall fan damn noisy lor! Motor like got its own concert. Confirm regret, better find one quieter, can sleep better.",
                    Reply = "Hi Joshua, we’re sorry to hear about the noise issue. Please contact our support team to share more details. We’re here to help. Thanks for letting us know!",
                    DateCreated = new DateTime(2024, 1, 4, 10, 30, 45),
                    DateReplied = new DateTime(2024, 1, 6, 11, 20, 10),
                    DateUpdated = new DateTime(2024, 1, 5, 10, 49, 49),
                    ProductId = 1,
                    ConsumerId = 3
                },
                new Review
                {
                    Id = 5,
                    Rating = 5,
                    Description = "Love this water heater sia! Instant hot water, sleek design, and easy to install.",
                    Reply = "Hi Joshua, glad to hear that you are loving our product! Thank you for choosing Aerogaz.",
                    DateCreated = new DateTime(2024, 1, 24, 10, 30, 45),
                    DateReplied = new DateTime(2024, 1, 26, 11, 40, 10),
                    DateUpdated = new DateTime(2024, 1, 24, 10, 49, 49),
                    ProductId = 2,
                    ConsumerId = 3
                },
                new Review
                {
                    Id = 6,
                    Rating = 1,
                    Description = "dvjhbwedjgfjsdjvjsovnsdvkjvjovjijsifdjijhfjjfijf9fofmlxxpp-qjjfjfkj",
                    DateCreated = new DateTime(2024, 1, 21, 10, 15, 45),
                    DateUpdated = new DateTime(2024, 1, 21, 10, 15, 45),
                    ProductId = 1,
                    ConsumerId = 4
                }
            );
        }
    }
}
