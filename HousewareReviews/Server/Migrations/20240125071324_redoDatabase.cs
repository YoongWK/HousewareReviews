using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HousewareReviews.Server.Migrations
{
    /// <inheritdoc />
    public partial class redoDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ce40de7-b2a7-4cf4-a8f3-c811191a664d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c6773f3-05f0-4e22-a590-0d16d862fc50", "AQAAAAIAAYagAAAAELNo7lr0cfg6TSMS3D7XmdJYi9rN1wcW1FQ51tXdrwHcvSUtFW0TJYGYQj1snqzIig==", "43ab68c2-9dd6-4665-883f-38647e343a06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a279016c-9e16-471c-b7c5-5b3f70913b4a", "AQAAAAIAAYagAAAAEDqV4mkJBv54XT3BjDsUt063ehvM0eTJd/S3TU1734ITXJ0FraoYTWdpCGqv40AhRA==", "c6904dbc-d2ac-4e8c-add0-1a467a67147f" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "ConsumerId", "DateCreated", "DateReplied", "DateUpdated", "Description", "ProductId", "Rating", "Reply" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2023, 12, 25, 10, 30, 45, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 28, 11, 20, 10, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 25, 10, 30, 45, 0, DateTimeKind.Unspecified), "This Aerogaz wall fan, power sia! Confirm plus chop the motor very solid. Really shiok for beating the heat. No kidding.", 1, 5, "Hey Ethan, awesome to hear you’re loving our wall fan. Stay cool and thanks for choosing Aerogaz!" },
                    { 2, 2, new DateTime(2024, 1, 2, 10, 30, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 11, 20, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 10, 30, 45, 0, DateTimeKind.Unspecified), "The fan does its job in cooling the place down. But always got a hum sound, need to tahan the extra background melody.", 1, 3, "Hello May, appreciate your honest review! We’re sorry to hear about the hum and we’ll look into improving this issue. If you have more details to share, hit us up. Thanks!" },
                    { 3, 1, new DateTime(2024, 1, 2, 14, 30, 45, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 2, 14, 30, 45, 0, DateTimeKind.Unspecified), "Reliable fan. Good choice for staying cool.", 1, 4, null },
                    { 4, 3, new DateTime(2024, 1, 4, 10, 30, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 11, 20, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 10, 49, 49, 0, DateTimeKind.Unspecified), "Alamak, this Aerogaz 16\" wall fan damn noisy lor! Motor like got its own concert. Confirm regret, better find one quieter, can sleep better.", 1, 1, "Hi Joshua, we’re sorry to hear about the noise issue. Please contact our support team to share more details. We’re here to help. Thanks for letting us know!" },
                    { 5, 3, new DateTime(2024, 1, 24, 10, 30, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 11, 40, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 10, 49, 49, 0, DateTimeKind.Unspecified), "Love this water heater sia! Instant hot water, sleek design, and easy to install.", 2, 5, "Hi Joshua, glad to hear that you are loving our product! Thank you for choosing Aerogaz." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ce40de7-b2a7-4cf4-a8f3-c811191a664d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "357acb70-142d-4dcf-ad33-aa680c36a76b", "AQAAAAIAAYagAAAAEE/Vxj71ZrDt+jkxtxPE6bD517estLj5YSsc/og0ZoFSIFi/yDxmeqYur9aPpB5Kxw==", "4cbb4c24-4947-40b6-8f42-d0229f186d93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c67cfe4b-71e9-4d93-94f7-f8e905c5331f", "AQAAAAIAAYagAAAAEC2fyObcH+c8y2y3O5bhRLKkYXharfc80HdYznHzfIwy3PIqtgZunoe8v7l6ynt9Bw==", "e0999fdf-d884-4ae1-b1bc-0ee42bf992b4" });
        }
    }
}
