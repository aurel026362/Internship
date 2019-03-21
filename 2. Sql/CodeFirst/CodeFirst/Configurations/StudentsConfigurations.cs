using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirst.Configurations
{
    class StudentsConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.BirthDay).HasColumnType("date");
            builder.Property(x => x.FirstName).HasMaxLength(20);
            builder.Property(x => x.LastName).HasMaxLength(20);
        }
    }
}
