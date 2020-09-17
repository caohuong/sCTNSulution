using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace sCTNSolution.Data.EF
{
    public class CTNKGContextFactory : IDesignTimeDbContextFactory<CTNKGContext>
    {
        public CTNKGContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionBuilder = configuration.GetConnectionString("CTNKGDatabase");
            var optionsBuilder = new DbContextOptionsBuilder<CTNKGContext>();
            optionsBuilder.UseSqlServer(connectionBuilder);

            return new CTNKGContext(optionsBuilder.Options);
        }
    }
}
