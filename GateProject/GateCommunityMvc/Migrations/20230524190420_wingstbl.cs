using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GateCommunityMvc.Migrations
{
    public partial class wingstbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.CreateTable(
                name: "Wingmodels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WingName = table.Column<string>(nullable: true),
                    Society_Id = table.Column<int>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wingmodels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wingmodels_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Wingmodels_Societies_Society_Id",
                        column: x => x.Society_Id,
                        principalTable: "Societies",
                        principalColumn: "Society_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Wingmodels_ApplicationUserId",
                table: "Wingmodels",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Wingmodels_Society_Id",
                table: "Wingmodels",
                column: "Society_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.CreateTable(
                name: "WingDetailViews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Society_Id = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WingName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WingDetailViews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WingDetailViews_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WingDetailViews_Societies_Society_Id",
                        column: x => x.Society_Id,
                        principalTable: "Societies",
                        principalColumn: "Society_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WingDetailViews_ApplicationUserId",
                table: "WingDetailViews",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_WingDetailViews_Society_Id",
                table: "WingDetailViews",
                column: "Society_Id");
        }
    }
}
