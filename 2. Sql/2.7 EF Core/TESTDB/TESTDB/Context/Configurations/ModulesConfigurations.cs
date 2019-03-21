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
        }
    }
}
