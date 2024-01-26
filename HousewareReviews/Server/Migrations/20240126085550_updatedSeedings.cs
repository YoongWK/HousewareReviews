using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HousewareReviews.Server.Migrations
{
    /// <inheritdoc />
    public partial class updatedSeedings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ce40de7-b2a7-4cf4-a8f3-c811191a664d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e219bcd-dade-42a7-83d4-e55c5b0cce0c", "AQAAAAIAAYagAAAAEBBI/spuv7wnowziQU1WZzKGcGvEGA/7B4LwY4L80tMDu6ObGW+qx366UVN1HrEL+g==", "5d38ef87-9b5b-4f4b-83d4-d8c8b057c2af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d594264-9593-44af-b434-728b3460aa1f", "AQAAAAIAAYagAAAAEI9F0g7OT4oaUyrLPSY74AH6tCM47+d/aAu3/6x3S1q36sutaWKImfYUiH72dfrd1g==", "aba0bc06-364a-4f09-b929-b5f4949119f4" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2oh7diw9-0or5-3jf9-8ss6-ks8ya5h297bd", 0, "c092a386-c04f-4d52-9a63-557e5c4a42e1", "joshuatan@outlook.com", false, false, null, "JOSHUATAN@OUTLOOK.COM", "JOSHUATAN@OUTLOOK.COM", "AQAAAAIAAYagAAAAEKaMk9M2mWhhk6Wbh/zq71OyFBvtN+/kSOIbzF3FH7mmD5ZpSozJGnEzm3uo2aNuTg==", "83072245", false, "c4aed10a-8535-4959-b198-4583e3dd88b1", false, "joshuatan@outlook.com" },
                    { "5di8sy83-2i9r-f56h-s8d9-s09njsh7dd53", 0, "c6a9cbe9-2eb6-4a07-a9ca-ed7796f066ae", "ethanlim@hotmail.com", false, false, null, "ETHANLIM@HOTMAIL.COM", "ETHANLIM@HOTMAIL.COM", "AQAAAAIAAYagAAAAENpF7ax8NIzMuMIn7kSEPuNhBha5rnuy0SR5XdhqJPK1NL3TSxMtmdC6hkvWA3SXbQ==", "87229044", false, "8a3117d0-947d-4848-9622-533f5a1f415d", false, "ethanlim@hotmail.com" },
                    { "9du2ii40-h7d9-8sj2-j98s-is0dh83jk48s", 0, "6a831e8d-4630-4223-bd73-83cacfc5c654", "maymorrison@gmail.com", false, false, null, "MAYMORRISON@GMAIL.COM", "MAYMORRISON@GMAIL.COM", "AQAAAAIAAYagAAAAEJ56WUG/j2o/mixESXqygm3ZWpExfHbbEVgNv791pD87rRbiZoix8e84yaVcot1l7w==", "92438900", false, "6b63222b-7902-46a5-a804-9507144734b4", false, "maymorrison@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Consumers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProfileImgUri",
                value: "/images/users/waikit.jpg");

            migrationBuilder.UpdateData(
                table: "Consumers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProfileImgUri",
                value: "/images/users/may.jpg");

            migrationBuilder.UpdateData(
                table: "Consumers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProfileImgUri",
                value: "/images/users/joshua.jpg");

            migrationBuilder.UpdateData(
                table: "Consumers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProfileImgUri",
                value: "/images/users/ethan.jpg");

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "ConsumerId", "DateCreated", "DateReplied", "DateUpdated", "Description", "ProductId", "Rating", "Reply" },
                values: new object[] { 6, 4, new DateTime(2024, 1, 21, 10, 15, 45, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 1, 21, 10, 15, 45, 0, DateTimeKind.Unspecified), "dvjhbwedjgfjsdjvjsovnsdvkjvjovjijsifdjijhfjjfijf9fofmlxxpp-qjjfjfkj", 1, 1, null });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProfileImgUri",
                value: "/images/users/andrina.jpg");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "2oh7diw9-0or5-3jf9-8ss6-ks8ya5h297bd" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "5di8sy83-2i9r-f56h-s8d9-s09njsh7dd53" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "9du2ii40-h7d9-8sj2-j98s-is0dh83jk48s" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "2oh7diw9-0or5-3jf9-8ss6-ks8ya5h297bd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "5di8sy83-2i9r-f56h-s8d9-s09njsh7dd53" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "9du2ii40-h7d9-8sj2-j98s-is0dh83jk48s" });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2oh7diw9-0or5-3jf9-8ss6-ks8ya5h297bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5di8sy83-2i9r-f56h-s8d9-s09njsh7dd53");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9du2ii40-h7d9-8sj2-j98s-is0dh83jk48s");

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

            migrationBuilder.UpdateData(
                table: "Consumers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProfileImgUri",
                value: null);

            migrationBuilder.UpdateData(
                table: "Consumers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProfileImgUri",
                value: null);

            migrationBuilder.UpdateData(
                table: "Consumers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProfileImgUri",
                value: null);

            migrationBuilder.UpdateData(
                table: "Consumers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProfileImgUri",
                value: null);

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProfileImgUri",
                value: null);
        }
    }
}
