using Microsoft.EntityFrameworkCore.Migrations;

namespace _2._9_EF_Advanced_Hierarchy.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ThemeMarks",
                columns: new[] { "Id", "Comment", "InternId", "Mark", "ThemeId" },
                values: new object[] { 1L, "Good", 1L, 9, 1L });

            migrationBuilder.InsertData(
                table: "ThemeMarks",
                columns: new[] { "Id", "Comment", "InternId", "Mark", "ThemeId" },
                values: new object[] { 2L, "No Comment", 1L, 1, 1L });

            migrationBuilder.InsertData(
                table: "ThemeMarks",
                columns: new[] { "Id", "Comment", "InternId", "Mark", "ThemeId" },
                values: new object[] { 3L, "The Best", 2L, 10, 2L });

            migrationBuilder.InsertData(
                table: "ThemeMarks",
                columns: new[] { "Id", "Comment", "InternId", "Mark", "ThemeId" },
                values: new object[] { 4L, null, 1L, 8, 4L });
        }
    }
}
