using Microsoft.EntityFrameworkCore.Migrations;

namespace GateCommunityMvc.Migrations
{
    public partial class soc3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isActive",
                table: "Societies");

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "Societies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "Societies");

            migrationBuilder.AddColumn<bool>(
                name: "isActive",
                table: "Societies",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
