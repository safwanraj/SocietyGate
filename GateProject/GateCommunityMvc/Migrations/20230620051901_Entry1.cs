using Microsoft.EntityFrameworkCore.Migrations;

namespace GateCommunityMvc.Migrations
{
    public partial class Entry1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "societyid",
                table: "entryexits",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_entryexits_societyid",
                table: "entryexits",
                column: "societyid");

            migrationBuilder.AddForeignKey(
                name: "FK_entryexits_Societies_societyid",
                table: "entryexits",
                column: "societyid",
                principalTable: "Societies",
                principalColumn: "Society_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_entryexits_Societies_societyid",
                table: "entryexits");

            migrationBuilder.DropIndex(
                name: "IX_entryexits_societyid",
                table: "entryexits");

            migrationBuilder.DropColumn(
                name: "societyid",
                table: "entryexits");
        }
    }
}
