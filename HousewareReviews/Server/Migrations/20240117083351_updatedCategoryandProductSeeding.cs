using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HousewareReviews.Server.Migrations
{
    /// <inheritdoc />
    public partial class updatedCategoryandProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgUri", "Name" },
                values: new object[,]
                {
                    { 4, "/images/Furniture.jpg", "Furniture" },
                    { 5, "/images/HomeDecor.jpg", "Home Decor" },
                    { 6, "/images/HomeOrganisation.jpg", "Home Organisation" },
                    { 7, "/images/HomeTools.jpg", "Home Tools" },
                    { 8, "/images/Kitchen&Dining.jpg", "Kitchen & Dining" },
                    { 9, "/images/Lighting.jpg", "Lighting" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CompanyId", "Description", "ImgUri", "Name", "Price" },
                values: new object[,]
                {
                    { 3, 1, 1, "Wall Fan with 3 speeds pull-string control, left-right oscillation and has an adjustable tilting angle", null, "16\" Wall Fan (AZ-171WF)", 49.899999999999999 },
                    { 4, 1, 1, "4 blade table fan with 3 speeds and a sleek retro design.", null, "12\" Table Fan (AZ-1283TF)", 49.899999999999999 },
                    { 5, 1, 1, "Table Fan with 4 speeds and wireless mobile charging capability.", null, "6\" Table Fan w Mobile Charger (AZ-6006TF)", 32.899999999999999 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ce40de7-b2a7-4cf4-a8f3-c811191a664d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a55b145f-8137-421b-954c-2c3bcfc0fbef", "AQAAAAIAAYagAAAAEG+PsppT7/1nxHW5/oan28tnwmxaoc4DHE1kEw1+TpxWcUM4mVWtaxpJ5CLRYFzb1Q==", "5dc7993a-bc3d-4c91-a644-bf9fad6bea52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78c4ffed-46b2-4d74-919f-724252d72d4a", "AQAAAAIAAYagAAAAEPVH9sRIZYV/ilhrehncbmbGphlLidWbgLgGlFqNdMra8EjuZZEY2f5FRpdiUZB3Vg==", "24518352-65a1-4977-a506-5572b46a80c3" });
        }
    }
}
