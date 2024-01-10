using HousewareReviews.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Drawing;

namespace HousewareReviews.Server.Configurations.Entities
{
    public class ProductSeedConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "16\" Wall Fan (AZ-173WF)",
                    Description = "Modern wall fan featuring a powerful motor with 3-speed control for customized airflow.",
                    Price = 39.90,
                    ImgUri = null,
                    CompanyId = 1,
                    CategoryId = 1,
                },
                new Product
                {
                    Id = 2,
                    Name = "Instant Water Heater – Slim Series (S895)",
                    Description = "Ultra slim water heater with splash-proof IPX5, anti scald device, & 5 shower options.",
                    Price = 169,
                    ImgUri = null,
                    CompanyId = 1,
                    CategoryId = 2,
                }
            );
        }
    }
}
