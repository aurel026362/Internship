using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TESTDB.Tables;

namespace TESTDB.Context.Configurations
{
    class ProjectConfigurations : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Projects");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(50);
            builder.Property(x => x.DurationDays);
            builder.HasMany(x => x.MenthorProjects).WithOne(x => x.Project).HasForeignKey(x => x.ProjectId);
        }
    }
}
