using App.Data.Domain.DomainModels.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Domain.DomainModelsConfigs.ConcreteConfigs
{
    public class ThemeMarkConfig : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<ThemeMark>
    {
        public void Configure(EntityTypeBuilder<ThemeMark> builder)
        {
            builder.ToTable("ThemeMarks");
            builder.HasKey(x => x.Id);
            builder.HasIndex(x=> new { x.InternId, x.ThemeId});
            builder.Property(x => x.Comment).HasMaxLength(200);

            builder.HasOne(x => x.Intern).WithMany(x => x.ThemeMarks).HasForeignKey(x => x.InternId).OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Theme).WithMany(x => x.ThemeMarks).HasForeignKey(x => x.ThemeId).OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.RowVersion).IsRowVersion();

            builder.HasData(
                new ThemeMark
                {
                    Id = 1,
                    Comment = "Good",
                    Mark = 9,
                    InternId = 1,
                    ThemeId = 1
                },
                new ThemeMark
                {
                    Id = 2,
                    Comment = "No Comment",
                    Mark = 1,
                    InternId = 1,
                    ThemeId = 2
                },
                new ThemeMark
                {
                    Id = 3,
                    Comment = "The Best",
                    Mark = 10,
                    InternId = 2,
                    ThemeId = 2
                },
                new ThemeMark
                {
                    Id = 4,
                    Mark = 8,
                    InternId = 1,
                    ThemeId = 4
                }
            );

        }
    }
}
