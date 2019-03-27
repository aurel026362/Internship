using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _2._9_EF_Advanced_Hierarchy.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateOfBirth", "EMail", "FirstName", "LastName", "Login", "NumberPhone", "Password" },
                values: new object[] { new DateTime(1994, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "alexandr@mail.ru", "Alexandr4", "Racovschi4", "alexandr1633", "+37336218321", "asd1236" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DateOfBirth", "EMail", "FirstName", "LastName", "Login", "NumberPhone", "Password" },
                values: new object[] { new DateTime(1984, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "iong@mail.ru", "Ion", "Gandrabura", "ion79345", "+373954035", "asdqwe123" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Discriminator", "EMail", "FirstName", "LastName", "Login", "NumberPhone", "Password" },
                values: new object[] { 3L, new DateTime(1994, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "UserMenthor", "alexandr@mail.ru", "Alexandr", "Racovschi", "alexandr1633", "+37336218321", "asd1236" });
        }
    }
}
