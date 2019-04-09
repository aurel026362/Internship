using _2._9_EF_Advanced_Hierarchy.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._9_EF_Advanced_Hierarchy.Configs.Configurations
{
    class CommentConfigs : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Theme).WithMany(x => x.Comments).HasForeignKey(x => x.ThemeId);
            builder.HasOne(x => x.User).WithMany(x => x.Comments).HasForeignKey(x => x.UserId);
        }
    }
}
