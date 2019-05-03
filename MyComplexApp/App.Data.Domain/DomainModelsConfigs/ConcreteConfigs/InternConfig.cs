using App.Data.Domain.DomainModels.Concrete;
using App.Data.Domain.DomainModels.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Domain.DomainModelsConfigs.ConcreteConfigs
{
    public class InternConfig : IEntityTypeConfiguration<Intern>
    {
        public void Configure(EntityTypeBuilder<Intern> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Group).WithMany(x => x.Interns).HasForeignKey(x => x.GroupId);
            builder.HasOne(x => x.Menthor).WithOne(x => x.Intern).HasForeignKey<Intern>(x => x.MenthorId).OnDelete(DeleteBehavior.SetNull) ;
            builder.HasOne(x => x.User)/*.WithOne(x => x.Intern).HasForeignKey<Intern>(x => x.UserId).IsRequired().OnDelete(DeleteBehavior.Restrict)*/;
            builder.Property(x => x.UserId).IsRequired();
           

            builder.HasData(
                new Intern()
                {
                Id = 1,
                GroupId = 1,
                UserId = 1,
                MenthorId = 2
                },
                new Intern()
                {
                    Id = 2,
                    GroupId = 1,
                    UserId = 2,
                    MenthorId = 1
                });
        }
    }
}
