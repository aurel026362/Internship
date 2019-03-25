using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TESTDB.Migrations
{
    public partial class WithData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "Name", "StartDate" },
                values: new object[] { 1L, "C#", new DateTime(2019, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "Name", "StartDate" },
                values: new object[] { 2L, "SQL AND EF CORE", new DateTime(2019, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "Name", "StartDate" },
                values: new object[] { 3L, "WEB", new DateTime(2019, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Themes",
                columns: new[] { "Id", "MenthorId", "ModuleId", "Name", "Source", "TimeOfTheme" },
                values: new object[,]
                {
                    { 1L, 1L, 1L, "Creational Pattern", "S:\\Internship\\C#", new DateTime(2019, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, 1L, 2L, "SQL SELECT", "S:\\Internship\\SQL", new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, 2L, 2L, "EF Core Mapping", "S:\\Internship\\SQL", new DateTime(2019, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, 2L, 3L, "JS", "S:\\Internship\\WEB", new DateTime(2019, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "ThemeMarks",
                columns: new[] { "Id", "Comment", "InternId", "Mark", "ThemeId" },
                values: new object[,]
                {
                    { 1L, "Good", 1L, 9.0, 1L },
                    { 2L, "No Comment", 1L, 1.0, 1L },
                    { 3L, "The Best", 2L, 10.0, 2L },
                    { 4L, null, 1L, 8.0, 4L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ThemeMarks",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "ThemeMarks",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "ThemeMarks",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "ThemeMarks",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3L);
        }
    }
}
