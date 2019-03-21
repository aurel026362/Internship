using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TESTDB.Context.Configurations
{
    class GroupsConfigurations : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.ToTable("GROUPS");

            builder.Property(e => e.Name).HasMaxLength(30);

            builder.Property(e => e.StartDate).HasColumnType("date");
        }
    }
}
