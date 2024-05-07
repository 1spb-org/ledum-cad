using Microsoft.EntityFrameworkCore;
using Volo.Abp.DependencyInjection;

namespace LedumCAD.Data;

public class LedumCADEFCoreDbSchemaMigrator : ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public LedumCADEFCoreDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the LedumCADDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<LedumCADDbContext>()
            .Database
            .MigrateAsync();
    }
}
