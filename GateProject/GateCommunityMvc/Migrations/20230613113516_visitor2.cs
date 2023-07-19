using Microsoft.EntityFrameworkCore.Migrations;

namespace GateCommunityMvc.Migrations
{
    public partial class visitor2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "residentid",
                table: "visitors",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_visitors_residentid",
                table: "visitors",
                column: "residentid");

            migrationBuilder.AddForeignKey(
                name: "FK_visitors_tblResidents_residentid",
                table: "visitors",
                column: "residentid",
                principalTable: "tblResidents",
                principalColumn: "residentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_visitors_tblResidents_residentid",
                table: "visitors");

            migrationBuilder.DropIndex(
                name: "IX_visitors_residentid",
                table: "visitors");

            migrationBuilder.DropColumn(
                name: "residentid",
                table: "visitors");
        }
    }
}
