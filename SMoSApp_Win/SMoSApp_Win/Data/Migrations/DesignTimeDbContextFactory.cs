using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

// Make sure the namespace matches your project's folder structure
namespace SMoSApp_Win.Data
{
    // This class is used by the EF Core tools (like for migrations) to create a DbContext instance
    // at design time. It's not used when your application is running normally.
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            // Build the configuration object to read from appsettings.json
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // Create a new DbContextOptionsBuilder
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();

            // Get the connection string from the configuration file
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            // Configure the DbContext to use SQL Server with the connection string
            builder.UseSqlServer(connectionString);

            // Create and return a new instance of the ApplicationDbContext
            return new ApplicationDbContext(builder.Options);
        }
    }
}
