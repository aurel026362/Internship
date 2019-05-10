using App.Data.Domain.DomainModels.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Domain.DomainModelsConfigs.ConcreteConfigs
{
    public class GroupConfig : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.ToTable("Groups");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(50);
            builder.Property(x => x.StartDate).HasColumnType("date");

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
