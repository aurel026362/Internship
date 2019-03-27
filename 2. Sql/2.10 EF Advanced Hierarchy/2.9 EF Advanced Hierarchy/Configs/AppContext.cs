using _2._9_EF_Advanced_Hierarchy.Configs.Configurations;
using _2._9_EF_Advanced_Hierarchy.Configurations;
using _2._9_EF_Advanced_Hierarchy.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace _2._9_EF_Advanced_Hierarchy
{
    public partial class AppContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserIntern> Interns { get; set; }
        public virtual DbSet<UserMenthor> Menthors { get; set; }
        public virtual DbSet<Tables.Module> Modules { get; set; }
        public virtual DbSet<Theme> Themes { get; set; }
        public virtual DbSet<ThemeMark> ThemeMarks { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<ExamMark> ExamMarks { get; set; }
        public virtual DbSet<Group> Groups { get; set; }

        public AppContext()
        {
            //Database.EnsureCreated();
        }

        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=MDDSK40071\TOMANDJERRY;Initial Catalog=test;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            //modelBuilder.ApplyConfiguration(new UserConfigurations());
            //modelBuilder.ApplyConfiguration(new UserInternConfigurations());
            //modelBuilder.ApplyConfiguration(new UserMenthorConfigurations());
            //modelBuilder.ApplyConfiguration(new ModuleConfig());
            //modelBuilder.ApplyConfiguration(new ThemeConfig());
            //modelBuilder.ApplyConfiguration(new ThemeMarkConfig());
            //modelBuilder.ApplyConfiguration(new ExamConfig());
            //modelBuilder.ApplyConfiguration(new ExamMarkConfig());
            //modelBuilder.ApplyConfiguration(new GroupConfig());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
           
        }
    }
}
