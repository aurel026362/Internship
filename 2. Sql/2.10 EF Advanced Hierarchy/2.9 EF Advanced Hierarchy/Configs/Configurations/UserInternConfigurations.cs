using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._9_EF_Advanced_Hierarchy.Configurations
{
    class UserInternConfigurations : IEntityTypeConfiguration<UserIntern>
    {
        public void Configure(EntityTypeBuilder<UserIntern> builder)
        {
            builder.Property(x => x.Speciality).HasMaxLength(20);
            builder.HasOne(x => x.Group).WithMany(x => x.Interns).HasForeignKey(x => x.GroupId);
        }
    }
}
