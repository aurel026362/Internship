using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Groups",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Groups",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");
        }
    }
}
