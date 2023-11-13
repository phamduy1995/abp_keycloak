using KeyCloakIntegrate.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace KeyCloakIntegrate.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(KeyCloakIntegrateEntityFrameworkCoreModule),
    typeof(KeyCloakIntegrateApplicationContractsModule)
    )]
public class KeyCloakIntegrateDbMigratorModule : AbpModule
{
}
