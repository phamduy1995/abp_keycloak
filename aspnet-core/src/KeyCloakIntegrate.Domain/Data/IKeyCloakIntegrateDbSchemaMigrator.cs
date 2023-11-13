using System.Threading.Tasks;

namespace KeyCloakIntegrate.Data;

public interface IKeyCloakIntegrateDbSchemaMigrator
{
    Task MigrateAsync();
}
