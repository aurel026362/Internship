using App.Data.Domain.DomainModels.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Domain.DomainModelsConfigs.ConcreteConfigs
{
    public class RequestedUserConfig : IEntityTypeConfiguration<RequestedUser>
    {
        public void Configure(EntityTypeBuilder<RequestedUser> builder)
        {

            builder.HasKey(x => x.Id);
            builder.Property(e => e.DateOfBirth).HasColumnType("date");

            builder.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMail")
                    .HasMaxLength(30)
                    .IsUnicode(false);

            builder.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20);

            builder.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(20);
            builder.Property(x => x.DateOfBirth).IsRequired();
            
            builder.Property(x => x.TypeUser).HasMaxLength(20);
        }
    }
}
