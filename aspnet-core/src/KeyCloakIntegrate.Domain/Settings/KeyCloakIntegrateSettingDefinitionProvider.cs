using Volo.Abp.Settings;

namespace KeyCloakIntegrate.Settings;

public class KeyCloakIntegrateSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(KeyCloakIntegrateSettings.MySetting1));
    }
}
