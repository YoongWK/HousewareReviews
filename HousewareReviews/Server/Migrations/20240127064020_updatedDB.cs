using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HousewareReviews.Server.Migrations
{
    /// <inheritdoc />
    public partial class updatedDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ce40de7-b2a7-4cf4-a8f3-c811191a664d",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a85f3d2e-53a5-407b-b62f-acfd3babeab5", "T1234567A", "AQAAAAIAAYagAAAAEPz6a5Wf0JJZlzstMZSZQLLvtQntoUTT1/XNOA6H1KTDEnfb6TNUwO3RIzfBHpB/WA==", "4481dba3-1206-44ea-a18a-18dc50f81586", "T1234567A" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2oh7diw9-0or5-3jf9-8ss6-ks8ya5h297bd",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "dc96c937-72d6-4687-a22c-d63ca5cfc1ae", "T9366538J", "AQAAAAIAAYagAAAAEJ+127pKIXHRs9g/AI/D66cRDGAs/O004m567qRElfnyUCiQZQv65T4YDtPTyB/Jcw==", "b00cd492-1186-4ce9-8223-90e4eeb22d71", "T9366538J" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "090ed106-db07-4afa-ba66-4f4111b20f2b", "S1234567A", "AQAAAAIAAYagAAAAEE3PRtSyHv+RXzZVegzcQe/pUnWR1NIw7JOmBo3JH1Dml9N/2TYrJgQ69aBDOxKzFw==", "7923cd1d-95a4-4c21-8e97-56535c6707a2", "S1234567A" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5di8sy83-2i9r-f56h-s8d9-s09njsh7dd53",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "625561d4-9301-4c9c-85b6-94a08896cd1f", "S9812704F", "AQAAAAIAAYagAAAAEO/qIJWLPwMJITrCvkWUqciAWoRI7zrtBzSeGbi4uZcH3gKGnNevxxRg2XDP/BuwKQ==", "d4042e81-8ddb-4e1c-b488-79f631afaee5", "S9812704F" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9du2ii40-h7d9-8sj2-j98s-is0dh83jk48s",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c7fb55cf-0d46-4463-8223-664babcc3f40", "S6523489J", "AQAAAAIAAYagAAAAEHX+gaivtJnUk3siK70Sv+GV0O2Aaeqd69T+hD8WR2tIpJ+Mytf7GkfGTHWPL1i/Cg==", "d43a20bd-9405-4294-9906-f13bc80e37f1", "S6523489J" });

            migrationBuilder.UpdateData(
                table: "Consumers",
                keyColumn: "Id",
                keyValue: 1,
                column: "NRIC",
                value: "T1234567A");

            migrationBuilder.UpdateData(
                table: "Consumers",
                keyColumn: "Id",
                keyValue: 2,
                column: "NRIC",
                value: "S6523489J");

            migrationBuilder.UpdateData(
                table: "Consumers",
                keyColumn: "Id",
                keyValue: 3,
                column: "NRIC",
                value: "T9366538J");

            migrationBuilder.UpdateData(
                table: "Consumers",
                keyColumn: "Id",
                keyValue: 4,
                column: "NRIC",
                value: "S9812704F");

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "NRIC",
                value: "S1234567A");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ce40de7-b2a7-4cf4-a8f3-c811191a664d",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9e219bcd-dade-42a7-83d4-e55c5b0cce0c", "CONSUMER@BLAZOR.COM", "AQAAAAIAAYagAAAAEBBI/spuv7wnowziQU1WZzKGcGvEGA/7B4LwY4L80tMDu6ObGW+qx366UVN1HrEL+g==", "5d38ef87-9b5b-4f4b-83d4-d8c8b057c2af", "consumer@blazor.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2oh7diw9-0or5-3jf9-8ss6-ks8ya5h297bd",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c092a386-c04f-4d52-9a63-557e5c4a42e1", "JOSHUATAN@OUTLOOK.COM", "AQAAAAIAAYagAAAAEKaMk9M2mWhhk6Wbh/zq71OyFBvtN+/kSOIbzF3FH7mmD5ZpSozJGnEzm3uo2aNuTg==", "c4aed10a-8535-4959-b198-4583e3dd88b1", "joshuatan@outlook.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4d594264-9593-44af-b434-728b3460aa1f", "STAFF@BLAZOR.COM", "AQAAAAIAAYagAAAAEI9F0g7OT4oaUyrLPSY74AH6tCM47+d/aAu3/6x3S1q36sutaWKImfYUiH72dfrd1g==", "aba0bc06-364a-4f09-b929-b5f4949119f4", "staff@blazor.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5di8sy83-2i9r-f56h-s8d9-s09njsh7dd53",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c6a9cbe9-2eb6-4a07-a9ca-ed7796f066ae", "ETHANLIM@HOTMAIL.COM", "AQAAAAIAAYagAAAAENpF7ax8NIzMuMIn7kSEPuNhBha5rnuy0SR5XdhqJPK1NL3TSxMtmdC6hkvWA3SXbQ==", "8a3117d0-947d-4848-9622-533f5a1f415d", "ethanlim@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9du2ii40-h7d9-8sj2-j98s-is0dh83jk48s",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6a831e8d-4630-4223-bd73-83cacfc5c654", "MAYMORRISON@GMAIL.COM", "AQAAAAIAAYagAAAAEJ56WUG/j2o/mixESXqygm3ZWpExfHbbEVgNv791pD87rRbiZoix8e84yaVcot1l7w==", "6b63222b-7902-46a5-a804-9507144734b4", "maymorrison@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Consumers",
                keyColumn: "Id",
                keyValue: 1,
                column: "NRIC",
                value: "S9067028Z");

            migrationBuilder.UpdateData(
                table: "Consumers",
                keyColumn: "Id",
                keyValue: 2,
                column: "NRIC",
                value: "S2836518E");

            migrationBuilder.UpdateData(
                table: "Consumers",
                keyColumn: "Id",
                keyValue: 3,
                column: "NRIC",
                value: "T8904392R");

            migrationBuilder.UpdateData(
                table: "Consumers",
                keyColumn: "Id",
                keyValue: 4,
                column: "NRIC",
                value: "T3876509Z");

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                column: "NRIC",
                value: "S9372136E");
        }
    }
}
