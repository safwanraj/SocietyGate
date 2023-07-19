using Microsoft.EntityFrameworkCore.Migrations;

namespace GateCommunityMvc.Migrations
{
    public partial class res : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "flatno",
                table: "tblResidents",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblResidents_flatno",
                table: "tblResidents",
                column: "flatno");

            migrationBuilder.AddForeignKey(
                name: "FK_tblResidents_Flats_flatno",
                table: "tblResidents",
                column: "flatno",
                principalTable: "Flats",
                principalColumn: "Flatid",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblResidents_Flats_flatno",
                table: "tblResidents");

            migrationBuilder.DropIndex(
                name: "IX_tblResidents_flatno",
                table: "tblResidents");

            migrationBuilder.AlterColumn<string>(
                name: "flatno",
                table: "tblResidents",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
