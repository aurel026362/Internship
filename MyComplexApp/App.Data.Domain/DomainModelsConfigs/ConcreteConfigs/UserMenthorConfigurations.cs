using App.Data.Domain.DomainModels.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Domain.DomainModelsConfigs.ConcreteConfigs
{
    class UserMenthorConfigurations : IEntityTypeConfiguration<UserMenthor>
    {
        public void Configure(EntityTypeBuilder<UserMenthor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.User).WithOne(x => x.Menthor).HasForeignKey<UserMenthor>(x => x.UserId);

            //builder.HasData(
            //new UserMenthor()
            //{
            //    Id = 3,
            //    FirstName = "Alexandr",
            //    LastName = "Racovschi",
            //    DateOfBirth = Convert.ToDateTime("1994/04/20"),
            //    NumberPhone = "+37336218321",
            //    Login = "alexandr1633",
            //    Password = "asd1236",
            //    Email = "alexandr@mail.ru"
            //},
            //new UserMenthor()
            //{
            //    Id = 4,
            //    FirstName = "Ion",
            //    LastName = "Gandrabura",
            //    DateOfBirth = Convert.ToDateTime("1984/04/22"),
            //    NumberPhone = "+373954035",
            //    Login = "ion79345",
            //    Password = "asdqwe123",
            //    Email = "iong@mail.ru"
            //}
            //);
        }
    }
}
