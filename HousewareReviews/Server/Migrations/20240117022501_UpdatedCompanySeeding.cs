using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HousewareReviews.Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedCompanySeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ce40de7-b2a7-4cf4-a8f3-c811191a664d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a2d7250-f4b0-4094-a938-634a31b19d34", "AQAAAAIAAYagAAAAEH4yyc9c3mKX9dfAcUPzY8ScAFzr6wXjR5IUlr5gRPEJIzKQRps09NIbh7TaG+TUlw==", "5d4e36a5-f14c-4451-a80e-febb1fe913b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "782ffd7b-1d1b-4373-b4f7-2896689a4406", "AQAAAAIAAYagAAAAEJZ3TvgOBUB7AUJgnldCIreDyseLZECYWZr6cKfW+wDraJI4RSWiq4bej9w1UuWpbQ==", "20bba2a7-4ce4-4165-a395-94cc3defb567" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "LogoUri",
                value: null);

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "LogoUri",
                value: null);
        }
    }
}
