using App.Data.Domain.DomainModels.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Domain.DomainModelsConfigs.ConcreteConfigs
{
    public class MenthorConfig : IEntityTypeConfiguration<Menthor>
    {
        public void Configure(EntityTypeBuilder<Menthor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.User).WithOne().OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
            new Menthor()
            {
                Id = 1,
                UserId = 3
            },
            new Menthor()
            {
                Id = 2,
                UserId = 4
            }
            );
        }
    }
}
