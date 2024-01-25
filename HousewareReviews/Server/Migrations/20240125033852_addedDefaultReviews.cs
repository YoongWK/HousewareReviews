using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HousewareReviews.Server.Migrations
{
    /// <inheritdoc />
    public partial class addedDefaultReviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateReplied",
                table: "Reviews",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

            migrationBuilder.InsertData(
                table: "Consumers",
                columns: new[] { "Id", "CommentId", "ContactNumber", "Email", "FirstName", "LastName", "NRIC", "Password", "ProfileImgUri", "ReviewId", "UserId" },
                values: new object[,]
                {
                    { 2, null, "92438900", "maymorrison@gmail.com", "May", "Morrison", "S2836518E", "P@ssword1", null, null, "9du2ii40-h7d9-8sj2-j98s-is0dh83jk48s" },
                    { 3, null, "83072245", "joshuatan@outlook.com", "Joshua", "Tan", "T8904392R", "P@ssword1", null, null, "2oh7diw9-0or5-3jf9-8ss6-ks8ya5h297bd" },
                    { 4, null, "87229044", "ethanlim@hotmail.com", "Ethan", "Lim", "T3876509Z", "P@ssword1", null, null, "5di8sy83-2i9r-f56h-s8d9-s09njsh7dd53" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Consumers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Consumers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Consumers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateReplied",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
        }
    }
}
