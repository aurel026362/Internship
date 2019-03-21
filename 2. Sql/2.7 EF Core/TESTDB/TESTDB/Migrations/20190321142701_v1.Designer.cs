﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TESTDB;

namespace TESTDB.Migrations
{
    [DbContext(typeof(TESTDBContext))]
    [Migration("20190321142701_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TESTDB.ExamMarks", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ExamenId");

                    b.Property<long>("InternId");

                    b.Property<double?>("Mark");

                    b.HasKey("Id");

                    b.HasIndex("ExamenId");

                    b.HasIndex("InternId");

                    b.ToTable("ExamMarks");
                });

            modelBuilder.Entity("TESTDB.Exams", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateOfExamen")
                        .HasColumnType("smalldatetime");

                    b.Property<long>("ModuleId");

                    b.HasKey("Id");

                    b.HasIndex("ModuleId")
                        .IsUnique()
                        .HasName("UQ__Exams__2B7477A6ED80BB8B");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("TESTDB.Group", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(30);

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("GROUPS");
                });

            modelBuilder.Entity("TESTDB.Interns", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("GroupId");

                    b.Property<long?>("MenthorId");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("MenthorId")
                        .IsUnique()
                        .HasName("UQ__Interns__262694BBC14690F6")
                        .HasFilter("[MenthorId] IS NOT NULL");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasName("UQ__Interns__1788CC4D9B185DF7");

                    b.ToTable("Interns");
                });

            modelBuilder.Entity("TESTDB.Menthors", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasName("UQ__Menthors__1788CC4D01D0DA72");

                    b.ToTable("Menthors");
                });

            modelBuilder.Entity("TESTDB.Modules", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("smalldatetime");

                    b.HasKey("Id");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("TESTDB.ThemeMarks", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("InternId");

                    b.Property<double>("Mark");

                    b.Property<long>("ThemeId");

                    b.HasKey("Id");

                    b.HasIndex("InternId");

                    b.HasIndex("ThemeId");

                    b.ToTable("ThemeMarks");
                });

            modelBuilder.Entity("TESTDB.Themes", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("MenthorId");

                    b.Property<long>("ModuleId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Source")
                        .HasMaxLength(40);

                    b.Property<DateTime?>("TimeOfTheme")
                        .HasColumnType("smalldatetime");

                    b.HasKey("Id");

                    b.HasIndex("MenthorId");

                    b.HasIndex("ModuleId");

                    b.ToTable("Themes");
                });

            modelBuilder.Entity("TESTDB.Users", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("EMail")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("NumberPhone")
                        .HasMaxLength(15);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TESTDB.ExamMarks", b =>
                {
                    b.HasOne("TESTDB.Exams", "Examen")
                        .WithMany("ExamMarks")
                        .HasForeignKey("ExamenId")
                        .HasConstraintName("FK__ExamMarks__Exame__74643BF9");

                    b.HasOne("TESTDB.Interns", "Intern")
                        .WithMany("ExamMarks")
                        .HasForeignKey("InternId")
                        .HasConstraintName("FK__ExamMarks__Inter__75586032");
                });

            modelBuilder.Entity("TESTDB.Exams", b =>
                {
                    b.HasOne("TESTDB.Modules", "Module")
                        .WithOne("Exams")
                        .HasForeignKey("TESTDB.Exams", "ModuleId")
                        .HasConstraintName("FK__Exams__ModuleId__7187CF4E");
                });

            modelBuilder.Entity("TESTDB.Interns", b =>
                {
                    b.HasOne("TESTDB.Group", "Group")
                        .WithMany("Interns")
                        .HasForeignKey("GroupId")
                        .HasConstraintName("FK__Interns__GroupId__61516785");

                    b.HasOne("TESTDB.Menthors", "Menthor")
                        .WithOne("Interns")
                        .HasForeignKey("TESTDB.Interns", "MenthorId")
                        .HasConstraintName("FK__Interns__Menthor__6339AFF7");

                    b.HasOne("TESTDB.Users", "User")
                        .WithOne("Interns")
                        .HasForeignKey("TESTDB.Interns", "UserId")
                        .HasConstraintName("FK__Interns__UserId__62458BBE");
                });

            modelBuilder.Entity("TESTDB.Menthors", b =>
                {
                    b.HasOne("TESTDB.Users", "User")
                        .WithOne("Menthors")
                        .HasForeignKey("TESTDB.Menthors", "UserId")
                        .HasConstraintName("FK__Menthors__UserId__5AA469F6");
                });

            modelBuilder.Entity("TESTDB.ThemeMarks", b =>
                {
                    b.HasOne("TESTDB.Interns", "Intern")
                        .WithMany("ThemeMarks")
                        .HasForeignKey("InternId")
                        .HasConstraintName("FK__ThemeMark__Inter__6CC31A31");

                    b.HasOne("TESTDB.Themes", "Theme")
                        .WithMany("ThemeMarks")
                        .HasForeignKey("ThemeId")
                        .HasConstraintName("FK__ThemeMark__Theme__6BCEF5F8");
                });

            modelBuilder.Entity("TESTDB.Themes", b =>
                {
                    b.HasOne("TESTDB.Menthors", "Menthor")
                        .WithMany("Themes")
                        .HasForeignKey("MenthorId")
                        .HasConstraintName("FK__Themes__MenthorI__67FE6514");

                    b.HasOne("TESTDB.Modules", "Module")
                        .WithMany("Themes")
                        .HasForeignKey("ModuleId")
                        .HasConstraintName("FK__Themes__ModuleId__68F2894D");
                });
#pragma warning restore 612, 618
        }
    }
}
