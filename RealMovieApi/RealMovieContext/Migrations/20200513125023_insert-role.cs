using Microsoft.EntityFrameworkCore.Migrations;

namespace RealMovieContext.Migrations
{
    public partial class insertrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c819cc1c-1e91-4a62-acc8-30f473abd8a9", "89c4482e-3fe9-4c39-bf0f-7cdfd5401fd8", "Administrator", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2a278fc3-6338-4f44-b3f5-3f02e6d80881", "71a764c0-abc0-4ef2-9242-4f1eda94583d", "User", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a278fc3-6338-4f44-b3f5-3f02e6d80881");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c819cc1c-1e91-4a62-acc8-30f473abd8a9");
        }
    }
}
