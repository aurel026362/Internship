using _2._9_EF_Advanced_Hierarchy.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._9_EF_Advanced_Hierarchy.Configs.Configurations
{
    class ModuleConfig : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Module>
    {
        public void Configure(EntityTypeBuilder<Module> builder)
        {
            builder.ToTable("Modules");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(20).HasColumnType("nvarchar");
            builder.Property(x => x.DateStart).HasColumnType("date");
        }
    }
}
