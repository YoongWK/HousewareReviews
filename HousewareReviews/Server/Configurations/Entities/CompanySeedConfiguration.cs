using HousewareReviews.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Drawing;
namespace HousewareReviews.Server.Configurations.Entities
{
    public class CompanySeedConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
                new Company
                {
                    Id = 1,
                    Name = "Aerogaz",
                    UEN = "200302472K",
                    Email = "enquiry@aerogaz.com",
                    ContactNumber = "67469933",
                    Description = "Leading home appliance brand for high-quality and affordable hobs, hoods, and instant water heaters.",
                    LogoUri = null,
                    WebsiteUrl = "https://aerogaz.com/"
                },
                new Company
                {
                    Id = 2,
                    Name = "Cornell",
                    UEN = "200310215D",
                    Email = "sg.support@cornellappliances.com",
                    ContactNumber = "64726500",
                    Description = "Singapore-based company for quality & affordable home appliances and consumer electronics.",
                    LogoUri = null,
                    WebsiteUrl = "https://sg.cornellappliances.com/"
                }
            );
        }
    }
}
