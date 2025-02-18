using EFCoreModeling.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
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
        public DbSet<Employee> employees{ get; set; }
    }
}
