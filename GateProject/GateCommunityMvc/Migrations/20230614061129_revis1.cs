using Microsoft.EntityFrameworkCore.Migrations;

namespace GateCommunityMvc.Migrations
{
    public partial class revis1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_staffs_AspNetUsers_ApplicationUserId",
                table: "staffs");

            migrationBuilder.DropIndex(
                name: "IX_staffs_ApplicationUserId",
                table: "staffs");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "staffs");

            migrationBuilder.RenameColumn(
                name: "userid",
                table: "staffs",
                newName: "userId");

            migrationBuilder.AlterColumn<string>(
                name: "userId",
                table: "staffs",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_staffs_userId",
                table: "staffs",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_staffs_AspNetUsers_userId",
                table: "staffs",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_staffs_AspNetUsers_userId",
                table: "staffs");

            migrationBuilder.DropIndex(
                name: "IX_staffs_userId",
                table: "staffs");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "staffs",
                newName: "userid");

            migrationBuilder.AlterColumn<string>(
                name: "userid",
                table: "staffs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "staffs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_staffs_ApplicationUserId",
                table: "staffs",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_staffs_AspNetUsers_ApplicationUserId",
                table: "staffs",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
