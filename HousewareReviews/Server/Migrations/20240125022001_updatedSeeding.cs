using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

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
                values: new object[] { "6c770a81-8412-4080-9091-cb2b000f0367", "AQAAAAIAAYagAAAAEF3e0mcXrzToSADk7GCDn4bFvfI/TCu7FPsTax0jz2bImhAUIPJEGvhxm8iiHM7DXg==", "6056a01f-c05f-4b51-a3aa-b69899f61f14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf53766a-84c0-46d8-91cb-daaa035b1a90", "AQAAAAIAAYagAAAAEMwFYVptJwJ0Pu65FntOegKkzO/UmPy1CJ+tBo+KbL4WskEP8oC6Ic5EfPl8aMNNgA==", "b4544ef5-b9e1-4dae-a966-f4dd25a25041" });

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

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "LogoUri",
                value: "/images/companies/Dyson.jpg");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "LogoUri",
                value: "/images/companies/Electrolux.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ce40de7-b2a7-4cf4-a8f3-c811191a664d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41dc76a6-89f9-4575-813d-571194e38f7d", "AQAAAAIAAYagAAAAEA4zOY0L5G/OcapFIjG0y/5MuqGT1hwWHVe2SluryIZS+pztyGMKz6lVY5zC+uSFWw==", "b5591953-4500-4380-b90b-0942ead60a5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a537d110-1c0d-46f4-838a-35638ad68693", "AQAAAAIAAYagAAAAELvEQowBo3523PzeBtZLP8iGgLgSfx5DcLx7ihsXoUCfSR2yXJivHDaBqvXkMIu+Lw==", "7734abf8-5628-4a56-b544-1b11ebb437eb" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "LogoUri",
                value: "/images/companies/Aerogaz");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "LogoUri",
                value: "/images/companies/Cornell");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "LogoUri",
                value: "/images/companies/Dyson");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                column: "LogoUri",
                value: "/images/companies/Electrolux");
        }
    }
}
