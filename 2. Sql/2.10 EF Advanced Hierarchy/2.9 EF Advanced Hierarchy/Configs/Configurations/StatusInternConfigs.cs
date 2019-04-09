using _2._9_EF_Advanced_Hierarchy.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._9_EF_Advanced_Hierarchy.Configs.Configurations
{
    //class StatusInternConfigs : IEntityTypeConfiguration<StatusIntern>
    //{
    //    public void Configure(EntityTypeBuilder<StatusIntern> builder)
    //    {
    //        builder.HasKey(x => x.Id);
    //        builder.Property(x => x.Status).HasColumnType("nvarchar(20)");
    //        builder.HasOne(x => x.Intern).WithMany(x => x.Statuses).HasForeignKey(x => x.InternId);
    //        builder.HasOne(x => x.Theme).WithMany(x => x.States).HasForeignKey(x => x.ThemeId);
    //    }
    //}
}
