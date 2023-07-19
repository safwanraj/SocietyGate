using Microsoft.EntityFrameworkCore.Migrations;

namespace GateCommunityMvc.Migrations
{
    public partial class guard2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "doc_type",
                table: "Security_Guards",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "doc_type",
                table: "Security_Guards");
        }
    }
}
