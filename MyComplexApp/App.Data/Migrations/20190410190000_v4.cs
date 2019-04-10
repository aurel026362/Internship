using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberPhone",
                table: "RequestedUsers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "RequestedUsers");

            migrationBuilder.AlterColumn<string>(
                name: "TypeUser",
                table: "RequestedUsers",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "RequestedUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "RequestedUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "RequestedUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "RequestedUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "RequestedUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "RequestedUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "RequestedUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "RequestedUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "RequestedUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "RequestedUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "RequestedUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "RequestedUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "RequestedUsers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "23251655-df63-4f39-ad94-9f719adc75dd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "17cb3830-355a-47d6-b95f-e037db8bf8b4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "4bcdad59-b3ea-4d20-ba53-905984d1dd1e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ConcurrencyStamp",
                value: "88c68724-3c47-47f6-b338-6cbfc396041c");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "RequestedUsers");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "RequestedUsers");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "RequestedUsers");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "RequestedUsers");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "RequestedUsers");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "RequestedUsers");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "RequestedUsers");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "RequestedUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "RequestedUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "RequestedUsers");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "RequestedUsers");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "RequestedUsers");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "RequestedUsers");

            migrationBuilder.AlterColumn<string>(
                name: "TypeUser",
                table: "RequestedUsers",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumberPhone",
                table: "RequestedUsers",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "RequestedUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "1b18b9a1-48d6-4ea1-b82f-f134e74ee2ef");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "4c69eb76-ca52-4daa-b638-3c7398f735ec");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "c652f82b-97c3-44fd-8f4e-4738f2011ce7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4L,
                column: "ConcurrencyStamp",
                value: "a29a7dff-4796-4520-9779-b38b078f8c20");
        }
    }
}
