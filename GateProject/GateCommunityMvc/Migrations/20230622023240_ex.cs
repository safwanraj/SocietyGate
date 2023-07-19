using Microsoft.EntityFrameworkCore.Migrations;

namespace GateCommunityMvc.Migrations
{
    public partial class ex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "type",
                table: "entryexits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "vname",
                table: "entryexits",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "type",
                table: "entryexits");

            migrationBuilder.DropColumn(
                name: "vname",
                table: "entryexits");
        }
    }
}
