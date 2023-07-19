using Microsoft.EntityFrameworkCore.Migrations;

namespace GateCommunityMvc.Migrations
{
    public partial class veh1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "flatid",
                table: "vehicles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "wingid",
                table: "vehicles",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_vehicles_flatid",
                table: "vehicles",
                column: "flatid");

            migrationBuilder.CreateIndex(
                name: "IX_vehicles_wingid",
                table: "vehicles",
                column: "wingid");

            migrationBuilder.AddForeignKey(
                name: "FK_vehicles_Flats_flatid",
                table: "vehicles",
                column: "flatid",
                principalTable: "Flats",
                principalColumn: "Flatid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_vehicles_Wingmodels_wingid",
                table: "vehicles",
                column: "wingid",
                principalTable: "Wingmodels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vehicles_Flats_flatid",
                table: "vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_vehicles_Wingmodels_wingid",
                table: "vehicles");

            migrationBuilder.DropIndex(
                name: "IX_vehicles_flatid",
                table: "vehicles");

            migrationBuilder.DropIndex(
                name: "IX_vehicles_wingid",
                table: "vehicles");

            migrationBuilder.DropColumn(
                name: "flatid",
                table: "vehicles");

            migrationBuilder.DropColumn(
                name: "wingid",
                table: "vehicles");
        }
    }
}
