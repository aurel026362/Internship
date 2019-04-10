using App.Data.Domain.DomainModels.Concrete;
using App.Data.Domain.DomainModels.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Domain.DomainModelsConfigs.ConcreteConfigs
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
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
           
            builder.Property(e => e.PhoneNumber).HasMaxLength(15);
            
            builder.Property(x => x.PhoneNumber).IsRequired();
            builder.Property(x => x.PasswordHash).IsRequired();
            builder.Property(x => x.DateOfBirth).IsRequired();

            builder.HasData(
                new User()
                {
                    Id = 1,
                    FirstName = "Aurel",
                    LastName = "Starciuc",
                    DateOfBirth = Convert.ToDateTime("1999/05/22"),
                    PhoneNumber = "+37367620932",
                    UserName = "aurel12345",
                    PasswordHash = "12345",
                    Email = "aurel@mail.ru"
                },
                new User()
                {
                    Id = 2,
                    FirstName = "Cristi",
                    LastName = "Anghelenici",
                    DateOfBirth = Convert.ToDateTime("1989/08/12"),
                    PhoneNumber = "+37367665467",
                    UserName = "cristi4324",
                    PasswordHash = "885464",
                    Email = "cristi@mail.ru"
                },
                new User()
                {
                    Id = 3,
                    FirstName = "Alexandr",
                    LastName = "Racovschi",
                    DateOfBirth = Convert.ToDateTime("1994/04/20"),
                    PhoneNumber = "+37336218321",
                    UserName = "alexandr1633",
                    PasswordHash = "asd1236",
                    Email = "alexandr@mail.ru"
                },
                new User()
                {
                    Id = 4,
                    FirstName = "Ion",
                    LastName = "Gandrabura",
                    DateOfBirth = Convert.ToDateTime("1984/04/22"),
                    PhoneNumber = "+373954035",
                    UserName = "ion79345",
                    PasswordHash = "asdqwe123",
                    Email = "iong@mail.ru"
                });
        }
    }
}
