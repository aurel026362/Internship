using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._9_EF_Advanced_Hierarchy.Configurations
{
    class ExchangesConfigurations : IEntityTypeConfiguration<Exchange>
    {
        public void Configure(EntityTypeBuilder<Exchange> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Valute).HasMaxLength(20);
            builder.Property(x => x.InMDL).IsRequired().HasMaxLength(100);
            builder.Property(x => x.RowVersion).IsRowVersion();
        }
    }
}
