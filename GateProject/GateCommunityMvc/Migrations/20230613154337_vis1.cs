using Microsoft.EntityFrameworkCore.Migrations;

namespace GateCommunityMvc.Migrations
{
    public partial class vis1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "gender",
                table: "visitors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "gender",
                table: "staffs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "gender",
                table: "familys",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "gender",
                table: "visitors");

            migrationBuilder.DropColumn(
                name: "gender",
                table: "staffs");

            migrationBuilder.DropColumn(
                name: "gender",
                table: "familys");
        }
    }
}
