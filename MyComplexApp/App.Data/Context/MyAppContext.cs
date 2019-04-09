using App.Data.Domain.DomainModels.Concrete;
using App.Data.Domain.DomainModelsConfigs.ConcreteConfigs;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace App.Data.Context
{
    public class MyAppContext // : DbContext
           :DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserIntern> Interns { get; set; }
        public virtual DbSet<UserMenthor> Menthors { get; set; }
        public virtual DbSet<Domain.DomainModels.Concrete.Module> Modules { get; set; }
        public virtual DbSet<Theme> Themes { get; set; }
        public virtual DbSet<ThemeMark> ThemeMarks { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<ExamMark> ExamMarks { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }

        public MyAppContext()
        {
            //Database.EnsureCreated();
        }

        public MyAppContext(DbContextOptions<MyAppContext> options) 
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=MDDSK40071\TOMANDJERRY;Initial Catalog=test;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.ApplyConfiguration(new UserConfigurations());
            modelBuilder.ApplyConfiguration(new UserInternConfigurations());
            modelBuilder.ApplyConfiguration(new UserMenthorConfigurations());
            modelBuilder.ApplyConfiguration(new ModuleConfig());
            modelBuilder.ApplyConfiguration(new ThemeConfig());
            modelBuilder.ApplyConfiguration(new ThemeMarkConfig());
            modelBuilder.ApplyConfiguration(new ExamConfig());
            modelBuilder.ApplyConfiguration(new ExamMarkConfig());
            modelBuilder.ApplyConfiguration(new GroupConfig());
            modelBuilder.ApplyConfiguration(new CommentConfig());

        }
    }
}
