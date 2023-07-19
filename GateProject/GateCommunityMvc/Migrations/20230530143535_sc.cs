using Microsoft.EntityFrameworkCore.Migrations;

namespace GateCommunityMvc.Migrations
{
    public partial class sc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Societies",
                nullable: true);

          
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Societies");

           
        }
    }
}
