using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.Web.Migrations
{
    public partial class CH2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ElectionCandidates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    NID = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectionCandidates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ElectionVoters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    NID = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectionVoters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ElectionRegistrations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoterId = table.Column<int>(nullable: false),
                    ElectionVoterId = table.Column<int>(nullable: true),
                    CandidateId = table.Column<int>(nullable: false),
                    ElectionCandidateId = table.Column<int>(nullable: true),
                    EnrollDate = table.Column<DateTime>(nullable: false),
                    IsPaymentComplete = table.Column<bool>(nullable: false)
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
                    table.ForeignKey(
                        name: "FK_ElectionRegistrations_ElectionVoters_ElectionVoterId",
                        column: x => x.ElectionVoterId,
                        principalTable: "ElectionVoters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ElectionRegistrations_ElectionCandidateId",
                table: "ElectionRegistrations",
                column: "ElectionCandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectionRegistrations_ElectionVoterId",
                table: "ElectionRegistrations",
                column: "ElectionVoterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElectionRegistrations");

            migrationBuilder.DropTable(
                name: "ElectionCandidates");

            migrationBuilder.DropTable(
                name: "ElectionVoters");
        }
    }
}
