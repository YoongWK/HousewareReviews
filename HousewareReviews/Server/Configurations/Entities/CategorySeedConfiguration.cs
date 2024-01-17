using HousewareReviews.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Drawing;

namespace HousewareReviews.Server.Configurations.Entities
{
    public class CategorySeedConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "Appliances",
                    ImgUri = "/images/Appliances.jpg"
                },
                new Category
                {
                    Id = 2,
                    Name = "Bathroom",
                    ImgUri = "/images/Bathroom.jpg"
                },
                new Category
                {
                    Id = 3,
                    Name = "Beddings",
                    ImgUri = "/images/Beddings.jpg"
                },
                new Category
                {
                    Id = 4,
                    Name = "Furniture",
                    ImgUri = "/images/Furniture.jpg"
                },
                new Category
                {
                    Id = 5,
                    Name = "Home Decor",
                    ImgUri = "/images/HomeDecor.jpg"
                },
                new Category
                {
                    Id = 6,
                    Name = "Home Organisation",
                    ImgUri = "/images/HomeOrganisation.jpg"
                },
                new Category
                {
                    Id = 7,
                    Name = "Home Tools",
                    ImgUri = "/images/HomeTools.jpg"
                },
                new Category
                {
                    Id = 8,
                    Name = "Kitchen & Dining",
                    ImgUri = "/images/Kitchen&Dining.jpg"
                },
                new Category
                {
                    Id = 9,
                    Name = "Lighting",
                    ImgUri = "/images/Lighting.jpg"
                }
            );
        }
    }
}
