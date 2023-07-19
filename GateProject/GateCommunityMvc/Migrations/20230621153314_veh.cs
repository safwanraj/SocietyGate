using Microsoft.EntityFrameworkCore.Migrations;

namespace GateCommunityMvc.Migrations
{
    public partial class veh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "societyid",
                table: "vehicles",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_vehicles_societyid",
                table: "vehicles",
                column: "societyid");

            migrationBuilder.AddForeignKey(
                name: "FK_vehicles_Societies_societyid",
                table: "vehicles",
                column: "societyid",
                principalTable: "Societies",
                principalColumn: "Society_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vehicles_Societies_societyid",
                table: "vehicles");

            migrationBuilder.DropIndex(
                name: "IX_vehicles_societyid",
                table: "vehicles");

            migrationBuilder.DropColumn(
                name: "societyid",
                table: "vehicles");
        }
    }
}
