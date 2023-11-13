using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace KeyCloakIntegrate;

[Dependency(ReplaceServices = true)]
public class KeyCloakIntegrateBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "KeyCloakIntegrate";
}
