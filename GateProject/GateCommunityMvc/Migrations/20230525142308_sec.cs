using Microsoft.EntityFrameworkCore.Migrations;

namespace GateCommunityMvc.Migrations
{
    public partial class sec : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Is_active",
                table: "Security_Guards");

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "Security_Guards",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "Security_Guards");

            migrationBuilder.AddColumn<bool>(
                name: "Is_active",
                table: "Security_Guards",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
