using EFCoreModeling.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreModeling
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //Parameterless Constructer
        {
            base.OnConfiguring(optionsBuilder);
            var config = new ConfigurationBuilder().AddJsonFile("appsetting.json")
                .Build();
            var connectionString = config.GetSection("ConnectionStrings:constr").Value;
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultSchema("--''--")//Default Schema for all Tables
            //modelBuilder.Entity<Employee>().HasKey(b => new { b.FirstName, b.LastName });// Composite Format Key
            modelBuilder.Entity<Employee>()
                .HasKey(k => k.Id)
                .HasName("PK_ID");
            modelBuilder.Ignore<Departments>();
            modelBuilder.Ignore<Products>();
            modelBuilder.Entity<Employee>()
                .Property(p => p.FullName)
                .HasComputedColumnSql("[LastName] + ', ' + [FirstName]");
        }
        public DbSet<Employee> employees{ get; set; }
        //[NotMapped]
        public DbSet<Departments> departments{ get; set; }
        //[NotMapped]
        public DbSet<Products> products{ get; set; }
    }
}
