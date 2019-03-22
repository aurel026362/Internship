using _2._9_EF_Advanced_Hierarchy.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._9_EF_Advanced_Hierarchy
{
    public partial class AppContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Exchange> Exchanges { get; set; }

        public AppContext()
        {
        }

        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            optionsBuilder.UseSqlServer(@"Data Source=MDDSK40071\TOMANDJERRY;Initial Catalog=Hierarchy;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserMenthor>();
            modelBuilder.Entity<UserIntern>();

            modelBuilder.ApplyConfiguration(new UserConfigurations());
            modelBuilder.ApplyConfiguration(new UserInternConfigurations());
            modelBuilder.ApplyConfiguration(new UserMenthorConfigurations());
            modelBuilder.ApplyConfiguration(new ExchangesConfigurations());
        }
    }
}
