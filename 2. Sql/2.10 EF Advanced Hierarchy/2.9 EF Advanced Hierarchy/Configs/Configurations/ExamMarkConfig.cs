using _2._9_EF_Advanced_Hierarchy.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._9_EF_Advanced_Hierarchy.Configs.Configurations
{
    class ExamMarkConfig : IEntityTypeConfiguration<ExamMark>
    {
        public void Configure(EntityTypeBuilder<ExamMark> builder)
        {
            builder.ToTable("ExamMarks");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Comment).HasMaxLength(200);
            builder.HasOne(x => x.Intern).WithMany(x => x.ExamMarks).HasForeignKey(x => x.InternId);
            builder.HasOne(x => x.Exam).WithMany(x => x.ExamMarks).HasForeignKey(x => x.ExamId);
        }
    }
}
