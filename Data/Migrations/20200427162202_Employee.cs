using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorProject.Data.Migrations
{
    public partial class Employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "496ff27b-595d-4440-90d0-1f5b1453fa79");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fae17514-571f-4a99-9bf5-0b37bd37f5c9", "564d47d9-c9c2-4cec-969e-770f130cb5c9", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fae17514-571f-4a99-9bf5-0b37bd37f5c9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "496ff27b-595d-4440-90d0-1f5b1453fa79", "1c7f210a-64c8-44d3-8bd7-d04a62e829b3", "Admin", "ADMIN" });
        }
    }
}
