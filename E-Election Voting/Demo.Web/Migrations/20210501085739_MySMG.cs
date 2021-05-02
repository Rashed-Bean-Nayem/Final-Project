using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.Web.Migrations
{
    public partial class MySMG : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ElectionRegistrations_ElectionVoters_ElectionVoterId",
                table: "ElectionRegistrations");

            migrationBuilder.DropIndex(
                name: "IX_ElectionRegistrations_ElectionVoterId",
                table: "ElectionRegistrations");

            migrationBuilder.DropColumn(
                name: "ElectionVoterId",
                table: "ElectionRegistrations");

            migrationBuilder.DropColumn(
                name: "IsPaymentComplete",
                table: "ElectionRegistrations");

            migrationBuilder.DropColumn(
                name: "VoterId",
                table: "ElectionRegistrations");

            migrationBuilder.CreateTable(
                name: "MakeElections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ElectionName = table.Column<string>(nullable: true),
                    ElectionDate = table.Column<DateTime>(nullable: false),
                    CID1 = table.Column<int>(nullable: false),
                    CID2 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakeElections", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MakeElections");

            migrationBuilder.AddColumn<int>(
                name: "ElectionVoterId",
                table: "ElectionRegistrations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPaymentComplete",
                table: "ElectionRegistrations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "VoterId",
                table: "ElectionRegistrations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ElectionRegistrations_ElectionVoterId",
                table: "ElectionRegistrations",
                column: "ElectionVoterId");

            migrationBuilder.AddForeignKey(
                name: "FK_ElectionRegistrations_ElectionVoters_ElectionVoterId",
                table: "ElectionRegistrations",
                column: "ElectionVoterId",
                principalTable: "ElectionVoters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
