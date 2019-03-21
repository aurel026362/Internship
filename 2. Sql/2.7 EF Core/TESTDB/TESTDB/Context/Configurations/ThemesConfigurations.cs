using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TESTDB.Context.Configurations
{
    class ThemesConfigurations : IEntityTypeConfiguration<Themes>
    {
        public void Configure(EntityTypeBuilder<Themes> builder)
        {
            builder.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(40);

            builder.Property(e => e.Source).HasMaxLength(40);

            builder.Property(e => e.TimeOfTheme).HasColumnType("smalldatetime");

            builder.HasOne(d => d.Menthor)
                    .WithMany(p => p.Themes)
                    .HasForeignKey(d => d.MenthorId)
                    .HasConstraintName("FK__Themes__MenthorI__67FE6514");

            builder.HasOne(d => d.Module)
                    .WithMany(p => p.Themes)
                    .HasForeignKey(d => d.ModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Themes__ModuleId__68F2894D");
        }
    }
}
