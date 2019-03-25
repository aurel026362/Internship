using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TESTDB.Context.Configurations
{
    class ModulesConfigurations : IEntityTypeConfiguration<Modules>
    {
        public void Configure(EntityTypeBuilder<Modules> builder)
        {
            builder.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);

            builder.Property(e => e.StartDate).HasColumnType("smalldatetime");

            builder.HasData(
                new Modules()
                {
                    Id = 1,
                    Name = "C#",
                    StartDate = Convert.ToDateTime("2019/02/04")
                },
                new Modules()
                {
                    Id = 2,
                    Name = "SQL AND EF CORE",
                    StartDate = Convert.ToDateTime("2019/03/04")
                },
                new Modules()
                {
                    Id = 3,
                    Name = "WEB",
                    StartDate = Convert.ToDateTime("2019/04/04")
                }
                );
        }
    }
}
