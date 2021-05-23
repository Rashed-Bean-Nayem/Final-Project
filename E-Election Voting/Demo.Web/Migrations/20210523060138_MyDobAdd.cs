using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.Web.Migrations
{
    public partial class MyDobAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DateOfBirth",
                table: "ElectionCandidates",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "ElectionCandidates");
        }
    }
}
