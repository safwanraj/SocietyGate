using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GateCommunityMvc.Migrations
{
    public partial class tblresident : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblResidents",
                columns: table => new
                {
                    residentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    societyid = table.Column<int>(nullable: true),
                    wingid = table.Column<int>(nullable: true),
                    flatno = table.Column<string>(nullable: true),
                    firstname = table.Column<string>(nullable: true),
                    lastname = table.Column<string>(nullable: true),
                    phoneNumber = table.Column<string>(nullable: true),
                    gender = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true),
                    doc_type = table.Column<string>(nullable: true),
                    Idfile_name = table.Column<string>(nullable: true),
                    Idfile_Path = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblResidents", x => x.residentId);
                    table.ForeignKey(
                        name: "FK_tblResidents_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblResidents_Societies_societyid",
                        column: x => x.societyid,
                        principalTable: "Societies",
                        principalColumn: "Society_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblResidents_Wingmodels_wingid",
                        column: x => x.wingid,
                        principalTable: "Wingmodels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblResidents_ApplicationUserId",
                table: "tblResidents",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_tblResidents_societyid",
                table: "tblResidents",
                column: "societyid");

            migrationBuilder.CreateIndex(
                name: "IX_tblResidents_wingid",
                table: "tblResidents",
                column: "wingid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblResidents");
        }
    }
}
