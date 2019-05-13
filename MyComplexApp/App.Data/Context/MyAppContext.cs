using App.Data.Domain.DomainModels.Concrete;
using App.Data.Domain.DomainModels.Identity;
using App.Data.Domain.DomainModelsConfigs.ConcreteConfigs;
using App.Data.Domain.DomainModelsConfigs.IdentityConfigs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Specialized;
using System.Linq;

namespace App.Data.Context
{
    public class MyAppContext : IdentityDbContext<User, Role,long>
    {
        //public virtual DbSet<Domain.DomainModels.Identity.User> Users { get; set; }
        public virtual DbSet<Intern> Interns { get; set; }
        public virtual DbSet<Menthor> Menthors { get; set; }
        public virtual DbSet<Domain.DomainModels.Concrete.Module> Modules { get; set; }
        public virtual DbSet<Theme> Themes { get; set; }
        public virtual DbSet<ThemeMark> ThemeMarks { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<ExamMark> ExamMarks { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }

        public MyAppContext()
        {
        }

        public MyAppContext(DbContextOptions<MyAppContext> options) 
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=MDDSK40071\TOMANDJERRY;Initial Catalog=test;Integrated Security=True");
            //optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-BIL3ATO\MSSQLSERVER1;Initial Catalog=test;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new InternConfig());
            modelBuilder.ApplyConfiguration(new MenthorConfig());
            modelBuilder.ApplyConfiguration(new ModuleConfig());
            modelBuilder.ApplyConfiguration(new ThemeConfig());
            modelBuilder.ApplyConfiguration(new ThemeMarkConfig());
            modelBuilder.ApplyConfiguration(new ExamConfig());
            modelBuilder.ApplyConfiguration(new ExamMarkConfig());
            modelBuilder.ApplyConfiguration(new GroupConfig());
            modelBuilder.ApplyConfiguration(new CommentConfig());
            modelBuilder.ApplyConfiguration(new RoleConfig());
        }
    }
}
