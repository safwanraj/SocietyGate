using Microsoft.EntityFrameworkCore.Migrations;

namespace GateCommunityMvc.Migrations
{
    public partial class societydetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Societies",
                columns: table => new
                {
                    Society_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Society_Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    President_Name = table.Column<string>(nullable: true),
                    Contact = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Postal_Code = table.Column<string>(nullable: true),
                    isActive = table.Column<bool>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    AdminID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Societies", x => x.Society_Id);
                    table.ForeignKey(
                        name: "FK_Societies_AspNetUsers_AdminID",
                        column: x => x.AdminID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Societies_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Societies_AdminID",
                table: "Societies",
                column: "AdminID");

            migrationBuilder.CreateIndex(
                name: "IX_Societies_ApplicationUserId",
                table: "Societies",
                column: "ApplicationUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Societies");
        }
    }
}
