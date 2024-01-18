using HousewareReviews.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

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
                    ImgUri = "/images/products/az173wf.jpg",
                    CompanyId = 1,
                    CategoryId = 1,
                },
                new Product
                {
                    Id = 2,
                    Name = "Instant Water Heater – Slim Series (S895)",
                    Description = "Ultra slim water heater with splash-proof IPX5, anti scald device, & 5 shower options.",
                    Price = 169,
                    ImgUri = "/images/products/s895.jpg",
                    CompanyId = 1,
                    CategoryId = 2,
                },
                new Product
                {
                    Id = 3,
                    Name = "16\" Wall Fan (AZ-171WF)",
                    Description = "Wall Fan with 3 speeds pull-string control, left-right oscillation and has an adjustable tilting angle",
                    Price = 49.90,
                    ImgUri = "/images/products/az171wf.jpg",
                    CompanyId = 1,
                    CategoryId = 1,
                },
                new Product
                {
                    Id = 4,
                    Name = "12\" Table Fan (AZ-1283TF)",
                    Description = "4 blade table fan with 3 speeds and a sleek retro design.",
                    Price = 49.90,
                    ImgUri = "/images/products/az1283tf.jpg",
                    CompanyId = 1,
                    CategoryId = 1,
                },
                new Product
                {
                    Id = 5,
                    Name = "6\" Table Fan w Mobile Charger (AZ-6006TF)",
                    Description = "Table Fan with 4 speeds and wireless mobile charging capability.",
                    Price = 32.90,
                    ImgUri = "/images/products/az6006tf.jpg",
                    CompanyId = 1,
                    CategoryId = 1,
                },
                new Product
                {
                    Id = 6,
                    Name = "2-Tier Multi-function Steamer (AZ-366ST)",
                    Description = "Durable high capacity 2-tier steamer with adjustable time & detachable steam tray.",
                    Price = 59.00,
                    ImgUri = "/images/products/az366st.jpg",
                    CompanyId = 1,
                    CategoryId = 8,
                },
                new Product
                {
                    Id = 7,
                    Name = "60cm Slim Hood (AZ-6880)",
                    Description = "Effective slim hood with 3-speed control, powerful extraction, efficient filtering, & re-circulation mode.",
                    Price = 230.00,
                    ImgUri = "/images/products/az6880.jpg",
                    CompanyId = 1,
                    CategoryId = 8,
                }
            );
        }
    }
}
