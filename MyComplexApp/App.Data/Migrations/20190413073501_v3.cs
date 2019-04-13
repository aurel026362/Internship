using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ThemeMarks_InternId",
                table: "ThemeMarks");

            migrationBuilder.DropIndex(
                name: "IX_ExamMarks_InternId",
                table: "ExamMarks");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "257d19df-b232-4351-a333-9f51daf54586", "1649895019" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "575af4ca-5c93-473d-81b7-22e810467de0", "654211248" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "30e928b5-cc2a-4fc4-8da4-b08989df0f21", "417983893" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8849337f-b66a-4449-add2-1e091d3ab27e", "-1063559547" });

            migrationBuilder.CreateIndex(
                name: "IX_ThemeMarks_InternId_ThemeId",
                table: "ThemeMarks",
                columns: new[] { "InternId", "ThemeId" });

            migrationBuilder.CreateIndex(
                name: "IX_ExamMarks_InternId_ExamId",
                table: "ExamMarks",
                columns: new[] { "InternId", "ExamId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ThemeMarks_InternId_ThemeId",
                table: "ThemeMarks");

            migrationBuilder.DropIndex(
                name: "IX_ExamMarks_InternId_ExamId",
                table: "ExamMarks");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "29b87e5d-9751-468f-8319-598d6f64b3b6", "1186476624" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "72ad0cb3-17cd-4595-abc8-6f2638a7c0e2", "2041111096" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9822efd3-ce79-4ebd-9935-88d9ce563e96", "-1898531178" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "81ba87e5-6f67-4a55-b1e0-03025665a4dc", "992253336" });

            migrationBuilder.CreateIndex(
                name: "IX_ThemeMarks_InternId",
                table: "ThemeMarks",
                column: "InternId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamMarks_InternId",
                table: "ExamMarks",
                column: "InternId");
        }
    }
}
