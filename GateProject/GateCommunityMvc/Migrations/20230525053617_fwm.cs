using Microsoft.EntityFrameworkCore.Migrations;

namespace GateCommunityMvc.Migrations
{
    public partial class fwm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "nooffloors",
                table: "Wingmodels",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "floorno",
                table: "Flats",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nooffloors",
                table: "Wingmodels");

            migrationBuilder.DropColumn(
                name: "floorno",
                table: "Flats");
        }
    }
}
