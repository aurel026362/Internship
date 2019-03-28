using _2._9_EF_Advanced_Hierarchy.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._9_EF_Advanced_Hierarchy
{
    class Selecting
    {
        AppContext context;

        public Selecting(AppContext con)
        {
            this.context = con;

            context.SaveChanges();

            EnumerableExample();
            AvgMarksForEachIntern();
            GroupJoinExample();
            DiffernetSubqueryExamples();
            ProjectionExample();
            PaginationExample();
            DynamicFilters();
        }

        private void DynamicFilters()
        {
            Console.WriteLine("Dynamic Filters Example:");

            IQueryable<ThemeMark> marks = context.ThemeMarks.Include(x=>x.Intern);

            int newMark = 8;
            string comment = "Best";


            if (newMark>0)
            {
                marks = marks.Where(x => x.Mark > newMark);
            }
            if (!string.IsNullOrEmpty(comment))
            {
                marks = marks.Where(x => x.Comment.Contains(comment));
            }

            foreach (var mark in marks)
            {
                Console.WriteLine("\t" + mark.Intern.FirstName + " " + mark.Mark + " " + mark.Comment);
            }
        }

        private void ProjectionExample()
        {
            Console.WriteLine("Projection Example:");
            Console.WriteLine("\tList of interns:");

            //IQueryable<UserIntern>
            var users = context.Users.OfType<UserIntern>().Where(x=>x.GroupId == 1);

            foreach(var user in users)
            {
                Console.WriteLine($"\t\t{user.FirstName} {user.LastName}");
            }
        }

        private void DiffernetSubqueryExamples()
        {
            Console.WriteLine("Different Subquery Example:");
            Console.WriteLine("\tShow interns which have a mark bigger than 9");
            var list = context.Interns.Where(x => x.ThemeMarks.Any(y => y.Mark > 9)).Select(x=> new { FName = x.FirstName, LName = x.LastName});

            foreach (var intern in list)
            {
                Console.WriteLine("\t\t" + intern.FName + " " + intern.LName);
            }

            Console.WriteLine("\tShow interns which have all marks smaller than 10");

            var users = context.Interns
                .Where(x => x.ThemeMarks
                .All(y => y.Mark < 10))
                .Select(
                    x => new
                    {
                        FName = x.FirstName,
                        LName = x.LastName
                    });

            foreach (var intern in users)
            {
                Console.WriteLine("\t\t" + intern.FName + " " + intern.LName);
            }
        }

        private void EnumerableExample()
        {
            Console.WriteLine("Show all Users:");

            IEnumerable<User> users = context.Users;

            foreach (var user in users)
            {
                Console.WriteLine(user.FirstName + " " + user.LastName);
            }
        }

        private void GroupJoinExample()
        {
            Console.WriteLine("\nGroupJoin EXAmple:");

            var themes = context.Themes.GroupJoin(
                context.ThemeMarks,
                t => t.Id,
                m => m.ThemeId,
                (theme, mark) =>
                new
                {
                    TName = theme.Name,
                    Marks = mark.Select(x => new { Mark = x.Mark>5 ? x.Mark : 2, Comment = x.Comment ?? "No Comment"})
                });

            foreach (var theme in themes)
            {
                Console.WriteLine("\nTheme " + theme.TName);
                foreach(var mark in theme.Marks)
                {
                    Console.WriteLine("\t" + mark.Mark + " " + mark.Comment);
                }
            }
        }

        private void AvgMarksForEachIntern()
        {
            Console.WriteLine("\nShow AVG(Marks) For Each Intern:");

            var list = context.ThemeMarks.Include(x => x.Intern).GroupBy(x => new { x.Intern.FirstName, x.Intern.LastName }).Select(x =>
           new
           {
               Name = x.Key,
               Avg = x.Average(y => y.Mark)
           }).Where(x=>x.Avg>8).ToList();

            foreach (var intern in list)
            {
                Console.WriteLine(intern.Name.FirstName + " "+ intern.Name.LastName + " " + intern.Avg);
            }
        }

        private void PaginationExample()
        {
            Console.WriteLine("Pagionation Example:");

            var marks = context.ThemeMarks.Include(x=>x.Intern).Page(2, 5);

            foreach (var mark in marks)
            {
                Console.WriteLine($"\t{mark.Intern.FirstName} {mark.Mark}");
            }
        }
    }

    static class Extension
    {
        public static IQueryable<T> Page<T>(this IQueryable<T> query, int skipNr = 1, int takeNr = 1)
        {
            return query.Skip(skipNr).Take(takeNr);
        }
    }
}
