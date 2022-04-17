using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Questions",
                newName: "Image");

            migrationBuilder.AlterColumn<short>(
                name: "Difficulty",
                table: "Questions",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Questions",
                newName: "Url");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Difficulty",
                table: "Questions",
                type: "varbinary(max)",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");
        }
    }
}
