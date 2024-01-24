﻿using HousewareReviews.Shared.Domain;
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
                    LogoUri = "/images/companies/Aerogaz",
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
                    LogoUri = "/images/companies/Cornell",
                    WebsiteUrl = "https://sg.cornellappliances.com/"
                },
                new Company
                {
                    Id = 3,
                    Name = "Dyson",
                    UEN = "197000473M",
                    Email = "sg.service@dyson.com",
                    ContactNumber = "67195413",
                    Description = "Renowned company famous for its innovative vacuum cleaners, hand dryers, & bladeless fans.",
                    LogoUri = "/images/companies/Dyson",
                    WebsiteUrl = "https://www.dyson.com.sg/"
                },
                new Company
                {
                    Id = 4,
                    Name = "Electrolux",
                    UEN = "200310215D",
                    Email = "customer-care.sin@electrolux.com",
                    ContactNumber = "67273699",
                    Description = "Recognised global appliance brand for high-quality home and kitchen appliances.",
                    LogoUri = "/images/companies/Electrolux",
                    WebsiteUrl = "https://www.electrolux.com.sg/"
                }
            );
        }
    }
}
