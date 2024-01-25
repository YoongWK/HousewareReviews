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
                },
                new Consumer
                {
                    Id = 2,
                    UserId = "9du2ii40-h7d9-8sj2-j98s-is0dh83jk48s",
                    FirstName = "May",
                    LastName = "Morrison",
                    NRIC = "S2836518E",
                    Email = "maymorrison@gmail.com",
                    ContactNumber = "92438900",
                    Password = "P@ssword1"
                },
                new Consumer
                {
                    Id = 3,
                    UserId = "2oh7diw9-0or5-3jf9-8ss6-ks8ya5h297bd",
                    FirstName = "Joshua",
                    LastName = "Tan",
                    NRIC = "T8904392R",
                    Email = "joshuatan@outlook.com",
                    ContactNumber = "83072245",
                    Password = "P@ssword1"
                },
                new Consumer
                {
                    Id = 4,
                    UserId = "5di8sy83-2i9r-f56h-s8d9-s09njsh7dd53",
                    FirstName = "Ethan",
                    LastName = "Lim",
                    NRIC = "T3876509Z",
                    Email = "ethanlim@hotmail.com",
                    ContactNumber = "87229044",
                    Password = "P@ssword1"
                }
            );
        }
    }
}
