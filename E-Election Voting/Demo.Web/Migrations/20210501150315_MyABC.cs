using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.Web.Migrations
{
    public partial class MyABC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ElectionDate",
                table: "MakeElections",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "CID2",
                table: "MakeElections",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CID1",
                table: "MakeElections",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CDName1",
                table: "MakeElections",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CDName2",
                table: "MakeElections",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CDName1",
                table: "MakeElections");

            migrationBuilder.DropColumn(
                name: "CDName2",
                table: "MakeElections");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ElectionDate",
                table: "MakeElections",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CID2",
                table: "MakeElections",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CID1",
                table: "MakeElections",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
