using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.Web.Migrations
{
    public partial class MytionF : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LogoImageUrl",
                table: "ElectionCandidates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Motto",
                table: "ElectionCandidates",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LogoImageUrl",
                table: "ElectionCandidates");

            migrationBuilder.DropColumn(
                name: "Motto",
                table: "ElectionCandidates");
        }
    }
}
