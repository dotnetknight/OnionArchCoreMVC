using Microsoft.EntityFrameworkCore.Migrations;

namespace OA.Repo.Migrations
{
    public partial class AddedGender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GenderID",
                table: "User",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenderID",
                table: "User");
        }
    }
}
