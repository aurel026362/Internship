using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TESTDB.Context.Configurations
{
    class ThemesConfigurations : IEntityTypeConfiguration<Themes>
    {
        public void Configure(EntityTypeBuilder<Themes> builder)
        {
            builder.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(40);

            builder.Property(e => e.Source).HasMaxLength(40);

            builder.Property(e => e.TimeOfTheme).HasColumnType("smalldatetime");

            builder.HasOne(d => d.Menthor)
                    .WithMany(p => p.Themes)
                    .HasForeignKey(d => d.MenthorId)
                    .HasConstraintName("FK__Themes__MenthorI__67FE6514");

            builder.HasOne(d => d.Module)
                    .WithMany(p => p.Themes)
                    .HasForeignKey(d => d.ModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Themes__ModuleId__68F2894D");

            builder.HasData(
                new Themes
                {
                    Id = 1,
                    Name = "Creational Pattern",
                    TimeOfTheme = Convert.ToDateTime("2019/02/06"),
                    Source = "S:\\Internship\\C#",
                    MenthorId = 1,
                    ModuleId = 1
                },
                new Themes
                {
                    Id = 2,
                    Name = "SQL SELECT",
                    TimeOfTheme = Convert.ToDateTime("2019/03/01"),
                    Source = "S:\\Internship\\SQL",
                    MenthorId = 1,
                    ModuleId = 2
                }, new Themes
                {
                    Id = 3,
                    Name = "EF Core Mapping",
                    TimeOfTheme = Convert.ToDateTime("2019/03/16"),
                    Source = "S:\\Internship\\SQL",
                    MenthorId = 2,
                    ModuleId = 2
                },
                new Themes
                {
                    Id = 4,
                    Name = "JS",
                    TimeOfTheme = Convert.ToDateTime("2019/04/02"),
                    Source = "S:\\Internship\\WEB",
                    MenthorId = 2,
                    ModuleId = 3
                }
                );
        }
    }
}
