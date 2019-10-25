using Microsoft.EntityFrameworkCore.Migrations;

namespace OA.Repo.Migrations
{
    public partial class RemovedGender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenderID",
                table: "User");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GenderID",
                table: "User",
                nullable: false,
                defaultValue: 0);
        }
    }
}
