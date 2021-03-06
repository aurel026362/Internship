﻿using App.Data.Domain.DomainModels.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Domain.DomainModelsConfigs.ConcreteConfigs
{
    public class ModuleConfig : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Module>
    {
        public void Configure(EntityTypeBuilder<Module> builder)
        {
            builder.ToTable("Modules");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasColumnType("nvarchar(50)");
            builder.Property(x => x.StartDate).HasColumnType("date");

            builder.HasData(
               new Module
               {
                   Id = 1,
                   Name = "C#",
                   StartDate = Convert.ToDateTime("2019/02/04")
               },
               new Module
               {
                   Id = 2,
                   Name = "SQL AND EF CORE",
                   StartDate = Convert.ToDateTime("2019/03/04")
               },
               new Module
               {
                   Id = 3,
                   Name = "WEB",
                   StartDate = Convert.ToDateTime("2019/04/04")
               }
               );
        }
    }
}
