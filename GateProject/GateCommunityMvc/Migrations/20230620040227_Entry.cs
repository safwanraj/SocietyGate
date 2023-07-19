using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GateCommunityMvc.Migrations
{
    public partial class Entry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "entryexits",
                columns: table => new
                {
                    eid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    residentid = table.Column<int>(nullable: true),
                    visitorid = table.Column<int>(nullable: true),
                    staffid = table.Column<int>(nullable: true),
                    Entry = table.Column<DateTime>(nullable: true),
                    Exit = table.Column<DateTime>(nullable: true),
                    Applicationuserid = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entryexits", x => x.eid);
                    table.ForeignKey(
                        name: "FK_entryexits_AspNetUsers_Applicationuserid",
                        column: x => x.Applicationuserid,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_entryexits_tblResidents_residentid",
                        column: x => x.residentid,
                        principalTable: "tblResidents",
                        principalColumn: "residentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_entryexits_staffs_staffid",
                        column: x => x.staffid,
                        principalTable: "staffs",
                        principalColumn: "staffId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_entryexits_visitors_visitorid",
                        column: x => x.visitorid,
                        principalTable: "visitors",
                        principalColumn: "visitorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_entryexits_Applicationuserid",
                table: "entryexits",
                column: "Applicationuserid");

            migrationBuilder.CreateIndex(
                name: "IX_entryexits_residentid",
                table: "entryexits",
                column: "residentid");

            migrationBuilder.CreateIndex(
                name: "IX_entryexits_staffid",
                table: "entryexits",
                column: "staffid");

            migrationBuilder.CreateIndex(
                name: "IX_entryexits_visitorid",
                table: "entryexits",
                column: "visitorid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "entryexits");
        }
    }
}
