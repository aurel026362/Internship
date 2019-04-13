using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interns_Groups_GroupId",
                table: "Interns");

            migrationBuilder.AlterColumn<long>(
                name: "GroupId",
                table: "Interns",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e73bec47-bbe9-4ae4-bae4-b1bc45e78294", "494091657" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a61f7ebd-76d0-49d3-adb1-32cb016f2733", "650237439" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "af61181c-d8a0-42d6-8b5f-07a977493cef", "-1011549758" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c6535135-1283-42bd-8525-d45d559c63ac", "-2053212294" });

            migrationBuilder.AddForeignKey(
                name: "FK_Interns_Groups_GroupId",
                table: "Interns",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interns_Groups_GroupId",
                table: "Interns");

            migrationBuilder.AlterColumn<long>(
                name: "GroupId",
                table: "Interns",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Interns_Groups_GroupId",
                table: "Interns",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
