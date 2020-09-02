using EfCorePoc.Api.Domain.Models;
using EfCorePoc.Api.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace EfCorePoc.Api.Infra.Data
{
    public class MainDbContext : DbContext
    {
        public DbSet<Migration> Migrations { get; set; }
        public MainDbContext([NotNull] DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MigrationMap());

        }
    }
}
