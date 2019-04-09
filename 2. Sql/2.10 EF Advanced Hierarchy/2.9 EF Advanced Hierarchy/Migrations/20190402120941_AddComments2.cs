using Microsoft.EntityFrameworkCore.Migrations;

namespace _2._9_EF_Advanced_Hierarchy.Migrations
{
    public partial class AddComments2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_UserMenthorId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_UserMenthorId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "UserMenthorId",
                table: "Comments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "UserMenthorId",
                table: "Comments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserMenthorId",
                table: "Comments",
                column: "UserMenthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_UserMenthorId",
                table: "Comments",
                column: "UserMenthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
