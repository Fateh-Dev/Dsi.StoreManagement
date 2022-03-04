using Dsi.StoreManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Dsi.StoreManagement.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class StoreManagementController : AbpControllerBase
{
    protected StoreManagementController()
    {
        LocalizationResource = typeof(StoreManagementResource);
    }
}
