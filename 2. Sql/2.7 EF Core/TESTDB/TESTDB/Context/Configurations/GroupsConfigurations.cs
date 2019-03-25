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

            builder.HasKey(x => x.Id);
            
            builder.Property(e => e.Name).HasMaxLength(30);

            builder.Property(e => e.StartDate).HasColumnType("date");

            builder.HasData(
                new Group
                {
                    Id = 1,
                    Name = "Interns123",
                    StartDate = Convert.ToDateTime("2019/02/01")
                }
                );
        }
    }
}
