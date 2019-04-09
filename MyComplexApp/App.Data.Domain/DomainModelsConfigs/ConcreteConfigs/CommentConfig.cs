using App.Data.Domain.DomainModels.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Domain.DomainModelsConfigs.ConcreteConfigs
{
    public class CommentConfig : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Theme).WithMany(x => x.Comments).HasForeignKey(x => x.ThemeId).OnDelete(DeleteBehavior.ClientSetNull);
            builder.HasOne(x => x.User).WithMany(x => x.Comments).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
