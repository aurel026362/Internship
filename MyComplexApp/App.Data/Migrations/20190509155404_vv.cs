using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class vv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "-151350337");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "756961811");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "1727800283");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dfcaf29c-e40a-4827-90b7-7c4f82b6f3cb", "-676656470" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "19c3808b-901d-4a80-9cd2-068dbd62a802", "2106376617" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cffb2a68-ce21-4e7d-b757-2832602b51ca", "-156999296" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bf794cc2-a4c3-44d9-89a8-7ddddec7f980", "-695038195" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9fe82a53-cf15-4c9d-bbef-0ed7bee7279d", "1929270129" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateComment",
                value: new DateTime(2019, 5, 9, 18, 54, 4, 49, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateComment",
                value: new DateTime(2019, 5, 9, 18, 54, 4, 51, DateTimeKind.Local).AddTicks(9204));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3L,
                column: "DateComment",
                value: new DateTime(2019, 5, 9, 18, 54, 4, 51, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4L,
                column: "DateComment",
                value: new DateTime(2019, 5, 9, 18, 54, 4, 51, DateTimeKind.Local).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5L,
                column: "DateComment",
                value: new DateTime(2019, 5, 9, 18, 54, 4, 51, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6L,
                column: "DateComment",
                value: new DateTime(2019, 5, 9, 18, 54, 4, 51, DateTimeKind.Local).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7L,
                column: "DateComment",
                value: new DateTime(2019, 5, 9, 18, 54, 4, 51, DateTimeKind.Local).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8L,
                column: "DateComment",
                value: new DateTime(2019, 5, 9, 18, 54, 4, 51, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9L,
                column: "DateComment",
                value: new DateTime(2019, 5, 9, 18, 54, 4, 51, DateTimeKind.Local).AddTicks(9255));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "-1173628420");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "789838944");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "-26898352");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1077fc9f-d29a-48b3-a37d-bfbeb69abe0c", "-318062771" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b17dd8d7-d03a-46d0-8ccc-886d890d31a1", "-481353250" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dce143c8-ee54-4b63-a97b-b3fa208362e6", "141415814" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c4104344-7fb1-4e37-927f-8ad74094da62", "-1061961899" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4a9caf5c-ff79-4b24-bedf-eefae658897a", "853031378" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateComment",
                value: new DateTime(2019, 5, 4, 17, 28, 18, 202, DateTimeKind.Local).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateComment",
                value: new DateTime(2019, 5, 4, 17, 28, 18, 205, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3L,
                column: "DateComment",
                value: new DateTime(2019, 5, 4, 17, 28, 18, 205, DateTimeKind.Local).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4L,
                column: "DateComment",
                value: new DateTime(2019, 5, 4, 17, 28, 18, 205, DateTimeKind.Local).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5L,
                column: "DateComment",
                value: new DateTime(2019, 5, 4, 17, 28, 18, 205, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6L,
                column: "DateComment",
                value: new DateTime(2019, 5, 4, 17, 28, 18, 205, DateTimeKind.Local).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7L,
                column: "DateComment",
                value: new DateTime(2019, 5, 4, 17, 28, 18, 205, DateTimeKind.Local).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8L,
                column: "DateComment",
                value: new DateTime(2019, 5, 4, 17, 28, 18, 205, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9L,
                column: "DateComment",
                value: new DateTime(2019, 5, 4, 17, 28, 18, 205, DateTimeKind.Local).AddTicks(377));
        }
    }
}
