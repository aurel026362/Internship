using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TESTDB.Tables;

namespace TESTDB.Context.Configurations
{
    class MenthorProjectConfigurations : IEntityTypeConfiguration<MenthorProject>
    {
        public void Configure(EntityTypeBuilder<MenthorProject> builder)
        {
            builder.ToTable("MenthorsProjects");
            builder.HasKey(x => new { x.MenthorId, x.ProjectId});
            builder.HasOne(x => x.Menthor).WithMany(x => x.MenthorProjects).HasForeignKey(x => x.MenthorId);
            builder.HasOne(x => x.Project).WithMany(x => x.MenthorProjects).HasForeignKey(x => x.ProjectId);
        }
    }
}
