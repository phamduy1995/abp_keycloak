using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using KeyCloakIntegrate.Data;
using Volo.Abp.DependencyInjection;

namespace KeyCloakIntegrate.EntityFrameworkCore;

public class EntityFrameworkCoreKeyCloakIntegrateDbSchemaMigrator
    : IKeyCloakIntegrateDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreKeyCloakIntegrateDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the KeyCloakIntegrateDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<KeyCloakIntegrateDbContext>()
            .Database
            .MigrateAsync();
    }
}
