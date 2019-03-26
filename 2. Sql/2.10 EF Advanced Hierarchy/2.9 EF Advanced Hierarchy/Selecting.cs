using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._9_EF_Advanced_Hierarchy
{
    class Selecting
    {
        AppContext context = new AppContext();
        public Selecting()
        {
            AvgMarksForEachIntern();
        }

        private void AvgMarksForEachIntern()
        {
            Console.WriteLine("ASD");

            var marks = context.ThemeMarks.GroupBy(x=>x.InternId).Select(x => new { Name = x.Key, mm = x.Average(y => y.Mark) });

            foreach(var mark in marks)
            {
                Console.WriteLine(mark.Name + " " + mark.mm);
            }

            var list = context.ThemeMarks.Include(x => x.Intern).GroupBy(x => x.Intern.FirstName).Select(x =>
            new
            {
                Name = x.Key,
                Avg = x.Average(y => y.Mark)
            }).ToList();

            foreach(var intern in list)
            {
                Console.WriteLine(intern.Name + " " + intern.Avg);
            }
        }
    }
}
