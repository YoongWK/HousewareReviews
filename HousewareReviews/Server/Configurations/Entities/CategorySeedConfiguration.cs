﻿using HousewareReviews.Shared.Domain;
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
                }
            );
        }
    }
}