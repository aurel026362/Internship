using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TESTDB.Context.Configurations
{
    class ExamsConfigurations : IEntityTypeConfiguration<Exams>
    {
        public void Configure(EntityTypeBuilder<Exams> builder)
        {
            builder.HasIndex(e => e.ModuleId)
                    .HasName("UQ__Exams__2B7477A6ED80BB8B")
                    .IsUnique();

            builder.Property(e => e.DateOfExamen).HasColumnType("smalldatetime");

            builder.HasOne(d => d.Module)
                    .WithOne(p => p.Exams)
                    .HasForeignKey<Exams>(d => d.ModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Exams__ModuleId__7187CF4E");
        }   
    }
}
