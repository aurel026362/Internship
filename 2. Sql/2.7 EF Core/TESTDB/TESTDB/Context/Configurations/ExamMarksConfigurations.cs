using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TESTDB.Context.Configurations
{
    class ExamMarksConfigurations : IEntityTypeConfiguration<ExamMarks>
    {
        public void Configure(EntityTypeBuilder<ExamMarks> builder)
        {
            builder.HasOne(d => d.Examen)
                    .WithMany(p => p.ExamMarks)
                    .HasForeignKey(d => d.ExamenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ExamMarks__Exame__74643BF9");

            builder.HasOne(d => d.Intern)
                    .WithMany(p => p.ExamMarks)
                    .HasForeignKey(d => d.InternId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ExamMarks__Inter__75586032");
        }
    }
}
