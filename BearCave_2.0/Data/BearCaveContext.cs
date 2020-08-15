using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BearCave_2._0.Models;

namespace BearCave_2._0.Models
{
    public class BearCaveContext : DbContext
    {
        public BearCaveContext (DbContextOptions<BearCaveContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Property> Properties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("Clients");
            modelBuilder.Entity<Property>().ToTable("Properties");
            modelBuilder.Entity<Unit>().ToTable("Units");
        }
    }
}
