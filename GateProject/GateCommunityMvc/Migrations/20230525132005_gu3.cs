using Microsoft.EntityFrameworkCore.Migrations;

namespace GateCommunityMvc.Migrations
{
    public partial class gu3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Guard_Email",
                table: "Security_Guards");

            migrationBuilder.DropColumn(
                name: "Guard_Password",
                table: "Security_Guards");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Guard_Email",
                table: "Security_Guards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Guard_Password",
                table: "Security_Guards",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
