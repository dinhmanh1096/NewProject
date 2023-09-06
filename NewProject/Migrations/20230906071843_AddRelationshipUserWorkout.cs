using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewProject.Migrations
{
    public partial class AddRelationshipUserWorkout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f012ef5-bf4f-4f7c-a0e0-959d8cfabafb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec89ee27-c5dd-4649-a0f3-394758d4e582");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Workout",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3580f53d-12d3-49c7-8cbf-590710202e5f", "2", "User", "User" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fbe4bee9-2505-428e-8e1d-ad2c63bf82e8", "1", "Admin", "Admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Workout_UserName",
                table: "Workout",
                column: "UserName");

            migrationBuilder.AddForeignKey(
                name: "FK_Workout_AspNetUsers_UserName",
                table: "Workout",
                column: "UserName",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workout_AspNetUsers_UserName",
                table: "Workout");

            migrationBuilder.DropIndex(
                name: "IX_Workout_UserName",
                table: "Workout");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3580f53d-12d3-49c7-8cbf-590710202e5f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fbe4bee9-2505-428e-8e1d-ad2c63bf82e8");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Workout",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7f012ef5-bf4f-4f7c-a0e0-959d8cfabafb", "2", "User", "User" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ec89ee27-c5dd-4649-a0f3-394758d4e582", "1", "Admin", "Admin" });
        }
    }
}
