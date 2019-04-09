using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Groups",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Groups",
                type: "smalldatetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");
        }
    }
}
