using Microsoft.EntityFrameworkCore.Migrations;

namespace GateCommunityMvc.Migrations
{
    public partial class flatmodel1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "endnumber",
                table: "Flats");

            migrationBuilder.DropColumn(
                name: "startnumber",
                table: "Flats");

            migrationBuilder.AlterColumn<string>(
                name: "floorno",
                table: "Flats",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "flatno",
                table: "Flats",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "flatno",
                table: "Flats");

            migrationBuilder.AlterColumn<string>(
                name: "floorno",
                table: "Flats",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "endnumber",
                table: "Flats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "startnumber",
                table: "Flats",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
