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
            builder.Property(x => x.Content).IsRequired();

            builder.HasData(
                new Comment()
                {
                    Id = 1,
                    UserId = 2,
                    ThemeId = 1,
                    Content = "Nicjdsladj sal djsa dsadsa.",
                    DateComment = DateTime.Now
                },
                new Comment()
                {
                    Id = 2,
                    UserId = 1,
                    ThemeId = 3,
                    Content = "dsafdsda.",
                    DateComment = DateTime.Now
                },
                new Comment()
                {
                    Id = 3,
                    UserId = 4,
                    ThemeId = 1,
                    Content = "qewqeqewqqewq.",
                    DateComment = DateTime.Now
                },
                new Comment()
                {
                    Id = 4,
                    UserId = 2,
                    ThemeId = 4,
                    Content = "asdsadsa sadsadsa dsa.",
                    DateComment = DateTime.Now
                },
                new Comment()
                {
                    Id = 5,
                    UserId = 3,
                    ThemeId = 1,
                    Content = "zxcxzcxz zc xz cxz z.",
                    DateComment = DateTime.Now
                },
                new Comment()
                {
                    Id = 6,
                    UserId = 1,
                    ThemeId = 2,
                    Content = "iopoipio iop io io.",
                    DateComment = DateTime.Now
                },
                new Comment()
                {
                    Id = 7,
                    UserId = 3,
                    ThemeId = 2,
                    Content = "qq q q q q q q",
                    DateComment = DateTime.Now
                },
                new Comment()
                {
                    Id = 8,
                    UserId = 4,
                    ThemeId = 1,
                    Content = "N4354535 43.",
                    DateComment = DateTime.Now
                },
                new Comment()
                {
                    Id = 9,
                    UserId = 2,
                    ThemeId = 3,
                    Content = "po'p'l';l;l'.",
                    DateComment = DateTime.Now
                });
        }
    }
}
