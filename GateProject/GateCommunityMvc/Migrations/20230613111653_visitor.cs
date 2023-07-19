using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GateCommunityMvc.Migrations
{
    public partial class visitor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "visitors",
                columns: table => new
                {
                    visitorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    societyid = table.Column<int>(nullable: true),
                    wingid = table.Column<int>(nullable: true),
                    flatid = table.Column<int>(nullable: true),
                    visitorName = table.Column<string>(nullable: true),
                    visitorType = table.Column<string>(nullable: true),
                    visitorcontact = table.Column<string>(nullable: true),
                    purposeofvisit = table.Column<string>(nullable: true),
                    aadharno = table.Column<string>(nullable: true),
                    from = table.Column<string>(nullable: true),
                    vehicleno = table.Column<string>(nullable: true),
                    Entry = table.Column<DateTime>(nullable: true),
                    Exit = table.Column<DateTime>(nullable: true),
                    doc_type = table.Column<string>(nullable: true),
                    doc_name = table.Column<string>(nullable: true),
                    doc_path = table.Column<string>(nullable: true),
                    gatepasscode = table.Column<string>(nullable: true),
                    userid = table.Column<string>(nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visitors", x => x.visitorId);
                    table.ForeignKey(
                        name: "FK_visitors_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_visitors_Flats_flatid",
                        column: x => x.flatid,
                        principalTable: "Flats",
                        principalColumn: "Flatid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_visitors_Societies_societyid",
                        column: x => x.societyid,
                        principalTable: "Societies",
                        principalColumn: "Society_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_visitors_Wingmodels_wingid",
                        column: x => x.wingid,
                        principalTable: "Wingmodels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_visitors_ApplicationUserId",
                table: "visitors",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_visitors_flatid",
                table: "visitors",
                column: "flatid");

            migrationBuilder.CreateIndex(
                name: "IX_visitors_societyid",
                table: "visitors",
                column: "societyid");

            migrationBuilder.CreateIndex(
                name: "IX_visitors_wingid",
                table: "visitors",
                column: "wingid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "visitors");
        }
    }
}
