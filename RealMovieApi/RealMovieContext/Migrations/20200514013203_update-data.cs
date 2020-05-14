using Microsoft.EntityFrameworkCore.Migrations;

namespace RealMovieContext.Migrations
{
    public partial class updatedata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsAdmin", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a08f4ac3-4a84-4daa-aa68-018d16161430", 0, "3bb6b9e2-59fc-4b1d-859e-a220297f5aee", "jhon.vedo@gmail.com", true, "Jhon", true, "Acevedo", false, null, "JHON.VEDO@GMAIL.COM", "JHON.VEDO@GMAIL.COM", "AQAAAAEAACcQAAAAEAcpd0feHUaaiB1iGtTA/fBAqGUEKB3fXjLHPd5kFyuB/nx0Zj98XJv5Ign9yTI0lA==", null, true, "de43c4a9-c768-4c71-adff-769306995583", false, "jhon.vedo@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a08f4ac3-4a84-4daa-aa68-018d16161430");

            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "AspNetUsers");

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
    }
}
