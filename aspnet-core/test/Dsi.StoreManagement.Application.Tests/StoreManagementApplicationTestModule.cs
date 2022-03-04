using Volo.Abp.Modularity;

namespace Dsi.StoreManagement;

[DependsOn(
    typeof(StoreManagementApplicationModule),
    typeof(StoreManagementDomainTestModule)
    )]
public class StoreManagementApplicationTestModule : AbpModule
{

}
