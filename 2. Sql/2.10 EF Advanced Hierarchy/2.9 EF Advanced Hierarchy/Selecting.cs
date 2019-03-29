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

            EnumerableExample();
            AvgMarksForEachIntern();
            GroupJoinExample();
            DiffernetSubqueryExamples();
            ProjectionExample();
            PaginationExample();
            DynamicFilters();
            GroupJoinEx();
            SelectManyExample();
            FromSqlExample();

        }

        private void FromSqlExample()
        {
            Console.WriteLine("\nShow number of theme for each module:");
            var list = context.Themes.Include(x => x.Modulep).GroupBy(x => x.Modulep.Name).Select(x =>
                new
                {
                    MName = x.Key,
                    LThemes = x.Count()
                }).ToList();

            foreach (var mod in list)
            {
                Console.WriteLine(mod.MName + " " + mod.LThemes);
            }

            Console.WriteLine("\nShow all themes:");

            var list2 = context.Themes.FromSql("SELECT * FROM Themes").Select(x =>
            new
            {
                MName = x.Name
            });

            foreach (var item in list2)
            {
                Console.WriteLine(item.MName);
            }
        }

        private void SelectManyExample()
        {


            var list = context.Groups.GroupJoin(context.Interns,
                g => g.Id,
                i => i.GroupId,
                (gr, intern) => new
                {
                    Name = gr.Name,
                    interns = intern
                });

            Console.WriteLine("------------------------------------------");

            foreach (var item in list)
            {
                Console.WriteLine(item.Name);
                foreach (var intern in item.interns)
                {
                    Console.WriteLine("\t" + intern.FirstName + " " + intern.LastName);
                }
            }

            Console.WriteLine("------------------------------------------");

            var outerJoin = from Group in context.Groups
                            join Interns in context.Interns
                            on Group.Id equals Interns.GroupId
                            into temp
                            from Interns in temp.DefaultIfEmpty()
                            select new
                            {
                                gr = (Group == null ? "NULL" : Group.Name),
                                intern = (Interns == null ? "NULL" : Interns.FirstName)
                            };

            foreach (var item in outerJoin)
            {
                Console.WriteLine(item.gr);

                foreach (var intern in item.intern)
                {
                    Console.WriteLine(intern);
                }
            }


            var marks = context.Interns.SelectMany(x => x.ThemeMarks);

            Console.WriteLine("\nShow all marks:");

            foreach (var mark in marks)
            {
                Console.WriteLine(mark.Intern.FirstName + " " + mark.Mark);
            }
        }

        private void GroupJoinEx()
        {
            var list = context.Groups.GroupJoin(context.Interns,
                g => g.Id,
                i => i.GroupId,
                (group, intern) => new
                {
                    NameG = group.Name,
                    interns = intern
                });

            Console.WriteLine("LIST OF GROUPS:");

            foreach (var item in list)
            {
                Console.WriteLine(item.NameG);
                foreach (var intern in item.interns)
                {
                    Console.WriteLine("\t" + intern.FirstName + " " + intern.LastName);
                }
            }
        }

        private void DynamicFilters()
        {
            Console.WriteLine("Dynamic Filters Example:");

            IQueryable<ThemeMark> marks = context.ThemeMarks.Include(x => x.Intern);

            int newMark = 8;
            string comment = "Best";


            if (newMark > 0)
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
            var users = context.Users.OfType<UserIntern>().Where(x => x.GroupId == 1);

            foreach (var user in users)
            {
                Console.WriteLine($"\t\t{user.FirstName} {user.LastName}");
            }
        }

        private void DiffernetSubqueryExamples()
        {
            Console.WriteLine("Different Subquery Example:");
            Console.WriteLine("\tShow interns which have a mark bigger than 9");
            var list = context.Interns.Where(x => x.ThemeMarks.Any(y => y.Mark > 9)).Select(x => new { FName = x.FirstName, LName = x.LastName });

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

            IQueryable<User> users = context.Users;

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
                    Marks = mark.Select(x => new { Mark = x.Mark > 5 ? x.Mark : 2, Comment = x.Comment ?? "No Comment" })
                });

            foreach (var theme in themes)
            {
                Console.WriteLine("\nTheme " + theme.TName);
                foreach (var mark in theme.Marks)
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
           }).Where(x => x.Avg > 8).ToList();

            foreach (var intern in list)
            {
                Console.WriteLine(intern.Name.FirstName + " " + intern.Name.LastName + " " + intern.Avg);
            }
        }

        private void PaginationExample()
        {
            Console.WriteLine("Pagionation Example:");

            var marks = context.ThemeMarks.Include(x => x.Intern).Page(2, 5);

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
