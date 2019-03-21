using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TESTDB.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GROUPS",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 30, nullable: true),
                    StartDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GROUPS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    StartDate = table.Column<DateTime>(type: "smalldatetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 20, nullable: false),
                    LastName = table.Column<string>(maxLength: 20, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    NumberPhone = table.Column<string>(maxLength: 15, nullable: true),
                    Login = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Password = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    EMail = table.Column<string>(unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateOfExamen = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ModuleId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Exams__ModuleId__7187CF4E",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Menthors",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menthors", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Menthors__UserId__5AA469F6",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Interns",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GroupId = table.Column<long>(nullable: false),
                    UserId = table.Column<long>(nullable: false),
                    MenthorId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interns", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Interns__GroupId__61516785",
                        column: x => x.GroupId,
                        principalTable: "GROUPS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Interns__Menthor__6339AFF7",
                        column: x => x.MenthorId,
                        principalTable: "Menthors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Interns__UserId__62458BBE",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Themes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 40, nullable: false),
                    TimeOfTheme = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    Source = table.Column<string>(maxLength: 40, nullable: true),
                    MenthorId = table.Column<long>(nullable: true),
                    ModuleId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Themes", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Themes__MenthorI__67FE6514",
                        column: x => x.MenthorId,
                        principalTable: "Menthors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Themes__ModuleId__68F2894D",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExamMarks",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExamenId = table.Column<long>(nullable: false),
                    InternId = table.Column<long>(nullable: false),
                    Mark = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamMarks", x => x.Id);
                    table.ForeignKey(
                        name: "FK__ExamMarks__Exame__74643BF9",
                        column: x => x.ExamenId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__ExamMarks__Inter__75586032",
                        column: x => x.InternId,
                        principalTable: "Interns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ThemeMarks",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ThemeId = table.Column<long>(nullable: false),
                    InternId = table.Column<long>(nullable: false),
                    Mark = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThemeMarks", x => x.Id);
                    table.ForeignKey(
                        name: "FK__ThemeMark__Inter__6CC31A31",
                        column: x => x.InternId,
                        principalTable: "Interns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__ThemeMark__Theme__6BCEF5F8",
                        column: x => x.ThemeId,
                        principalTable: "Themes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExamMarks_ExamenId",
                table: "ExamMarks",
                column: "ExamenId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamMarks_InternId",
                table: "ExamMarks",
                column: "InternId");

            migrationBuilder.CreateIndex(
                name: "UQ__Exams__2B7477A6ED80BB8B",
                table: "Exams",
                column: "ModuleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Interns_GroupId",
                table: "Interns",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "UQ__Interns__262694BBC14690F6",
                table: "Interns",
                column: "MenthorId",
                unique: true,
                filter: "[MenthorId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__Interns__1788CC4D9B185DF7",
                table: "Interns",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Menthors__1788CC4D01D0DA72",
                table: "Menthors",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ThemeMarks_InternId",
                table: "ThemeMarks",
                column: "InternId");

            migrationBuilder.CreateIndex(
                name: "IX_ThemeMarks_ThemeId",
                table: "ThemeMarks",
                column: "ThemeId");

            migrationBuilder.CreateIndex(
                name: "IX_Themes_MenthorId",
                table: "Themes",
                column: "MenthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Themes_ModuleId",
                table: "Themes",
                column: "ModuleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExamMarks");

            migrationBuilder.DropTable(
                name: "ThemeMarks");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "Interns");

            migrationBuilder.DropTable(
                name: "Themes");

            migrationBuilder.DropTable(
                name: "GROUPS");

            migrationBuilder.DropTable(
                name: "Menthors");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
