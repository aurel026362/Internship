using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TESTDB.Context.Configurations
{
    class ThemeMarksConfigurations : IEntityTypeConfiguration<ThemeMarks>
    {
        public void Configure(EntityTypeBuilder<ThemeMarks> builder)
        {
            builder.HasOne(d => d.Intern)
                    .WithMany(p => p.ThemeMarks)
                    .HasForeignKey(d => d.InternId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ThemeMark__Inter__6CC31A31");

            builder.HasOne(d => d.Theme)
                    .WithMany(p => p.ThemeMarks)
                    .HasForeignKey(d => d.ThemeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ThemeMark__Theme__6BCEF5F8");

            builder.Property(x => x.Comment).HasMaxLength(50);
        }
    }
}
