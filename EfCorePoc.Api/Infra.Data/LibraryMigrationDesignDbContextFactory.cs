using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace EfCorePoc.Api.Infra.Data
{
    public class LibraryDesignTimeDbContextFactory : IDesignTimeDbContextFactory<MainDbContext>
    {
        private string SqlServerConnectionString { get; }
        public LibraryDesignTimeDbContextFactory(IConfiguration configuration)
        {
            SqlServerConnectionString = configuration.GetConnectionString("PocConnection");
        }
        public MainDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MainDbContext>();
            builder.UseSqlServer(SqlServerConnectionString);
            return new MainDbContext(builder.Options);
        }
    }
}
