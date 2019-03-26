using System;
using TESTDB.Context;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TESTDB.Repository;
using System.Transactions;
using Microsoft.EntityFrameworkCore;

namespace TESTDB
{
    public class Tran
    {
        public Tran()
        {
            ShowUsersWithMarks();
        }

        private void ShowUsersWithMarks()
        {
            using (var tran = new CommittableTransaction(
                new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
            {
                try
                {
                    using (var context = new TESTDBContext())
                    {

                        var list = context.Groups.Include(x => x.Interns).ThenInclude(x=>x.User);

                        foreach(var item in list)
                        {
                            Console.WriteLine(item.Name);
                            foreach(var mark in item.Interns)
                            {
                                Console.WriteLine(mark.User.FirstName + " " + mark.User.LastName);
                            }
                        }


                    }
                    tran.Commit();
                }
                catch (Exception)
                {
                    tran.Rollback();
                }
            }
        }

        private void ModifySomeUser()
        {
            using (var context = new TESTDBContext())
            {
                using (var contextTransaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        Repository<Users> rep = new Repository<Users>(context);

                        //rep.Add(new Users()
                        //{
                        //    FirstName = "test",
                        //    LastName = "test",
                        //    Login = "test12354",
                        //    Password = "12345",
                        //    DateOfBirth = Convert.ToDateTime("01/01/2000"),
                        //    Email = "test@mail.ru",
                        //    NumberPhone = "+373543543",

                        //});

                        var user = rep.FindById(6);
                        user.Email = "asdfghjkl@mail.ru";

                        rep.Update(user);

                        Console.WriteLine(user.FirstName + " " + user.LastName);

                        contextTransaction.Commit();
                    }
                    catch (Exception)
                    {
                        contextTransaction.Rollback();
                    }
                }
            }
        }
    }
}
