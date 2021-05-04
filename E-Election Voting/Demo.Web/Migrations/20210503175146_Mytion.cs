using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.Web.Migrations
{
    public partial class Mytion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Count1",
                table: "MakeElections",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Count2",
                table: "MakeElections",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count1",
                table: "MakeElections");

            migrationBuilder.DropColumn(
                name: "Count2",
                table: "MakeElections");
        }
    }
}
