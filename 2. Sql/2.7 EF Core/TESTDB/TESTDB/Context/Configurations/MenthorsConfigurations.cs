using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TESTDB.Context.Configurations
{
    class MenthorsConfigurations : IEntityTypeConfiguration<UsersMenthor>
    {
        public void Configure(EntityTypeBuilder<UsersMenthor> builder)
        {
            builder.HasIndex(e => e.UserId)
                    .HasName("UQ__Menthors__1788CC4D01D0DA72")
                    .IsUnique();

            builder.HasOne(d => d.User)
                    .WithOne(p => p.Menthors)
                    .HasForeignKey<UsersMenthor>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Menthors__UserId__5AA469F6");

            builder.HasMany(x => x.MenthorProjects).WithOne(x => x.Menthor).HasForeignKey(x => x.MenthorId);

            builder.HasData(
                new UsersMenthor()
                {
                    Id = 1,
                    UserId = 3
                },
                new UsersMenthor()
                {
                    Id = 2,
                    UserId = 4
                }
                );
        }
    }
}
