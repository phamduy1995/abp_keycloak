using KeyCloakIntegrate.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace KeyCloakIntegrate;

[DependsOn(
    typeof(KeyCloakIntegrateEntityFrameworkCoreTestModule)
    )]
public class KeyCloakIntegrateDomainTestModule : AbpModule
{

}
