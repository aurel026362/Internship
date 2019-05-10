using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "PhoneNumberConfirmed",
                table: "RequestedUsers");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "RequestedUsers");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "RequestedUsers");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "RequestedUsers",
                newName: "Password");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "-1689975465");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "1998290627");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "-1168802217");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4a828646-7c52-4102-b153-9e5368520930", "517659222" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "68b2294b-0047-407f-871f-bd72a1e687c3", "75786608" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2c05bc6a-dff6-4f11-a56f-4ee04df8a2f2", "1555676843" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f71cca3a-08b9-415c-ad93-b7ab92850a77", "-1754930925" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "76c39cd4-74bb-44b0-b80b-cc47b6953f2a", "1297788367" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateComment",
                value: new DateTime(2019, 5, 10, 17, 9, 58, 41, DateTimeKind.Local).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateComment",
                value: new DateTime(2019, 5, 10, 17, 9, 58, 43, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3L,
                column: "DateComment",
                value: new DateTime(2019, 5, 10, 17, 9, 58, 43, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4L,
                column: "DateComment",
                value: new DateTime(2019, 5, 10, 17, 9, 58, 43, DateTimeKind.Local).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5L,
                column: "DateComment",
                value: new DateTime(2019, 5, 10, 17, 9, 58, 43, DateTimeKind.Local).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6L,
                column: "DateComment",
                value: new DateTime(2019, 5, 10, 17, 9, 58, 43, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7L,
                column: "DateComment",
                value: new DateTime(2019, 5, 10, 17, 9, 58, 43, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8L,
                column: "DateComment",
                value: new DateTime(2019, 5, 10, 17, 9, 58, 43, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9L,
                column: "DateComment",
                value: new DateTime(2019, 5, 10, 17, 9, 58, 43, DateTimeKind.Local).AddTicks(7455));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "RequestedUsers",
                newName: "UserName");

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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "2136113851");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "1458260772");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "ConcurrencyStamp",
                value: "-591555148");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6f367ff4-5ce3-458c-8f4d-dd8ae386e903", "-346738272" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "708c03ff-18c9-4799-bce4-4df19e3b03fb", "-2103642142" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ce73eed-70de-41f8-aaff-9d6ed41305f2", "1469126538" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c85debc1-8d6c-4263-b1c3-3f075313a687", "-38941081" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "16c9f2c9-db0b-4e42-820b-9f7cec984a5b", "259351512" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateComment",
                value: new DateTime(2019, 5, 10, 13, 36, 13, 657, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateComment",
                value: new DateTime(2019, 5, 10, 13, 36, 13, 659, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3L,
                column: "DateComment",
                value: new DateTime(2019, 5, 10, 13, 36, 13, 659, DateTimeKind.Local).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4L,
                column: "DateComment",
                value: new DateTime(2019, 5, 10, 13, 36, 13, 659, DateTimeKind.Local).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5L,
                column: "DateComment",
                value: new DateTime(2019, 5, 10, 13, 36, 13, 659, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6L,
                column: "DateComment",
                value: new DateTime(2019, 5, 10, 13, 36, 13, 659, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7L,
                column: "DateComment",
                value: new DateTime(2019, 5, 10, 13, 36, 13, 659, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8L,
                column: "DateComment",
                value: new DateTime(2019, 5, 10, 13, 36, 13, 659, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9L,
                column: "DateComment",
                value: new DateTime(2019, 5, 10, 13, 36, 13, 659, DateTimeKind.Local).AddTicks(9089));
        }
    }
}
