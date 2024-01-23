using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HousewareReviews.Server.Migrations
{
    /// <inheritdoc />
    public partial class updatedSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ce40de7-b2a7-4cf4-a8f3-c811191a664d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2598b931-ab05-4737-96b6-ed933c75d0dc", "AQAAAAIAAYagAAAAEKPDHNKYIR154FS2jlAsP3NklC0wgi7/HGiCCfBeuLQUXUy8mhw/imGqohxOy3m6Tw==", "e2270cd3-90a9-493c-a4b0-cd67975dc2e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f54b81e6-e51a-46bf-b4d4-8e32c218fcd3", "AQAAAAIAAYagAAAAEG+o8grhWk4pEF7dMIEUaTp4cY9FYyq3BCw3/MlDGOJv5sXmZ9NWQACUFxoYN08umg==", "9136ca99-79bc-4bd5-bf21-822df6ec1e24" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImgUri",
                value: "/images/categories/Appliances.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImgUri",
                value: "/images/categories/Bathroom.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgUri",
                value: "/images/categories/Beddings.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImgUri",
                value: "/images/categories/Furniture.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImgUri",
                value: "/images/categories/HomeDecor.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImgUri",
                value: "/images/categories/HomeOrganisation.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImgUri",
                value: "/images/categories/HomeTools.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImgUri",
                value: "/images/categories/Kitchen&Dining.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImgUri",
                value: "/images/categories/Lighting.jpg");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "LogoUri",
                value: "/images/companies/Aerogaz.jpg");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "LogoUri",
                value: "/images/companies/Cornell.jpg");

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "ContactNumber", "Description", "Email", "LogoUri", "Name", "UEN", "WebsiteUrl" },
                values: new object[,]
                {
                    { 3, "67195413", "Renowned company famous for its innovative vacuum cleaners, hand dryers, & bladeless fans.", "sg.service@dyson.com", "/images/companies/Dyson.jpg", "Dyson", "197000473M", "https://www.dyson.com.sg/" },
                    { 4, "67273699", "Recognised global appliance brand for high-quality home and kitchen appliances.", "customer-care.sin@electrolux.com", "/images/companies/Electrolux.jpg", "Electrolux", "200310215D", "https://www.electrolux.com.sg/" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImgUri",
                value: "/images/products/az173wf.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImgUri",
                value: "/images/products/s895.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgUri",
                value: "/images/products/az171wf.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImgUri",
                value: "/images/products/az1283tf.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImgUri",
                value: "/images/products/az6006tf.jpg");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CompanyId", "Description", "ImgUri", "Name", "Price" },
                values: new object[,]
                {
                    { 6, 8, 1, "Durable high capacity 2-tier steamer with adjustable time & detachable steam tray.", "/images/products/az366st.jpg", "2-Tier Multi-function Steamer (AZ-366ST)", 59.0 },
                    { 7, 8, 1, "Effective slim hood with 3-speed control, powerful extraction, efficient filtering, & re-circulation mode.", "/images/products/az6880.jpg", "60cm Slim Hood (AZ-6880)", 230.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ce40de7-b2a7-4cf4-a8f3-c811191a664d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "daaee414-3d2a-432b-bb8e-4a7f313b9f50", "AQAAAAIAAYagAAAAEA+1/ztaOiKHTiMsYC0dHqOgATzG6Vokd2KeBBIYyJIf6plFPJZB6OeGwC/5pGOoLw==", "1c27a53c-dca7-4dff-b399-d5b145f18dad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "159a5410-cbff-453d-bc0c-bcf887fc515e", "AQAAAAIAAYagAAAAEMyhnONzYTH1ucgHCApoBZgfc8sGBY/b9wJZYkYCBazrOTcnnML7c/7OQbErldUykA==", "28b3c195-927c-40a8-9738-7094fe0e4daa" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImgUri",
                value: "/images/Appliances.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImgUri",
                value: "/images/Bathroom.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgUri",
                value: "/images/Beddings.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImgUri",
                value: "/images/Furniture.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImgUri",
                value: "/images/HomeDecor.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImgUri",
                value: "/images/HomeOrganisation.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImgUri",
                value: "/images/HomeTools.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImgUri",
                value: "/images/Kitchen&Dining.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImgUri",
                value: "/images/Lighting.jpg");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "LogoUri",
                value: "/images/Aerogaz.jpg");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "LogoUri",
                value: "/images/Cornell.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImgUri",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImgUri",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgUri",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImgUri",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImgUri",
                value: null);
        }
    }
}
