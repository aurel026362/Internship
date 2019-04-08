using App.Data.Domain.DomainModels.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Domain.DomainModelsConfigs.ConcreteConfigs
{
    class ExamConfig : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Exam>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Exam> builder)
        {
            builder.ToTable("Exams");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Date).HasColumnType("smalldatetime");
            builder.HasOne(x => x.Module).WithOne(x => x.Exam).HasForeignKey<Exam>(x => x.ModuleId);
        }
    }
}
