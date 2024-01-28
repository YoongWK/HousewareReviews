using System;
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
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumers", x => x.Id);
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
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    UsefulCnt = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateReplied = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ConsumerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Consumers_ConsumerId",
                        column: x => x.ConsumerId,
                        principalTable: "Consumers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    UsefulCnt = table.Column<int>(type: "int", nullable: true),
                    ReviewId = table.Column<int>(type: "int", nullable: false),
                    ConsumerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Consumers_ConsumerId",
                        column: x => x.ConsumerId,
                        principalTable: "Consumers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Comments_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviewreports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Outcome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsumerId = table.Column<int>(type: "int", nullable: true),
                    ReviewId = table.Column<int>(type: "int", nullable: true),
                    StaffId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviewreports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviewreports_Consumers_ConsumerId",
                        column: x => x.ConsumerId,
                        principalTable: "Consumers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Reviewreports_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Reviewreports_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Commentreports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Outcome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsumerId = table.Column<int>(type: "int", nullable: true),
                    CommentId = table.Column<int>(type: "int", nullable: true),
                    StaffId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commentreports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Commentreports_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Commentreports_Consumers_ConsumerId",
                        column: x => x.ConsumerId,
                        principalTable: "Consumers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Commentreports_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
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
                    { "1ce40de7-b2a7-4cf4-a8f3-c811191a664d", 0, "387cbae0-3d66-4a37-991e-68cb5061d08b", "consumer@blazor.com", false, false, null, "CONSUMER@BLAZOR.COM", "T1234567A", "AQAAAAIAAYagAAAAEJA7I9H8Ij0dybyZInTuJoCna/8mBGh+VZTt2vjkeTlvPN3a13osdyjkkNz08aTfKg==", "98765432", false, "e492ed2a-0b3f-4192-a17a-0b04c53a22b1", false, "T1234567A" },
                    { "2oh7diw9-0or5-3jf9-8ss6-ks8ya5h297bd", 0, "ec40f65f-b3b7-4099-8ecf-4331e8d6d038", "joshuatan@outlook.com", false, false, null, "JOSHUATAN@OUTLOOK.COM", "T9366538J", "AQAAAAIAAYagAAAAEFB3OsCTein32v+mEl5DVQa8saLeqjtQoRF07dMA+NsPmuvOgg0GzQus/lHuTpHb8w==", "83072245", false, "d8cc5637-0845-49af-866d-404d89d6a49c", false, "T9366538J" },
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "8f488644-c07f-41fb-876b-ecb84b22facb", "staff@blazor.com", false, false, null, "STAFF@BLAZOR.COM", "S1234567A", "AQAAAAIAAYagAAAAEBigObR90muYTekVeyoMxid7GwIv0dZWNbIou/J2QiFxl3XLcoQI3a1cTriqpufttA==", "91234567", false, "209a02f7-e750-4168-a841-6219ce8dc4e2", false, "S1234567A" },
                    { "5di8sy83-2i9r-f56h-s8d9-s09njsh7dd53", 0, "77220a40-c264-44df-8913-6a23f1e00a07", "ethanlim@hotmail.com", false, false, null, "ETHANLIM@HOTMAIL.COM", "S9812704F", "AQAAAAIAAYagAAAAEAqYSlIUG3O7i+x2T9axGPIiJOVwOJ1Ll6nIPFWm5Zctlgh03LHRQ70AOJ5oNMJ9OQ==", "87229044", false, "8da5cb4a-80cd-4698-80f0-7e1bd2ff83c5", false, "S9812704F" },
                    { "9du2ii40-h7d9-8sj2-j98s-is0dh83jk48s", 0, "11615762-0610-4a0e-af15-f8a248b006b3", "maymorrison@gmail.com", false, false, null, "MAYMORRISON@GMAIL.COM", "S6523489J", "AQAAAAIAAYagAAAAEAfJdChv4j/XISuiOV/Imnwa03k7aqYtHrQrIgE9DUW1y3KGDZFvRChjVMtdv2iFgg==", "92438900", false, "005d30df-623e-40b7-84d8-7b82ebc7cb30", false, "S6523489J" }
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
                    { 1, "67469933", "Leading home appliance brand for high-quality and affordable hobs, hoods, and instant water heaters.", "enquiry@aerogaz.com", "/images/companies/Aerogaz.jpg", "Aerogaz", "200302472K", "https://aerogaz.com/" },
                    { 2, "64726500", "Singapore-based company for quality & affordable home appliances and consumer electronics.", "sg.support@cornellappliances.com", "/images/companies/Cornell.jpg", "Cornell", "200310215D", "https://sg.cornellappliances.com/" },
                    { 3, "67195413", "Renowned company famous for its innovative vacuum cleaners, hand dryers, & bladeless fans.", "sg.service@dyson.com", "/images/companies/Dyson.jpg", "Dyson", "197000473M", "https://www.dyson.com.sg/" },
                    { 4, "67273699", "Recognised global appliance brand for high-quality home and kitchen appliances.", "customer-care.sin@electrolux.com", "/images/companies/Electrolux.jpg", "Electrolux", "200310215D", "https://www.electrolux.com.sg/" }
                });

            migrationBuilder.InsertData(
                table: "Consumers",
                columns: new[] { "Id", "ContactNumber", "Email", "FirstName", "LastName", "NRIC", "Password", "ProfileImgUri", "UserId" },
                values: new object[,]
                {
                    { 1, "98765432", "consumer@blazor.com", "Yoong", "Wai Kit", "T1234567A", "P@ssword1", "/images/users/waikit.jpg", "1ce40de7-b2a7-4cf4-a8f3-c811191a664d" },
                    { 2, "92438900", "maymorrison@gmail.com", "May", "Morrison", "S6523489J", "P@ssword1", "/images/users/may.jpg", "9du2ii40-h7d9-8sj2-j98s-is0dh83jk48s" },
                    { 3, "83072245", "joshuatan@outlook.com", "Joshua", "Tan", "T9366538J", "P@ssword1", "/images/users/joshua.jpg", "2oh7diw9-0or5-3jf9-8ss6-ks8ya5h297bd" },
                    { 4, "87229044", "ethanlim@hotmail.com", "Ethan", "Lim", "S9812704F", "P@ssword1", "/images/users/ethan.jpg", "5di8sy83-2i9r-f56h-s8d9-s09njsh7dd53" }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "ContactNumber", "Email", "FirstName", "LastName", "NRIC", "Password", "ProfileImgUri", "UserId" },
                values: new object[] { 1, "91234567", "staff@blazor.com", "Andrina", "Morrison", "S1234567A", "P@ssword1", "/images/users/andrina.jpg", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "1ce40de7-b2a7-4cf4-a8f3-c811191a664d" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "2oh7diw9-0or5-3jf9-8ss6-ks8ya5h297bd" },
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "5di8sy83-2i9r-f56h-s8d9-s09njsh7dd53" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "9du2ii40-h7d9-8sj2-j98s-is0dh83jk48s" }
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

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "ConsumerId", "DateCreated", "DateReplied", "DateUpdated", "Description", "ProductId", "Rating", "Reply", "UsefulCnt" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2023, 12, 25, 10, 30, 45, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 28, 11, 20, 10, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 25, 10, 30, 45, 0, DateTimeKind.Unspecified), "This Aerogaz wall fan, power sia! Confirm plus chop the motor very solid. Really shiok for beating the heat. No kidding.", 1, 5, "Hey Ethan, awesome to hear you’re loving our wall fan. Stay cool and thanks for choosing Aerogaz!", null },
                    { 2, 2, new DateTime(2024, 1, 2, 10, 30, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 11, 20, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 10, 30, 45, 0, DateTimeKind.Unspecified), "The fan does its job in cooling the place down. But always got a hum sound, need to tahan the extra background melody.", 1, 3, "Hello May, appreciate your honest review! We’re sorry to hear about the hum and we’ll look into improving this issue. If you have more details to share, hit us up. Thanks!", null },
                    { 3, 1, new DateTime(2024, 1, 2, 14, 30, 45, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 2, 14, 30, 45, 0, DateTimeKind.Unspecified), "Reliable fan. Good choice for staying cool.", 1, 4, null, null },
                    { 4, 3, new DateTime(2024, 1, 4, 10, 30, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 11, 20, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 10, 49, 49, 0, DateTimeKind.Unspecified), "Alamak, this Aerogaz 16\" wall fan damn noisy lor! Motor like got its own concert. Confirm regret, better find one quieter, can sleep better.", 1, 1, "Hi Joshua, we’re sorry to hear about the noise issue. Please contact our support team to share more details. We’re here to help. Thanks for letting us know!", null },
                    { 5, 3, new DateTime(2024, 1, 24, 10, 30, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 11, 40, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 10, 49, 49, 0, DateTimeKind.Unspecified), "Love this water heater sia! Instant hot water, sleek design, and easy to install.", 2, 5, "Hi Joshua, glad to hear that you are loving our product! Thank you for choosing Aerogaz.", null },
                    { 6, 4, new DateTime(2024, 1, 21, 10, 15, 45, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 21, 10, 15, 45, 0, DateTimeKind.Unspecified), "dvjhbwedjgfjsdjvjsovnsdvkjvjovjijsifdjijhfjjfijf9fofmlxxpp-qjjfjfkj", 1, 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ConsumerId", "DateCreated", "DateUpdated", "Description", "ReviewId", "UsefulCnt" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2024, 1, 6, 15, 32, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 15, 32, 40, 0, DateTimeKind.Unspecified), "Agreed! The Aerogaz 16” wall fan is way too noisy. Regretted buying it. Found a quieter one for better sleep.", 4, null },
                    { 2, 2, new DateTime(2024, 1, 6, 15, 32, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 15, 32, 40, 0, DateTimeKind.Unspecified), "Absolutely agree! It's a game-changer!", 5, null },
                    { 3, 3, new DateTime(2024, 1, 17, 15, 10, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 15, 10, 40, 0, DateTimeKind.Unspecified), ":#%#&%”?*%”#%6", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Reviewreports",
                columns: new[] { "Id", "Category", "ConsumerId", "Description", "Outcome", "ReviewId", "StaffId" },
                values: new object[] { 1, "Spam", 1, "Irrelevant gibberish review", "Pending", 6, null });

            migrationBuilder.InsertData(
                table: "Commentreports",
                columns: new[] { "Id", "Category", "CommentId", "ConsumerId", "Description", "Outcome", "StaffId" },
                values: new object[] { 1, "Spam", 3, 1, "Unhelpful comment that serves no purpose", "Pending", null });

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
                name: "IX_Commentreports_CommentId",
                table: "Commentreports",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Commentreports_ConsumerId",
                table: "Commentreports",
                column: "ConsumerId");

            migrationBuilder.CreateIndex(
                name: "IX_Commentreports_StaffId",
                table: "Commentreports",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ConsumerId",
                table: "Comments",
                column: "ConsumerId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ReviewId",
                table: "Comments",
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
                name: "IX_Reviewreports_ConsumerId",
                table: "Reviewreports",
                column: "ConsumerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviewreports_ReviewId",
                table: "Reviewreports",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviewreports_StaffId",
                table: "Reviewreports",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ConsumerId",
                table: "Reviews",
                column: "ConsumerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "Commentreports");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "Keys");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "Reviewreports");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Consumers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
