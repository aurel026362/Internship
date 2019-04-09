using App.Data.Domain.DomainModels.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Domain.DomainModelsConfigs.ConcreteConfigs
{
    public class UserMenthorConfigurations : IEntityTypeConfiguration<UserMenthor>
    {
        public void Configure(EntityTypeBuilder<UserMenthor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.User).WithOne(x => x.Menthor).HasForeignKey<UserMenthor>(x => x.UserId);

            builder.HasData(
            new UserMenthor()
            {
                Id = 1,
                UserId = 3
            },
            new UserMenthor()
            {
                Id = 2,
                UserId = 4
            }
            );
        }
    }
}
