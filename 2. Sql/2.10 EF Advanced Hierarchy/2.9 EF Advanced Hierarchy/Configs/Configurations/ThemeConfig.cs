using _2._9_EF_Advanced_Hierarchy.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._9_EF_Advanced_Hierarchy.Configs.Configurations
{
    class ThemeConfig : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Theme>
    {
        public void Configure(EntityTypeBuilder<Theme> builder)
        {
            builder.ToTable("Themes");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(20);
            builder.Property(x => x.Source).HasMaxLength(100);
            builder.Property(x => x.TimeOfTheme).HasColumnType("smalldatetime");
            builder.Property(x => x.MenthroId).HasColumnName("MenthorId");
            builder.HasOne(x => x.Modulep).WithMany(x => x.Themes).HasForeignKey(x => x.ModuleId);
            builder.HasOne(x => x.Menthor).WithMany(x => x.Themes).HasForeignKey(x => x.MenthroId);
        }
    }
}
