using KeyCloakIntegrate.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace KeyCloakIntegrate.Permissions;

public class KeyCloakIntegratePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(KeyCloakIntegratePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(KeyCloakIntegratePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<KeyCloakIntegrateResource>(name);
    }
}
