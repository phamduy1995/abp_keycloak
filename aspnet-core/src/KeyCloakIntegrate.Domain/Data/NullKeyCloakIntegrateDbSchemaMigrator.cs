using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace KeyCloakIntegrate.Data;

/* This is used if database provider does't define
 * IKeyCloakIntegrateDbSchemaMigrator implementation.
 */
public class NullKeyCloakIntegrateDbSchemaMigrator : IKeyCloakIntegrateDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
