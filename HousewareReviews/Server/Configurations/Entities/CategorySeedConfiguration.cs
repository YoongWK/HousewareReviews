using HousewareReviews.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HousewareReviews.Server.Configurations.Entities
{
    public class CategorySeedConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            // Seed the database with initial data for the Category entity
            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "Appliances",
                    ImgUri = "/images/categories/Appliances.jpg"
                },
                new Category
                {
                    Id = 2,
                    Name = "Bathroom",
                    ImgUri = "/images/categories/Bathroom.jpg"
                },
                new Category
                {
                    Id = 3,
                    Name = "Beddings",
                    ImgUri = "/images/categories/Beddings.jpg"
                },
                new Category
                {
                    Id = 4,
                    Name = "Furniture",
                    ImgUri = "/images/categories/Furniture.jpg"
                },
                new Category
                {
                    Id = 5,
                    Name = "Home Decor",
                    ImgUri = "/images/categories/HomeDecor.jpg"
                },
                new Category
                {
                    Id = 6,
                    Name = "Home Organisation",
                    ImgUri = "/images/categories/HomeOrganisation.jpg"
                },
                new Category
                {
                    Id = 7,
                    Name = "Home Tools",
                    ImgUri = "/images/categories/HomeTools.jpg"
                },
                new Category
                {
                    Id = 8,
                    Name = "Kitchen & Dining",
                    ImgUri = "/images/categories/Kitchen&Dining.jpg"
                },
                new Category
                {
                    Id = 9,
                    Name = "Lighting",
                    ImgUri = "/images/categories/Lighting.jpg"
                }
            );
        }
    }
}
