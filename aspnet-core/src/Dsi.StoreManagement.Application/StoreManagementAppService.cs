using System;
using System.Collections.Generic;
using System.Text;
using Dsi.StoreManagement.Localization;
using Volo.Abp.Application.Services;

namespace Dsi.StoreManagement;

/* Inherit your application services from this class.
 */
public abstract class StoreManagementAppService : ApplicationService
{
    protected StoreManagementAppService()
    {
        LocalizationResource = typeof(StoreManagementResource);
    }
}
