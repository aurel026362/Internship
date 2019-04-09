using App.Data.Domain.DomainModels.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Domain.DomainModelsConfigs.ConcreteConfigs
{
    public class UserInternConfigurations : IEntityTypeConfiguration<UserIntern>
    {
        public void Configure(EntityTypeBuilder<UserIntern> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Group).WithMany(x => x.Interns).HasForeignKey(x => x.GroupId);
            builder.HasOne(x => x.Menthor).WithOne(x => x.Intern).HasForeignKey<UserIntern>(x => x.MenthorId).OnDelete(DeleteBehavior.SetNull) ;
            builder.HasOne(x => x.User).WithOne(x => x.Intern).HasForeignKey<UserIntern>(x => x.UserId).IsRequired().OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new UserIntern()
                {
                Id = 1,
                GroupId = 1,
                UserId = 1,
                MenthorId = 2
                },
                new UserIntern()
                {
                    Id = 2,
                    GroupId = 1,
                    UserId = 2,
                    MenthorId = 1
                });
        }
    }
}
