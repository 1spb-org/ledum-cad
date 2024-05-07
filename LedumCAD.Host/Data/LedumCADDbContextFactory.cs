using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace LedumCAD.Data;

public class LedumCADDbContextFactory : IDesignTimeDbContextFactory<LedumCADDbContext>
{
    public LedumCADDbContext CreateDbContext(string[] args)
    {

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<LedumCADDbContext>()
            .UseSqlite(configuration.GetConnectionString("Default"));

        return new LedumCADDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
