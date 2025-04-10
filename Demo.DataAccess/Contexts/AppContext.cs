using Demo.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccess.Contexts
{
    public class AppContext:DbContext //Apply Denpendency Injection
    {
        public AppContext(DbContextOptions<AppContext> options) :base (options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Server=.;Database=Demo;Integrated Security=true");
        //    }
        //}
         

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Department> Departments { get; set; } = null!;

    }
    
}
