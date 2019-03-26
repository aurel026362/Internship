using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._9_EF_Advanced_Hierarchy.Configurations
{
    class UserInternConfigurations : IEntityTypeConfiguration<UserIntern>
    {
        public void Configure(EntityTypeBuilder<UserIntern> builder)
        {
            //builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Group).WithMany(x => x.Interns).HasForeignKey(x => x.GroupId);

            builder.HasData(new UserIntern()
            {
                Id = 1,
                GroupId = 1,
                FirstName = "Aurel",
                LastName = "Starciuc",
                DateOfBirth = Convert.ToDateTime("1999/05/22"),
                NumberPhone = "+37367620932",
                Login = "aurel12345",
                Password = "12345",
                Email = "aurel@mail.ru"
            },
            new UserIntern()
            {
                Id = 2,
                GroupId = 1,
                FirstName = "Cristi",
                LastName = "Anghelenici",
                DateOfBirth = Convert.ToDateTime("1997/03/19"),
                NumberPhone = "++3732167321",
                Login = "cristi12345",
                Password = "54321",
                Email = "cristia@mail.ru"
            });
        }
    }
}
