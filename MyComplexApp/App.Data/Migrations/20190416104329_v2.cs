using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "-821159610");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "843965884");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "-444230126");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "451c7962-41fa-47f1-8ece-f5739488eaf9", "181499254" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9c293a03-ac10-46db-b7c3-7972c8651f36", "1947001317" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "87235235-5eee-4a05-a09e-29d4707cec7d", "684924813" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5fae4a54-3015-4ec5-9e2d-e4b4bbb87c5b", "-1874551532" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ea3f1d5a-915b-440f-be42-6c309cb5c7bb", "1713575187" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "DateComment", "ThemeId", "UserId" },
                values: new object[,]
                {
                    { 9L, "po'p'l';l;l'.", new DateTime(2019, 4, 16, 13, 43, 28, 901, DateTimeKind.Local).AddTicks(7303), 3L, 2L },
                    { 7L, "qq q q q q q q", new DateTime(2019, 4, 16, 13, 43, 28, 901, DateTimeKind.Local).AddTicks(7296), 2L, 3L },
                    { 6L, "iopoipio iop io io.", new DateTime(2019, 4, 16, 13, 43, 28, 901, DateTimeKind.Local).AddTicks(7292), 2L, 1L },
                    { 5L, "zxcxzcxz zc xz cxz z.", new DateTime(2019, 4, 16, 13, 43, 28, 901, DateTimeKind.Local).AddTicks(7289), 1L, 3L },
                    { 4L, "asdsadsa sadsadsa dsa.", new DateTime(2019, 4, 16, 13, 43, 28, 901, DateTimeKind.Local).AddTicks(7285), 4L, 2L },
                    { 3L, "qewqeqewqqewq.", new DateTime(2019, 4, 16, 13, 43, 28, 901, DateTimeKind.Local).AddTicks(7279), 1L, 4L },
                    { 2L, "dsafdsda.", new DateTime(2019, 4, 16, 13, 43, 28, 901, DateTimeKind.Local).AddTicks(7262), 3L, 1L },
                    { 8L, "N4354535 43.", new DateTime(2019, 4, 16, 13, 43, 28, 901, DateTimeKind.Local).AddTicks(7299), 1L, 4L },
                    { 1L, "Nicjdsladj sal djsa dsadsa.", new DateTime(2019, 4, 16, 13, 43, 28, 899, DateTimeKind.Local).AddTicks(3479), 1L, 2L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "-1025030764");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "1249488988");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "263676492");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "44eca687-0e32-4e6a-9fef-452d1e2a302a", "-943891492" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0d84869a-3718-49ce-b1a5-bbbe8484336e", "1630691884" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ab7fb2ce-7e18-4017-b7ca-1dcb7453747f", "-350703844" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1dfdc4d9-a6fe-40fa-aad8-b3322fcf3d79", "13987656" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "941fb0c6-dfc2-4ede-995d-097c6545c383", "-1415464994" });
        }
    }
}
