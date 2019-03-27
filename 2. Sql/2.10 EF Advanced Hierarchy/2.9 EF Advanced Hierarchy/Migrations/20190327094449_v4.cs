using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _2._9_EF_Advanced_Hierarchy.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Discriminator", "EMail", "FirstName", "LastName", "Login", "NumberPhone", "Password" },
                values: new object[] { 5L, new DateTime(1994, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "UserMenthor", "alexandr@mail.ru", "Alexandr5", "Racovschi4", "alexandr1633", "+37336218321", "asd1236" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Discriminator", "EMail", "FirstName", "LastName", "Login", "NumberPhone", "Password" },
                values: new object[] { 4L, new DateTime(1994, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "UserMenthor", "alexandr@mail.ru", "Alexandr4", "Racovschi4", "alexandr1633", "+37336218321", "asd1236" });
        }
    }
}
