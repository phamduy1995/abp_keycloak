using System;
using System.Collections.Generic;
using System.Text;
using KeyCloakIntegrate.Localization;
using Volo.Abp.Application.Services;

namespace KeyCloakIntegrate;

/* Inherit your application services from this class.
 */
public abstract class KeyCloakIntegrateAppService : ApplicationService
{
    protected KeyCloakIntegrateAppService()
    {
        LocalizationResource = typeof(KeyCloakIntegrateResource);
    }
}
