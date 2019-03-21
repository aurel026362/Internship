using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirst.Configurations
{
    class MarksConfigurations : IEntityTypeConfiguration<Marks>
    {
        public void Configure(EntityTypeBuilder<Marks> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Discipline).HasMaxLength(20);
            builder.HasOne(x => x.student).WithMany(x => x.SMarks);
        }
    }
}
