using Microsoft.EntityFrameworkCore.Migrations;

namespace GateCommunityMvc.Migrations
{
    public partial class family : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "familys",
                columns: table => new
                {
                    FamilyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FamilyName = table.Column<string>(nullable: true),
                    relationship = table.Column<string>(nullable: true),
                    contact = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    societyid = table.Column<int>(nullable: true),
                    wingid = table.Column<int>(nullable: true),
                    flatid = table.Column<int>(nullable: true),
                    residentid = table.Column<int>(nullable: true),
                    userid = table.Column<string>(nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_familys", x => x.FamilyId);
                    table.ForeignKey(
                        name: "FK_familys_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_familys_Flats_flatid",
                        column: x => x.flatid,
                        principalTable: "Flats",
                        principalColumn: "Flatid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_familys_tblResidents_residentid",
                        column: x => x.residentid,
                        principalTable: "tblResidents",
                        principalColumn: "residentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_familys_Societies_societyid",
                        column: x => x.societyid,
                        principalTable: "Societies",
                        principalColumn: "Society_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_familys_Wingmodels_wingid",
                        column: x => x.wingid,
                        principalTable: "Wingmodels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_familys_ApplicationUserId",
                table: "familys",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_familys_flatid",
                table: "familys",
                column: "flatid");

            migrationBuilder.CreateIndex(
                name: "IX_familys_residentid",
                table: "familys",
                column: "residentid");

            migrationBuilder.CreateIndex(
                name: "IX_familys_societyid",
                table: "familys",
                column: "societyid");

            migrationBuilder.CreateIndex(
                name: "IX_familys_wingid",
                table: "familys",
                column: "wingid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "familys");
        }
    }
}
