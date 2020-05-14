using Microsoft.EntityFrameworkCore.Migrations;

namespace RealMovieContext.Migrations
{
    public partial class updateinitvalues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8af595f1-850c-40ff-b115-ee5e93e57934");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb9733a1-dc1e-4ceb-92b3-4a581f2f1ed5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "211fee05-66bc-4670-a56f-7d7b9cdab6cd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e4e85213-558f-4666-9583-0f2562a5c941", "fddbb424-aa8f-4744-974f-dca321bcb692", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1f828eb6-a6e5-40f0-9add-fde2a5719e30", "457e8f00-c530-4e35-b90a-5742498ddd9b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "497f7464-fac2-42b5-a585-01cca3be077e", 0, "d9085c3f-c1b8-4372-b461-6251da405412", "jhon.vedo@gmail.com", true, "Jhon", "Acevedo", false, null, "JHON.VEDO@GMAIL.COM", "JHON.VEDO@GMAIL.COM", "AQAAAAEAACcQAAAAECeg96e3Wz1VzNdaIEIhgBcP8qjHlDjHMN4I+rg3B5QORjQJjRVlncnT6V9qRMpsCA==", null, true, "6e13ec34-3a44-4d12-a255-53a5611aaf45", false, "jhon.vedo@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f828eb6-a6e5-40f0-9add-fde2a5719e30");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4e85213-558f-4666-9583-0f2562a5c941");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "497f7464-fac2-42b5-a585-01cca3be077e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8af595f1-850c-40ff-b115-ee5e93e57934", "b92ab350-552f-4ec1-9c2d-bcbdb71af57d", "Administrator", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eb9733a1-dc1e-4ceb-92b3-4a581f2f1ed5", "67831549-d372-4ce5-8f62-db4c19d2e096", "User", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "211fee05-66bc-4670-a56f-7d7b9cdab6cd", 0, "aae3a6e6-8a4e-4ffd-ad59-ad347ecd0174", "jhon.vedo@gmail.com", true, "Jhon", "Acevedo", false, null, "JHON.VEDO@GMAIL.COM", "JHON.VEDO@GMAIL.COM", "AQAAAAEAACcQAAAAENdSi/u23cRop6EyBbQmYutz6LbO8rvmoVA9n0szmfE/1idshJVXCxyygrp4h1qFjg==", null, true, "fa44a87b-b880-439f-98c0-d71c9f8679a9", false, "jhon.vedo@gmail.com" });
        }
    }
}
