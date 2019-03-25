using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TESTDB.Migrations
{
    public partial class WithData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GROUPS",
                columns: new[] { "Id", "Name", "StartDate" },
                values: new object[] { 1L, "Interns123", new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "EMail", "FirstName", "LastName", "Login", "NumberPhone", "Password" },
                values: new object[,]
                {
                    { 1L, new DateTime(1999, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "aurel@mail.ru", "Aurel", "Starciuc", "aurel12345", "+37367620932", "12345" },
                    { 2L, new DateTime(1997, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "cristia@mail.ru", "Cristi", "Anghelenici", "cristi12345", "++3732167321", "54321" },
                    { 3L, new DateTime(1994, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "alexandr@mail.ru", "Alexandr", "Racovschi", "alexandr1633", "+37336218321", "asd1236" },
                    { 4L, new DateTime(1984, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "iong@mail.ru", "Ion", "Gandrabura", "ion79345", "+373954035", "asdqwe123" }
                });

            migrationBuilder.InsertData(
                table: "Menthors",
                columns: new[] { "Id", "UserId" },
                values: new object[] { 1L, 3L });

            migrationBuilder.InsertData(
                table: "Menthors",
                columns: new[] { "Id", "UserId" },
                values: new object[] { 2L, 4L });

            migrationBuilder.InsertData(
                table: "Interns",
                columns: new[] { "Id", "GroupId", "MenthorId", "UserId" },
                values: new object[] { 2L, 1L, 1L, 2L });

            migrationBuilder.InsertData(
                table: "Interns",
                columns: new[] { "Id", "GroupId", "MenthorId", "UserId" },
                values: new object[] { 1L, 1L, 2L, 1L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Interns",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Interns",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "GROUPS",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Menthors",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Menthors",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L);
        }
    }
}
