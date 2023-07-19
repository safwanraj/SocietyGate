using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GateCommunityMvc.Migrations
{
    public partial class flatmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flats",
                columns: table => new
                {
                    Flatid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    startnumber = table.Column<int>(nullable: false),
                    endnumber = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    SocietyId = table.Column<int>(nullable: true),
                    WingId = table.Column<int>(nullable: true),
                    CurrentuserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flats", x => x.Flatid);
                    table.ForeignKey(
                        name: "FK_Flats_AspNetUsers_CurrentuserId",
                        column: x => x.CurrentuserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Flats_Societies_SocietyId",
                        column: x => x.SocietyId,
                        principalTable: "Societies",
                        principalColumn: "Society_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Flats_Wingmodels_WingId",
                        column: x => x.WingId,
                        principalTable: "Wingmodels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Flats_CurrentuserId",
                table: "Flats",
                column: "CurrentuserId");

            migrationBuilder.CreateIndex(
                name: "IX_Flats_SocietyId",
                table: "Flats",
                column: "SocietyId");

            migrationBuilder.CreateIndex(
                name: "IX_Flats_WingId",
                table: "Flats",
                column: "WingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flats");
        }
    }
}
