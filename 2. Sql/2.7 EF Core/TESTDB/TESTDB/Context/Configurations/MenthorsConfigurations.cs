using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TESTDB.Context.Configurations
{
    class MenthorsConfigurations : IEntityTypeConfiguration<Menthors>
    {
        public void Configure(EntityTypeBuilder<Menthors> builder)
        {
            builder.HasIndex(e => e.UserId)
                    .HasName("UQ__Menthors__1788CC4D01D0DA72")
                    .IsUnique();

            builder.HasOne(d => d.User)
                    .WithOne(p => p.Menthors)
                    .HasForeignKey<Menthors>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Menthors__UserId__5AA469F6");
        }
    }
}
