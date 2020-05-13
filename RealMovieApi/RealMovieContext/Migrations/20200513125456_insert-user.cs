using Microsoft.EntityFrameworkCore.Migrations;

namespace RealMovieContext.Migrations
{
    public partial class insertuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a278fc3-6338-4f44-b3f5-3f02e6d80881");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c819cc1c-1e91-4a62-acc8-30f473abd8a9");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c819cc1c-1e91-4a62-acc8-30f473abd8a9", "89c4482e-3fe9-4c39-bf0f-7cdfd5401fd8", "Administrator", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2a278fc3-6338-4f44-b3f5-3f02e6d80881", "71a764c0-abc0-4ef2-9242-4f1eda94583d", "User", null });
        }
    }
}
