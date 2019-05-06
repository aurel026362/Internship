using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 30, nullable: true),
                    StartDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RequestedUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    EMail = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 20, nullable: false),
                    LastName = table.Column<string>(maxLength: 20, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    TypeUser = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestedUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<long>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    EMail = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 15, nullable: false),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 20, nullable: false),
                    LastName = table.Column<string>(maxLength: 20, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    RoleId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    ModuleId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exams_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<long>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<long>(nullable: false),
                    RoleId = table.Column<long>(nullable: false),
                    UserId1 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<long>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_Menthors_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Interns",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GroupId = table.Column<long>(nullable: true),
                    UserId = table.Column<long>(nullable: false),
                    MenthorId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interns_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Interns_Menthors_MenthorId",
                        column: x => x.MenthorId,
                        principalTable: "Menthors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Interns_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Themes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 20, nullable: true),
                    StartDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    Source = table.Column<string>(maxLength: 100, nullable: true),
                    ModuleId = table.Column<long>(nullable: false),
                    MenthorId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Themes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Themes_Menthors_MenthorId",
                        column: x => x.MenthorId,
                        principalTable: "Menthors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Themes_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExamMarks",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Mark = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(maxLength: 200, nullable: true),
                    InternId = table.Column<long>(nullable: false),
                    ExamId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamMarks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamMarks_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamMarks_Interns_InternId",
                        column: x => x.InternId,
                        principalTable: "Interns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<long>(nullable: true),
                    ThemeId = table.Column<long>(nullable: true),
                    Content = table.Column<string>(nullable: false),
                    DateComment = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Themes_ThemeId",
                        column: x => x.ThemeId,
                        principalTable: "Themes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThemeMarks",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Mark = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(maxLength: 200, nullable: true),
                    InternId = table.Column<long>(nullable: true),
                    ThemeId = table.Column<long>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThemeMarks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ThemeMarks_Interns_InternId",
                        column: x => x.InternId,
                        principalTable: "Interns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ThemeMarks_Themes_ThemeId",
                        column: x => x.ThemeId,
                        principalTable: "Themes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1L, "-1173628420", "Admin", "ADMIN" },
                    { 2L, "789838944", "Menthor", "MENTHOR" },
                    { 3L, "-26898352", "Intern", "INTERN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "EMail", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RoleId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1L, 0, "1077fc9f-d29a-48b3-a37d-bfbeb69abe0c", new DateTime(1999, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "aurel@mail.ru", false, "Aurel", "Starciuc", false, null, null, null, "-318062771", "+37367620932", false, null, null, false, "aurel@mail.ru" },
                    { 2L, 0, "b17dd8d7-d03a-46d0-8ccc-886d890d31a1", new DateTime(1989, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "cristi@mail.ru", false, "Cristi", "Anghelenici", false, null, null, null, "-481353250", "+37367665467", false, null, null, false, "cristi@mail.ru" },
                    { 3L, 0, "dce143c8-ee54-4b63-a97b-b3fa208362e6", new DateTime(1994, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "alexandr@mail.ru", false, "Alexandr", "Racovschi", false, null, null, null, "141415814", "+37336218321", false, null, null, false, "alexandr@mail.ru" },
                    { 4L, 0, "c4104344-7fb1-4e37-927f-8ad74094da62", new DateTime(1984, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "iong@mail.ru", false, "Ion", "Gandrabura", false, null, null, null, "-1061961899", "+373954035", false, null, null, false, "iong@mail.ru" },
                    { 5L, 0, "4a9caf5c-ff79-4b24-bedf-eefae658897a", new DateTime(1978, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "gosa@mail.ru", false, "Gosa", "Dudari", false, null, null, null, "853031378", "+37354354398", false, null, null, false, "gosa@mail.ru" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1L, "Interns123", new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, "interns234", new DateTime(2019, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1L, "C#", new DateTime(2019, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, "SQL AND EF CORE", new DateTime(2019, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, "WEB", new DateTime(2019, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
                values: new object[,]
                {
                    { 2L, 1L, 1L, 2L },
                    { 1L, 1L, 2L, 1L }
                });

            migrationBuilder.InsertData(
                table: "Themes",
                columns: new[] { "Id", "MenthorId", "ModuleId", "Name", "Source", "StartDate" },
                values: new object[,]
                {
                    { 1L, 1L, 1L, "Creational Pattern", "S:\\Internship\\C#", new DateTime(2019, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, 1L, 2L, "SQL SELECT", "S:\\Internship\\SQL", new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, 2L, 2L, "EF Core Mapping", "S:\\Internship\\SQL", new DateTime(2019, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, 2L, 3L, "JS", "S:\\Internship\\WEB", new DateTime(2019, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "DateComment", "ThemeId", "UserId" },
                values: new object[,]
                {
                    { 1L, "Nicjdsladj sal djsa dsadsa.", new DateTime(2019, 5, 4, 17, 28, 18, 202, DateTimeKind.Local).AddTicks(648), 1L, 2L },
                    { 3L, "qewqeqewqqewq.", new DateTime(2019, 5, 4, 17, 28, 18, 205, DateTimeKind.Local).AddTicks(337), 1L, 4L },
                    { 5L, "zxcxzcxz zc xz cxz z.", new DateTime(2019, 5, 4, 17, 28, 18, 205, DateTimeKind.Local).AddTicks(350), 1L, 3L },
                    { 8L, "N4354535 43.", new DateTime(2019, 5, 4, 17, 28, 18, 205, DateTimeKind.Local).AddTicks(370), 1L, 4L },
                    { 6L, "iopoipio iop io io.", new DateTime(2019, 5, 4, 17, 28, 18, 205, DateTimeKind.Local).AddTicks(357), 2L, 1L },
                    { 7L, "qq q q q q q q", new DateTime(2019, 5, 4, 17, 28, 18, 205, DateTimeKind.Local).AddTicks(363), 2L, 3L },
                    { 2L, "dsafdsda.", new DateTime(2019, 5, 4, 17, 28, 18, 205, DateTimeKind.Local).AddTicks(310), 3L, 1L },
                    { 9L, "po'p'l';l;l'.", new DateTime(2019, 5, 4, 17, 28, 18, 205, DateTimeKind.Local).AddTicks(377), 3L, 2L },
                    { 4L, "asdsadsa sadsadsa dsa.", new DateTime(2019, 5, 4, 17, 28, 18, 205, DateTimeKind.Local).AddTicks(345), 4L, 2L }
                });

            migrationBuilder.InsertData(
                table: "ThemeMarks",
                columns: new[] { "Id", "Comment", "InternId", "Mark", "ThemeId" },
                values: new object[] { 3L, "The Best", 2L, 10, 2L });

            migrationBuilder.InsertData(
                table: "ThemeMarks",
                columns: new[] { "Id", "Comment", "InternId", "Mark", "ThemeId" },
                values: new object[] { 1L, "Good", 1L, 9, 1L });

            migrationBuilder.InsertData(
                table: "ThemeMarks",
                columns: new[] { "Id", "Comment", "InternId", "Mark", "ThemeId" },
                values: new object[] { 2L, "No Comment", 1L, 1, 2L });

            migrationBuilder.InsertData(
                table: "ThemeMarks",
                columns: new[] { "Id", "Comment", "InternId", "Mark", "ThemeId" },
                values: new object[] { 4L, null, 1L, 8, 4L });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId1",
                table: "AspNetUserRoles",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_RoleId",
                table: "AspNetUsers",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ThemeId",
                table: "Comments",
                column: "ThemeId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamMarks_ExamId",
                table: "ExamMarks",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamMarks_InternId_ExamId",
                table: "ExamMarks",
                columns: new[] { "InternId", "ExamId" });

            migrationBuilder.CreateIndex(
                name: "IX_Exams_ModuleId",
                table: "Exams",
                column: "ModuleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Interns_GroupId",
                table: "Interns",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Interns_MenthorId",
                table: "Interns",
                column: "MenthorId",
                unique: true,
                filter: "[MenthorId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Interns_UserId",
                table: "Interns",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Menthors_UserId",
                table: "Menthors",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ThemeMarks_ThemeId",
                table: "ThemeMarks",
                column: "ThemeId");

            migrationBuilder.CreateIndex(
                name: "IX_ThemeMarks_InternId_ThemeId",
                table: "ThemeMarks",
                columns: new[] { "InternId", "ThemeId" });

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "ExamMarks");

            migrationBuilder.DropTable(
                name: "RequestedUsers");

            migrationBuilder.DropTable(
                name: "ThemeMarks");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "Interns");

            migrationBuilder.DropTable(
                name: "Themes");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Menthors");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");
        }
    }
}
