using Microsoft.EntityFrameworkCore.Migrations;

namespace GateCommunityMvc.Migrations
{
    public partial class b16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "gatepasscode",
                table: "tblResidents",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "staffs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "familys",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "gatepasscode",
                table: "tblResidents");

            migrationBuilder.DropColumn(
                name: "status",
                table: "staffs");

            migrationBuilder.DropColumn(
                name: "status",
                table: "familys");
        }
    }
}
