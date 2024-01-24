﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HousewareReviews.Server.Migrations
{
    /// <inheritdoc />
    public partial class newDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgUri = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UEN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoUri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebsiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "Keys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Use = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Algorithm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsX509Certificate = table.Column<bool>(type: "bit", nullable: false),
                    DataProtected = table.Column<bool>(type: "bit", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NRIC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfileImgUri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    ImgUri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReviewId = table.Column<int>(type: "int", nullable: true),
                    ConsumerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Consumers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NRIC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfileImgUri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentId = table.Column<int>(type: "int", nullable: true),
                    ReviewId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Consumers_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reply = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateReplied = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    ConsumerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Consumers_ConsumerId",
                        column: x => x.ConsumerId,
                        principalTable: "Consumers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Outcome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewId = table.Column<int>(type: "int", nullable: true),
                    ConsumerId = table.Column<int>(type: "int", nullable: true),
                    CommentId = table.Column<int>(type: "int", nullable: true),
                    StaffId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reports_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reports_Consumers_ConsumerId",
                        column: x => x.ConsumerId,
                        principalTable: "Consumers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reports_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reports_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Staff", "STAFF" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "Consumer", "CONSUMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1ce40de7-b2a7-4cf4-a8f3-c811191a664d", 0, "4c759886-9797-4593-a7d5-c0680ca3ff6b", "consumer@blazor.com", false, false, null, "CONSUMER@BLAZOR.COM", "CONSUMER@BLAZOR.COM", "AQAAAAIAAYagAAAAEL/YIyly/KqPhs3oon0bwb/KpHVMUFOe17NO7mI/t5qkibccYuANqzFH/qygJzdtoA==", null, false, "8194b206-ce16-4e41-80d7-d528e8663550", false, "consumer@blazor.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "0095ce20-ecc7-486b-af87-bc02d946e05e", "staff@blazor.com", false, false, null, "STAFF@BLAZOR.COM", "STAFF@BLAZOR.COM", "AQAAAAIAAYagAAAAEI+9YNQivLbdn5UY81M5g+WotsRsj/B220SLLs5xyeLOXCXcT+276nELBPouGB86oQ==", null, false, "15d2656a-d10a-47ab-809e-2ac404090232", false, "staff@blazor.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUri", "Name" },
                values: new object[,]
                {
                    { 1, "/images/categories/Appliances.jpg", "Appliances" },
                    { 2, "/images/categories/Bathroom.jpg", "Bathroom" },
                    { 3, "/images/categories/Beddings.jpg", "Beddings" },
                    { 4, "/images/categories/Furniture.jpg", "Furniture" },
                    { 5, "/images/categories/HomeDecor.jpg", "Home Decor" },
                    { 6, "/images/categories/HomeOrganisation.jpg", "Home Organisation" },
                    { 7, "/images/categories/HomeTools.jpg", "Home Tools" },
                    { 8, "/images/categories/Kitchen&Dining.jpg", "Kitchen & Dining" },
                    { 9, "/images/categories/Lighting.jpg", "Lighting" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "ContactNumber", "Description", "Email", "LogoUri", "Name", "UEN", "WebsiteUrl" },
                values: new object[,]
                {
                    { 1, "67469933", "Leading home appliance brand for high-quality and affordable hobs, hoods, and instant water heaters.", "enquiry@aerogaz.com", "data:image/png;base64,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", "Aerogaz", "200302472K", "https://aerogaz.com/" },
                    { 2, "64726500", "Singapore-based company for quality & affordable home appliances and consumer electronics.", "sg.support@cornellappliances.com", "data:image/png;base64,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", "Cornell", "200310215D", "https://sg.cornellappliances.com/" },
                    { 3, "67195413", "Renowned company famous for its innovative vacuum cleaners, hand dryers, & bladeless fans.", "sg.service@dyson.com", "data:image/png;base64,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", "Dyson", "197000473M", "https://www.dyson.com.sg/" },
                    { 4, "67273699", "Recognised global appliance brand for high-quality home and kitchen appliances.", "customer-care.sin@electrolux.com", "data:image/png;base64,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", "Electrolux", "200310215D", "https://www.electrolux.com.sg/" }
                });

            migrationBuilder.InsertData(
                table: "Consumers",
                columns: new[] { "Id", "CommentId", "ContactNumber", "Email", "FirstName", "LastName", "NRIC", "Password", "ProfileImgUri", "ReviewId", "UserId" },
                values: new object[] { 1, null, "98765432", "consumer@blazor.com", "Yoong", "Wai kit", "S9067028Z", "P@ssword1", null, null, "1ce40de7-b2a7-4cf4-a8f3-c811191a664d" });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "ContactNumber", "Email", "FirstName", "LastName", "NRIC", "Password", "ProfileImgUri", "UserId" },
                values: new object[] { 1, "91234567", "staff@blazor.com", "Andrina", "Morrison", "S9372136E", "P@ssword1", null, "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "1ce40de7-b2a7-4cf4-a8f3-c811191a664d" },
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CompanyId", "Description", "ImgUri", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, 1, "Modern wall fan featuring a powerful motor with 3-speed control for customized airflow.", "/images/products/az173wf.jpg", "16\" Wall Fan (AZ-173WF)", 39.899999999999999 },
                    { 2, 2, 1, "Ultra slim water heater with splash-proof IPX5, anti scald device, & 5 shower options.", "/images/products/s895.jpg", "Instant Water Heater – Slim Series (S895)", 169.0 },
                    { 3, 1, 1, "Wall Fan with 3 speeds pull-string control, left-right oscillation and has an adjustable tilting angle", "/images/products/az171wf.jpg", "16\" Wall Fan (AZ-171WF)", 49.899999999999999 },
                    { 4, 1, 1, "4 blade table fan with 3 speeds and a sleek retro design.", "/images/products/az1283tf.jpg", "12\" Table Fan (AZ-1283TF)", 49.899999999999999 },
                    { 5, 1, 1, "Table Fan with 4 speeds and wireless mobile charging capability.", "/images/products/az6006tf.jpg", "6\" Table Fan w Mobile Charger (AZ-6006TF)", 32.899999999999999 },
                    { 6, 8, 1, "Durable high capacity 2-tier steamer with adjustable time & detachable steam tray.", "/images/products/az366st.jpg", "2-Tier Multi-function Steamer (AZ-366ST)", 59.0 },
                    { 7, 8, 1, "Effective slim hood with 3-speed control, powerful extraction, efficient filtering, & re-circulation mode.", "/images/products/az6880.jpg", "60cm Slim Hood (AZ-6880)", 230.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ConsumerId",
                table: "Comments",
                column: "ConsumerId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ReviewId",
                table: "Comments",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Consumers_CommentId",
                table: "Consumers",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Consumers_ReviewId",
                table: "Consumers",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_Keys_Use",
                table: "Keys",
                column: "Use");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_ConsumedTime",
                table: "PersistedGrants",
                column: "ConsumedTime");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CompanyId",
                table: "Products",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_CommentId",
                table: "Reports",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ConsumerId",
                table: "Reports",
                column: "ConsumerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ReviewId",
                table: "Reports",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_StaffId",
                table: "Reports",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ConsumerId",
                table: "Reviews",
                column: "ConsumerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Consumers_ConsumerId",
                table: "Comments",
                column: "ConsumerId",
                principalTable: "Consumers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Reviews_ReviewId",
                table: "Comments",
                column: "ReviewId",
                principalTable: "Reviews",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Consumers_Reviews_ReviewId",
                table: "Consumers",
                column: "ReviewId",
                principalTable: "Reviews",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Consumers_ConsumerId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Consumers_ConsumerId",
                table: "Reviews");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "Keys");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Consumers");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
