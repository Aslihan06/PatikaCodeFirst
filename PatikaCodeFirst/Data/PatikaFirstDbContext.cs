using Microsoft.EntityFrameworkCore;
using PatikaCodeFirst.Models;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;

namespace PatikaCodeFirst.Data
{
    public class PatikaFirstDbContext : DbContext
    {
        public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}

