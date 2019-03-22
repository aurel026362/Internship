using CodeFirst.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirst
{
    public class AppContext : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Marks> SMarks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source = MDDSK40071\TOMANDJERRY; Initial Catalog = CodeFirst; Integrated Security = True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MarksConfigurations());
            modelBuilder.ApplyConfiguration(new StudentsConfigurations());
        }
    }
}
