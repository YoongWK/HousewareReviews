using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HousewareReviews.Server.Migrations
{
    /// <inheritdoc />
    public partial class updatedCategorySeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ce40de7-b2a7-4cf4-a8f3-c811191a664d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77bfa4ec-cd82-4214-aafa-d95c2a865987", "AQAAAAIAAYagAAAAEC6JBjafH12PadOH6mmf0r/YW6i8Wkk3XLzmJ4utq/agtrsnykJoIvd5NUqRCFtEbQ==", "0ef086ca-53c0-4918-a5ec-84b3cf2d51d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c46ab471-4b3e-439a-bb92-808309bdbfc2", "AQAAAAIAAYagAAAAEBkDYTRhJhqOGE5BmX7ZgLulcUVCYuHEv23w4aK4B5eYeNwGOsAlb/1heRsyHIVG0A==", "e702e473-190e-4b94-a5b6-c64034bce45c" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImgUri",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImgUri",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgUri",
                value: null);
        }
    }
}
