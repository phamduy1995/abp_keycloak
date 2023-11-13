using Volo.Abp.Modularity;

namespace KeyCloakIntegrate;

[DependsOn(
    typeof(KeyCloakIntegrateApplicationModule),
    typeof(KeyCloakIntegrateDomainTestModule)
    )]
public class KeyCloakIntegrateApplicationTestModule : AbpModule
{

}
