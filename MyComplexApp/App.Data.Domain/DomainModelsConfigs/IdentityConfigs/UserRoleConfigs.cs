using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Domain.DomainModelsConfigs.IdentityConfigs
{
    public class UserRoleConfigs : IEntityTypeConfiguration<IdentityUserRole<long>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<long>> builder)
        {
            builder.HasData(
                new IdentityUserRole<long>()
                {
                    UserId = 1,
                    RoleId = 3
                },
                new IdentityUserRole<long>()
                {
                    UserId = 2,
                    RoleId = 3
                },
                new IdentityUserRole<long>()
                {
                    UserId = 3,
                    RoleId = 2
                },
                new IdentityUserRole<long>()
                {
                    UserId = 4,
                    RoleId = 2
                },
                new IdentityUserRole<long>()
                {
                    UserId = 5,
                    RoleId = 1
                });
        }
    }
}
