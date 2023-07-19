using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GateCommunityMvc.Migrations
{
    public partial class revis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_familys_AspNetUsers_ApplicationUserId",
                table: "familys");

            migrationBuilder.DropForeignKey(
                name: "FK_familys_Flats_flatid",
                table: "familys");

            migrationBuilder.DropForeignKey(
                name: "FK_familys_Societies_societyid",
                table: "familys");

            migrationBuilder.DropForeignKey(
                name: "FK_familys_Wingmodels_wingid",
                table: "familys");

            migrationBuilder.DropIndex(
                name: "IX_familys_ApplicationUserId",
                table: "familys");

            migrationBuilder.DropIndex(
                name: "IX_familys_flatid",
                table: "familys");

            migrationBuilder.DropIndex(
                name: "IX_familys_societyid",
                table: "familys");

            migrationBuilder.DropIndex(
                name: "IX_familys_wingid",
                table: "familys");

            migrationBuilder.DropColumn(
                name: "Entry",
                table: "visitors");

            migrationBuilder.DropColumn(
                name: "Exit",
                table: "visitors");

            migrationBuilder.DropColumn(
                name: "expecteddate",
                table: "visitors");

            migrationBuilder.DropColumn(
                name: "gatepasscode",
                table: "visitors");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "familys");

            migrationBuilder.DropColumn(
                name: "flatid",
                table: "familys");

            migrationBuilder.DropColumn(
                name: "societyid",
                table: "familys");

            migrationBuilder.DropColumn(
                name: "userid",
                table: "familys");

            migrationBuilder.DropColumn(
                name: "wingid",
                table: "familys");

            migrationBuilder.AddColumn<string>(
                name: "passcode",
                table: "staffs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "passcode",
                table: "familys",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "passcode",
                table: "staffs");

            migrationBuilder.DropColumn(
                name: "passcode",
                table: "familys");

            migrationBuilder.AddColumn<DateTime>(
                name: "Entry",
                table: "visitors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Exit",
                table: "visitors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "expecteddate",
                table: "visitors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "gatepasscode",
                table: "visitors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "familys",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "flatid",
                table: "familys",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "societyid",
                table: "familys",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "userid",
                table: "familys",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "wingid",
                table: "familys",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_familys_ApplicationUserId",
                table: "familys",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_familys_flatid",
                table: "familys",
                column: "flatid");

            migrationBuilder.CreateIndex(
                name: "IX_familys_societyid",
                table: "familys",
                column: "societyid");

            migrationBuilder.CreateIndex(
                name: "IX_familys_wingid",
                table: "familys",
                column: "wingid");

            migrationBuilder.AddForeignKey(
                name: "FK_familys_AspNetUsers_ApplicationUserId",
                table: "familys",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_familys_Flats_flatid",
                table: "familys",
                column: "flatid",
                principalTable: "Flats",
                principalColumn: "Flatid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_familys_Societies_societyid",
                table: "familys",
                column: "societyid",
                principalTable: "Societies",
                principalColumn: "Society_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_familys_Wingmodels_wingid",
                table: "familys",
                column: "wingid",
                principalTable: "Wingmodels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
