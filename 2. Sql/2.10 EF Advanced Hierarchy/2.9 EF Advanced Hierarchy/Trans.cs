using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using _2._9_EF_Advanced_Hierarchy.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace _2._9_EF_Advanced_Hierarchy
{
    public class Trans
    {
        public Trans()
        {
            //AddGroupAndUser();
            DeleteGroupAndUser();
        }

        private void DeleteGroupAndUser()
        {
            var options = new DbContextOptionsBuilder<AppContext>()
                .UseSqlServer(new SqlConnection(@"Data Source=MDDSK40071\TOMANDJERRY;Initial Catalog=test;Integrated Security=True"))
                .Options;

            using (var context = new AppContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var newIntern = context.Interns.LastOrDefault();

                        context.Interns.Remove(newIntern);
                        context.SaveChanges();

                        using (var context2 = new AppContext())
                        {
                            context2.Database.UseTransaction(transaction.GetDbTransaction());

                            var newGroup = context2.Groups.LastOrDefault();

                            context2.Groups.Remove(newGroup);
                            context2.SaveChanges();
                        }

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                    }
                }
            }
        }

        private void AddGroupAndUser()
        {
            using (var context = new AppContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var newGroup = new Group()
                        {
                            Name = "TESTGROUP",
                            StartDate = Convert.ToDateTime("2019/05/05")
                        };

                        context.Groups.Add(newGroup);

                        var newIntern = new UserIntern()
                        {
                            Group = newGroup,
                            FirstName = "FTestIntern",
                            LastName = "LTestIntern",
                            NumberPhone = "t+37346372",
                            Email = "test@mail.ru",
                            Login = "testLogin",
                            Password = "testPass",
                            DateOfBirth = Convert.ToDateTime("2000/01/01")
                        };

                        context.Interns.Add(newIntern);

                        context.SaveChanges();

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                    }
                }
            }
        }
    }
}
