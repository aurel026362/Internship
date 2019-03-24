using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TESTDB.Context.Configurations;
using TESTDB.Tables;

namespace TESTDB
{
    public partial class TESTDBContext : DbContext
    {
        public TESTDBContext()
        {
        }

        public TESTDBContext(DbContextOptions<TESTDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ExamMarks> ExamMarks { get; set; }
        public virtual DbSet<Exams> Exams { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<UsersIntern> Interns { get; set; }
        public virtual DbSet<UsersMenthor> Menthors { get; set; }
        public virtual DbSet<Modules> Modules { get; set; }
        public virtual DbSet<ThemeMarks> ThemeMarks { get; set; }
        public virtual DbSet<Themes> Themes { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<TestTable> Tests { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-BIL3ATO\MSSQLSERVER1;Initial Catalog=test;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.ApplyConfiguration(new ExamMarksConfigurations());
            modelBuilder.ApplyConfiguration(new ExamsConfigurations());
            modelBuilder.ApplyConfiguration(new GroupsConfigurations());
            modelBuilder.ApplyConfiguration(new InternsConfigurations());
            modelBuilder.ApplyConfiguration(new MenthorsConfigurations());
            modelBuilder.ApplyConfiguration(new ModulesConfigurations());
            modelBuilder.ApplyConfiguration(new ThemeMarksConfigurations());
            modelBuilder.ApplyConfiguration(new ThemesConfigurations());
            modelBuilder.ApplyConfiguration(new UsersConfigurations());
        }
    }
}
