using System;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary1
{
    public class TestContext : DbContext
    {
            public TestContext(DbContextOptions<TestContext> options) : base(options)
            {
            }
    
            public DbSet<Config> Configs { get; set; }
            
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Config>().ToTable("Config");
            }
    }
}