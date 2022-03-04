using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Dsi.StoreManagement;

[Dependency(ReplaceServices = true)]
public class StoreManagementBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "StoreManagement";
}
