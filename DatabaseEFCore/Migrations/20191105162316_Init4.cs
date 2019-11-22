using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseEFCore.Migrations
{
    public partial class Init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "DepId",
                table: "Employees",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepId",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Employees",
                nullable: true);
        }
    }
}
