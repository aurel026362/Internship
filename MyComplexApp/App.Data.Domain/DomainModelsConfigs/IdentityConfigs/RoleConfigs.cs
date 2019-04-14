using App.Data.Domain.DomainModels.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Domain.DomainModelsConfigs.IdentityConfigs
{
    public class RoleConfigs : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(
                new Role()
                {
                    Id = 1,
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    ConcurrencyStamp = Convert.ToString(("Admin").GetHashCode())
                },
                new Role()
                {
                    Id = 2,
                    Name = "Menthor",
                    NormalizedName = "MENTHOR",
                    ConcurrencyStamp = Convert.ToString(("Menthor").GetHashCode())
                },
                new Role()
                {
                    Id = 3,
                    Name = "Intern",
                    NormalizedName = "INTERN",
                    ConcurrencyStamp = Convert.ToString(("Intern").GetHashCode())
                });
        }
    }
}
