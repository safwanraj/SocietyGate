using Microsoft.EntityFrameworkCore.Migrations;

namespace GateCommunityMvc.Migrations
{
    public partial class vehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "vehicles",
                columns: table => new
                {
                    vehicleid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vehicleno = table.Column<string>(nullable: true),
                    vehicletype = table.Column<string>(nullable: true),
                    manufacturer = table.Column<string>(nullable: true),
                    residentid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicles", x => x.vehicleid);
                    table.ForeignKey(
                        name: "FK_vehicles_tblResidents_residentid",
                        column: x => x.residentid,
                        principalTable: "tblResidents",
                        principalColumn: "residentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_vehicles_residentid",
                table: "vehicles",
                column: "residentid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "vehicles");
        }
    }
}
