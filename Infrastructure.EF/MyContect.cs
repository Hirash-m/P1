using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EF
{
    public class MyContect:DbContext
    {
        
        #region DbSet 
        public DbSet<Product> products { get; set; }
        #endregion

        public MyContect(DbContextOptions<MyContect> options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

             var assembly = typeof(ProductMapping).Assembly;
             modelBuilder.ApplyConfigurationsFromAssembly(assembly);
             base.OnModelCreating(modelBuilder);
        }


    }
}