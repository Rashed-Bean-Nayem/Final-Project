using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.Web.Migrations
{
    public partial class MyApi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElectionRegistrations");

            migrationBuilder.CreateTable(
                name: "ApiClasses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApiNid = table.Column<int>(nullable: false),
                    ApiName = table.Column<string>(nullable: true),
                    ApiDateOfBirth = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiClasses", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApiClasses");

            migrationBuilder.CreateTable(
                name: "ElectionRegistrations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandidateId = table.Column<int>(type: "int", nullable: false),
                    ElectionCandidateId = table.Column<int>(type: "int", nullable: true),
                    EnrollDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectionRegistrations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElectionRegistrations_ElectionCandidates_ElectionCandidateId",
                        column: x => x.ElectionCandidateId,
                        principalTable: "ElectionCandidates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ElectionRegistrations_ElectionCandidateId",
                table: "ElectionRegistrations",
                column: "ElectionCandidateId");
        }
    }
}
