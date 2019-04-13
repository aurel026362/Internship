
using App.Data.Domain.DomainModels.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Domain.DomainModelsConfigs.ConcreteConfigs
{
    public class ExamMarkConfig : IEntityTypeConfiguration<ExamMark>
    {
        public void Configure(EntityTypeBuilder<ExamMark> builder)
        {
            builder.ToTable("ExamMarks");
            builder.HasKey(x => x.Id);
            builder.HasIndex(x=> new { x.InternId, x.ExamId});
            builder.Property(x => x.Comment).HasMaxLength(200);
            builder.HasOne(x => x.Intern).WithMany(x => x.ExamMarks).HasForeignKey(x => x.InternId);
            builder.HasOne(x => x.Exam).WithMany(x => x.ExamMarks).HasForeignKey(x => x.ExamId);
           
        }
    }
}
