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

            builder.HasData(new Users() {
                Id = 1,
                FirstName = "Aurel",
                LastName = "Starciuc",
                DateOfBirth = Convert.ToDateTime("1999/05/22"),
                NumberPhone = "+37367620932",
                Login = "aurel12345",
                Password = "12345",
                Email = "aurel@mail.ru"
            },
            new Users()
            {
                Id = 2,
                FirstName = "Cristi",
                LastName = "Anghelenici",
                DateOfBirth = Convert.ToDateTime("1997/03/19"),
                NumberPhone = "++3732167321",
                Login = "cristi12345",
                Password = "54321",
                Email = "cristia@mail.ru"
            },
            new Users()
            {
                Id = 3,
                FirstName = "Alexandr",
                LastName = "Racovschi",
                DateOfBirth = Convert.ToDateTime("1994/04/20"),
                NumberPhone = "+37336218321",
                Login = "alexandr1633",
                Password = "asd1236",
                Email = "alexandr@mail.ru"
            },
            new Users()
            {
                Id = 4,
                FirstName = "Ion",
                LastName = "Gandrabura",
                DateOfBirth = Convert.ToDateTime("1984/04/22"),
                NumberPhone = "+373954035",
                Login = "ion79345",
                Password = "asdqwe123",
                Email = "iong@mail.ru"
            }
            );
        }
    }
}
