using KeyCloakIntegrate.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace KeyCloakIntegrate.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class KeyCloakIntegrateController : AbpControllerBase
{
    protected KeyCloakIntegrateController()
    {
        LocalizationResource = typeof(KeyCloakIntegrateResource);
    }
}
