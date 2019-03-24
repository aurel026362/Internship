using _2._9_EF_Advanced_Hierarchy.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._9_EF_Advanced_Hierarchy.Configs.Configurations
{
    class ThemeMarkConfig : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<ThemeMark>
    {
        public void Configure(EntityTypeBuilder<ThemeMark> builder)
        {
            builder.ToTable("ThemeMarks");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Comment).HasMaxLength(200);

            builder.HasOne(x => x.Intern).WithMany(x => x.ThemeMarks).HasForeignKey(x => x.InternId)
                .OnDelete(DeleteBehavior.Restrict).HasConstraintName("FK_Mark_Intern");

            builder.HasOne(x => x.theme).WithMany(x => x.ThemeMarks).HasForeignKey(x => x.ThemeId)
                .OnDelete(DeleteBehavior.Restrict).HasConstraintName("FK_Mark_Theme");

            builder.Property(x => x.RowVersion).IsRowVersion();

        }
    }
}
