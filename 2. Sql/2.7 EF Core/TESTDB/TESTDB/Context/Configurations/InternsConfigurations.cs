using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TESTDB.Context.Configurations
{
    class InternsConfigurations : IEntityTypeConfiguration<Interns>
    {
        public void Configure(EntityTypeBuilder<Interns> builder)
        {
            builder.HasIndex(e => e.MenthorId)
                .HasName("UQ__Interns__262694BBC14690F6")
                .IsUnique();

            builder.HasIndex(e => e.UserId)
                .HasName("UQ__Interns__1788CC4D9B185DF7")
                .IsUnique();

            builder.HasOne(d => d.Group)
                .WithMany(p => p.Interns)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Interns__GroupId__61516785");

            builder.HasOne(d => d.Menthor)
                .WithOne(p => p.Interns)
                .HasForeignKey<Interns>(d => d.MenthorId)
                .HasConstraintName("FK__Interns__Menthor__6339AFF7");

            builder.HasOne(d => d.User)
                .WithOne(p => p.Interns)
                .HasForeignKey<Interns>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Interns__UserId__62458BBE");
        }
    }
}
