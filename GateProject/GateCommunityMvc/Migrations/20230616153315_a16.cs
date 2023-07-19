using Microsoft.EntityFrameworkCore.Migrations;

namespace GateCommunityMvc.Migrations
{
    public partial class a16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "profilepath",
                table: "visitors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "profilepath",
                table: "tblResidents",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "profilepath",
                table: "Security_Guards",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "profilepath",
                table: "visitors");

            migrationBuilder.DropColumn(
                name: "profilepath",
                table: "tblResidents");

            migrationBuilder.DropColumn(
                name: "profilepath",
                table: "Security_Guards");
        }
    }
}
