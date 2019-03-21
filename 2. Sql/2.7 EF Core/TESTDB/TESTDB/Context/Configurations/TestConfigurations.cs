using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TESTDB.Tables;

namespace TESTDB.Context.Configurations
{
    class TestConfigurations : IEntityTypeConfiguration<TestTable>
    {
        public void Configure(EntityTypeBuilder<TestTable> builder)
        {
            builder.HasKey(x => x.Id).HasName("Id");
            builder.Property(x => x.Name).HasMaxLength(30);
        }
    }
}
