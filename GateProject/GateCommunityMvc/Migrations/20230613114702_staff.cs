using Microsoft.EntityFrameworkCore.Migrations;

namespace GateCommunityMvc.Migrations
{
    public partial class staff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "filename",
                table: "familys",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "filepath",
                table: "familys",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "staffs",
                columns: table => new
                {
                    staffId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    staffName = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    contact = table.Column<string>(nullable: true),
                    aadharno = table.Column<string>(nullable: true),
                    workas = table.Column<string>(nullable: true),
                    filename = table.Column<string>(nullable: true),
                    filepath = table.Column<string>(nullable: true),
                    societyid = table.Column<int>(nullable: true),
                    wingid = table.Column<int>(nullable: true),
                    flatid = table.Column<int>(nullable: true),
                    residentid = table.Column<int>(nullable: true),
                    userid = table.Column<string>(nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staffs", x => x.staffId);
                    table.ForeignKey(
                        name: "FK_staffs_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_staffs_Flats_flatid",
                        column: x => x.flatid,
                        principalTable: "Flats",
                        principalColumn: "Flatid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_staffs_tblResidents_residentid",
                        column: x => x.residentid,
                        principalTable: "tblResidents",
                        principalColumn: "residentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_staffs_Societies_societyid",
                        column: x => x.societyid,
                        principalTable: "Societies",
                        principalColumn: "Society_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_staffs_Wingmodels_wingid",
                        column: x => x.wingid,
                        principalTable: "Wingmodels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_staffs_ApplicationUserId",
                table: "staffs",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_staffs_flatid",
                table: "staffs",
                column: "flatid");

            migrationBuilder.CreateIndex(
                name: "IX_staffs_residentid",
                table: "staffs",
                column: "residentid");

            migrationBuilder.CreateIndex(
                name: "IX_staffs_societyid",
                table: "staffs",
                column: "societyid");

            migrationBuilder.CreateIndex(
                name: "IX_staffs_wingid",
                table: "staffs",
                column: "wingid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "staffs");

            migrationBuilder.DropColumn(
                name: "filename",
                table: "familys");

            migrationBuilder.DropColumn(
                name: "filepath",
                table: "familys");
        }
    }
}
