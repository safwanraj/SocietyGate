using Microsoft.EntityFrameworkCore.Migrations;

namespace GateCommunityMvc.Migrations
{
    public partial class poll1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Answered",
                table: "Polls",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "residentid",
                table: "Polls",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Polls_residentid",
                table: "Polls",
                column: "residentid");

            migrationBuilder.AddForeignKey(
                name: "FK_Polls_tblResidents_residentid",
                table: "Polls",
                column: "residentid",
                principalTable: "tblResidents",
                principalColumn: "residentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Polls_tblResidents_residentid",
                table: "Polls");

            migrationBuilder.DropIndex(
                name: "IX_Polls_residentid",
                table: "Polls");

            migrationBuilder.DropColumn(
                name: "Answered",
                table: "Polls");

            migrationBuilder.DropColumn(
                name: "residentid",
                table: "Polls");
        }
    }
}
