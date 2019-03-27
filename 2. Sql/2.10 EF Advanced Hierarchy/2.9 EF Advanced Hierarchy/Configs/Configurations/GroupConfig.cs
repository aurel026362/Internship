using _2._9_EF_Advanced_Hierarchy.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._9_EF_Advanced_Hierarchy.Configs.Configurations
{
    class GroupConfig : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.ToTable("Groups");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(30);
            builder.Property(x => x.StartDate).HasColumnType("smalldatetime");

            builder.HasData(
               new Group
               {
                   Id = 1,
                   Name = "Interns123",
                   StartDate = Convert.ToDateTime("2019/02/01")
               },
               new Group
               {
                   Id = 2,
                   Name = "interns234",
                   StartDate = Convert.ToDateTime("2019-06-01")
               }
               );
        }
    }
}
