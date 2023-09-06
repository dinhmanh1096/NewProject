using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewProject.Migrations
{
    public partial class EditColumnWorkout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e4fa7ca-27cb-4978-af4c-e8602f0509f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aaf0a9ea-600a-42b2-9aed-e6841c5d53a8");

            migrationBuilder.DropColumn(
                name: "id",
                table: "Workout");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Workout",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7f012ef5-bf4f-4f7c-a0e0-959d8cfabafb", "2", "User", "User" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ec89ee27-c5dd-4649-a0f3-394758d4e582", "1", "Admin", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f012ef5-bf4f-4f7c-a0e0-959d8cfabafb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec89ee27-c5dd-4649-a0f3-394758d4e582");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Workout");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "Workout",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e4fa7ca-27cb-4978-af4c-e8602f0509f4", "1", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aaf0a9ea-600a-42b2-9aed-e6841c5d53a8", "2", "User", "User" });
        }
    }
}
