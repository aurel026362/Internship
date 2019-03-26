using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TESTDB.Context;
using System.Text;
using Microsoft.EntityFrameworkCore.Internal;

namespace TESTDB
{
    class Selecting
    {
        TESTDBContext context = new TESTDBContext();
        public Selecting()
        {
            MarksForEachIntern();
        }

        private void MarksForEachIntern()
        {
            //var interns = context.Interns.Include(x => x.User).Include(x => x.ThemeMarks);
            //var interns = context.Interns.Join(Users,
            //    i => i.Id,
            //    m => m.InternId
            //    );
            Console.WriteLine("----------------");

            //foreach(var intern in interns)
            //{
            //    Console.WriteLine(intern.User.FirstName + " " + intern.User.LastName);
                    
            //    foreach(var mark in intern.ThemeMarks)
            //    {
            //        Console.WriteLine("\t" + mark.Mark + " " + mark.Comment);
            //    }
            //}
        }
    }
}
