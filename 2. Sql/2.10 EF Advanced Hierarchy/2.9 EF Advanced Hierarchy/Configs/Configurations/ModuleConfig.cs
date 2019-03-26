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

            builder.HasData(
               new Module()
               {
                   Id = 1,
                   Name = "C#",
                   DateStart = Convert.ToDateTime("2019/02/04")
               },
               new Module()
               {
                   Id = 2,
                   Name = "SQL AND EF CORE",
                   DateStart = Convert.ToDateTime("2019/03/04")
               },
               new Module()
               {
                   Id = 3,
                   Name = "WEB",
                   DateStart = Convert.ToDateTime("2019/04/04")
               }
               );
        }
    }
}
