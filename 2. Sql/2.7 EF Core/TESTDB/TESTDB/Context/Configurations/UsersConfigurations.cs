using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TESTDB.Context.Configurations
{
    class UsersConfigurations : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
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

            builder.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

            builder.Property(e => e.NumberPhone).HasMaxLength(15);

            builder.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
        }
    }
}
