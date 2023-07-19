using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GateCommunityMvc.Migrations
{
    public partial class guard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Security_Guards",
                columns: table => new
                {
                    Guard_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guard_FullName = table.Column<string>(nullable: true),
                    Guard_Email = table.Column<string>(nullable: true),
                    Guard_Contact = table.Column<string>(nullable: true),
                    alternate_contact = table.Column<string>(nullable: true),
                    Guard_Gender = table.Column<string>(nullable: true),
                    Is_active = table.Column<bool>(nullable: false),
                    Job_position = table.Column<string>(nullable: true),
                    Idfile_name = table.Column<string>(nullable: true),
                    Idfile_Path = table.Column<string>(nullable: true),
                    Guard_Password = table.Column<string>(nullable: true),
                    Societyid = table.Column<int>(nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    currentuserid = table.Column<string>(nullable: true),
                    createddate = table.Column<DateTime>(nullable: false),
                    updateddate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Security_Guards", x => x.Guard_Id);
                    table.ForeignKey(
                        name: "FK_Security_Guards_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Security_Guards_Societies_Societyid",
                        column: x => x.Societyid,
                        principalTable: "Societies",
                        principalColumn: "Society_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Security_Guards_AspNetUsers_currentuserid",
                        column: x => x.currentuserid,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Security_Guards_ApplicationUserId",
                table: "Security_Guards",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Security_Guards_Societyid",
                table: "Security_Guards",
                column: "Societyid");

            migrationBuilder.CreateIndex(
                name: "IX_Security_Guards_currentuserid",
                table: "Security_Guards",
                column: "currentuserid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Security_Guards");
        }
    }
}
