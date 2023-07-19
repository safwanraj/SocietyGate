using Microsoft.EntityFrameworkCore.Migrations;

namespace GateCommunityMvc.Migrations
{
    public partial class Entry2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_entryexits_staffs_staffid",
                table: "entryexits");

            migrationBuilder.DropIndex(
                name: "IX_entryexits_staffid",
                table: "entryexits");

            migrationBuilder.DropColumn(
                name: "staffid",
                table: "entryexits");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "staffid",
                table: "entryexits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_entryexits_staffid",
                table: "entryexits",
                column: "staffid");

            migrationBuilder.AddForeignKey(
                name: "FK_entryexits_staffs_staffid",
                table: "entryexits",
                column: "staffid",
                principalTable: "staffs",
                principalColumn: "staffId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
