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
    public class MyAppContext // : DbContext
           : IdentityDbContext<User, Role,long>
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
        public virtual DbSet<RequestedUser> RequestedUsers { get; set; }

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
            //optionsBuilder.UseSqlServer(@"Data Source=MDDSK40071\TOMANDJERRY;Initial Catalog=test;Integrated Security=True");
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-BIL3ATO\MSSQLSERVER1;Initial Catalog=test;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

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
            modelBuilder.ApplyConfiguration(new RequestedUserConfig());
            modelBuilder.ApplyConfiguration(new RoleConfig());

            //modelBuilder.Entity<User>().ToTable("Users");
            //modelBuilder.Entity<Role>().ToTable("Roles");
            //modelBuilder.Entity<IdentityUserRole<long>>().ToTable("UserRoles");
            //modelBuilder.Entity<IdentityUserToken<long>>().ToTable("UserTokens");
            //modelBuilder.Entity<IdentityUserLogin<long>>().ToTable("UserLogins");
            //modelBuilder.Entity<IdentityUserClaim<long>>().ToTable("UserClaims");
            //modelBuilder.Entity<IdentityRoleClaim<long>>().ToTable("RoleClaims");
            //foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            //{
            //    relationship.DeleteBehavior = DeleteBehavior.Restrict;
            //}

        }
    }
}
