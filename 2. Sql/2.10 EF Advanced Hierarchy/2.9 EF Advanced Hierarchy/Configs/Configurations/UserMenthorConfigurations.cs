using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._9_EF_Advanced_Hierarchy.Configurations
{
    class UserMenthorConfigurations : IEntityTypeConfiguration<UserMenthor>
    {
        public void Configure(EntityTypeBuilder<UserMenthor> builder)
        {
            builder.Property(x => x.Job).HasMaxLength(20);
            builder.Property(x => x.Level).HasMaxLength(30);
        }
    }
}
