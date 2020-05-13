using Microsoft.EntityFrameworkCore.Migrations;

namespace RealMovieContext.Migrations
{
    public partial class insertuserpassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0509e933-a721-4124-b86f-c157cc477609");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31dec25f-8db2-4a92-9b94-72dcca1e4e78");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed89fca3-3927-4d59-ade9-573fdc8c7468");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "0509e933-a721-4124-b86f-c157cc477609", "818b8a8c-cf26-499d-ab9c-f66e713223a0", "Administrator", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "31dec25f-8db2-4a92-9b94-72dcca1e4e78", "ac74d4ee-2cbe-4d1a-94dc-f5c649b9e507", "User", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ed89fca3-3927-4d59-ade9-573fdc8c7468", 0, "a02c8c48-fbf5-475f-836f-bde3a12b61bc", "jhon.vedo@gmail.com", true, "Jhon", "Acevedo", false, null, "JHON.VEDO@GMAIL.COM", "JHON.VEDO@GMAIL.COM", "AQAAAAEAACcQAAAAEOIW9zb2am7CFsMOfVw5G2J6w1LSmgdpUKEcFbWySD22q1krM4UrDQxwsIURG36rYw==", null, true, "7aeb5999-bd02-4978-9b7f-126f3a17bb46", false, "jhon.vedo@gmail.com" });
        }
    }
}
